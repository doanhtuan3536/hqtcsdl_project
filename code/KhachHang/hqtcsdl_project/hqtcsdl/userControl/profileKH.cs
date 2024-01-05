using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hqtcsdl.userControl
{
    public partial class profileKH : UserControl
    {
        public profileKH()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void profileKH_Load(object sender, EventArgs e)
        {
            usernameKH.Text = saveUserDetail.username;
            hotenKH.Text = saveUserDetail.hoten;
            diachiKH.Text = saveUserDetail.diachi;
            ngaysinhKH.Text = saveUserDetail.ngaysinh;
            sdtKH.Text = saveUserDetail.sdt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.ShowDialog();
        }
    }
}
