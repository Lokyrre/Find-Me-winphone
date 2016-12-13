using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMe.Helpers;
using FindMe.ViewModels;

using Xamarin.Forms;

namespace FindMe.Views
{
    public partial class Leaderboard : ContentPage
    {
        public Leaderboard()
        {
            Title = "Leaderboard";
            InitializeComponent();
            BindingContext = new LeaderboardViewModel();
            list.Header = new Label { Text = "Meilleurs Scores" };
            list.ItemsSource = Settings.HighScoresSettings;
            list.ItemTemplate = new DataTemplate();
        }
    }
}
