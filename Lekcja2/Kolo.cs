using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_2
{
    internal class Kolo : Figura
    {
        private readonly double r;

        public Kolo(int x, int y, string kolor, double r) : base(x, y, kolor)
        {
            this.r = r;
        }

        public override double Obwod => 2 * Math.PI * r;

        public override double Pole()
        {
            return Math.PI * r *r;
        }
    }
}
