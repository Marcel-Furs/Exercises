using Bogus;
using lekcja5B;


Stos<string> imiona = new Stos<string>();
for(int i = 0; i < 10; i++)
{
    Faker fake = new Faker();
    imiona.Push(fake.Person.FirstName);
}

Console.WriteLine(imiona);
imiona.Sort((x, y) => y.CompareTo(x));
Console.WriteLine(imiona);

Stos<Punkt> punkty = new Stos<Punkt>();
punkty.Push(new Punkt(10, 20));
punkty.Push(new Punkt(5, 1));
punkty.Push(new Punkt(100, 5));
punkty.Push(new Punkt(7, 178));
punkty.Push(new Punkt(56, 1));

Console.WriteLine(punkty);
punkty.Sort();
Console.WriteLine(punkty);
