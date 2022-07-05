using Biblioteca.Model;
using System;
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

        private void IrAEjemplares(object sender, EventArgs e)
        {
            _viewMediator.IrAListaEjemplares();
        }

        private void Operaciones_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

            DialogResult dialogResult = MessageBox.Show("¿Desea persistir la base de datos?", "Biblioteca Express",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.No)
            {
                DataBase.Clear();
            }

        }

    }
}
