using Biblioteca.Model;
using Biblioteca.Utils;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Biblioteca.Controller
{
    public class LibrosController
    {
        public MessageResult AñadirNuevoLibro(string titulo, string codigoISBN, string autor)
        {
            if (DataBase.Libros.ContainsKey(codigoISBN))
            {
                return new MessageResult("Ya existe un libro con ese código ISBN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Libro libro = new Libro(titulo, codigoISBN, autor);
            DataBase.Libros.Add(libro.CodigoISBN, libro);

            DataBase.Libros.Update();

            return new MessageResult($"El libro {libro.Nombre} ha sido añadido", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public MessageResult AñadirEjemplarALibro(string codigoISBN, string numeroEdicion, string ubicacion)
        {
            if (!DataBase.Libros.TryGetValue(codigoISBN, out Libro libro))
            {
                return new MessageResult("No se encontro el libro con el código ISBN ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!uint.TryParse(numeroEdicion, out uint edicionId))
            {
                return new MessageResult("El numero de edicion no corresponde al formato requerido use unicamente números positivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            libro.AgregarEjemplar(edicionId, ubicacion);
            DataBase.Libros.Update();
            return new MessageResult($"El Ejemplar {numeroEdicion} del libro {libro.Nombre} con ubicación en {ubicacion} ha sido añadido", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
