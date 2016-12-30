using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMe.Helpers;
using FindMe.Windows;
using SQLite;
using Xamarin.Forms;
using Windows.Storage;
using System.IO;
using SQLite.Net;
using SQLite.Net.Platform.WinRT;

[assembly: Dependency(typeof(DataBaseConnection_Windows))]

namespace FindMe.Windows
{
    public class DataBaseConnection_Windows : IDatabaseConnection
    {
        public SQLiteConnection GetConnection()
        {
            var dBPath = GetDatabasePath("Scores.db3");
            return new SQLiteConnection(new SQLitePlatformWinRT(), dBPath);
        }

        private static string GetDatabasePath(string sqliteFilename)
        {
            string documentsPath = ApplicationData.Current.LocalFolder.Path;
            var path = Path.Combine(documentsPath, sqliteFilename);

            return path;
        }
    }
}
