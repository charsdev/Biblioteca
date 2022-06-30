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
    public partial class ListaDeSocios : Form
    {
        private readonly SociosController _sociosController;
        private readonly ViewMediator _viewMediator;

        public ListaDeSocios(SociosController sociosController, ViewMediator viewMediator)
        {
            InitializeComponent();
            _sociosController = sociosController;
            _viewMediator = viewMediator;
            DefinirColumnas();
        }

        private void VolverAOperaciones(object sender, EventArgs e)
        {
            _viewMediator.IrAOperaciones();
        }

        private void VistaSocios_Load(object sender, EventArgs e)
        {
            MostrarListadoSociosActual();
        }

        private void DefinirColumnas()
        {
            string[] columns = new string[] {
                "N°",
                "Nombre",
                "Apellido",
                "Numero de identificacion",
                "Tipo"
            };

            for (int i = 0; i < columns.Length; i++)
            {
                dataGridView1.Columns.Add(columns[i], columns[i]);
            }
        }

        private void MostrarListadoSociosActual()
        {
            //Limpiamos lista para traer todos las filas nuevamente y evitar agregarlas nuevamente
            dataGridView1.Rows.Clear();

            var listadoDeSocios = _sociosController.ObtenerListadoSocios();

            for (int i = 0; i < listadoDeSocios.Count; i++)
            {
                dataGridView1.Rows.Add(listadoDeSocios[i]);
            }
        }
    }
}
