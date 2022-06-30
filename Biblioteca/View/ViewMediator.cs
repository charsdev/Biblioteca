using Biblioteca.Controller;
using System.Windows.Forms;

namespace Biblioteca.View
{
    public class ViewMediator
    {
        private readonly NuevoEjemplar _nuevoEjemplar;
        private readonly NuevoLibro _nuevoLibro;
        private readonly NuevoSocio _nuevoSocio;
        private readonly PrestamosYDevoluciones _prestamosYDevoluciones;
        private readonly Operaciones _operaciones;
        private readonly ListaDeLibros _listaDeLibros;
        private readonly ListaDeSocios _listaDeSocios;
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
            VistaActual = _operaciones;
        }

        public void IrANuevoEjemplar()
        {
            VistaActual.Hide();
            _nuevoEjemplar.Show();
            VistaActual = _nuevoEjemplar;
        }

        public void IrANuevoLibro()
        {
            VistaActual.Hide();
            _nuevoLibro.Show();
            VistaActual = _nuevoLibro;
        }

        public void IrANuevoSocio()
        {
            VistaActual.Hide();
            _nuevoSocio.Show();
            VistaActual = _nuevoSocio;
        }

        public void IrAPrestamosYDevoluciones()
        {
            VistaActual.Hide();
            _prestamosYDevoluciones.Show();
            VistaActual = _prestamosYDevoluciones;
        }

        public void IrAOperaciones()
        {
            VistaActual.Hide();
            _operaciones.Show();
            VistaActual = _operaciones;
        }

        public void IrAListaDeLibros()
        {
            VistaActual.Hide();
            _listaDeLibros.Show();
            VistaActual = _listaDeLibros;
        }

        public void IrAListaDeSocios() 
        {
            VistaActual.Hide();
            _listaDeSocios.Show();
            VistaActual = _listaDeSocios;
        }

    }
}
