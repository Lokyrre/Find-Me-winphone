using System;
using FindMe.ViewModels;
using Xamarin.Forms;

namespace FindMe.Views
{
    public partial class Leaderboard : ContentPage
    {
        private LeaderboardViewModel lvm = new LeaderboardViewModel();
        public Leaderboard()
        {
            Title = "Leaderboard";
            InitializeComponent();
            typeScore.SelectedIndex = 0;
            nbrIcon.SelectedIndex = 0;
            BindingContext = lvm;
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
            lvm.SetListItem(typeScore.Items[typeScore.SelectedIndex], switchHard.IsToggled, Int32.Parse(nbrIcon.Items[nbrIcon.SelectedIndex]));
        }
    }
}
