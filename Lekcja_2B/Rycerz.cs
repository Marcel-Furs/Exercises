using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_2B
{
    internal class Rycerz : Postac, IAtakujacy
    {
        private int atak;

        public Rycerz(string nazwa, int atak) : base(nazwa)
        {
            this.atak = atak;
        }

        public void ZadajObrazenia(IObronca o)
        {
            o.PrzyjmijObrazenia(atak);
        }
    }
}
