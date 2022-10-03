using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja7
{
    public static class ListExtension
    {
        public static void Show<T>(this IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
