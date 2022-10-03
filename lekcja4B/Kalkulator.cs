using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja4B
{
    internal class Kalkulator
    {
        public delegate double Operacja(double x, double y);

        private List<Operacja> operacje = new List<Operacja>();

        public void Add(Operacja op)
        {
            operacje.Add(op);
        }

        public double Oblicz(double x, double y, int nrOperacji)
        {
            return operacje[nrOperacji](x, y);
        }
    }
}
