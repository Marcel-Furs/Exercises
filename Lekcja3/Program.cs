using Lekcja3;

int x = 10;
int y = x;
x = 5;
Console.WriteLine(y);
//typy wartosciowe: int long float double struktura
//typy referencyjne: klasy, tablice, listy 

User user = new User
{
    Email = "ada@gmail.com",
    Username = "ada"
};

User user2 = user;
user.Email = "ola@gmail.com";

Console.WriteLine(user.Email);
Console.WriteLine(user2.Email);


Punkt p = new Punkt(10, 20);

Punkt p2 = p;
p.X = 100;
p.Y = 300;

Console.WriteLine(p);
Console.WriteLine(p2);

DateTime date = DateTime.Now;
Console.WriteLine(date);


Przedmiot przedmiot = new Przedmiot("Mleko", "Nabial", 4);
Console.WriteLine(przedmiot.Nazwa);
Console.WriteLine(przedmiot);

Przedmiot przedmiot2 = przedmiot with { Cena = 8 };
Console.WriteLine(przedmiot2);

Console.WriteLine(przedmiot2.CenaBrutto());

List<Punkt> punkty = new List<Punkt>() { p, p2 };
punkty.Add(new Punkt(10, 5));
punkty.Add(new Punkt(1, 7));
punkty.Add(new Punkt(2, 9));
Console.WriteLine(punkty.Count);

for(int i = 0; i < punkty.Count; i++)
{
    Console.WriteLine(punkty[i]);
}

foreach (var item in punkty)
{
    Console.WriteLine(item);
}

Punkt szukany = new Punkt(2, 9);
Console.WriteLine(punkty.Contains(szukany));
punkty.Remove(szukany);

Console.WriteLine();
foreach (var item in punkty)
{
    Console.WriteLine(item);
}

punkty.RemoveAt(1);
Console.WriteLine();
foreach (var item in punkty)
{
    Console.WriteLine(item);
}

List<Punkt> points = new List<Punkt>();
points.Add(new Punkt(1, 100));
points.Add(new Punkt(100, 4));
points.Add(new Punkt(5, 4));
points.Add(new Punkt(7, 8));
points.Add(new Punkt(88, 7));
points.Add(new Punkt(14, 4));
points.Add(new Punkt(78, 6));
points.Add(new Punkt(1, 100));
points.Add(new Punkt(78, 8));
points.Add(new Punkt(100, 50));
points.Add(new Punkt(1, 1));

List<Punkt> bliskie = new List<Punkt>();
foreach (var item in points)
{
    if(Math.Sqrt(item.X * item.X + item.Y * item.Y) < 10)
    {
        bliskie.Add(item);
    }
}

Console.WriteLine();
foreach (var item in bliskie)
{
    Console.WriteLine(item);
}


Console.WriteLine();
List<Punkt> bliskie2 = points.Where(item => Math.Sqrt(item.X * item.X + item.Y * item.Y) < 10).ToList();
bliskie2.ForEach(x => Console.WriteLine(x));


int ileWsporz = points.Count(x => x.X < 10 && x.Y < 10);
Console.WriteLine("Ile: " + ileWsporz);

Console.WriteLine(points.Any(x => x.X > 10 && x.Y > 10));


List<Przedmiot> przedmioty = new List<Przedmiot>
{
    new Przedmiot("Maslo", "Nabial", 8),
    new Przedmiot("Lipton", "Sypkie", 14),
    new Przedmiot("Lipton Black", "Sypkie", 20),
    przedmiot,
    przedmiot2,
    new Przedmiot("Fortuna Czarna", "Piwo", 6.2),
};

List<double> ceny = przedmioty.Select(x => x.Cena).ToList();
ceny.ForEach(x => Console.Write(x + " "));