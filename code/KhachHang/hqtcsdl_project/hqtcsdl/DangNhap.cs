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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-TD9TJMNG\SQLEXPRESS;Initial Catalog=QLNHAKHOA;Integrated Security=True");
        SqlCommand command;
        int LoaiAcc = -1;
        string ma = null;
        string matk = null;
        int trangthai = 0;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string usern = txUsername.Text.Trim().ToString();
            string pass = txPass.Text.Trim().ToString();

            // nếu chưa có dữ liệu 
            if (usern.Length == 0 | pass.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            try
            {
                conn.Open();
                using (command = new SqlCommand("Sp_DangNhap", conn))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SDT", txUsername.Text);
                    command.Parameters.AddWithValue("@MatKhau", txPass.Text);
                    SqlParameter loaiTKParameter = new SqlParameter("@LoaiAcc", SqlDbType.Int);
                    loaiTKParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(loaiTKParameter);

                    SqlParameter maParameter = new SqlParameter("@Ma", SqlDbType.VarChar, 10);
                    maParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(maParameter);

                    SqlParameter matkParameter = new SqlParameter("@MaTK", SqlDbType.VarChar, 10);
                    matkParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(matkParameter);

                    SqlParameter trangthaiParameter = new SqlParameter("@Trangthai", SqlDbType.Bit);
                    trangthaiParameter.Direction = ParameterDirection.Output;
                    command.Parameters.Add(trangthaiParameter);

                    command.ExecuteNonQuery();
                    //Console.WriteLine("Đăng nhập thành công. Loại tài khoản: " + loaiTKParameter.Value);
                    LoaiAcc = Convert.ToInt32(loaiTKParameter.Value);
                    ma = maParameter.Value.ToString();
                    matk = matkParameter.Value.ToString();
                    trangthai = Convert.ToInt32(trangthaiParameter.Value);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                if(ma != null)
                {
                    string sql = "SELECT kh.HOTEN, kh.NGAYSINH, kh.SDT, kh.DIACHI FROM KHACHHANG kh WHERE MAKH = " + "'" + ma + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(sql, conn);
                    DataTable dtableInfo = new DataTable();
                    sda.Fill(dtableInfo);
                    saveUserDetail.hoten = dtableInfo.Rows[0][0].ToString();
                    saveUserDetail.ngaysinh = dtableInfo.Rows[0][1].ToString();
                    saveUserDetail.sdt = dtableInfo.Rows[0][2].ToString();
                    saveUserDetail.diachi = dtableInfo.Rows[0][3].ToString();
                }
                conn.Close();
            }
            if(LoaiAcc == -1)
            {
                return;
            }
            if (trangthai==1)
            {
                MessageBox.Show("Tài khoản đã bị khóa !", "Thông báo");
                return;
            }
            ConnectDatabase.Connect(@"Data Source=LAPTOP-TD9TJMNG\SQLEXPRESS;Initial Catalog=QLNHAKHOA;User ID=" + usern + ";Password=" + pass + "");
            if(LoaiAcc == 0)
            {
                saveUserDetail.id = ma;
                saveUserDetail.idTK = matk;
                saveUserDetail.username = txUsername.Text;
                GiaoDienChinh gdkh = new GiaoDienChinh();
                this.Hide();
                gdkh.ShowDialog();
                this.Close();
            }    
        }
    }
}
