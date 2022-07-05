using Biblioteca.Controller;
using Biblioteca.Utils;
using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Biblioteca.View
{
    public partial class EjemplaresDisponibles: Form
    {
        private readonly LibrosController _librosController;
	    private readonly ViewMediator _viewMediator;

        public EjemplaresDisponibles(LibrosController librosController, ViewMediator viewMediator)
        {
            InitializeComponent();
            ControlBox = false;
            _librosController = librosController;
	        _viewMediator = viewMediator;
        }

        private void SocioTextBox_TextChanged(object sender, EventArgs e)
        {
            ChequearSiTextoHaSidoCargado();
        }

        private void ChequearSiTextoHaSidoCargado()
        {
            ObtenerEjemplaresDisponiblesBoton.Enabled = !string.IsNullOrWhiteSpace(CodigoISBNTextbox.Text);
        }

        private void VolverAOperaciones(object sender, EventArgs e)
        {
		    _viewMediator.IrAOperaciones();
        }

        private void ObtenerEjemplaresDisponiblesBoton_Click(object sender, EventArgs e)
        {
            GrillaDeEjemplares.Rows.Clear();

            _librosController.ObtenerListadoEjemplares(CodigoISBNTextbox.Text, out var listaDeEjemplares);

            for (int i = 0; i < listaDeEjemplares.Count; i++)
            {
                GrillaDeEjemplares.Rows.Add(listaDeEjemplares[i]);
            }

        }
    }
}
