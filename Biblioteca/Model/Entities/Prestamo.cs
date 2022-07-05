using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Biblioteca.Model
{
    [DataContract(Name = "Prestamo", Namespace = "")]
    [KnownType(typeof(SocioComun))]
    [KnownType(typeof(SocioVip))]
    public sealed class Prestamo
    {
        [DataMember(Name = "Nombre", Order = 1)]
        public Ejemplar Ejemplar { get;  set; }
        [DataMember(Name = "Socio", Order = 2)]
        public Socio Socio { get;  set; }
        [DataMember(Name = "FechaDePrestamo", Order = 3)]
        public DateTime FechaDePrestamo { get;  set; }

        public Prestamo(Socio socio, Ejemplar ejemplar)
        {
            Socio = socio;
            Ejemplar = ejemplar;
            FechaDePrestamo = DateTime.Now;
        }
    }
}
