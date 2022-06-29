using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Linq;
using System.Runtime.Serialization;

namespace Biblioteca.Model
{
    [DataContract(IsReference = true, Name ="Libro", Namespace = "")]
    public class Libro {
        [DataMember(Name = "Nombre", Order = 1)]
        public string Nombre { get; set; }
        [DataMember(Name = "CodigoISBN", Order = 2)]
        public string CodigoISBN { get; set; }
        [DataMember(Name = "Autor", Order = 3)]
        public string Autor { get; set; }
        [DataMember(Name = "Ejemplares", Order = 4)]
        private Queue<Ejemplar> _ejemplares { get; set; }

        public Libro()
        {

        }

        public Libro(string nombre, string codigoISBN, string autor)
        {
            Nombre = nombre;
            CodigoISBN = codigoISBN;
            Autor = autor;
            _ejemplares = new Queue<Ejemplar>();
        }

        public void AgregarEjemplar(uint numeroDeEdicion, string ubicacion)
        {
            _ejemplares.Enqueue(new Ejemplar(this, numeroDeEdicion, ubicacion));
        }

        public bool TieneEjemplares()
        {
            return _ejemplares.Count > 0;
        }

        public Ejemplar PrestarUnEjemplar()
        {
           return _ejemplares.Dequeue();
        }

        public void ReingresarEjemplar(Ejemplar ejemplar)
        {
            _ejemplares.Enqueue(ejemplar);
        }

    }
}
