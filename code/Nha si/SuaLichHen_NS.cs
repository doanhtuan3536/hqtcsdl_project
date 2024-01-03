using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HQTCSDL
{
    public partial class SuaLichHen_NS : Form
    {
        string connectionString = @"Data Source=LAPTOP-L0R0JU1M\SQLEXPRESS;Initial Catalog=QLNHAKHOA;Integrated Security=True";
        private string cur_user; 
        private DateTime cur_gio;
        private DateTime cur_ngay;
        private string cur_kh;
        public SuaLichHen_NS()
        {
            InitializeComponent();
        }

        public SuaLichHen_NS(DateTime ngay, DateTime gio, string makh, string mans)
        {
            InitializeComponent();
            dateTimePicker2.MaxDate = dateTimePicker1.Value;
            cur_user = mans;
            textBox1.Text = makh;
            cur_kh = makh;
            dateTimePicker1.Value = ngay;
            cur_ngay = ngay;
            dateTimePicker2.Value = gio;
            cur_gio = gio;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("sp_NS_capnhatlichhen", connection))
                {

                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@MAKH", cur_kh);
                    command.Parameters.AddWithValue("@MANHASI", cur_user);
                    command.Parameters.AddWithValue("@NGAYHEN", cur_ngay);
                    command.Parameters.AddWithValue("@GIO", cur_gio);
                    command.Parameters.AddWithValue("@MAKH_new", textBox1.Text);
                    command.Parameters.AddWithValue("@NGAYHEN_new", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@GIO_new", dateTimePicker2.Value);
                    int success = command.ExecuteNonQuery();
                    if (success > 0) MessageBox.Show("Sua lich hen thanh cong");
                }

                connection.Close();
            }
        }
    }
}
