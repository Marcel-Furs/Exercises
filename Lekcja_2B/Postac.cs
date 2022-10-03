using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_2B
{
    internal class Postac : IObronca
    {
        private string nazwa;
        private int hp;

        public string Nazwa { get => nazwa; set => nazwa = value; }
        public int Hp { get => hp; set => hp = value; }

        public bool IsAlive => hp > 0;

        public Postac(string nazwa)
        {
            this.Nazwa = nazwa;
            Hp = 100;
        }

        public void PrzyjmijObrazenia(int ile)
        {
            hp -= ile;
            if(hp < 0)
            {
                hp = 0;
            }
        }
    }
}
