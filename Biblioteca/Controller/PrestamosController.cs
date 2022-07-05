using System;
using System.Collections.Generic;
using Biblioteca.Model;
using System.Linq;
using Biblioteca.Utils;
using System.Windows.Forms;
using System.ComponentModel.DataAnnotations;

namespace Biblioteca.Controller
{
    public class PrestamosController
    {
        public List<string[]> ObtenerListadoPrestamos()
        {
            List<string[]> filas = new List<string[]>();

            for (int i = 0; i < DataBase.Historial.Count; i++)
            {
                string tipo = DataBase.Historial[i].Item1;
                Prestamo prestamo = DataBase.Historial[i].Item2;
                DateTime fechaDevolucion = DataBase.Historial[i].Item3;

                string[] row = new string[]
                {
                    (i + 1).ToString(),
                    tipo,
                    prestamo.Ejemplar.Libro.CodigoISBN,
                    prestamo.Ejemplar.Libro.Nombre,
                    prestamo.Socio.NumeroDeIdentificacion,
                    prestamo.Socio.Nombre + ' ' + prestamo.Socio.Apellido,
                    //Dado que solo hay dos opciones (Prestamo o Devolución) opto por un operador ternario
                    tipo == "Prestamo" ? prestamo.FechaDePrestamo.ToString() : fechaDevolucion.ToString()
                };
                filas.Add(row);
            }
            return filas;
        }

        public void RealizarPrestamo(string socioID, string codigoISBN)
        {
            if (!DataBase.Socios.TryGetValue(socioID, out Tuple<string, Socio> socio))
            {
                MessageBox.Show("No se encontro un socio asociado a ese numero de identificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!DataBase.Libros.TryGetValue(codigoISBN, out Libro libro))
            {
                MessageBox.Show("No se encontro un libro con ese código ISBN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!libro.TieneEjemplares())
            {
                MessageBox.Show("El libro que busca no tiene ejemplares", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        
            if (!socio.Item2.TieneCupoDisponibleParaRetiroDeLibro())
            {
                MessageBox.Show($"El Socio { socio.Item2.Nombre } { socio.Item2.Apellido }" +
                    " llegó al máximo de retiros disponibles.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            Ejemplar ejemplarAPrestar = libro.PrestarUnEjemplar();
            socio.Item2.PedirPrestadoEjemplar(ejemplarAPrestar);
            Prestamo prestamo =  new Prestamo(socio.Item2, ejemplarAPrestar);
            DataBase.Prestamos.Add(prestamo);
            DataBase.Historial.Add(Tuple.Create("Prestamo", prestamo, DateTime.Now));
            DataBase.UpdateAll();

            MessageBox.Show($"Se ha prestado un ejemplar del libro {libro.Nombre} " +
                $"al socio {socio.Item2.Nombre} {socio.Item2.Apellido}",
                "Success", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        public void RecibirDevolucion(string socioID, string codigoISBN)
        {
            if (!DataBase.Socios.TryGetValue(socioID, out Tuple<string, Socio> socio))
            {
                MessageBox.Show("El libro que busca no tiene ejemplares", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!DataBase.Libros.TryGetValue(codigoISBN, out Libro libro))
            {
                MessageBox.Show("El libro que busca no tiene ejemplares", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ObtenerEjemplarADevolver(codigoISBN, socio.Item2, out Ejemplar ejemplarADevolver))
            {
                MessageBox.Show($"No se encontro un ejemplar a devolver para el libro {libro.Nombre}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            socio.Item2.DevolverEjemplar(ejemplarADevolver);
            libro.ReingresarEjemplar(ejemplarADevolver);

            //Busca el ejemplar a devolver dentro de la lista de prestamos realizados 
            //para colocarlo tambien en la lista de devolucion
            //buscar el prestamo que sea del mismo usuario 

            string message = "";
            foreach (var item in DataBase.Prestamos)
            {
                if (item.Ejemplar.NumeroDeEdicion == ejemplarADevolver.NumeroDeEdicion
                    && item.Socio.NumeroDeIdentificacion == socio.Item2.NumeroDeIdentificacion)
                {
                    DataBase.Historial.Add(Tuple.Create("Devolución", item, DateTime.Now));
                    DataBase.Prestamos.Remove(item);
                    message = $"El ejemplar {ejemplarADevolver.NumeroDeEdicion} del libro {libro.Nombre} ha sido devuelto";
                    break;
                }
            }

            DataBase.UpdateAll();
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private bool ObtenerEjemplarADevolver(string CodigoISBN, Socio socio, out Ejemplar ejemplarADevolver)
        {
            ejemplarADevolver = default;

            foreach (var ejemplar in socio.EjemplaresRetirados)
            {
                if (ejemplar.Libro.CodigoISBN == CodigoISBN)
                {
                    ejemplarADevolver = ejemplar;
                    return true;
                }
            }
            return false;
        }
    }

   
}
