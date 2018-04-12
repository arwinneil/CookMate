using Plugin.SpeechRecognition;
using Plugin.TextToSpeech;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace CookMate
{
    public partial class MainPage : ContentPage
    {

        Recipe recipe;
        public MainPage(String name)
        {
            InitializeComponent();

           recipe = Data.recipes.Single(r => r.Name == name);

            recipe.Steps.Insert(0, "Swipe to start >");
            recipe.Steps.Add("Recipe Completed!");

           Carou.ItemsSource = recipe.Steps;

          

            Listen();
        }

         public void  Listen()

        {
            //var listener = CrossSpeechRecognition
            //        .Current
            //          .ContinuousDictation()
            //         // .ListenUntilPause()

            var listener = CrossSpeechRecognition
            .Current
           .ContinuousDictation()

            .Subscribe(async phrase =>
            {
                label.Text = phrase;
                label.TextColor = Color.Black;

                if (phrase.IndexOf("next") > -1)
                {
                    label.TextColor = Color.Red;

                    if (Carou.Position <  recipe.Steps.Count - 1)
                    {
                        Carou.Position++;
                        Carou.ItemsSource =  recipe.Steps;
                    }
                }
                else if (phrase.IndexOf("previous") > -1)
                {
                    if (Carou.Position > 0)
                    {
                        Carou.Position--;
                        Carou.ItemsSource =  recipe.Steps;
                    }
                }
                if ((phrase.IndexOf("speak") > -1) || (phrase.IndexOf("read") > -1) || (phrase.IndexOf("tell") > -1))
                {
                    await CrossTextToSpeech.Current.Speak( recipe.Steps[Carou.Position]);

          
                }
            });

           
           
        }

       
    }
}