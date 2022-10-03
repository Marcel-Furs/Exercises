using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja4
{
    internal class Phone : ISubscriber
    {
        public void Update()
        {
            Console.WriteLine("Send sms: warning, window is open");
        }
    }
}
