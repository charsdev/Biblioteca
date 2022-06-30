using System;
using System.Collections.Generic;
using Biblioteca.Model;
using System.Linq;
using Biblioteca.Utils;
using System.Windows.Forms;

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
                    prestamo.Socio.NumeroDeIdentificacion.ToString(),
                    prestamo.Socio.Nombre + ' ' + prestamo.Socio.Apellido,
                    //Dado que solo hay dos opciones (Prestamo o Devolución) opto por un operador ternario
                    tipo == "Prestamo" ? prestamo.FechaDePrestamo.ToString() : fechaDevolucion.ToString()
                };
                filas.Add(row);
            }
            return filas;
        }

        public MessageResult RealizarPrestamo(string socioID, string libroID)
        {
            if (!ulong.TryParse(socioID, out ulong socioParseID))
            {
                return new MessageResult("El Numero de identificación no corresponde al formato requerido, utilice unicamente numeros positivos para identificar un socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!DataBase.Socios.TryGetValue(socioParseID, out Tuple<string, Socio> socio))
            {
                return new MessageResult("No se encontro un socio asociado a ese numero de identificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!DataBase.Libros.TryGetValue(libroID, out Libro libro))
            {
                return new MessageResult("No se encontro un libro con ese código ISBN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!libro.TieneEjemplares())
            {
                return new MessageResult("El libro que busca no tiene ejemplares.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!socio.Item2.TieneCupoDisponibleParaRetiroDeLibro())
            {
                return new MessageResult($"El Socio { socio.Item2.Nombre } { socio.Item2.Apellido } llegó al máximo de retiros disponibles.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Ejemplar ejemplarAPrestar = libro.PrestarUnEjemplar();
            socio.Item2.PedirPrestadoEjemplar(ejemplarAPrestar);
            Prestamo prestamo = new Prestamo(socio.Item2, ejemplarAPrestar);
            DataBase.Prestamos.Add(prestamo);
            DataBase.Historial.Add(Tuple.Create("Prestamo", prestamo, DateTime.Now));

            DataBase.UpdateAll();

            return new MessageResult($"Se ha prestado un ejemplar del libro {libro.Nombre} al socio {socio.Item2.Nombre} {socio.Item2.Apellido}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public MessageResult RecibirDevolucion(string socioID, string libroID)
        {
            if (!ulong.TryParse(socioID, out ulong socioParseID))
            {
                return new MessageResult("El Numero de identificación no corresponde al formato requerido, utilice unicamente numeros positivos para identificar un socio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!DataBase.Socios.TryGetValue(socioParseID, out Tuple<string, Socio> socio))
            {
                return new MessageResult("No se encontro un socio asociado a ese numero de identificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!DataBase.Libros.TryGetValue(libroID, out Libro libro))
            {
                return new MessageResult("No se encontro un libro con ese código ISBN", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!ObtenerEjemplarADevolver(libroID, socio.Item2, out Ejemplar ejemplarADevolver))
            {
                return new MessageResult($"No se encontro un ejemplar a devolver para el libro {libro.Nombre}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            socio.Item2.DevolverEjemplar(ejemplarADevolver);
            libro.ReingresarEjemplar(ejemplarADevolver);

            //Busca el ejemplar a devolver dentro de la lista de prestamos realizados 
            //para colocarlo tambien en la lista de devolucion
            //buscar el prestamo que sea del mismo usuario 

            MessageResult message = default(MessageResult);

            foreach (var item in
                from item in DataBase.Prestamos
                where item.Ejemplar.NumeroDeEdicion == ejemplarADevolver.NumeroDeEdicion
                where item.Socio.NumeroDeIdentificacion == socio.Item2.NumeroDeIdentificacion
                select item)
            {
                DataBase.Historial.Add(Tuple.Create("Devolución", item, DateTime.Now));
                DataBase.Prestamos.Remove(item);
                message = new MessageResult($"El ejemplar {ejemplarADevolver.NumeroDeEdicion} del libro {libro.Nombre} ha sido devuelto", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                break;
            }

            DataBase.UpdateAll();
            return message;
        }

        private bool ObtenerEjemplarADevolver(string libroID, Socio socio, out Ejemplar ejemplarADevolver)
        {
            ejemplarADevolver = default(Ejemplar);

            foreach (var ejemplar in socio.EjemplaresRetirados)
            {
                if (ejemplar.Libro.CodigoISBN == libroID)
                {
                    ejemplarADevolver = ejemplar;
                    return true;
                }
            }
            return false;
        }
    }
}
