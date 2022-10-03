using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja3
{
    internal record Przedmiot(string Nazwa, string Kategoria, double Cena) : IComparable<Przedmiot>
    {
        public double CenaBrutto() => Cena * 1.23;

        public int CompareTo(Przedmiot? other)
        {
            return Nazwa.CompareTo(other.Nazwa);
        }
    }
}
