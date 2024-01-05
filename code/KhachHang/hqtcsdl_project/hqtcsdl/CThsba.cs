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
namespace hqtcsdl
{
    public partial class CThsba : Form
    {
        private string idhsba = null;
        private string mansi = null;
        public CThsba(string idhs = null, string manhasi = null)
        {
            InitializeComponent();
            idhsba = idhs;
            mansi = manhasi;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        //SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-TD9TJMNG\SQLEXPRESS;Initial Catalog=QLNHAKHOA;Integrated Security=True");
        private void CThsba_Load(object sender, EventArgs e)
        {
            makh.Text = saveUserDetail.id;
            hotenkh.Text = saveUserDetail.hoten;
            string query = "select t.MATHUOC, t.TENTHUOC, ct.SOLUONG, ct.SOLUONG*t.GIA from CT_THUOC ct join THUOC t on ct.MATHUOC = t.MATHUOC where ct.IDHOSOBA='" + idhsba + "'";
            DataTable dtableThuoc = ConnectDatabase.GetData(query);
            if (dtableThuoc.Rows.Count > 0)
            {
                foreach (DataRow dr in dtableThuoc.Rows)
                {
                    dsthuoc.Rows.Add(dr.ItemArray);
                }
            }

            string query2 = "select ns.HOTENNS, ns.SDTNS, ns.DIACHINS from NHASI ns where ns.MANHASI='" + mansi + "'";
            DataTable dtableNhasi = ConnectDatabase.GetData(query2);
            if (dtableNhasi.Rows.Count > 0)
            {
                foreach (DataRow dr in dtableNhasi.Rows)
                {
                    mans.Text = mansi.ToString();
                    hotennhasi.Text = dr.ItemArray[0].ToString();
                    sdtnhasi.Text = dr.ItemArray[1].ToString();
                    diachins.Text = dr.ItemArray[2].ToString();
                }
            }

            string query3 = "select dv.MADV, dv.TENDV, dv.DONGIA from CT_DICHVU ct join DICHVU dv on ct.MADV = DV.MADV where ct.IDHOSOBA='" + idhsba + "'";
            DataTable dtableDV = ConnectDatabase.GetData(query3);
            if (dtableDV.Rows.Count > 0)
            {
                foreach (DataRow dr in dtableDV.Rows)
                {
                    dsdv.Rows.Add(dr.ItemArray);
                }
            }
        }
    }
}
