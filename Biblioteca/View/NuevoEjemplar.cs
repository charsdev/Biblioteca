using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Controller;

namespace Biblioteca.View
{
    public partial class NuevoEjemplar : Form
    {
        private readonly BibliotecaController _bibliotecaController;

        public NuevoEjemplar(BibliotecaController bibliotecaController)
        {
            InitializeComponent();
            _bibliotecaController = bibliotecaController;
        }

        private void NuevoEjemplar_Load(object sender, EventArgs e)
        {

        }

        private void VolverAOperaciones(object sender, EventArgs e)
        {
            ViewMediator.Operaciones.Show();
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
