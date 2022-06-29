using System;
using System.Collections.Generic;
using Biblioteca.Model;
using System.Linq;
using Biblioteca.Utils;
using System.Windows.Forms;

namespace Biblioteca.Controller
{
    public class BibliotecaController
    {
        private const string MensajeErrorIdFormato = "El id no corresponde al formato requerido, utilice unicamente numeros positivos para identificar un socio.";
        private const string MensajeErrorIdSocioNoEncontrado = "No se encontro el socio con el id ";
        private const string MensajeErrorIdLibroNoEncontrado = "No se encontro el libro con el código ISBN ";

        public MessageResult AñadirNuevoSocioComun(string nombre, string apellido, string numeroIdentificador)
        {
            if (!ulong.TryParse(numeroIdentificador, out ulong SocioID))
            {
                return new MessageResult(MensajeErrorIdFormato, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (DataBase.Socios.ContainsKey(SocioID))
            {
                return new MessageResult("Ya existe un socio con ese número de identificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Socio socio = new SocioComun(nombre, apellido, SocioID);
            DataBase.Socios.Add(socio.NumeroDeIdentificacion, Tuple.Create("Común", socio));
            DataBase.Socios.Update();

            return new MessageResult($"El Socio {socio.Nombre} {socio.Apellido} ha sido añadido", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public MessageResult AñadirNuevoSocioVip(string nombre, string apellido, string numeroIdentificador, string cuotaMensual)
        {
            if (!ulong.TryParse(numeroIdentificador, out ulong SocioID))
            {
                return new MessageResult(MensajeErrorIdFormato, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (DataBase.Socios.ContainsKey(SocioID))
            {
                return new MessageResult("Ya existe un socio con ese número de identificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!decimal.TryParse(cuotaMensual, out decimal cuotaMensualParsed))
            {
                return new MessageResult("La cuota mensual debe ser expresada como decimal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Socio socio = new SocioVip(nombre, apellido, SocioID, cuotaMensualParsed);
            DataBase.Socios.Add(socio.NumeroDeIdentificacion, Tuple.Create("VIP", socio));
            DataBase.Socios.Update();
            return new MessageResult($"El Socio {socio.Nombre} {socio.Apellido} ha sido añadido", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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
                return new MessageResult(MensajeErrorIdLibroNoEncontrado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!uint.TryParse(numeroEdicion, out uint edicionId))
            {
                return new MessageResult("El numero de edicion no corresponde al formato requerido use unicamente números positivos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            libro.AgregarEjemplar(edicionId, ubicacion);
            DataBase.Libros.Update();
            return new MessageResult($"El Ejemplar {numeroEdicion} del libro {libro.Nombre} con ubicación en {ubicacion} ha sido añadido", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

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

        public List<string[]> ObtenerListadoSocios()
        {
            List<string[]> filas = new List<string[]>();

            int i = 1;
            foreach (var key in DataBase.Socios.Keys)
            {
                string nombre = DataBase.Socios[key].Item2.Nombre;
                string apellido = DataBase.Socios[key].Item2.Apellido;
                ulong numeroDeIdentificacion = key;
                string tipo = DataBase.Socios[key].Item1;

                string[] row = new string[]
                {
                    i.ToString(),
                    nombre,
                    apellido,
                    numeroDeIdentificacion.ToString(),
                    tipo
                };
                filas.Add(row);
                i++;
            }
            return filas;
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

        public MessageResult RealizarPrestamo(string socioID, string libroID)
        {
            if (!ulong.TryParse(socioID, out ulong socioParseID))
            {
                return new MessageResult(MensajeErrorIdFormato, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!DataBase.Socios.TryGetValue(socioParseID, out Tuple<string, Socio> socio))
            {
                return new MessageResult(MensajeErrorIdSocioNoEncontrado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!DataBase.Libros.TryGetValue(libroID, out Libro libro))
            {
                return new MessageResult(MensajeErrorIdLibroNoEncontrado, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                return new MessageResult(MensajeErrorIdFormato, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!DataBase.Socios.TryGetValue(socioParseID, out Tuple<string, Socio> socio))
            {
                return new MessageResult(MensajeErrorIdSocioNoEncontrado + socioParseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!DataBase.Libros.TryGetValue(libroID, out Libro libro))
            {
                return new MessageResult(MensajeErrorIdLibroNoEncontrado + libro, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!ObtenerEjemplarADevolver(libroID, socio.Item2, out Ejemplar ejemplarADevolver))
            {
                return new MessageResult($"No se encontro un ejemplar a devolver para el libro {libro.Nombre}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            socio.Item2.DevolverEjemplar(ejemplarADevolver);
            libro.ReingresarEjemplar(ejemplarADevolver);

            //Busca el ejemplar a devolver dentro de la lista de prestamos realizados 
            // para colocarlo tambien en la lista de devolucion
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
