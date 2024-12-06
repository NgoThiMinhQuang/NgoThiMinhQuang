using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_8
{
    public partial class FrmBai1_8 : Form
    {
        public FrmBai1_8()
        {
            InitializeComponent();
        }
        private void ValidateInputs()
        {
            bool isAValid = int.TryParse(txtNhapA.Text, out _); //ktra nhập A
            bool isBValid = int.TryParse(txtNhapB.Text, out _);  // ktra nhap B

            // Đặt lỗi nếu không hợp lệ
            errorProvider1.SetError(txtNhapA, isAValid ? "" : "Lỗi dữ liệu!");
            errorProvider1.SetError(txtNhapB, isBValid ? "" : "Lỗi dữ liệu!");

            // Bật nút giải nếu cả 2 hợp lệ
            btnGiai.Enabled = isAValid && isBValid  ;

            // bật nút Xóa khi có bất kì dữ liệu nào được nhập
            btnXoa.Enabled = !string.IsNullOrWhiteSpace(txtNhapA.Text) || !string.IsNullOrWhiteSpace(txtNhapB.Text) ;
        }
        private void txtNhapA_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();  
        }


        private void FrmBai1_8_Load(object sender, EventArgs e)
        {
            txtNhapA.Focus();
            btnGiai.Enabled = false;
            btnXoa.Enabled = false;
        }

        private void txtNhapB_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs() ;  // Gọi nhập hàm kiếm tra chung
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtNhapA.Text);
            double b = Convert.ToDouble(txtNhapB.Text);
            if ( a ==0)
            {
                if (b == 0) txtNghiem.Text = "Vô số nghiệm";
                else txtNghiem.Text = "Vô nghiệm";

            }   
            else
            {
                txtNghiem.Text = "" + (-b / a);
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhapA.Text = "";
            txtNhapB.Text = "";
            txtNghiem.Text = "";
            txtNhapA.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn dừng phần mềm ? ", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
