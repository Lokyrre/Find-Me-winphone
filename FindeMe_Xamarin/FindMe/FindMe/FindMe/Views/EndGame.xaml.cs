using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMe.Models;

using Xamarin.Forms;
using FindMe.ViewModels;

namespace FindMe.Views
{
    public partial class EndGame : ContentPage
    {
        public EndGame(int score)
        {
            InitializeComponent();

            Random rnd = new Random();
            int i = rnd.Next(Facts.UKnow.Count);
            fact.Text = "\n"+Facts.UKnow[i]+"\n";

            scoreGame.Text = score.ToString()+"\n";

            BindingContext = new OptionsViewModel();

            bRestart.Clicked += OnRestartSelected;
            bMenu.Clicked += OnMenuSelected;
        }

        private void OnMenuSelected(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Home());
        }

        private void OnRestartSelected(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Game());
        }
    }
}
