using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;

namespace Biblioteca.Utils
{
    public static class DataContractUtils
    {
        public static void Serialize(this object dataToSerialize, string filename)
        {
            DataContractSerializer serializer = new DataContractSerializer(dataToSerialize.GetType());
            using (var xmlFile = XmlWriter.Create(filename, new XmlWriterSettings { Indent = true }))
            {
               serializer.WriteObject(xmlFile, dataToSerialize);
            }
        }

        public static T Deserialize<T>(this T data, string filename) 
        {
            using (var xmlFile = XmlReader.Create(filename))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(T));
                return (T)serializer.ReadObject(xmlFile);
            }
        }

    }
}
