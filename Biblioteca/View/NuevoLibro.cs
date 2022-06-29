using Biblioteca.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.View
{
    public partial class NuevoLibro : Form
    {
        private readonly BibliotecaController _bibliotecaController;

        public NuevoLibro(BibliotecaController bibliotecaController)
        {
            InitializeComponent();
            _bibliotecaController = bibliotecaController;
        }

        private void VolverAOperaciones(object sender, EventArgs e)
        {
            ViewMediator.Operaciones.Show();
            Hide();
        }

        private void AñadirLibro(object sender, EventArgs e)
        {
            var titulo = TituloTextBox.Text;
            var codigoISBN = CodigoISBNTextBox.Text;
            var autor = AutorTextBox.Text;

            var resultado = _bibliotecaController.AñadirNuevoLibro(titulo, codigoISBN, autor);
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
