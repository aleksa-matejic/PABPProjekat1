using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Aleksa: namespace needed
using System.Data.SqlClient;

namespace PABPProjekat1.src.DB
{
    public class DB
    {
        /// <summary>
        /// Returns an open connection to the caller.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }

        private static string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=NORTHWND;Data Source=DESKTOP-B83D19M\\SQLEXPRESS";

    }
}
