using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookMate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();

            Spaghetti.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Navigation.PushAsync(new DetailPage("Spaghetti"));
                })
            });

            Ball.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Navigation.PushAsync(new DetailPage("Cheesy Corn and Tuna Balls"));
                })
            });

            Potato.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Navigation.PushAsync(new DetailPage("Potato Pave"));
                })
            });

            Dhalleggs.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Navigation.PushAsync(new DetailPage("Spicy dhal with eggs"));
                })
            });
        }
    }
}