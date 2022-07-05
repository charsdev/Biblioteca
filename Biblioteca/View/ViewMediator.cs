using Biblioteca.Controller;
using System.Windows.Forms;

namespace Biblioteca.View
{
    public class ViewMediator : ApplicationContext
    {
        private readonly NuevoEjemplar _nuevoEjemplar;
        private readonly NuevoLibro _nuevoLibro;
        private readonly NuevoSocio _nuevoSocio;
        private readonly PrestamosYDevoluciones _prestamosYDevoluciones;
        private readonly Operaciones _operaciones;
        private readonly ListaDeLibros _listaDeLibros;
        private readonly ListaDeSocios _listaDeSocios;
        private readonly EjemplaresDisponibles _ejemplaresDisponibles;

        public Form VistaActual { get; private set; }

        public ViewMediator()
        {
            var librosController = new LibrosController();
            var sociosController = new SociosController();
            var prestamosController = new PrestamosController();

            _nuevoEjemplar = new NuevoEjemplar(librosController, this);
            _nuevoLibro = new NuevoLibro(librosController, this);
            _nuevoSocio = new NuevoSocio(sociosController, this);
            _prestamosYDevoluciones = new PrestamosYDevoluciones(prestamosController, this);
            _operaciones = new Operaciones(this);
            _listaDeLibros = new ListaDeLibros(librosController, this);
            _listaDeSocios = new ListaDeSocios(sociosController, this);
            _ejemplaresDisponibles = new EjemplaresDisponibles(librosController, this);

            VistaActual = _operaciones;
            _operaciones.Show();

            VistaActual = _operaciones;
            VistaActual.ShowInTaskbar = true;
        }

        public void IrANuevoEjemplar()
        {
            IrAVista(_nuevoEjemplar);
            _nuevoEjemplar.DisableButton();
        }

        public void IrAListaEjemplares()
        {
            IrAVista(_ejemplaresDisponibles);
        }

        public void IrANuevoLibro()
        {
            IrAVista(_nuevoLibro);
            _nuevoLibro.DisableButton();
        }

        public void IrANuevoSocio()
        {
            IrAVista(_nuevoSocio);
            _nuevoSocio.DisableButton();
        }

        public void IrAPrestamosYDevoluciones()
        {
            IrAVista(_prestamosYDevoluciones);
            _prestamosYDevoluciones.DisableButtons();
        }

        public void IrAOperaciones()
        {
            IrAVista(_operaciones, true);
        }

        public void IrAListaDeLibros()
        {
            IrAVista(_listaDeLibros);
        }

        public void IrAListaDeSocios() 
        {
            IrAVista(_listaDeSocios);
        }

        private void IrAVista(Form form, bool mostrarEnListaDeTareas = false) 
        {
            VistaActual.TopMost = false;
            VistaActual.Opacity = 0;

            VistaActual = form;
            VistaActual.Show();
            VistaActual.Opacity = 1;

            VistaActual.ShowInTaskbar = mostrarEnListaDeTareas;
            VistaActual.TopMost = true;
        }
    }
}
