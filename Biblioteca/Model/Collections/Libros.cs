using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using Biblioteca.Utils;
using Biblioteca.Interfaces;

namespace Biblioteca.Model
{
    [CollectionDataContract(Name = "Libros", ItemName = "Libro", KeyName = "ID", ValueName = "Data",
    Namespace = "")]
    public class Libros : Dictionary<string, Libro>, IUpdateable
    {
        public const string File = "libros.xml";

        public Libros()
        {
        }

        public void Update()
        {
            this.Serialize(File);
        }
    }
}


  