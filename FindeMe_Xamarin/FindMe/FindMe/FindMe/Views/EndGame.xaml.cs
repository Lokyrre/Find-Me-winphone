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
        private ScoresDataAccess sda = new ScoresDataAccess();

        public EndGame(int score)
        {
            InitializeComponent();

            Score = score;

            Random rnd = new Random();
            int i = rnd.Next(Facts.UKnow.Count);
            fact.Text = "\n"+Facts.UKnow[i]+"\n";
            Score s;
            List<DataScore> listDataScores = sda.GetScoreGameMode(Settings.TypeGameSettings, Settings.IsHardSettings, Settings.NbrIconSettings);
            List<Score> listScores = new List<Score>();

            //Conversion de DataScore en Score
            for(int j = 0; j < listDataScores.Count; j++)
            {
                s = new Score(listDataScores[j]);
                listScores.Add(s);
            }

            //Tri du tableau de Scores
            listScores.Sort();

            if(listScores.Count > 0 && score > listScores[0].ValueScore)
            {
                newHighScore.Text = "\n Bravo ! Vous avez établi le meilleur score !";
            }
            else
            {
                newHighScore.Text = "\n Vous pouvez mieux faire... :'(";
            }

            scoreGame.Text = "\n" + scoreGame.Text + score.ToString() + "\n";

            BindingContext = new OptionsViewModel(); // Recuperation du Username afin de l'afficher dans la page de fin de partie

            bRestart.Clicked += OnRestartSelected;
            bMenu.Clicked += OnMenuSelected;
        }

        private void AddScore()
        {
            Score score = new Score(Settings.UsernameSettings, Score, Settings.IsHardSettings, Settings.NbrIconSettings, Settings.TypeGameSettings);
            sda.InsertUpdateData(score);
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
