using Biblioteca.Controller;
using Biblioteca.Utils;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            ControlBox = false;
            this.BotonAñadir.Enabled = false;
        }

        private void VolverAOperaciones(object sender, EventArgs e)
        {
            LimpiarTextboxes();
            this.BotonAñadir.Enabled = false;
            _viewMediator.IrAOperaciones();
        }

        private void AñadirEjemplar(object sender, EventArgs e)
        {
            errorProvider.Clear();

            List<bool> validationResults = new List<bool>();
            validationResults.Add(Validator.TryCheckTextboxRule(CodigoISBNTextBox, TextBoxRules.ISBNFormatRule, errorProvider));
            if (validationResults.Contains(false))
            {
                return;
            }

            _bibliotecaController.AñadirEjemplarALibro(CodigoISBNTextBox.Text, (uint)numeroDeEdicion.Value, ubicacion.Text);
        }

        private void CheckValues(object sender, EventArgs e)
        {
            BotonAñadir.Enabled = !string.IsNullOrWhiteSpace(CodigoISBNTextBox.Text)
                && !string.IsNullOrWhiteSpace(ubicacion.Text)
                && !string.IsNullOrWhiteSpace(numeroDeEdicion.Text);
        }

        private void LimpiarTextboxes()
        {
            CodigoISBNTextBox.Clear();
            ubicacion.SelectedIndex = -1;
            numeroDeEdicion.ResetText();
            errorProvider.Clear();
        }

        public void DisableButton()
        {
            BotonAñadir.Enabled = false;
        }
        
    }
}
