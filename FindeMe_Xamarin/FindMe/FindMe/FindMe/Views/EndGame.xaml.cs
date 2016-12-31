using System;
using FindMe.Helpers;
using Xamarin.Forms;
using FindMe.ViewModels;
using FindMe.Models;

namespace FindMe.Views
{
    public partial class EndGame : ContentPage
    {
        EndGameViewModel egvm;
        public EndGame(int score)
        {
            Title = "Partie Terminée";
            InitializeComponent();

            egvm = new EndGameViewModel(score);

            // Desactive le bouton retour
            NavigationPage.SetHasBackButton(this, false);
            username.TextChanged += (e, sender) =>
            {
                Settings.UsernameSettings = username.Text;
            };

            fact.Text = egvm.LoadFact();

            newHighScore.Text = egvm.isNewHightScore();

            scoreGame.Text = scoreGame.Text + score.ToString();

            // Recuperation du Username afin de l'afficher dans la page de fin de partie
            BindingContext = new OptionsViewModel(); 

            bRestart.Clicked += OnRestartSelected;
            bMenu.Clicked += OnMenuSelected;
        }

        private async void OnMenuSelected(object sender, EventArgs e)
        {
            egvm.AddScore();
            await Navigation.PopToRootAsync();
        }

        private void OnRestartSelected(object sender, EventArgs e)
        {
            egvm.AddScore();
            Navigation.PushAsync(new Game(Settings.TypeGameSettings));
        }
    }
}
