using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using FindMe.Helpers;

namespace FindMe
{
    public class App : Application
    {
        public App()
        {
            // The root page of your application

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
