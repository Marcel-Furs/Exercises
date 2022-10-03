using Lekcja6;
using System.Globalization;
using System.Text.Json;

//string imie = Console.ReadLine();
//string plec = imie.EndsWith("a") ? "kobieta" : "mezczyzna";
//Console.WriteLine("Jestes " + plec);

HttpClient httpClient = new HttpClient();
var data = httpClient.GetAsync("https://www.cheapshark.com/api/1.0/deals?storeID=1&upperPrice=1000").Result.Content.ReadAsStringAsync().Result;

var games = JsonSerializer.Deserialize<List<Game>>(data);
games = games.OrderByDescending(x => x.salePrice).ToList();
games.ForEach(x => Console.WriteLine(x));

Console.WriteLine();
Game bestGame = games.FirstOrDefault(x => x.steamRatingText == "Overwhelmingly Positive");
Console.WriteLine(bestGame);

var max = games.Max(x => x.GetNormalPrice());
Console.WriteLine(max);

var maxGame = games.OrderByDescending(x => x.GetNormalPrice()).FirstOrDefault();
Console.WriteLine(maxGame);

maxGame = games.Aggregate((x, y) => x.GetNormalPrice() > y.GetNormalPrice() ? x : y);
Console.WriteLine(maxGame);


var rates = games.Select(x => x.steamRatingText).Distinct().ToList();
rates.ForEach(x => Console.WriteLine(x));

Console.WriteLine();
var groups = games.GroupBy(x => x.steamRatingText).ToList();

//foreach (var group in groups)
//{
//    Console.WriteLine(group.Key + "-----------------------------------------------");
//    foreach (var item in group)
//    {
//        Console.WriteLine(item);
//    }
//}

groups.ForEach(x =>
{
    Console.WriteLine(x.Key);
    x.AsParallel().ForAll(y => Console.WriteLine(y));
});


groups = games.GroupBy(x => x.GetNormalPrice() > 10 ? "Droga" : "Tania").ToList();
groups.ForEach(x =>
{
    Console.WriteLine(x.Key);
    x.AsParallel().ForAll(y => Console.WriteLine(y));
});

