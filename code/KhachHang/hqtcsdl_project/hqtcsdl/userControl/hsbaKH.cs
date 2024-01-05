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

namespace hqtcsdl.userControl
{
    public partial class hsbaKH : UserControl
    {
        public hsbaKH()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-TD9TJMNG\SQLEXPRESS;Initial Catalog=QLNHAKHOA;Integrated Security=True");
        private void hsbaKH_Load(object sender, EventArgs e)
        {
            conn.Open();
            string query = "select hs.IDHOSOBA, hs.NGAYKHAM, ns.MANHASI,ns.HOTENNS, ns.SDTNS from HOSOBENHAN hs join NHASI ns on ns.MANHASI = hs.MANHASI where MAKH='" + saveUserDetail.id + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtable = new DataTable();
            sda.Fill(dtable);
            //string namerow = "MANHASI";
            if (dtable.Rows.Count > 0)
            {
                foreach (DataRow dr in dtable.Rows)
                {
                    dgvHSBA.Rows.Add(dr.ItemArray);
                }
            }
            conn.Close();

        }

        private void dgvHSBA_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvHSBA.CurrentRow.Selected = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(dgvHSBA.CurrentRow.Cells["column1"].Value != null && dgvHSBA.CurrentRow.Cells["column5"].Value != null)
            {
                CThsba cthsba = new CThsba(dgvHSBA.CurrentRow.Cells["column1"].Value.ToString(), dgvHSBA.CurrentRow.Cells["column5"].Value.ToString());
                //MessageBox.Show(dgvHSBA.CurrentRow.Cells["column5"].Value.ToString());
                cthsba.ShowDialog();
            }    
            
        }
    }
}
