using System;
using FindMe.Helpers;
using Xamarin.Forms;
using FindMe.ViewModels;

namespace FindMe.Views
{
    public partial class EndGame : ContentPage
    {
        public EndGame(int score)
        {
            InitializeComponent();

            EndGameViewModel egvm = new EndGameViewModel(score);

            // Desactive le bouton retour
            NavigationPage.SetHasBackButton(this, false);

            egvm.AddScore();

            fact.Text = "\n"+egvm.LoadFact()+"\n";

            newHighScore.Text = egvm.isNewHightScore();

            scoreGame.Text = "\n" + scoreGame.Text + score.ToString() + "\n";

            // Recuperation du Username afin de l'afficher dans la page de fin de partie
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
            Navigation.PushAsync(new Game(Settings.TypeGameSettings));
        }
    }
}
