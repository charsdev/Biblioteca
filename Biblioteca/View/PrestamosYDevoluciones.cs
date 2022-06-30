using Biblioteca.Controller;
using System;
using System.Windows.Forms;

namespace Biblioteca.View
{
    public partial class PrestamosYDevoluciones : Form
    {
        private readonly PrestamosController _prestamosController;
	    private readonly ViewMediator _viewMediator;

        public PrestamosYDevoluciones(PrestamosController bibliotecaController, ViewMediator viewMediator)
        {
            InitializeComponent();
            _prestamosController = bibliotecaController;
	        _viewMediator = viewMediator;
        }

        private void PrestamosYDevoluciones_Load(object sender, EventArgs e)
        {
            DefinirColumnas();
            MostrarListadoPrestamosActual();
        }

        private void DefinirColumnas()
        {
            string[] columns = new string[] {
                "N°",
                "Tipo",
                "Nro° Libro",
                "Nombre del Libro",
                "Nro° Socio",
                "Nombre y Apellido del Socio",
                "Fecha de prestamo"
            };

            for (int i = 0; i < columns.Length; i++)
            {
                GrillaPrestamos.Columns.Add(columns[i], columns[i]);
            }
        }

        private void MostrarListadoPrestamosActual()
        {
            //Limpiamos lista para traer todos las filas nuevamente y evitar agregarlas nuevamente
            GrillaPrestamos.Rows.Clear();

            var listadoDePrestamos = _prestamosController.ObtenerListadoPrestamos();

            for (int i = 0; i < listadoDePrestamos.Count; i++)
            {
                GrillaPrestamos.Rows.Add(listadoDePrestamos[i]);
            }
        }

        private void Prestar(object sender, EventArgs e)
        {
            var resultado = _prestamosController.RealizarPrestamo(socioTexbox.Text, LibroTextBox.Text);
            Utils.MessageBoxExtension.Show(resultado);
            MostrarListadoPrestamosActual();
        }

        private void Devolver(object sender, EventArgs e)
        {
            var resultado = _prestamosController.RecibirDevolucion(socioTexbox.Text, LibroTextBox.Text);
            Utils.MessageBoxExtension.Show(resultado);

            MostrarListadoPrestamosActual();
        }

        private void SocioTextBox_TextChanged(object sender, EventArgs e)
        {
            ChequearSiTextoHaSidoCargado();
        }

        private void LibroTextBox_TextChanged(object sender, EventArgs e)
        {
            ChequearSiTextoHaSidoCargado();
        }

        private void ChequearSiTextoHaSidoCargado()
        {
            PrestamoBoton.Enabled = !string.IsNullOrWhiteSpace(socioTexbox.Text) && !string.IsNullOrWhiteSpace(LibroTextBox.Text);
            DevolucionBoton.Enabled = !string.IsNullOrWhiteSpace(socioTexbox.Text) && !string.IsNullOrWhiteSpace(LibroTextBox.Text);
        }

        private void VolverAOperaciones(object sender, EventArgs e)
        {
		    _viewMediator.IrAOperaciones();
        }
    }
}
