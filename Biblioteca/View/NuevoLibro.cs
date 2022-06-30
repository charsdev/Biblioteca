using Biblioteca.Controller;
using System;
using System.Windows.Forms;

namespace Biblioteca.View
{
    public partial class NuevoLibro : Form
    {
        private readonly LibrosController _nuevoLibroController;
        private readonly ViewMediator _viewMediator;
        public NuevoLibro(LibrosController nuevoLibroController, ViewMediator viewMediator)
        {
            InitializeComponent();
            _nuevoLibroController = nuevoLibroController;
            _viewMediator = viewMediator;
        }

        private void VolverAOperaciones(object sender, EventArgs e)
        {
            _viewMediator.IrAOperaciones();
        }

        private void AñadirLibro(object sender, EventArgs e)
        {
            var titulo = TituloTextBox.Text;
            var codigoISBN = CodigoISBNTextBox.Text;
            var autor = AutorTextBox.Text;

            var resultado = _nuevoLibroController.AñadirNuevoLibro(titulo, codigoISBN, autor);
            Utils.MessageBoxExtension.Show(resultado);
        }

        private void CodigoISBNTextBox_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrWhiteSpace(TituloTextBox.Text)
               && !string.IsNullOrWhiteSpace(AutorTextBox.Text)
               && !string.IsNullOrWhiteSpace(CodigoISBNTextBox.Text);
        }

        private void AutorTextBox_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrWhiteSpace(TituloTextBox.Text)
            && !string.IsNullOrWhiteSpace(AutorTextBox.Text)
            && !string.IsNullOrWhiteSpace(CodigoISBNTextBox.Text);
        }

        private void TituloTextBox_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrWhiteSpace(TituloTextBox.Text)
            && !string.IsNullOrWhiteSpace(AutorTextBox.Text)
            && !string.IsNullOrWhiteSpace(CodigoISBNTextBox.Text);
        }

        private void NuevoLibro_Unload(object sender, EventArgs e)
        {
            CodigoISBNTextBox.Clear();
            AutorTextBox.Clear();
            TituloTextBox.Clear();
        }
    }
}
