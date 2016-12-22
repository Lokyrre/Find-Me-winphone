using FindMe.Helpers;
using FindMe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Vibrate;

using Xamarin.Forms;

namespace FindMe.Views
{
    public partial class Game : ContentPage
    {
        public Game(string typeGame)
        {
            InitializeComponent();
            BindingContext = new GameViewModel();
            Loading();
        }

        void Loading()
        {
            Random r = new Random();

            int nbIcones;

            switch (Settings.nbrIconSettings)
            {
                case 1:
                    nbIcones = 5;
                    break;
                case 2:
                    nbIcones = 7;
                    break;
                default:
                    nbIcones = 3;
                    break;
            }

            for (int i = 0; i < nbIcones; i++)
            {
                var img = new Image();
                //img.Source = ""; //TODO récupérer image aléatoire de la liste correspondante
                img.BackgroundColor = Color.FromRgb(r.Next(255), r.Next(255), r.Next(255));
                img.HeightRequest = 60;
                img.WidthRequest = 60;
                var tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += (s, e) => {
                    Image imgTemp = (Image)s;
                    imgTemp.BackgroundColor = Color.Red;
                    if (Settings.IsVibrationEnabledSettings)
                    {
                        CrossVibrate.Current.Vibration(500);
                    }
                    if (Settings.IsSongEnabledSettings)
                    {
                       
                    }
                    aLayout.Children.Clear();
                    Loading();
                };
                img.GestureRecognizers.Add(tapGestureRecognizer);
                aLayout.Children.Add(img);

                AbsoluteLayout.SetLayoutBounds(img, new Rectangle(1.0 * r.Next(100) / 100, 1.0 * r.Next(100) / 100, .1, .1));
                AbsoluteLayout.SetLayoutFlags(img, AbsoluteLayoutFlags.All);

                
            }
            

        }

    }
}
