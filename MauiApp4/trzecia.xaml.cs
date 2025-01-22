using MauiApp4.Dane;
using MauiApp4.Dane;
namespace MauiApp4;

public partial class trzecia : ContentPage
{
	public trzecia()
	{
		InitializeComponent();
        lblNapis.Text = Dane.Dane.napis;
    }
}