using System.Collections.Generic;
using System.Runtime.Serialization;
using Biblioteca.Interfaces;
using Biblioteca.Utils;
using System;

namespace Biblioteca.Model
{
    [CollectionDataContract(Name="Socios", ItemName = "Socio", KeyName = "ID", ValueName = "Data",
    Namespace = "")]
    [KnownType(typeof(SocioComun))]
    [KnownType(typeof(SocioVip))]
    public class ColeccionDeSocios : Dictionary<string, Tuple<string, Socio>>, ICollectionDataContract
    {
        public string File { get => "socios.xml"; }

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


  