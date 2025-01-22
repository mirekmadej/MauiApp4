using MauiApp4.Dane;
using System.Net;
using System.Text.Json;
namespace MauiApp4
{
    public class Waluta
    {
        public string? currency { get; set; }
        public string? code { get; set; }
        public IList<Rate> rates { get; set; }
    }
    public class Rate
    {
        public double? bid { get; set; }
        public double? ask { get; set; }
    }
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            pobierzDane();
        }
        private void btnOdswiez(object sender, EventArgs e)
        {
            pobierzDane();
        }

        private void pobierzDane()
        {
            string napis = "";

            using (var webClient = new WebClient())
            {
                foreach (var s in Dane.Dane.waluty)
                {
                    string url = @"https://api.nbp.pl/api/exchangerates/rates/c/" + s + @"/2024-10-22/?format=json";
                    var wynik = webClient.DownloadString(url);
                    var waluta = new Waluta();
                    var json = JsonSerializer.Deserialize<Waluta>(wynik);
                    napis += json.currency + ", " + json.code + ", kurs sprzedarzy: " +
                        json.rates[0].ask + " zł, kurs skupu:" + json.rates[0].bid + " zł\n ";

                }
            }

            //foreach (var s in Dane.Dane.waluty)
            //    napis += s + "; ";
            lblNapis.Text = napis;
        }
    }

}
