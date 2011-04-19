using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Xml;
using System.Collections.Generic;
using System.Xml.Serialization;


namespace MobileStorage.Business
{
    public class XMLSerialize
    {
        static public void SerializeToXML(StorageItems pStorageItems, string pFilePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(StorageItems));
            TextWriter textWriter = new StreamWriter(pFilePath);
            serializer.Serialize(textWriter, pStorageItems);
            textWriter.Close();
        }

        static public void SerializeToXML(List<StorageItems> movies, string pFilePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<StorageItems>));
            TextWriter textWriter = new StreamWriter(pFilePath);
            serializer.Serialize(textWriter, movies);
            textWriter.Close();
        }

        static public List<StorageItems> DeserializeFromXML(string pFilePath)
        {
            XmlSerializer deserializer = new XmlSerializer(typeof(List<StorageItems>));
            TextReader textReader = new StreamReader(pFilePath);
            List<StorageItems> pStorageItems;
            pStorageItems = (List<StorageItems>)deserializer.Deserialize(textReader);
            textReader.Close();

            return pStorageItems;
        }
    }
}
