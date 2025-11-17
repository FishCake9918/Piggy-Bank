using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Layout
{
    public partial class UserControlBaoCao : UserControl
    {
        public UserControlBaoCao()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            FormDongTaiKhoan f = new FormDongTaiKhoan();
            f.Show();
        }
    }
}
