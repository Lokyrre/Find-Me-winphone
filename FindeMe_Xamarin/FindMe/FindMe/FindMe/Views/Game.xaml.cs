using FindMe.Helpers;
using FindMe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Vibrate;

using Xamarin.Forms;
using System.Diagnostics;

namespace FindMe.Views
{
    public partial class Game : ContentPage
    {
        private int score;
        private double addingTime;
        private double coefficientTime ;
        private int time;

        public Game(string gameType)
        {
            InitializeComponent();
            Settings.TypeGameSettings = gameType;
            GameViewModel.ClearListItem();
            score = 0;
            addingTime = .2;
            coefficientTime = 0.02;
            time = 10000;
            Loading();
        }

        public async void Loading()
        {
            Random r = new Random();
            GameViewModel gvm = new GameViewModel();
            bool isWhiteIntruder = Convert.ToBoolean(r.Next(2));
            int intruder = r.Next(Settings.NbrIconSettings);
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
                        GameViewModel.ClearListItem();

                        addingTime = addingTime - addingTime * coefficientTime;
                        if (progress.Progress + addingTime > 1)
                        {
                            progress.Progress = 1;
                            time = 10000;
                        }
                        else
                        {
                            progress.Progress = progress.Progress + addingTime;
                            time = (int)( progress.Progress * 10000);
                        }
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
                        GameViewModel.ClearListItem();
                        Loading();
                    };
                }
                img.GestureRecognizers.Add(tapGestureRecognizer);
                aLayout.Children.Add(img);
                AbsoluteLayout.SetLayoutBounds(img, new Rectangle(1.0 * r.Next(100) / 100, 1.0 * r.Next(100) / 100, .1, .1));
                AbsoluteLayout.SetLayoutFlags(img, AbsoluteLayoutFlags.All);
            }

            labelScore.Text = "Score: " + score;
            await progress.ProgressTo(0, (uint)time, Easing.Linear);
            if(progress.Progress == 0)
            {
                await Navigation.PushAsync(new EndGame(score));
            }
        }

    }
}
//Navigation.PushAsync(new EndGame(score));