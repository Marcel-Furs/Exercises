using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lekcja_1C
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

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
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string imie = imieTb.Text;
            MessageBox.Show($"Witaj {imie}!");
        }
    }
}
