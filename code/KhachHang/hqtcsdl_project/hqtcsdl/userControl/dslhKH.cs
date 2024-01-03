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
    }
}
