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
    public partial class DSHoso_NS : Form
    {
        string connectionString = @"Data Source=LAPTOP-L0R0JU1M\SQLEXPRESS;Initial Catalog=QLNHAKHOA;Integrated Security=True";
        public DSHoso_NS()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.CellDoubleClick += dataGridView1_CellContentClick;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            string query = "select * from HOSOBENHAN";
            if (textBox1.Text != "")
            {
                query += " where MAKH = '" + textBox1.Text + "'";
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(ds);
                connection.Close();
            }
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }
    }
}
