using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FindMe.Helpers;
using FindMe.UWP;
using SQLite;
using Xamarin.Forms;
using Windows.Storage;
using System.IO;
using SQLite.Net.Async;
using SQLite.Net;
using SQLite.Net.Platform.WinRT;

[assembly: Dependency(typeof(DataBaseConnection_UWP))]

namespace FindMe.UWP
{
    public class DataBaseConnection_UWP : IDatabaseConnection
    {
        public SQLiteConnection GetConnection()
        {
            var dBPath = GetDatabasePath("Scores.db3");
            return new SQLiteConnection(new SQLitePlatformWinRT(), dBPath);
        }

        public static string GetDatabasePath(string sqliteFilename)
        {
            string documentsPath = ApplicationData.Current.LocalFolder.Path;
            var path = Path.Combine(documentsPath, sqliteFilename);

            return path;
        }
    }
}
