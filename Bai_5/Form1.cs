using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_5
{
    public partial class FrmBai1_5 : Form
    {
        public FrmBai1_5()
        {
            InitializeComponent();
        }

        private void FrmBai1_5_Load(object sender, EventArgs e)
        {
            radRed.Checked = true;
        }

        private void txtNhapTen_TextChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Text = txtNhapTen.Text;
        }

        private void radRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radRed.Checked == true)
            {
                lblLapTrinh.ForeColor = radRed.ForeColor;
            }
        }

        private void radGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radGreen.Checked == true)
            {
                lblLapTrinh.ForeColor = radGreen.ForeColor;
            }
        }

        private void radBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlue.Checked == true)
            {
                lblLapTrinh.ForeColor = radBlue.ForeColor;
            }
        }

        private void radBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radBlack.Checked == true)
            {
                lblLapTrinh.ForeColor = radBlack.ForeColor;
            }
        }

        private void chkBold_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Bold);
        }

        private void chkItalic_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Italic);
        }

        private void chkUnderline_CheckedChanged(object sender, EventArgs e)
        {
            lblLapTrinh.Font = new Font(lblLapTrinh.Font.Name, lblLapTrinh.Font.Size, lblLapTrinh.Font.Style ^ FontStyle.Underline);
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
