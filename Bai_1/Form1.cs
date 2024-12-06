using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_1
{
    public partial class FrmBai1_1 : Form
    {
        public FrmBai1_1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string ThongBao;
            ThongBao = "Tên đăng nhập là: ";
            ThongBao += this.txtTenDangNhap.Text;
            ThongBao += "\n\rMật khẩu là: ";
            ThongBao += this.txtMatKhau.Text;
            if (this.chkNho.Checked == true)
            {
                ThongBao += "\n\rBạn có ghi nhớ. ";
            }
            MessageBox.Show(ThongBao, "Thông báo");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtTenDangNhap.Clear();
            this.txtMatKhau.Clear();
            this.txtTenDangNhap.Focus();
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn dừng phần mềm ? ", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
