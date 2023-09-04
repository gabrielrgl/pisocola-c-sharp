using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pisocola.control
{
    class MySqlConnectionConfig
    {

        private static string server = "localhost";
        private static string user = "root";
        private static string database = "pisocola";
        private static string port = "3306";
        private static string password = "";

        public static MySqlConnection GetConnection()
        {
            string connParams = "server=" + server + ";user=" + user + ";database=" + database + ";port=" + port + ";password=" + password;
            MySqlConnection connection = new MySqlConnection(connParams);

            return connection;
        }

        public static string GetDatabase()
        {
            return database;
        }

    }
}
