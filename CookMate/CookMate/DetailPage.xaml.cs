using System;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CookMate
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetailPage : ContentPage
    {
        private string _name;

        public DetailPage(string name, string desc)
        {
            InitializeComponent();

            _name = name;

            Title = "Recipe Details";
            title.Text = name;
            description.Text = desc;

        

            if (name == "Cheesy Corn and Tuna Balls")
                picture.Source = "Balls.jpeg";

            if (name == "Spaghetti")
                picture.Source = "spaghetti.jpeg";

            if (name == "Potato Pave")
                picture.Source = "potato.jpeg";

            if (name == "Spicy dhal with eggs")
                picture.Source = "dhalleggs.jpeg";

            Recipe recipe = Data.recipes.Single(r => r.Name == name);
        }

        private void Button_Pressed(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage(_name)
            {
                Title = _name
            });
            
        }
    }
}