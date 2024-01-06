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
   
    public partial class DSLichHen_NS : Form
    {
        string maNS = "'NS001'";
        string connectionString = @"Data Source=LAPTOP-L0R0JU1M\SQLEXPRESS;Initial Catalog=QLNHAKHOA;Integrated Security=True";

        public DSLichHen_NS()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = GetLichHen().Tables[0];
            dataGridView1.CellDoubleClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                if ((bool)row.Cells[4].Value == true)
                {
                    DateTime ngay = Convert.ToDateTime(row.Cells[0].Value);
                    TimeSpan gio = (TimeSpan)row.Cells[1].Value;
                    string makh = row.Cells[2].Value.ToString();
                    var mans = row.Cells[3].Value.ToString();
                    DateTime combinedDateTime = ngay.Date + gio;
                    SuaLichHen_NS newForm = new SuaLichHen_NS(ngay, combinedDateTime, makh, mans);
                    newForm.StartPosition = FormStartPosition.CenterParent;
                    newForm.ShowDialog();
                }
                
            }
        }


        DataSet GetLichHen()
        {
            DataSet ds = new DataSet();
            string query = "select * from LICHHEN where MANHASI = " + maNS;
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(ds);
                connection.Close();
            }
            return ds;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThemLichHen_NS newForm = new ThemLichHen_NS();
            newForm.StartPosition = FormStartPosition.CenterParent;
            newForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = GetLichHen().Tables[0];
        }
    }
}
