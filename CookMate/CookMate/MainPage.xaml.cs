using Plugin.SpeechRecognition;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CookMate
{
    public partial class MainPage : ContentPage
    {
        private List<String> receipe = new List<string>
            { "Step 1 Bring a pot of salted water to a boil, add spaghetti and cook according to package directions, stirring often, until al dente. Drain pasta and rinse well with cold water.",
               "Step 2 Preheat oven to 400°F. Grease an ovenproof 9- or 10-inch skillet with about 1/2 Tbsp. butter.",
               "Step 3 In a bowl, whisk together eggs, milk, bacon, scallion, pepper and 3 Tbsp. Parmesan. Add spaghetti; mix well.Transfer mixture to skillet, spreading evenly. Dot with remaining butter and sprinkle remaining 1 Tbsp.Parmesan on top.Bake for 25 to 30 minutes, until center is set and top is golden.Let cool for 10 minutes before serving."
            };



        public MainPage()
        {
            InitializeComponent();

            Listen();

            Carou.ItemsSource = receipe;

     
        }

        private  void Listen()

        {
            

            var listener = CrossSpeechRecognition
                    .Current
                       .ContinuousDictation()
                     // .ListenUntilPause()

                    .Subscribe(phrase =>
                    {
                        label.Text = phrase;
                        label.TextColor = Color.Black;

                        if (phrase.IndexOf("next") > -1)
                        {
                            label.TextColor = Color.Red;

                            if (Carou.Position < receipe.Count - 1)
                            {
                                Carou.Position++;
                                Carou.ItemsSource = receipe;
                            }
                        }
                        else if (phrase.IndexOf("previous") > -1)
                        {
                            if (Carou.Position > 0)
                            {
                                Carou.Position--;
                                Carou.ItemsSource = receipe;
                            }
                        }
                    });

        }
    }
}