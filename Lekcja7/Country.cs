using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja7
{
    [Serializable]
    public class CountryData
    {

        public string Country { get; set; }
        public string Slug { get; set; }
        public string ISO2 { get; set; }

        public override string ToString()
        {
            return $"{Country} {Slug} {ISO2}";
        }
    }
}
