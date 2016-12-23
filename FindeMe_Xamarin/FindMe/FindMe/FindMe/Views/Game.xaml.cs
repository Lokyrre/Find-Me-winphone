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
        private int score;
        public Game(string gameType)
        {
            InitializeComponent();
            Settings.TypeGameSettings = gameType;
            GameViewModel.ClearListItem();
            score = 0;
            Loading();
        }

        async void Loading()
        {
            Random r = new Random();
            GameViewModel gvm = new GameViewModel();
            bool isWhiteIntruder = Convert.ToBoolean(r.Next(2));
            int intruder = r.Next(Settings.NbrIconSettings);
            var progressBar = new ProgressBar
            {
                Progress = .2,
            };
            for (int i = 0; i < Settings.NbrIconSettings; i++)
            {
                var img = new Image();

                img.HeightRequest = 60;
                img.WidthRequest = 60;

                var tapGestureRecognizer = new TapGestureRecognizer();

                if (i == intruder)
                {
                    img.Source = ImageSource.FromFile(gvm.Item(isWhiteIntruder, true));
                    tapGestureRecognizer.Tapped += (s, e) =>
                    {
                        if (Settings.IsVibrationEnabledSettings)
                        {
                            CrossVibrate.Current.Vibration(300);
                        }
                        score += 150;
                        aLayout.Children.Clear();
                        Loading();
                    };
                }
                else
                {
                    img.Source = ImageSource.FromFile(gvm.Item(isWhiteIntruder, false));

                    tapGestureRecognizer.Tapped += (s, e) =>
                    {
                        if (Settings.IsSongEnabledSettings)
                        {

                        }
                        score -= 33;
                        aLayout.Children.Clear();
                        Loading();
                    };
                }
                img.GestureRecognizers.Add(tapGestureRecognizer);
                aLayout.Children.Add(img);
                await progressBar.ProgressTo(.8, 250, Easing.Linear);
                AbsoluteLayout.SetLayoutBounds(img, new Rectangle(1.0 * r.Next(100) / 100, 1.0 * r.Next(100) / 100, .1, .1));
                AbsoluteLayout.SetLayoutFlags(img, AbsoluteLayoutFlags.All);


            }


        }

    }
}
//GameViewModel.ClearListItem(); Navigation.PushAsync(new EndGame(score));