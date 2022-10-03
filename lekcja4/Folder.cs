using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja4
{
    internal class Folder : Element
    {
        private List<Element> elements;
        public Folder(string nazwa) : base(nazwa)
        {
            elements = new List<Element>(); 
        }

        public override int Rozmiar => elements.Sum(x => x.Rozmiar);

        public void Add(Element e)
        {
            elements.Add(e);
        }

        public override void Pokaz(int wciecie = 0)
        {
            base.Pokaz(wciecie);
            foreach (var item in elements)
            {
                item.Pokaz(wciecie + 3);
            }
        }
    }
}
