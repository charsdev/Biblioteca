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
    public partial class VistaLibros : Form
    {
        private BibliotecaController _bibliotecaController;

        public VistaLibros(BibliotecaController bibliotecaController)
        {
            InitializeComponent();
            _bibliotecaController = bibliotecaController;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewMediator.Operaciones.Show();
            Hide();
        }

        private void DefinirColumnas()
        {
            string[] columns = new string[] {
                "N°",
                "Titulo",
                "Autor",
                "Codigo ISBN",
            };

            for (int i = 0; i < columns.Length; i++)
            {
                dataGridView1.Columns.Add(columns[i], columns[i]);
            }
        }

        private void MostrarListadoDeLibrosActual()
        {
            //Limpiamos lista para traer todos las filas nuevamente y evitar agregarlas nuevamente
            dataGridView1.Rows.Clear();

            var listadoDeLibros = _bibliotecaController.ObtenerListadoLibros();

            for (int i = 0; i < listadoDeLibros.Count; i++)
            {
                dataGridView1.Rows.Add(listadoDeLibros[i]);
            }
        }

        private void VistaLibros_Load(object sender, EventArgs e)
        {
            DefinirColumnas();
            MostrarListadoDeLibrosActual();
        }
    }
}
