using Xamarin.Forms;
using FindMe.Helpers;
using System.Collections.Generic;

namespace FindMe
{
    public class App : Application
    {
        public static Dictionary<string, List<string>> ListImageSettings;
        public App()
        {
            // The root page of your application
            ListImageSettings = new Dictionary<string, List<string>>();
            var dB = DependencyService.Get<IDatabaseConnection>().GetConnection();
            dB.CreateTable<DataScore>();
            MainPage = new NavigationPage(new Views.Home());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
