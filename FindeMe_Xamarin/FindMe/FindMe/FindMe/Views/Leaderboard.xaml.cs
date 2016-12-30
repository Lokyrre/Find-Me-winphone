using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMe.Helpers;
using FindMe.ViewModels;
using Xamarin.Forms;
using FindMe.Models;

namespace FindMe.Views
{
    public partial class Leaderboard : ContentPage
    {
        public Leaderboard()
        {
            Title = "Leaderboard";
            InitializeComponent();
            typeScore.SelectedIndex = 0;
            nbrIcon.SelectedIndex = 0;
            BindingContext = new LeaderboardViewModel();
            typeScore.SelectedIndexChanged += (s, e) =>
            {
                reloadLeaderboard();
            };

            nbrIcon.SelectedIndexChanged += (s, e) =>
            {
                reloadLeaderboard();
            };

            switchHard.Toggled += (s, e) =>
            {
                reloadLeaderboard();
            };
        }

        private void reloadLeaderboard()
        {
            string value = typeScore.Items[typeScore.SelectedIndex];
            bool isHard = switchHard.IsToggled;
            int nbrIcons = Int32.Parse(nbrIcon.Items[nbrIcon.SelectedIndex]);
            BindingContext = new LeaderboardViewModel(value, isHard, nbrIcons);
        }
    }
}
