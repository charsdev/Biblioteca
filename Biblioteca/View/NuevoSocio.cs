using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Biblioteca.Controller;
using Biblioteca.Utils;

namespace Biblioteca.View
{
    public partial class NuevoSocio : Form
    {
        private readonly SociosController _nuevoSocioController;
        private readonly ViewMediator _viewMediator;

        public NuevoSocio(SociosController nuevoSocioController, ViewMediator viewMediator)
        {
            InitializeComponent();
            ControlBox = false;
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            _nuevoSocioController = nuevoSocioController;
            _viewMediator = viewMediator;
            CuotaMensualTextBox.ResetText();
        }

        private void VipRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CuotaMensualTextBox.Enabled = true;
            CheckTextboxes();
        }

        private void ComunRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CuotaMensualTextBox.Enabled = false;
            CuotaMensualTextBox.ResetText();
            CheckTextboxes();
        }

        private void AñadirSocio(object sender, EventArgs e)
        {
            errorProvider.Clear();

            List<bool> listaTexbox = new List<bool>();
            listaTexbox.Add(Validator.TryCheckTextboxRule(NombreTextBox, TextBoxRules.OnlyTextRule, errorProvider));
            listaTexbox.Add(Validator.TryCheckTextboxRule(NumeroIdentificacionTextBox, TextBoxRules.DNIFormatRule, errorProvider));
            listaTexbox.Add(Validator.TryCheckTextboxRule(ApellidoTextBox, TextBoxRules.OnlyTextRule, errorProvider));
            
            if (listaTexbox.Contains(false))
            {
                return;
            }

            _nuevoSocioController.AñadirNuevoSocio(
                NombreTextBox.Text,
                ApellidoTextBox.Text,
                NumeroIdentificacionTextBox.Text, 
                VIP.Checked,
                CuotaMensualTextBox.Value
            );
        }

        private void VolverAOperaciones(object sender, EventArgs e)
        {
            Limpiar();
            _viewMediator.IrAOperaciones();
        }

        internal void DisableButton()
        {
            BotonAñadir.Enabled = false;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            CheckTextboxes();
        }

        private void CheckTextboxes()
        {
            if (Comun.Checked)
            {
                BotonAñadir.Enabled = !string.IsNullOrWhiteSpace(NombreTextBox.Text)
                && !string.IsNullOrWhiteSpace(ApellidoTextBox.Text)
                && !string.IsNullOrWhiteSpace(NumeroIdentificacionTextBox.Text);
            }
            else if(VIP.Checked)
            {
                BotonAñadir.Enabled = !string.IsNullOrWhiteSpace(NombreTextBox.Text)
                && !string.IsNullOrWhiteSpace(ApellidoTextBox.Text)
                && !string.IsNullOrWhiteSpace(NumeroIdentificacionTextBox.Text)
                && !string.IsNullOrWhiteSpace(CuotaMensualTextBox.Text);
            }
        }

        private void Limpiar() 
        { 
            NombreTextBox.Clear();
            ApellidoTextBox.Clear();
            NumeroIdentificacionTextBox.Clear();
            CuotaMensualTextBox.ResetText();
            Comun.Checked = true;
            errorProvider.Clear();
        }
    }
}