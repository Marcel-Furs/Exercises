using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekcja7
{
    public static class StringExtension
    {
        public static string RemoveSpaces(this string text)
        {
            return text.Replace(" ", "");
        }
    }
}
