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
        private List<double> xPerCent;
        private List<double> yPerCent;

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

            xPerCent = new List<double>();
            yPerCent = new List<double>();

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
                        if (Settings.IsVibrationEnabledSettings && Device.OS != TargetPlatform.Windows)
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

                xPerCent.Add(1.0 * r.Next(100) / 100);
                yPerCent.Add(1.0 * r.Next(100) / 100);

                AbsoluteLayout.SetLayoutBounds(img, new Rectangle(xPerCent[xPerCent.Count -1], yPerCent[yPerCent.Count - 1], .1, .1));
                AbsoluteLayout.SetLayoutFlags(img, AbsoluteLayoutFlags.All);
            }

           // await progress.ProgressTo(0, (uint)time, Easing.Linear);

            if (Settings.IsHardSettings)
            {
                foreach (Image img in aLayout.Children)
                {
                    double x;
                    double y;
                    if ((Convert.ToBoolean(r.Next(2))))
                    {
                        x = 3000;
                    }
                    else
                    {
                        x = -3000;
                    }
                    if ((Convert.ToBoolean(r.Next(2))))
                    {
                        y = 3000;
                    }
                    else
                    {
                        y = -3000;
                    }

                    img.TranslateTo(x, y, (uint)time, Easing.Linear);
                }
            }

            labelScore.Text = "Score: " + score;

            await progress.ProgressTo(0, (uint)time, Easing.Linear);

            if (progress.Progress == 0)
            {
                await Navigation.PushAsync(new EndGame(score));
            }
        }

    }
}
//Navigation.PushAsync(new EndGame(score));