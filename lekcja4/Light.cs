using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja4
{
    internal class Light : ISubscriber
    {
        public void Update()
        {
            Console.WriteLine("Light ON");
        }
    }
}
