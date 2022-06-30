using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Model
{
    [DataContract(Name = "SocioComun", Namespace = "")]
    public sealed class SocioComun : Socio
    {
        public SocioComun(string nombre, string apellido, ulong numeroDeIdentificacion)
            : base(nombre, apellido, numeroDeIdentificacion)
        {
            CantidadMaximaDeRetiro = 1;
        }
    }
}
