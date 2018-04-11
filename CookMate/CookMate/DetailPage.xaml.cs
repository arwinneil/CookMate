using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookMate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        public DetailPage(string x)
        {
            InitializeComponent();
            Title = "Recipe Details";
            picture.Source = "spaget.jpg";

            if (x == "Cheesy Corn and Tuna Balls")
                picture.Source = "Balls.jpeg";

            if (x == "Spaghetti")
                picture.Source = "spaghetti.jpeg";

            if (x == "Potato Pave")
                picture.Source = "potato.jpeg";

            if (x == "Spicy dhal with eggs")
                picture.Source = "dhalleggs.jpeg";
        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage()
            {
                Title = this.Title
            });
        }
    }
}