using Biblioteca.Controller;
using System;
using System.Windows.Forms;

namespace Biblioteca.View
{
    public partial class PrestamosYDevoluciones : Form
    {
        private readonly BibliotecaController _bibliotecaController;

        public PrestamosYDevoluciones(BibliotecaController bibliotecaController)
        {
            InitializeComponent();
            _bibliotecaController = bibliotecaController;
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

            var listadoDePrestamos = _bibliotecaController.ObtenerListadoPrestamos();

            for (int i = 0; i < listadoDePrestamos.Count; i++)
            {
                GrillaPrestamos.Rows.Add(listadoDePrestamos[i]);
            }
        }

        private void Prestar(object sender, EventArgs e)
        {
            var resultado = _bibliotecaController.RealizarPrestamo(textBox1.Text, textBox2.Text);
            Utils.MessageBoxExtension.Show(resultado);
            MostrarListadoPrestamosActual();
        }

        private void Devolver(object sender, EventArgs e)
        {
            var resultado = _bibliotecaController.RecibirDevolucion(textBox1.Text, textBox2.Text);
            Utils.MessageBoxExtension.Show(resultado);

            MostrarListadoPrestamosActual();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ChequearSiTextoHaSidoCargado();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            ChequearSiTextoHaSidoCargado();
        }

        private void ChequearSiTextoHaSidoCargado()
        {
            PrestamoBoton.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text);
            DevolucionBoton.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text) && !string.IsNullOrWhiteSpace(textBox2.Text);
        }

        private void VolverAOperaciones(object sender, EventArgs e)
        {
            ViewMediator.Operaciones.Show();
            this.Hide();
        }
    }
}
