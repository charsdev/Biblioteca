using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Biblioteca.Model
{
    [DataContract(Name = "Socio", IsReference = true, Namespace = "")]
    public abstract class Socio
    {
        [DataMember(Name = "Nombre", Order = 1)]
        public string Nombre { get; set; }
        [DataMember(Name = "Apellido", Order = 2)]
        public string Apellido { get; set; }
        [DataMember(Name = "NumeroDeIdentificacion", Order = 3)]
        public string NumeroDeIdentificacion { get; set; }
        [DataMember(Name = "EjemplaresRetirados", Order = 4)]
        public List<Ejemplar> EjemplaresRetirados { get; set; }
        [DataMember(Name = "CantidadMaximaDeRetiro", Order = 5)]
        protected uint CantidadMaximaDeRetiro { get; set; }

        protected Socio(string nombre, string apellido, string numeroDeIdentificacion)
        {
            Nombre = nombre;
            Apellido = apellido;
            NumeroDeIdentificacion = numeroDeIdentificacion;
            EjemplaresRetirados = new List<Ejemplar>();
        }

        public bool TieneCupoDisponibleParaRetiroDeLibro()
        {
            return EjemplaresRetirados.Count < CantidadMaximaDeRetiro;
        }

        public void PedirPrestadoEjemplar(Ejemplar ejemplar)
        {
            if (TieneCupoDisponibleParaRetiroDeLibro())
            {
                EjemplaresRetirados.Add(ejemplar);
            }
        }

        public void DevolverEjemplar(Ejemplar ejemplar)
        {
            EjemplaresRetirados.Remove(ejemplar);
        }

    }
  
}
