using MauiApp4.Dane;
namespace MauiApp4;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
		lblNapis.Text = Dane.Dane.napis;
	}
}