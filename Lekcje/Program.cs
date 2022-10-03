namespace Lekcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //cw + 2x tab
            Console.WriteLine("Podaj liczbe");
            int liczba = int.Parse(Console.ReadLine());
            Console.WriteLine($"Twoja liczba to: {liczba}.");
            Console.WriteLine("Podaj imie");
            string imie = Console.ReadLine();
            Console.WriteLine("Twoje imie to: " + imie);

            int[] tablica = new int[10];
            decimal[] numbers = { 5, 9, 10, 4, 7 };
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            //Garbage Collector

            File.WriteAllText("dane.txt", "ala ma kota");
            using(StreamWriter sw = new StreamWriter("dane2.txt"))
            {
                sw.WriteLine("Ala");
                sw.WriteLine("ma");
                sw.WriteLine("kota");
            }

            
            string allText = File.ReadAllText("dane2.txt");
            Console.WriteLine(allText);
            Console.WriteLine();
            using (StreamReader sr = new StreamReader("dane2.txt"))
            {
                while(!sr.EndOfStream)
                {
                    Console.WriteLine(sr.ReadLine());
                }
            }

            string text = "Latawiec – zabytkowe osiedle mieszkaniowe znajdujące się w dzielnicy Śródmieście w Warszawie, wybudowane w latach 50. XX wieku. Powstało w miejscu zabudowy prawie całkowicie zniszczonej w czasie II wojny światowej, na tzw. Osi Stanisławowskiej.";
            text = text.Replace(".", "").Replace(",", "").Replace("-", "");
            string[] slowa = text.Split(" ");
            Console.WriteLine(slowa.Contains("50"));
        }
    }
}