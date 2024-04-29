using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Classes
{
    public class DbConnect
    {
        public static string ConnectionString { get; } =
            "Data Source=AutoDb.db;Version=3;Cache=Shared;JournalMode=WAL;Synchronous=OFF;";
        public static SQLiteConnection connection { get; private set; }

        public static void Connect()
        {
            connection = new SQLiteConnection(ConnectionString);
            connection.Open();
        }

        public static void Disconnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
        }
    }
}
