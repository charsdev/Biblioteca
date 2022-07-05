using Biblioteca.Controller;
using Biblioteca.Utils;
using System;
using System.Collections.Generic;
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
            ControlBox = false;
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            _nuevoLibroController = nuevoLibroController;
            _viewMediator = viewMediator;
        }

        private void VolverAOperaciones(object sender, EventArgs e)
        {
            Limpiar();
            _viewMediator.IrAOperaciones();
        }

        private void AñadirLibro(object sender, EventArgs e)
        {
            errorProvider.Clear();

            List<bool> validationResults = new List<bool>();
            validationResults.Add(Validator.TryCheckTextboxRule(TituloTextBox, TextBoxRules.IsNotEmpty, errorProvider));
            validationResults.Add(Validator.TryCheckTextboxRule(CodigoISBNTextBox, TextBoxRules.ISBNFormatRule, errorProvider));
            validationResults.Add(Validator.TryCheckTextboxRule(AutorTextBox, TextBoxRules.OnlyTextRule, errorProvider));

            if (validationResults.Contains(false))
            {
                return;
            }

            _nuevoLibroController.AñadirNuevoLibro(TituloTextBox.Text, CodigoISBNTextBox.Text, AutorTextBox.Text);
        }

        private void CodigoISBNTextBox_TextChanged(object sender, EventArgs e)
        {
            BotonNuevoLibro.Enabled = !string.IsNullOrWhiteSpace(TituloTextBox.Text)
               && !string.IsNullOrWhiteSpace(AutorTextBox.Text)
               && !string.IsNullOrWhiteSpace(CodigoISBNTextBox.Text);
        }

        private void AutorTextBox_TextChanged(object sender, EventArgs e)
        {
            BotonNuevoLibro.Enabled = !string.IsNullOrWhiteSpace(TituloTextBox.Text)
            && !string.IsNullOrWhiteSpace(AutorTextBox.Text)
            && !string.IsNullOrWhiteSpace(CodigoISBNTextBox.Text);
        }

        internal void DisableButton()
        {
            BotonNuevoLibro.Enabled = false;
        }

        private void TituloTextBox_TextChanged(object sender, EventArgs e)
        {
            BotonNuevoLibro.Enabled = !string.IsNullOrWhiteSpace(TituloTextBox.Text)
            && !string.IsNullOrWhiteSpace(AutorTextBox.Text)
            && !string.IsNullOrWhiteSpace(CodigoISBNTextBox.Text);
        }

        private void Limpiar()
        { 
            CodigoISBNTextBox.Clear();
            AutorTextBox.Clear();
            TituloTextBox.Clear();
            errorProvider.Clear();
        }

    }
}
