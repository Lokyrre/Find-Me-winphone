using FindMe.Helpers;
using Xamarin.Forms;
using Windows.Storage;
using System.IO;
using SQLite.Net;
using FindMe.WinPhone;
using SQLite.Net.Platform.WinRT;

[assembly: Dependency(typeof(DataBaseConnection_WinPhone))]

namespace FindMe.WinPhone
{
    public class DataBaseConnection_WinPhone : IDatabaseConnection
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
;

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
