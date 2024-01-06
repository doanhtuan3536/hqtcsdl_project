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
    public partial class Form1 : Form
    {
        string maNS = "'NS001'";
        string connectionString = @"Data Source=LAPTOP-L0R0JU1M\SQLEXPRESS;Initial Catalog=QLNHAKHOA;Integrated Security=True";
        private string hoten = "";
        private string diachi = "";
        private string sdt = "";
        private DateTime ngaysinh;
        public Form1()
        {
            InitializeComponent();
            string query = "select * from NHASI where MANHASI = " + maNS;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {

                            hoten = reader.GetString(1); // Assuming Column1 is of type int
                            diachi = reader.GetString(3); // Assuming Column2 is of type string
                            ngaysinh = reader.GetDateTime(2);
                            sdt = reader.GetString(4);// Assuming Column3 is of type DateTime

                            // Now you can use these variables as needed
                      
                        }
                    }
                }

                connection.Close();
            }
            textBox1.Text = hoten;
            textBox2.Text = diachi;
            textBox3.Text = sdt;
            dateTimePicker1.Value = ngaysinh;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {
            DSLichHen_NS lh = new DSLichHen_NS();
            lh.StartPosition = FormStartPosition.CenterParent;
            lh.ShowDialog();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            DSHoso_NS ds = new DSHoso_NS();
            ds.StartPosition = FormStartPosition.CenterParent;
            ds.ShowDialog();
        }
    }
}