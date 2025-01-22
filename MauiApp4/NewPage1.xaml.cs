using MauiApp4.Dane;
namespace MauiApp4;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
		
	}

	private async void btnZatwierdz(object sender, EventArgs e)
	{
		Dane.Dane.waluty.Clear();
		if (chkUSD.IsChecked)
			Dane.Dane.waluty.Add("usd");
        if (chkEUR.IsChecked)
            Dane.Dane.waluty.Add("eur");
        if (chkGBP.IsChecked)
            Dane.Dane.waluty.Add("gbp");
        if (chkCHF.IsChecked)
            Dane.Dane.waluty.Add("chf");
        if (chkDKK.IsChecked)
            Dane.Dane.waluty.Add("dkk");
		if (Dane.Dane.waluty.Count == 0)
			DisplayAlert("Uwaga", "brak wybranej waluty", "OK");
		else
			await Shell.Current.GoToAsync("//MainPage");
    }
}