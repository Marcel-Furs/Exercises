using Lekcja7;
using System.Text.Json;

//HttpClient httpClient = new HttpClient();
//var data = httpClient.GetAsync("https://api.covid19api.com/countries").Result.Content.ReadAsStringAsync().Result;

//var countries = JsonSerializer.Deserialize<List<CountryData>>(data);
//countries.ForEach(x => Console.WriteLine(x));

//var c = new Countries(countries);
//c.SerializeBin("data.bin");

var c = Countries.DeserializeBin("data.bin");
Console.WriteLine();

c.SerializeXML("data.xml");
c = SerializationExtension.DeserializeXML<Countries>("data.xml");
Console.WriteLine();

c.SerializeJSON("data.json");
c = Countries.DeserializeJSON("data.json");
Console.WriteLine();

string text = "ala ma kota";
//Console.WriteLine(StringExtension.RemoveSpaces(text));
Console.WriteLine(text.RemoveSpaces());

c.CountriesList.Show();

HashSet<int> liczby = new HashSet<int>();
liczby.Add(2);
liczby.Add(5);
liczby.Add(5);
liczby.Add(1);
liczby.Add(5);
liczby.Show();


int[] tablica = { 10, 5, 8, 1, 6, 9, 1, 100 };
tablica.Show();


DateTime.Now.SerializeXML("now.xml");

tablica.SerializeXML("array.xml");

Console.WriteLine(SerializationExtension.DeserializeXML<DateTime>("now.xml"));