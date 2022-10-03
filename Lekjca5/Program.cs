using lekcja5;

void Show(int[] tab, string separator = " ")
{
    foreach (var item in tab)
    {
        Console.Write(item + separator);
    }
    Console.WriteLine();
}

Action<int[], string> akcja = Show;
akcja(new int[] { 1, 2, 3, 4, 5 }, ", ");

void BubbleSort(int[] tab, Func<int, int, bool> Cmp)
{
    for (int i = 0; i < tab.Length - 1; i++)
    {
        for (int j = 0; j < tab.Length - 1 - i; j++)
        {
            if (Cmp(tab[j], tab[j+1]))
            {
                (tab[j], tab[j + 1]) = (tab[j + 1], tab[j]);
            }
        }
    }
}

int[] arr = { 10, 1, 5, 8, 9, 1, 100, 141, 10, 115, 14, 1, 8, 100, 6, 9, 100 };
BubbleSort(arr, (x, y) => x < y);
Show(arr);
//BubbleSort(arr, (x, y) => x > y);
//Show(arr);
BubbleSort(arr, (x, y) => x.ToString().Length > y.ToString().Length);
Show(arr);

var alarm = new Alarm();
var light = new Light();
var phone = new Phone();
Home home = new Home();
home.OnWindowOpen += alarm.Update;
home.OnWindowOpen += light.Update;
home.OnWindowOpen += phone.Update;
home.OnWindowOpen += () => Console.WriteLine("Testowa funkcja");

home.OpenWindow();

