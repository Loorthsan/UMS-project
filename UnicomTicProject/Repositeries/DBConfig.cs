using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicProject.Repositeries
{
    internal class DBConfig
    {
        private static string ConnectionString = "Data Source = Unicom_TMS_database.db;version=3;";


        public static SQLiteConnection GetConnection()
        {
            SQLiteConnection connection = new SQLiteConnection(ConnectionString);
            connection.Open();
            return connection;
        }
    }
}
