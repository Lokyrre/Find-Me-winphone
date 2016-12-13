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
            bLeaderboard.Clicked += OnItemSelected;
           
        }

        void OnItemSelected(object sender, EventArgs args)
        {
            Navigation.PushAsync(new Leaderboard());
        }
    }
}
