using hqtcsdl.userControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static hqtcsdl.userControl.profileKH;

namespace hqtcsdl
{
    public partial class GiaoDienChinh : Form
    {
        public GiaoDienChinh()
        {
            InitializeComponent();
            profileKH pf = new profileKH();
            addUserControl(pf);
            //btn_profile_KH.BackColor = Color.FromArgb(39, 39, 58);
            //btn_profile_KH.ForeColor = Color.White;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void myBtnSetting(object sender, EventArgs e)
        {
            foreach(Control c in btnPanel.Controls)
            {
                c.BackColor = Color.FromArgb(39, 39, 58);
                c.ForeColor = Color.White;
            }

            Control click = (Control)sender;
            click.BackColor = Color.Blue;
            click.ForeColor = Color.White;
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btn_profile_KH_Click(object sender, EventArgs e)
        {
            profileKH pf = new profileKH();
            addUserControl(pf);
            myBtnSetting(btn_profile_KH, null);
        }

        private void btn_dslh_KH_Click_1(object sender, EventArgs e)
        {
            dslhKH lh = new dslhKH();
            addUserControl(lh);
            myBtnSetting(btn_dslh_KH, null);
        }

        private void btn_hsba_KH_Click_1(object sender, EventArgs e)
        {
            hsbaKH hs = new hsbaKH();
            addUserControl(hs);
            myBtnSetting(btn_hsba_KH, null);
        }
    }
}
