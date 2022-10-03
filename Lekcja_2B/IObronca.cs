using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja_2B
{
    internal interface IObronca
    {
        void PrzyjmijObrazenia(int ile);
        bool IsAlive { get; }
    }
}
