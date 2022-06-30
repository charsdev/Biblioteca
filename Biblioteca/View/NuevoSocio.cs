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
            _nuevoSocioController = nuevoSocioController;
            _viewMediator = viewMediator;
        }

        private void VipRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CuotaMensualTextBox.Enabled = true;
            CheckTextboxs();
        }

        private void ComunRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            CuotaMensualTextBox.Enabled = false;
            CuotaMensualTextBox.Clear();
            CheckTextboxs();
        }

        private void AñadirSocio(object sender, EventArgs e)
        {
            var nombre = NombreTextBox.Text;
            var apellido = ApellidoTextBox.Text;
            var numeroIdentificacion = NumeroIdentificacionTextBox.Text;

            MessageResult resultado = default(MessageResult);

            if (VIP.Checked)
            {
                var cuotaMensual = NumeroIdentificacionTextBox.Text;
                resultado = _nuevoSocioController.AñadirNuevoSocioVip(nombre, apellido, numeroIdentificacion, cuotaMensual);
            }
            else if (Comun.Checked)
            {
                resultado = _nuevoSocioController.AñadirNuevoSocioComun(nombre, apellido, numeroIdentificacion);
            }

            MessageBoxExtension.Show(resultado);
        }

        private void VolverAOperaciones(object sender, EventArgs e)
        {
            _viewMediator.IrAOperaciones();
        }

        private void NombreTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckTextboxs();
        }

        private void ApellidoTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckTextboxs();
        }

        private void NumeroIdentificacionTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckTextboxs();
        }

        private void CheckTextboxs()
        {
            if (VIP.Checked)
            {
                button1.Enabled = !string.IsNullOrWhiteSpace(NombreTextBox.Text)
                && !string.IsNullOrWhiteSpace(ApellidoTextBox.Text)
                && !string.IsNullOrWhiteSpace(NumeroIdentificacionTextBox.Text)
                && !string.IsNullOrWhiteSpace(CuotaMensualTextBox.Text);
            }
            else if (Comun.Checked)
            {
                button1.Enabled = !string.IsNullOrWhiteSpace(NombreTextBox.Text)
                && !string.IsNullOrWhiteSpace(ApellidoTextBox.Text)
                && !string.IsNullOrWhiteSpace(NumeroIdentificacionTextBox.Text);
            }
        }

        private void CuotaMensualTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckTextboxs();
        }


        private void NuevoSocio_Unload(object sender, EventArgs e)
        {
            NombreTextBox.Clear();
            ApellidoTextBox.Clear();
            NumeroIdentificacionTextBox.Clear();
            VIP.Checked = true; //por default
            CuotaMensualTextBox.Clear();
        }
    }
}
