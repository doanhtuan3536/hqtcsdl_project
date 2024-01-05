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
    public partial class DatLichHen : Form
    {
        public DatLichHen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DatLichHen_Load(object sender, EventArgs e)
        {

        }
        //SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-TD9TJMNG\SQLEXPRESS;Initial Catalog=QLNHAKHOA;Integrated Security=True");
        private void LocNhaSi_Click(object sender, EventArgs e)
        {
            string datepick = ngayhen.Value.ToString("dd/MM/yyyy");
            DateTime date = DateTime.ParseExact(datepick, "dd/MM/yyyy", null);
            DayOfWeek weekday = date.DayOfWeek;
            int weekdayAsInt = (int)weekday + 1;
            string time = giohen.Value.ToString("HH:mm");
            nhasiphuhop.Rows.Clear();
            nhasiphuhop.Refresh();
            string query = "select ns.MANHASI, ns.HOTENNS, ns.NGAYSINHNS, ns.SDTNS, lns.NGAYTRONGTUAN, lns.GIOLAMVIEC, lns.GIOKETTHUC from LICHNHASI lns join NHASI ns on lns.MANHASI = ns.MANHASI where NGAYTRONGTUAN=" + weekdayAsInt + " and '" + time + "' between lns.GIOLAMVIEC and lns.GIOKETTHUC";
            DataTable dtable = ConnectDatabase.GetData(query);
            if (dtable.Rows.Count > 0)
            {
                foreach (DataRow dr in dtable.Rows)
                {
                    nhasiphuhop.Rows.Add(dr.ItemArray);
                }
            }
        }

        private void DatLich_Click(object sender, EventArgs e)
        {
            string datepick = ngayhen.Value.ToString("dd/MM/yyyy");
            string today = DateTime.Today.ToString("dd/MM/yyyy");
            DateTime datep = DateTime.Parse(datepick);
            DateTime tod = DateTime.Parse(today);
            if(datep < tod)
            {
                MessageBox.Show("Không thể đặt ! Chỉ có thể đặt ngày bắt đầu từ ngày hôm nay");
                return;
            }
            if(datep == tod)
            {
                TimeSpan timeSpan1 = TimeSpan.Parse(giohen.Value.ToString("HH:mm"));
                TimeSpan timeSpan2 = TimeSpan.Parse(DateTime.Now.ToString("HH:mm"));
                TimeSpan adjustedTimeSpan2 = timeSpan2.Add(new TimeSpan(1, 0, 0));
                int comparisonResult = TimeSpan.Compare(timeSpan1, adjustedTimeSpan2);
                if (comparisonResult < 0)
                {
                    MessageBox.Show("Đặt trước tối thiểu một giờ kể từ hôm nay");
                    return;
                }
            }
            //XacNhanLH xnlh = new XacNhanLH();
            //xnlh.ShowDialog();
            //DateTime date = DateTime.ParseExact(datepick, "dd/MM/yyyy", null);
            //DayOfWeek weekday = date.DayOfWeek;
            //int weekdayAsInt = (int)weekday + 1;
            //string time = giohen.Value.ToString("HH:mm");
            //MessageBox.Show(datepick);
            //MessageBox.Show(time);
            if (nhasiphuhop.CurrentRow != null && nhasiphuhop.CurrentRow.Cells["column1"] != null && nhasiphuhop.CurrentRow.Cells["column1"].Value != null)
            {

                XacNhanLH xnlh = new XacNhanLH(datepick, giohen.Value.ToString("HH:mm"), nhasiphuhop.CurrentRow.Cells["column1"].Value.ToString(), 
                    nhasiphuhop.CurrentRow.Cells["column2"].Value.ToString(), nhasiphuhop.CurrentRow.Cells["column5"].Value.ToString(), nhasiphuhop.CurrentRow.Cells["column3"].Value.ToString());
                xnlh.ShowDialog();
            }
        }

        private void nhasiphuhop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nhasiphuhop.CurrentRow.Selected = true;
        }


    }
}
