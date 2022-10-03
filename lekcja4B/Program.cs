using lekcja4B;
using static lekcja4B.Tools;

void hello()
{
    Console.WriteLine("Hello world");
}

//Jaki ma byc typ zwracany funkcji oraz jakie argumenty ma przyjmowac?? 


MyFunction funkcja = hello;
funkcja();

double Dodawanie(double a, double b)
{
    return a + b;
}

double Odejmowanie(double a, double b)
{
    return a - b;
}

Kalkulator k = new Kalkulator();
k.Add(Dodawanie);
k.Add(Odejmowanie);
k.Add((a, b) => a * b);
k.Add(Math.Pow);
k.Add((a, b) => a / b);

Console.WriteLine("Podaj wartosc nr 1");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj wartosc nr 2");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Podaj nr operacji");
int nr = int.Parse(Console.ReadLine());
Console.WriteLine("Wynik to: " + k.Oblicz(a, b, nr));

Action akcja = hello;
akcja();