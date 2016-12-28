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
[assembly: Dependency(typeof(DatabaseConnection_Windows))]

namespace FindMe.Windows
{
    class DatabaseConnection_Windows : IDatabaseConnection
    {
        public SQLiteConnection DbConnection()
        {
            var dbName = "CustomersDb.db3";
            var path = Path.Combine(ApplicationData.
              Current.LocalFolder.Path, dbName);
            return new SQLiteConnection(path);
        }
    }
}
