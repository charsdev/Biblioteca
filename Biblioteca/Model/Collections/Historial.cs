using Biblioteca.Interfaces;
using Biblioteca.Utils;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Biblioteca.Model
{
    [CollectionDataContract(Name = "Historial")]
    public class Historial : List<Tuple<string, Prestamo, DateTime>>, IUpdateable
    {
        public const string File = "historial.xml";

        public Historial()
        {
        }

        public void Update()
        {
            this.Serialize(File);
        }

    }
}


  