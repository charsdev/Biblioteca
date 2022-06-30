using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.View
{
    public partial class Operaciones : Form
    {
        private readonly ViewMediator _viewMediator;

        public Operaciones(ViewMediator viewMediator)
        {
            InitializeComponent();
            _viewMediator = viewMediator;
        }

        private void IrANuevoLibro(object sender, EventArgs e)
        {
            _viewMediator.IrANuevoLibro();
        }

        private void IrAPrestamosYDevoluciones(object sender, EventArgs e)
        {
            _viewMediator.IrAPrestamosYDevoluciones();
        }

        private void IrANuevoSocio(object sender, EventArgs e)
        {
            _viewMediator.IrANuevoSocio();
        }

        private void IrANuevoEjemplar(object sender, EventArgs e)
        {
            _viewMediator.IrANuevoEjemplar();
        }

        private void IrALibros(object sender, EventArgs e)
        {
            _viewMediator.IrAListaDeLibros();
        }

        private void IrASocios(object sender, EventArgs e)
        {
            _viewMediator.IrAListaDeSocios();
        }

    }
}
