
using Lekcja_2B;

void Symulacja(IAtakujacy a, IObronca b)
{
    while(b.IsAlive)
    {
        a.ZadajObrazenia(b);
    }
}

Rycerz r = new Rycerz("Janusz", 12);
Wieza w = new Wieza();
Symulacja(r, w);
Console.WriteLine();