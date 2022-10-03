using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja5B
{
    internal class Stos<T> where T : IComparable<T>
    {
        private T[] array;
        private int count;


        public Stos()
        {
            array = new T[10];
            count = 0;
        }

        public void Push(T element)
        {
            if(count < array.Length)
            {
                array[count++] = element;
            }
        }

        public T Pop()
        {
            if(count == 0)
            {
                throw new Exception("Pusty stos");
            }

            return array[--count];
        }

        public override string ToString()
        {
            //string text = string.Empty;
            //for(int i = 0; i < count; i++)
            //{
            //    text += array[i] + ", ";
            //}
            //return text;

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                sb.Append(array[i].ToString()).Append(", ");
            }
            return sb.ToString();
        }

        public void Sort()
        {
            Sort((x, y) => x.CompareTo(y));
        }

        public void Sort(Func<T, T, int> compare)
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = 0; j < count - i - 1; j++)
                {
                    if (compare(array[j], array[j+1]) > 0)
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                }
            }
        }
    }
}
