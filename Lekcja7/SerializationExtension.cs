using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lekcja7
{
    public static class SerializationExtension
    {
        public static void SerializeXML<T>(this T element, string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                xml.Serialize(sw, element);
            }
        }

        public static T DeserializeXML<T>(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                XmlSerializer xml = new XmlSerializer(typeof(T));
                return (T)xml.Deserialize(sr);
            }
        }
    }
}
