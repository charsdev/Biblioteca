using Biblioteca.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.View
{
    public static class ViewMediator
    {
        public static NuevoEjemplar NuevoEjemplar { get; set; }
        public static NuevoLibro NuevoLibro { get; set; }
        public static NuevoSocio NuevoSocio { get; set; }
        public static PrestamosYDevoluciones PrestamosYDevoluciones { get; set; }
        public static Operaciones Operaciones { get; set; }
        public static VistaLibros VistaLibros { get; set; }
        public static ListaDeSocios VistaSocios { get; set; }
        public static Form vistaActual = null;

        public static void Init(BibliotecaController bibliotecaController)
        {
            NuevoEjemplar = new NuevoEjemplar(bibliotecaController);
            NuevoLibro = new NuevoLibro(bibliotecaController);
            NuevoSocio = new NuevoSocio(bibliotecaController);
            PrestamosYDevoluciones = new PrestamosYDevoluciones(bibliotecaController);
            Operaciones = new Operaciones();
            VistaLibros = new VistaLibros(bibliotecaController);
            VistaSocios = new ListaDeSocios(bibliotecaController);
        }

    }
}
