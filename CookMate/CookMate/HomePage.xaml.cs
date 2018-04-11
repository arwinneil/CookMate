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
                    Navigation.PushAsync(new DetailPage("Spaghetti", "Try this delicious spaghetti bolognese for a classic family favourite."));
                })
            });

            Ball.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Navigation.PushAsync(new DetailPage("Cheesy Corn and Tuna Balls", "They're perfect for a snack, quick budget dinner or lunchbox treat."));
                })
            });

            Potato.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Navigation.PushAsync(new DetailPage("Potato Pave", "Thinly slice potatoes and layer with punchy rosemary for an elegant side."));
                })
            });

            Dhalleggs.GestureRecognizers.Add(new TapGestureRecognizer()
            {
                Command = new Command(() =>
                {
                    Navigation.PushAsync(new DetailPage("Spicy dhal with eggs", "Perfect for those busy weeknights!"));
                })
            });
        }
    }
}