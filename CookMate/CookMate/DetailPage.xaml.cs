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
            Recipe recipe = Data.recipes.Single(r => r.Name == name);
            _name = name;

            Title = "Recipe Details";
            title.Text = name +" - " + recipe.Time +"min";
            description.Text = desc;

        

            if (name == "Cheesy Corn and Tuna Balls")
                picture.Source = "Balls.jpeg";

            if (name == "Spaghetti")
                picture.Source = "spaghetti.jpeg";

            if (name == "Potato Pave")
                picture.Source = "potato.jpeg";

            if (name == "Spicy dhal with eggs")
                picture.Source = "dhalleggs.jpeg";

           

            i1.Text = recipe.Ingredients[0];
            i2.Text = recipe.Ingredients[1];
            i3.Text = recipe.Ingredients[2];
            i4.Text = recipe.Ingredients[3];
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