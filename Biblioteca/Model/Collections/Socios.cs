using System.Collections.Generic;
using System.Runtime.Serialization;
using Biblioteca.Interfaces;
using Biblioteca.Utils;
using System.Collections;
using System;

namespace Biblioteca.Model
{
    [CollectionDataContract(Name="Socios", ItemName = "Socio", KeyName = "ID", ValueName = "Data",
    Namespace = "")]
    [KnownType(typeof(SocioComun))]
    [KnownType(typeof(SocioVip))]
    public class Socios : Dictionary<ulong, Tuple<string, Socio>>, IUpdateable
    {
        public const string File = "socios.xml";

        public Socios()
        {
        }

        public void Update()
        {
            this.Serialize(File);
        }
    }

 
}


  