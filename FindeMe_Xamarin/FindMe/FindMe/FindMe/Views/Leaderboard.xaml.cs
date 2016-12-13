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
            List<Score> listItems = Settings.HighScoresSettings; 
        }
    }
}
