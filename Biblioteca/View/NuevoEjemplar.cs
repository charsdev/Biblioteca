using System;
using System.Windows.Forms;
using Biblioteca.Controller;

namespace Biblioteca.View
{
    public partial class NuevoEjemplar : Form
    {
        private readonly LibrosController _bibliotecaController;
        private readonly ViewMediator _viewMediator;

        public NuevoEjemplar(LibrosController bibliotecaController, ViewMediator viewMediator)
        {
            InitializeComponent();
            _bibliotecaController = bibliotecaController;
            _viewMediator = viewMediator;
        }

        private void VolverAOperaciones(object sender, EventArgs e)
        {
            _viewMediator.IrAOperaciones();
            Hide();
        }

        private void AñadirEjemplar(object sender, EventArgs e)
        {
            var codigoISBN = CodigoISBNTextBox.Text;
            var ubicacion = UbicacionTextBox.Text;
            var numeroDeEdicion = TexboxEdicion.Text;

            var resultado = _bibliotecaController.AñadirEjemplarALibro(codigoISBN, numeroDeEdicion, ubicacion);
            Utils.MessageBoxExtension.Show(resultado);
        }

        private void UbicacionTextBox_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrWhiteSpace(CodigoISBNTextBox.Text)
                && !string.IsNullOrWhiteSpace(UbicacionTextBox.Text)
                && !string.IsNullOrWhiteSpace(TexboxEdicion.Text);
        }

        private void TexboxEdicion_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrWhiteSpace(CodigoISBNTextBox.Text)
                && !string.IsNullOrWhiteSpace(UbicacionTextBox.Text)
                && !string.IsNullOrWhiteSpace(TexboxEdicion.Text);
        }

        private void CodigoISBNTextBox_TextChanged(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrWhiteSpace(CodigoISBNTextBox.Text)
                    && !string.IsNullOrWhiteSpace(UbicacionTextBox.Text)
                    && !string.IsNullOrWhiteSpace(TexboxEdicion.Text);
        }

        private void NuevoEjemplar_Unload(object sender, EventArgs e)
        {
            CodigoISBNTextBox.Clear();
            UbicacionTextBox.Clear();
            TexboxEdicion.Clear();
        }
    }
}
