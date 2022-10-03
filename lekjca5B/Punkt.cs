using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lekcja5B
{
    internal struct Punkt : IEqualityComparer<Punkt>, IComparable<Punkt>
    {
        private int x;
        private int y;

        public Punkt(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }

        public double Odl0 => Math.Sqrt(X * X + Y * Y);

        public bool Equals(Punkt a, Punkt b)
        {
            return a.X == b.X && a.Y == b.Y;
        }

        public int GetHashCode([DisallowNull] Punkt obj)
        {
            return HashCode.Combine(x, y);
        }

        public override string? ToString()
        {
            return $"({x}, {y})"; 
        }

        public override bool Equals(object? obj) //zeby dzialalo contains listy trzeba nadpisac metode Equals z Object
        {
            if(obj is Punkt p)
            {
                return Equals(this, p);
            }
            return false;
        }

        public int CompareTo(Punkt other)
        {
            return Odl0.CompareTo(other.Odl0);
        }
    }
}
