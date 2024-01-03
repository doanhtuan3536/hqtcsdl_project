using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HQTCSDL
{
    public partial class ThemLichHen_NS : Form
    {
        //Sua lai sau khi xong login va phan quyen
        string cur_user = "NS001";
        string connectionString = @"Data Source=LAPTOP-L0R0JU1M\SQLEXPRESS;Initial Catalog=QLNHAKHOA;Integrated Security=True";
        public ThemLichHen_NS()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("sp_NS_themlichhen", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@NGAYHEN", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@GIO", dateTimePicker2.Value);
                    command.Parameters.AddWithValue("@MAKH", textBox1.Text);
                    command.Parameters.AddWithValue("@MANHASI", cur_user);
                    int success = command.ExecuteNonQuery();
                    if (success > 0) MessageBox.Show("Them lich hen thanh cong");
                }
            }
        }

        
    }
}
