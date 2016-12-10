using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, voir la page http://go.microsoft.com/fwlink/?LinkId=234238

namespace FindMe
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class GameView : Page
    {
        private Frame rootFrame = Window.Current.Content as Frame;
        private Game game;

        public GameView()
        {
            this.InitializeComponent();
            rootFrame.Navigated += OnNavigated;
            SystemNavigationManager.GetForCurrentView().BackRequested += OnBackRequested;
        }

        private void OnBackRequested(object sender, BackRequestedEventArgs e)
        {
            Frame rootFrame = Window.Current.Content as Frame;
            if (rootFrame.CanGoBack)
            {
                e.Handled = true;
                rootFrame.GoBack();
            }
        }

        private void OnNavigated(object sender, NavigationEventArgs e)
        {
            if (((Frame)sender).CanGoBack)
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            }
            else
            {
                SystemNavigationManager.GetForCurrentView().AppViewBackButtonVisibility = AppViewBackButtonVisibility.Collapsed;
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if ((String)Application.Current.Resources["game"] == "MLP")
            {
                game = new MLPGame();
                launchGame();
            }
            else if ((String)Application.Current.Resources["game"] == "DoctorWho")
            {
                game = new DoctorWhoGame();
            }
            else if ((String)Application.Current.Resources["game"] == "Pokemon")
            {
                game = new PokemonGame();
            }
        }

        private void launchGame()
        {
            Random rnd = new Random();
            Image i = game.getItem(true, 0);
            double maxX = CanvasGame.Width - i.Width;
            double maxY = CanvasGame.Height - i.Height;
            Canvas.SetLeft(i, rnd.NextDouble() * maxX);
            Canvas.SetTop(i, rnd.NextDouble() * maxY);
            CanvasGame.Children.Add(i);
        }
    }
}
