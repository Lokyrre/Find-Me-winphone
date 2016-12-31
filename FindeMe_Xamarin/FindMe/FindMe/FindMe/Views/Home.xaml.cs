using FindMe.Helpers;
using FindMe.Models;
using FindMe.ViewModels;
using System;
using Xamarin.Forms;

namespace FindMe.Views
{

    public partial class Home : ContentPage
    {
        string modeSelected = "Doctor Who";
        public Home()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
            Settings.TypeGameSettings = modeSelected;

            bLeaderboard.Clicked += OnLeaderboardSelected;
            bOptions.Clicked += OnOptionsSelected;
            bNewGame.Clicked += OnNewGameSelected;
            
            CarrouselGameModes.ItemSelected += (sender, args) =>
            {
                var mode = args.SelectedItem as GameMode;
                if (mode == null)
                    return;

                modeSelected = mode.Name;
                Settings.TypeGameSettings = modeSelected;
            };
        }

        private void OnNewGameSelected(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Game(modeSelected));
        }

        private void OnOptionsSelected(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Options());
        }

        private void OnLeaderboardSelected(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Leaderboard());
        }
    }
}