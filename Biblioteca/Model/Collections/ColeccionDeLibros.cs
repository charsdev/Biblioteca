using System.Collections.Generic;
using System.Runtime.Serialization;
using Biblioteca.Utils;
using Biblioteca.Interfaces;

namespace Biblioteca.Model
{
    [CollectionDataContract(Name = "Libros", ItemName = "Libro", KeyName = "ID", ValueName = "Data",
    Namespace = "")]
    public class ColeccionDeLibros : Dictionary<string, Libro>, ICollectionDataContract
    {
        public string File { get => "libros.xml"; }

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


  