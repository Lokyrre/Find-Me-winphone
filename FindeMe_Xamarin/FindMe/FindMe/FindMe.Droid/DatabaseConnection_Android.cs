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
using SQLite.Net.Platform.XamarinAndroid;

[assembly: Xamarin.Forms.Dependency(typeof(DataBaseConnection_Android))]

namespace FindMe.Droid
{
    public class DataBaseConnection_Android : IDatabaseConnection
    {
        public SQLiteConnection GetConnection()
        {
            var dBPath = GetDatabasePath();
            return new SQLiteConnection(new SQLitePlatformAndroid(), dBPath);
        }

        public static string GetDatabasePath()
        {
            const string sqliteFilename = "Scores.db3";

            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal); // Documents folder
            var path = Path.Combine(documentsPath, sqliteFilename);

            return path;
        }
    }
}