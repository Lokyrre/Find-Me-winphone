using FindMe.Helpers;
using System.IO;
using SQLite.Net;
using SQLite.Net.Platform.XamarinIOS;
using FindMe.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(DataBaseConnection_iOS))]

namespace FindMe.iOS
{
    public class DataBaseConnection_iOS : IDatabaseConnection
    {
        public SQLiteConnection GetConnection()
        {
            var dBPath = GetDatabasePath();
            return new SQLiteConnection(new SQLitePlatformIOS(), dBPath);
        }

        public static string GetDatabasePath()
        {
            const string sqliteFilename = "Scores.db3";

            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);

            return path;
        }
    }
}