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
    public partial class DangKi : Form
    {
        public DangKi()
        {
            InitializeComponent();
        }

        private void DangKi_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-TD9TJMNG\SQLEXPRESS;Initial Catalog=QLNHAKHOA;Integrated Security=True");
            conn.Open();
            string sdtdn = txussername.Text;
            string matkhau1 = pass1.Text;
            string matkhau2 = pass2.Text;
            string hotenn = hoten.Text.Trim();
            string ngaysinhh = ngaysinh.Value.ToString("dd/MM/yyyy"); ;
            string diachii = diachi.Text.Trim();
            if (sdtdn.Length == 0 | matkhau1.Length == 0 | matkhau2.Length == 0 | hotenn.Length == 0 | ngaysinhh.Length ==0 | diachii.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if(matkhau1 != matkhau2)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                string sql = "insert into TAIKHOAN(MATK,TENTK, MATKHAU, TRANGTHAI, LOAIACC) values ((SELECT CONCAT('TK', RIGHT('000' + CAST(ISNULL(MAX(CAST(SUBSTRING(MATK, 3, LEN(MATK) - 2) AS INT)), 0) + 1 AS VARCHAR(3)), 3)) FROM TAIKHOAN),'" + sdtdn + "', '" + matkhau1 + "', 0, 0)";
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = sql;
                com.Connection = conn;
                com.ExecuteNonQuery();
                com.Dispose();
                com = null;
                sql = "select MATK from TAIKHOAN where TENTK='" + sdtdn + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                string matk = dtable.Rows[0][0].ToString();
                sql = "insert into KHACHHANG(MAKH,HOTEN, NGAYSINH, SDT, DIACHI, MATK_KH) values ((SELECT 'KH' + RIGHT('000' + CAST(ISNULL(MAX(CAST(SUBSTRING(MAKH, 3, LEN(MAKH) - 2) AS INT)), 0) + 1 AS VARCHAR(3)), 3) FROM KHACHHANG),'" + hotenn + "', '" + ngaysinhh + "', '"  + sdtdn + "', '" + diachii + "', '" + matk+"')";
                com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = sql;
                com.Connection = conn;
                com.ExecuteNonQuery();
                com.Dispose();
                com = null;
                sql = "EXEC sp_addlogin " + sdtdn + " ,'" + matkhau1 + "', 'QLNHAKHOA'";
                com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = sql;
                com.Connection = conn;
                com.ExecuteNonQuery();
                com.Dispose();
                com = null;
                sql = "CREATE USER [" + sdtdn + "] FOR LOGIN [" + sdtdn + "]";
                com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = sql;
                com.Connection = conn;
                com.ExecuteNonQuery();
                com.Dispose();
                com = null;
                sql = "EXEC sp_addrolemember 'KHACHHANGROLE', [" + sdtdn + "];";
                com = new SqlCommand();
                com.CommandType = CommandType.Text;
                com.CommandText = sql;
                com.Connection = conn;
                com.ExecuteNonQuery();
                com.Dispose();
                com = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}\n\nĐã có người đăng nhập bằng số điện thoại này. Thử cách khác.");
                MessageBox.Show("Đã có người đăng nhập bằng số điện thoại này. Thử cách khác. ");
                return;
            }
            finally
            {
                conn.Close();
            }
            MessageBox.Show("Đăng kí thành công, bấm quay lại để đăng nhập");
        }
    }
}
