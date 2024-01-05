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
    public partial class XacNhanLH : Form
    {
        private string ngayhen;
        private string giohen;
        private string mansi;
        private string hoten;
        private string sdt;
        private string ngaysinh;
        public XacNhanLH(string ngayhen, string giohen, string manhasi, string hotenns, string sdtns, string ngaysinhns)
        {
            InitializeComponent();
            this.ngayhen = ngayhen;
            this.giohen = giohen;
            this.mansi = manhasi;
            this.hoten = hotenns;
            this.sdt = sdtns;
            this.ngaysinh = ngaysinhns;
        }
        private void XacNhanLH_Load(object sender, EventArgs e)
        {
            ngayhenlabel.Text = this.ngayhen;
            giohenlabel.Text = this.giohen;
            manhasi.Text = this.mansi;
            hotennhasi.Text = this.hoten;
            ngaysinhnhasi.Text = this.ngaysinh;
            sdtnhasi.Text = this.sdt;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "insert into LICHHEN(NGAY, GIO, MAKH, MANHASI, NHASIDAT) values ('" + ngayhen + "','" + giohen + "','" + saveUserDetail.id + "','" + mansi + "'," + '0' + ")";
                int rowafftected = ConnectDatabase.InsertData(query);
                if(rowafftected > 0)
                {
                    MessageBox.Show("Thêm lịch hẹn mới thành công");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                //MessageBox.Show("Xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Xảy ra lỗi, vui lòng kiểm tra lại thông tin hoặc thử lại");
            }
            finally
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
