using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lekcja7
{
    [Serializable] //to jest atrybut 
    public class Countries
    {
        private List<CountryData> countries;
        private DateTime data = DateTime.Now;

        public List<CountryData> CountriesList { get => countries; set => countries = value; }
        public DateTime Data { get => data; set => data = value; }

        public Countries()
        {
            this.CountriesList = new List<CountryData>();
        }

        public Countries(List<CountryData> countries)
        {
            this.CountriesList = countries;
        }

        public void SerializeBin(string filename)
        {
            using(FileStream fs = new FileStream(filename, FileMode.Create))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, this);
            }
        }

        public static Countries DeserializeBin(string filename)
        {
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                return bf.Deserialize(fs) as Countries;
            }
        }

        public void SerializeJSON(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write(JsonSerializer.Serialize(this));
            }
        }

        public static Countries DeserializeJSON(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                return JsonSerializer.Deserialize<Countries>(sr.ReadToEnd());
            }
        }
    }
}
