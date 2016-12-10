using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Pour plus d'informations sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FindMe
{
    /// <summary>
    /// Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Frame rootFrame = Window.Current.Content as Frame;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void MPL_Click(object sender, RoutedEventArgs e)
        {
            GoToGameView("MLP");
        }

        private void DoctoWho_Click(object sender, RoutedEventArgs e)
        {
            GoToGameView("DoctoWho");
        }

        private void Pokemon_Click(object sender, RoutedEventArgs e)
        {
            GoToGameView("Pokemon");
        }

        private void GoToGameView(string game)
        {
            Application.Current.Resources["game"] = game;
            rootFrame.Navigate(typeof(GameView));
        }
    }
}
