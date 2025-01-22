using MauiApp4.Dane;
namespace MauiApp4
{
    public partial class MainPage : ContentPage
    {
        
        public MainPage()
        {
            InitializeComponent();
            lblNapis.Text = Dane.Dane.napis;
        }


    }

}
