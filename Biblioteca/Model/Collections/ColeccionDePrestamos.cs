using Biblioteca.Interfaces;
using Biblioteca.Utils;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Biblioteca.Model
{
    [CollectionDataContract(Name = "Prestamos")]
    public class ColeccionDePrestamos : List<Prestamo>, ICollectionDataContract
    {
        public string File { get => "prestamos.xml"; }

        public void Update()
        {
            this.Serialize(File);
        }

        public new void Clear()
        {
            base.Clear();
            this.Serialize(File);
        }
    }
}


  