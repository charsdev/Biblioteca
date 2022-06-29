using Biblioteca.Interfaces;
using Biblioteca.Utils;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Biblioteca.Model
{
    [CollectionDataContract(Name = "Historial")]
    public class HisotorialDePrestamosYDevoluciones : List<Tuple<string, Prestamo, DateTime>>, ICollectionDataContract
    {
        public string File { get => "historial.xml"; }

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


  