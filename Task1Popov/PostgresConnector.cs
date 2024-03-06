using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1Popov
{
    class PostgresConnector
    {
        NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; " +
            "Port=5432; " +
            "User Id=postgres; " +
            "Password=8702; " +
            "Database=Task1Popov");

        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public NpgsqlConnection getConnection()
        {
            return connection;
        }
    }
}