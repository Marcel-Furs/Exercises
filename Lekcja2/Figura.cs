using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_2
{
    internal abstract class Figura
    {
        private int x;
        private int y;
        private string kolor;

        public Figura(int x, int y, string kolor)
        {
            this.x = x;
            this.y = y;
            this.kolor = kolor;
        }

        public abstract double Pole();
        public abstract double Obwod { get; }
    }
}
