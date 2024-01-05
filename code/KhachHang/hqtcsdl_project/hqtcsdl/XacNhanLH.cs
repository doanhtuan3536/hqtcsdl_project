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
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-TD9TJMNG\SQLEXPRESS;Initial Catalog=QLNHAKHOA;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            //conn.Open();
            //string query = "insert into LICHHEN(NGAY, GIO, MAKH, MANHASI, NHASIDAT) values (" + ngayhen + "," + giohen + "," + saveUserDetail.id +","+ mansi + ","  + 0 + ")";
            //conn.Close();
            try
            {
                conn.Open();

                string query = "INSERT INTO LICHHEN (NGAY, GIO, MAKH, MANHASI, NHASIDAT) " +
                               "VALUES (@Ngay, @Gio, @MaKH, @MaNhasi, @NhasiDat)";

                SqlCommand cmd = new SqlCommand(query, conn);

                // Assuming ngayhen, giohen, saveUserDetail.id, mansi are your variables
                cmd.Parameters.AddWithValue("@Ngay", ngayhen);
                cmd.Parameters.AddWithValue("@Gio", giohen);
                cmd.Parameters.AddWithValue("@MaKH", saveUserDetail.id);
                cmd.Parameters.AddWithValue("@MaNhasi", mansi);
                cmd.Parameters.AddWithValue("@NhasiDat", 0);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Đặt lịch hẹn thành công");
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("Xảy ra lỗi, vui lòng kiểm tra lại thông tin hoặc thử lại");
            }
            finally
            {
                conn.Close();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
