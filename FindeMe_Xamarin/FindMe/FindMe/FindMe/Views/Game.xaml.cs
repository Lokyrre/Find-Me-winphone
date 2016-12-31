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
using System.Runtime.CompilerServices;

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
		private bool stopTranslation;
		private Dictionary<Image, Rectangle> images;

        public Game(string gameType)
        {
			InitializeComponent();
            GameViewModel.ClearListItem();
            score = 0;
            addingTime = .2;
            coefficientTime = 0.02;
            time = 10000;
			Loading();
        }

        public async void Loading()
        {
			images = new Dictionary<Image, Rectangle>();
            Random r = new Random();
            GameViewModel gvm = new GameViewModel();
            bool isWhiteIntruder = Convert.ToBoolean(r.Next(2));
            int intruder = r.Next(Settings.NbrIconSettings);

			stopTranslation = false;

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
						stopTranslation = true;
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
						stopTranslation = true;
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

				Rectangle rect = new Rectangle(xPerCent[xPerCent.Count - 1], yPerCent[yPerCent.Count - 1], .1, .1);
                AbsoluteLayout.SetLayoutBounds(img, rect);
                AbsoluteLayout.SetLayoutFlags(img, AbsoluteLayoutFlags.All);

				images.Add(img,new Rectangle(rect.X,rect.Y,rect.Width,rect.Height));
            }

			// await progress.ProgressTo(0, (uint)time, Easing.Linear);

			if (Settings.IsHardSettings)
			{
				List<Image> imageList = new List<Image>();

				foreach (var image in images)
				{
					imageList.Add(image.Key);
				}
				foreach (var image in imageList)
				{
					ApplyTranslate(image);
				}
            }

            labelScore.Text = "Score: " + score;

            await progress.ProgressTo(0, (uint)time, Easing.Linear);

            if (progress.Progress == 0)
            {
				stopTranslation = true;
                await Navigation.PushAsync(new EndGame(score));
            }
        }

		private void ApplyTranslate(Image oneImage)
		{

			if (images.ContainsKey(oneImage))
			{
				
				Random r = new Random();
				Rectangle oldRect = images[oneImage];

				var size = Plugin.XamJam.Screen.CrossScreen.Current.Size;

				double layoutWitdh = size.Width;
				double layoutHeight = size.Height;

				double newRectX = 1.0 * (r.Next(60) + 20) / 100;
				double newRectY = 1.0 * (r.Next(60) + 20) / 100;

				double x = (newRectX - oldRect.X) * layoutWitdh;
				double y = (newRectY - oldRect.Y) * layoutHeight;

				images[oneImage] = new Rectangle(newRectX, newRectY, 0.1, 0.1);

				var task = oneImage.TranslateTo(x, y, (uint)2000, Easing.Linear);
				task.GetAwaiter().OnCompleted(delegate
				{
					if (!stopTranslation)
						ApplyTranslate(oneImage);
				});

			}
		}

    }
}
//Navigation.PushAsync(new EndGame(score));