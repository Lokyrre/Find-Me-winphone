using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using FindMe.Helpers;
using FindMe.Droid;
using System.IO;
using SQLite.Net;

[assembly: Xamarin.Forms.Dependency(typeof(DatabaseConnection_Android))]

namespace FindMe.Droid
{
    class DatabaseConnection_Android : IDatabaseConnection
    {
        public SQLiteConnection GetConnection()
        {
            throw new NotImplementedException();
        }
    }
}