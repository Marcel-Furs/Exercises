using System.Globalization;

namespace Lekcje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HttpClient client = new HttpClient();
            string text = client.GetAsync("http://api.nbp.pl/api/cenyzlota/last/20").Result.Content.ReadAsStringAsync().Result;
            var kursy = text.Split("},{");
            foreach (var item in kursy)
            {
                string data = item.Replace("\"", "").Replace("{", "").Replace("cena:", "").Replace("data:", "").Replace("}", "").Replace("[", "").Replace("]", "");
                string[] elements = data.Split(",");
                DateTime date = DateTime.Parse(elements[0]);
                double price = double.Parse(elements[1], CultureInfo.InvariantCulture);
                var czas = DateTime.Now - date;
                Console.WriteLine($"{date,20} {price,5} {czas.Days} days ago");
                Console.WriteLine();
            }

            DateTime dzisiaj = DateTime.Now;
            Console.WriteLine("Mamy rok: " + dzisiaj.Year);
        }
    }
}