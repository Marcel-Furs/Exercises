using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja4
{
    internal abstract class Element
    {
        protected string nazwa;

        public Element(string nazwa)
        {
            this.nazwa = nazwa;
        }

        public virtual void Pokaz(int wciecie = 0)
        {
            for(int i = 0; i < wciecie; i++)
            {
                Console.Write(" ");
            }
            Console.WriteLine(nazwa);
        }

        public abstract int Rozmiar { get; }
    }
}
