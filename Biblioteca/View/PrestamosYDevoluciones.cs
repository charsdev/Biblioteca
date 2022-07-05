using Biblioteca.Controller;
using Biblioteca.Utils;
using System;
using System.Windows.Forms;

namespace Biblioteca.View
{
    public partial class PrestamosYDevoluciones : Form
    {
        private readonly PrestamosController _prestamosController;
        private readonly ViewMediator _viewMediator;

        public PrestamosYDevoluciones(PrestamosController prestamosController, ViewMediator viewMediator)
        {
            InitializeComponent();
            ControlBox = false;
            _prestamosController = prestamosController;
            _viewMediator = viewMediator;
        }

        private void PrestamosYDevoluciones_Load(object sender, EventArgs e)
        {
            MostrarListadoPrestamosActual();
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

        public void DisableButtons()
        {
            DevolucionBoton.Enabled = false;
            PrestamoBoton.Enabled = false;
        }

        private void Prestar(object sender, EventArgs e)
        {
            _prestamosController.RealizarPrestamo(socioTexbox.Text, LibroTextBox.Text);
            MostrarListadoPrestamosActual();
        }

        private void Devolver(object sender, EventArgs e)
        {
            _prestamosController.RecibirDevolucion(socioTexbox.Text, LibroTextBox.Text);
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
