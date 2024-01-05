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
    public partial class dslhKH : UserControl
    {
        public dslhKH()
        {
            InitializeComponent();
        }

        private void dgvHSBA_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DatLichHen f3 = new DatLichHen();
            f3.ShowDialog();
        }
        private void dslhKH_Load(object sender, EventArgs e)
        {
            string query = "select lh.NGAY, lh.GIO, lh.MANHASI, ns.HOTENNS, ns.SDTNS from LICHHEN lh join NHASI ns on ns.MANHASI = lh.MANHASI where MAKH='" + saveUserDetail.id+"'";
            
            //SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable dtable = ConnectDatabase.GetData(query);
            //string namerow = "MANHASI";
            if (dtable.Rows.Count > 0)
            {
                foreach (DataRow dr in dtable.Rows)
                {
                    dslhData.Rows.Add(dr.ItemArray);
                }
            }
        }
    }
}
