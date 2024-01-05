using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace hqtcsdl
{
    internal class ConnectDatabase
    {
        public static SqlConnection connection;
        public static void Connect(string DBconnect)
        {
            connection = new SqlConnection(DBconnect);
            connection.Open();
        }

        public static DataTable GetData(string sql)
        {
            SqlDataAdapter sda = new SqlDataAdapter(sql, connection);
            DataTable table = new DataTable();
            sda.Fill(table);
            return table;
        }
        public static void Disconnect()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
        }
    }
}
