using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Biblioteca.Model
{
    [DataContract(Name = "SocioVip", Namespace = "")]
    public sealed class SocioVip : Socio
    {
        [DataMember(Name ="CuotaMensual")]
        private readonly decimal _cuotaMensual;

        public SocioVip()
        {

        }

        public SocioVip(string nombre, string apellido, ulong numeroDeIdentificacion, decimal cuotaMensual)
            : base(nombre, apellido, numeroDeIdentificacion)
        {
            _cuotaMensual = cuotaMensual;
            CantidadMaximaDeRetiro = 3;
        }
    }
}
