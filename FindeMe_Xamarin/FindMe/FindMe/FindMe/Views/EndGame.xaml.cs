using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMe.Models;
using FindMe.Helpers;
using Xamarin.Forms;
using FindMe.ViewModels;

namespace FindMe.Views
{
    public partial class EndGame : ContentPage
    {
        private double Score;

        public EndGame(int score)
        {
            InitializeComponent();

            Score = score;

            Random rnd = new Random();
            int i = rnd.Next(Facts.UKnow.Count);
            fact.Text = "\n"+Facts.UKnow[i]+"\n";

            if ((Settings.HighScoresSettings.Count > 0 && score > Settings.HighScoresSettings[0].ValueScore) || Settings.HighScoresSettings.Count == 0)
            {
                newHighScore.Text = "\n Bravo ! Vous avez établi le meilleur score !";
            }
            else
            {
                newHighScore.Text = "\n Peut mieux faire... :'(";
            }

            scoreGame.Text = score.ToString()+"\n";

            BindingContext = new OptionsViewModel(); // Recuperation du Username afin de l'afficher dans la page de fin de partie

            bRestart.Clicked += OnRestartSelected;
            bMenu.Clicked += OnMenuSelected;
        }

        private void AddScore()
         {
             Score score = new Score(Settings.UsernameSettings, Score, Settings.IsHardSettings, Settings.NbrIconSettings, "Doctor Who");
             Settings.HighScoresSettings.Sort();
             if(Settings.HighScoresSettings.Count< 10)
             {
                 Settings.HighScoresSettings.Add(score);
             }
             else
             {
                 if(Settings.HighScoresSettings[9].ValueScore<Score)
                 {
                    Settings.HighScoresSettings.RemoveAt(9);
                    Settings.HighScoresSettings.Add(score);
                 }
             }
         }

        private void OnMenuSelected(object sender, EventArgs e)
        {
            AddScore();
            Navigation.PushAsync(new Home());
        }

        private void OnRestartSelected(object sender, EventArgs e)
        {
            AddScore();
            Navigation.PushAsync(new Game(Settings.TypeGameSettings));
        }
    }
}
