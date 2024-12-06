using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_2
{
    public partial class FrmBai_2 : Form
    {
        public FrmBai_2()
        {
            InitializeComponent();
        }

        private void btnKetQua_Click(object sender, EventArgs e)
        {
            string HoTen = this.txtHoTen.Text.Trim();
            if (this.radChuThuong.Checked == true)
            {
                txtKetQua.Text = HoTen.ToLower();
            }
            if(this.radChuInHoa.Checked == true)
            {
                txtKetQua.Text = HoTen.ToUpper();
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtHoTen.Clear();
            this.txtKetQua.Clear();
            this.radChuThuong.Checked = true;
            this.txtHoTen.Focus();
        }

        private void txtKetQua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
