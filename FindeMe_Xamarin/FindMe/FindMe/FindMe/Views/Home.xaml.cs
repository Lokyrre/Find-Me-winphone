using FindMe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FindMe.Views
{
    public partial class Home : ContentPage
    {
        public Home()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
            bLeaderboard.Clicked += OnLeaderboardSelected;
            bOptions.Clicked += OnOptionsSelected;
            bNewGame.Clicked += OnNewGameSelected;
        }

       private void OnNewGameSelected(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Game());
        }

        private void OnOptionsSelected(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Options());
        }

        void OnLeaderboardSelected(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Leaderboard());
        }
    }
}
