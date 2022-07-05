using Biblioteca.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Biblioteca.Controller
{
    public class LibrosController
    {
        public void AñadirNuevoLibro(string titulo, string codigoISBN, string autor)
        {
            if (DataBase.Libros.ContainsKey(codigoISBN))
            {
                MessageBox.Show("Ya existe un libro con ese código ISBN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Libro libro = new Libro(titulo, codigoISBN, autor);

            DataBase.Libros.Add(codigoISBN, libro);
            DataBase.Libros.Update();
            MessageBox.Show($"El libro {libro.Nombre} ha sido añadido", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void AñadirEjemplarALibro(string codigoISBN, uint numeroEdicion, string ubicacion)
        {
            if (!DataBase.Libros.TryGetValue(codigoISBN, out Libro libro))
            {
                MessageBox.Show("No se encontró el libro con el código ISBN ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            libro.AgregarEjemplar(numeroEdicion, ubicacion);
            DataBase.Libros.Update();
            MessageBox.Show($"Se ha agregado el ejemplar para el libro {libro.Nombre}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public List<string[]> ObtenerListadoLibros()
        {
            List<string[]> filas = new List<string[]>();

            int i = 1;
            foreach (var key in DataBase.Libros.Keys)
            {
                string titulo = DataBase.Libros[key].Nombre;
                string autor = DataBase.Libros[key].Autor;
                string CodigoISBN = key;

                string[] row = new string[]
                {
                    i.ToString(),
                    titulo,
                    autor,
                    CodigoISBN,
                };
                filas.Add(row);
                i++;
            }
            return filas;
        }

        public void ObtenerListadoEjemplares(string codigoISBN, out List<string[]> ejemplaresDisponibles)
        {
            ejemplaresDisponibles = new List<string[]>();

            if (!DataBase.Libros.TryGetValue(codigoISBN, out Libro libro))
            {
                MessageBox.Show("No se encontro un libro con ese código ISBN.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }
            
            if (!libro.TieneEjemplares())
            {
                MessageBox.Show("El libro no tiene ejemplares disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            int i = 1;
            foreach (var ejemplar in libro.Ejemplares)
            {
                string ubicacion = ejemplar.Ubicacion;
                uint numeroDeEdicion = ejemplar.NumeroDeEdicion;
                string titulo = ejemplar.Libro.Nombre;

                string[] row = new string[]
                {
                    i.ToString(),
                    titulo,
                    ubicacion,
                    numeroDeEdicion.ToString(),
                };
                ejemplaresDisponibles.Add(row);
                i++;
            }
            MessageBox.Show("Se han traido todos los ejemplares disponibles", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
