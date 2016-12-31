using SQLite.Net;

namespace FindMe.Helpers
{
    public interface IDatabaseConnection
    {
        SQLiteConnection GetConnection();
    }
}
