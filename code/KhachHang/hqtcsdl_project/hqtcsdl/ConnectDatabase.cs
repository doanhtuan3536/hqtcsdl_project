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
        public static int InsertData(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connection);
            int rowsAffected = cmd.ExecuteNonQuery();
            return rowsAffected;
        }
        public static void Disconnect()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
                connection = null;
            }
        }
    }
}
