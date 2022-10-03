
using Lekcja_2;

User u = new User("ada", "ada@gmail.com", "1234", 2000);
Console.WriteLine(u);
Console.WriteLine(u.Name);
Console.WriteLine(u.Payment());
u.Name = "Ola";

User u2 = new Administrator("Ania", "ania@gmail.com", "5678", 2000, 0.5);
Console.WriteLine(u2.Payment());


Random random = new Random();
Console.WriteLine(random.ToString());

int a = 15;
Console.WriteLine(a.ToString());


User? u3 = null;
int? x = null; //? - zmienna jest w stanie akceptowac null

