using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja6
{
    internal class Game
    {
        private double _normalPrice;
        private double _salePrice;
        private DateTime _releaseDate;

        public string title { get; set; }
        public string salePrice 
        { 
            get
            {
                return _salePrice.ToString();
            }
            set
            {
                _salePrice = double.Parse(value, CultureInfo.InvariantCulture);
            }
        }
        public string normalPrice 
        {
            get
            {
                return _normalPrice.ToString();
            }
            set
            {
                _normalPrice = double.Parse(value, CultureInfo.InvariantCulture);
            }
        }
        public string steamRatingText { get; set; }
        public long releaseDate
        {
            get
            {
                return (long)(_releaseDate - new DateTime(1970, 1, 1)).TotalSeconds;
            }
            set
            {
                _releaseDate = new DateTime(1970, 1, 1).AddSeconds(value);
            }
        }

        public override string ToString()
        {
            return $"{title,-50} {salePrice,5} {normalPrice,5} {steamRatingText,30} {_releaseDate}";
        }

        public double GetNormalPrice()
        {
            return _normalPrice;
        }
    }
}
