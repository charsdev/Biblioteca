using Biblioteca.Interfaces;
using Biblioteca.Utils;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Biblioteca.Model
{
    [CollectionDataContract(Name = "Prestamos")]
    public class Prestamos : List<Prestamo>, IUpdateable
    {
        public const string File = "prestamos.xml";

        public Prestamos()
        {
        }

        public void Update()
        {
            this.Serialize(File);
        }
    }
}


  