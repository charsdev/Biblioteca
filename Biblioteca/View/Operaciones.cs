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

        public Operaciones()
        {
            InitializeComponent();
        }

        private void Operaciones_Load(object sender, EventArgs e)
        {

        }

        private void IrANuevoLibro(object sender, EventArgs e)
        {
            ViewMediator.NuevoLibro.Show();
            this.Hide();
        }

        private void IrAPrestamosYDevoluciones(object sender, EventArgs e)
        {
            ViewMediator.PrestamosYDevoluciones.Show();
            this.Hide();
        }

        private void IrANuevoSocio(object sender, EventArgs e)
        {
            ViewMediator.NuevoSocio.Show();
            this.Hide();
        }

        private void IrANuevoEjemplar(object sender, EventArgs e)
        {
            ViewMediator.NuevoEjemplar.Show();
            this.Hide();
        }

        private void IrALibros(object sender, EventArgs e)
        {
            ViewMediator.VistaLibros.Show();
            this.Hide();
        }

        private void IrASocios(object sender, EventArgs e)
        {
            ViewMediator.VistaSocios.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
