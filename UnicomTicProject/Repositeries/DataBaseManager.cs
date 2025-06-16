using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicomTicProject.Repositeries
{
    internal class DataBaseManager
    {
        public static void createTables()
        {
            using (var conn = DBConfig.GetConnection())
            {
                var cmd = conn.CreateCommand();

                cmd.CommandText = @" CREATE TABLE IF NOT EXISTS Sections (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Name TEXT NOT NULL );";
                cmd.ExecuteNonQuery();


            }
        }
    }
}

