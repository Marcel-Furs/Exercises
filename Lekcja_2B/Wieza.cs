using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_2B
{
    internal class Wieza : IObronca, IAtakujacy
    {
        private int odpornosc;

        public Wieza()
        {
            odpornosc = 100;   
        }

        public bool IsAlive => odpornosc > 0;

        public void PrzyjmijObrazenia(int ile)
        {
            odpornosc -= ile / 2;
            if(odpornosc < 0)
            {
                odpornosc = 0;
            }
        }

        public void ZadajObrazenia(IObronca o)
        {
            if(odpornosc > 0)
            {
                o.PrzyjmijObrazenia(30);
            }
        }
    }
}
