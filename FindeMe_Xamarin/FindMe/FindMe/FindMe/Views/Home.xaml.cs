using FindMe.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace FindMe.Views
{
    public partial class Home : CarouselPage
    {
        public Home()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
            bLeaderboardDW.Clicked += OnLeaderboardSelected;
            bOptionsDW.Clicked += OnOptionsSelected;
            bNewGameDW.Clicked += OnNewGameDWSelected;

            bLeaderboardP.Clicked += OnLeaderboardSelected;
            bOptionsP.Clicked += OnOptionsSelected;
            bNewGameP.Clicked += OnNewGamePSelected;

            bLeaderboardMLP.Clicked += OnLeaderboardSelected;
            bOptionsMLP.Clicked += OnOptionsSelected;
            bNewGameMLP.Clicked += OnNewGameMLPSelected;
        }

       private void OnNewGameDWSelected(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Game("DoctorWho"));
        }

        private void OnNewGamePSelected(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Game("Pokemon"));
        }

        private void OnNewGameMLPSelected(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Game("MLP"));
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
