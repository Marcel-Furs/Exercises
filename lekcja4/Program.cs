//Singleton
//-jeden obiekt, nie mozna towrzyc kolejnych
//-powinien byc dostepny wszedzie
//-powinien byc tworzony przy pierwszym uzyciu


using lekcja4;

//Settings s = new Settings();
//Console.WriteLine(s.Resolution);


Settings.Instance.Sound = 95;


//Kompozyt
Folder f = new Folder("doc");
Plik p1 = new Plik("dane.txt", 10);
Plik p2 = new Plik("tekst.docx", 20);

f.Add(p1);
f.Add(p2);

Folder f2 = new Folder("podfolder");
f2.Add(new Plik("xxx.txt", 100));
f.Add(f2);

f.Pokaz();
Console.WriteLine(f2.Rozmiar);
Console.WriteLine(f.Rozmiar);
Console.WriteLine(p1.Rozmiar);

//Obserwator (Observer)
//-element ktory zmienia stan informuje o tym swoich odbiorcow (obserwatorow)

ISubscriber light = new Light();
Home home = new Home();
home.Add(new Alaram());
home.Add(new Phone());
home.Add(light);

home.OpenWindow();

home.Remove(light);
Console.WriteLine();
home.OpenWindow();