using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja4
{
    internal class Plik : Element
    {
        private int rozmiar;

        public string Rozszerzenie => nazwa.Split(".")[1];

        public override int Rozmiar { get => rozmiar;}

        public Plik(string nazwa, int rozmiar) : base(nazwa)
        {
            this.rozmiar = rozmiar;
        }

    }
}
