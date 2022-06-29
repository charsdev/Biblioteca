using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace Biblioteca.Model
{
    [DataContract(IsReference = true, Name="Ejemplar", Namespace ="")]
    public sealed class Ejemplar  
    {
        [DataMember(Order = 1)]
        public uint NumeroDeEdicion { get; set; }
        [DataMember(Order = 2)]
        public string Ubicacion { get; set; }
        [DataMember(Order = 3)]
        public Libro Origen { get; set; }

        public Ejemplar()
        {

        }

        public Ejemplar(Libro origen, uint numeroDeEdicion, string ubicacion)
        {
            NumeroDeEdicion = numeroDeEdicion;
            Ubicacion = ubicacion;
            Origen = origen;
        }
    }
}
