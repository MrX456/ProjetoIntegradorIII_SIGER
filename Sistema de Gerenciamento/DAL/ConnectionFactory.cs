using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;

namespace DAL
{
    public class ConnectionFactory
    {
        //Objeto de conexão
        private static SQLiteConnection sqliteConn;

        public static SQLiteConnection RequestConnection() 
        {
            try
            {
                sqliteConn = new SQLiteConnection("Data Source=c:\\SQLITE3\\db_pi3.sqlite;Version=3;");
                sqliteConn.Open();
                return sqliteConn;
            }
            catch (Exception) 
            {
                return null;
            }
        }

        public static void DisposeConnection() 
        {
            if (sqliteConn.State == System.Data.ConnectionState.Open)
            {
                sqliteConn.Close();
            }
        }
    }
}
