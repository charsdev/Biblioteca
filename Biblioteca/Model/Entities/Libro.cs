using System.Collections.Generic;
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
        public Queue<Ejemplar> Ejemplares { get; set; }

        public Libro(string nombre, string codigoISBN, string autor)
        {
            Nombre = nombre;
            CodigoISBN = codigoISBN;
            Autor = autor;
            Ejemplares = new Queue<Ejemplar>();
        }

        public void AgregarEjemplar(uint numeroDeEdicion, string ubicacion)
        {
            Ejemplares.Enqueue(new Ejemplar(this, numeroDeEdicion, ubicacion));
        }

        public bool TieneEjemplares()
        {
            return Ejemplares.Count > 0;
        }

        public Ejemplar PrestarUnEjemplar()
        {
           return Ejemplares.Dequeue();
        }

        public void ReingresarEjemplar(Ejemplar ejemplar)
        {
            Ejemplares.Enqueue(ejemplar);
        }
    }
}
