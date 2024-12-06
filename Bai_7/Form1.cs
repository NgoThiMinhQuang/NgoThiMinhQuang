using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_7
{
    public partial class frmBai1_7 : Form
    {
        public frmBai1_7()
        {
            InitializeComponent();
        }

        private void txtYourName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void frmBai1_7_Load(object sender, EventArgs e)
        {
            txtYourName.Focus();
        }
        private void Show()
        {
            MessageBox.Show("Your Name: " + txtYourName.Text + "\nAge: " + (DateTime.Now.Year - int.Parse(txtYearOfBirth.Text)));
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            bool kt = true;
            if (string.IsNullOrWhiteSpace(txtYourName.Text))
            {
                errDuLieu.SetError(txtYourName, "Vui lòng nhập dữ liệu!");
                kt = false;
            }
            else
            {
                errDuLieu.SetError(txtYourName, "");
            }    
            if (!int.TryParse(txtYearOfBirth.Text, out int result))
            {
                errDuLieu.SetError(txtYearOfBirth, "Sai dữ liệu");
                kt = false;
            }    
            else
            {
                errDuLieu.SetError(txtYearOfBirth, "");
            }
            if (kt) { Show(); }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtYourName.Text = string.Empty;
            txtYearOfBirth.Text = string.Empty;
            txtYourName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ret = MessageBox.Show("Bạn có muốn dừng phần mềm ? ", "Hỏi Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ret == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
