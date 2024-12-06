using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_6
{
    public partial class FrmBai1_6 : Form
    {
        public FrmBai1_6()
        {
            InitializeComponent();
        }

        

        private void radTimesNewRoman_CheckedChanged(object sender, EventArgs e)
        {
            if (radTimesNewRoman.Checked)
            {
                rtbVanBan.Font = new Font("Times New Roman", 18, FontStyle.Regular);
            }    
        }

        private void FrmBai1_6_Load(object sender, EventArgs e)
        {
            rtbVanBan.Focus();
            radTimesNewRoman.Checked = true;
            rtbVanBan.Font = new Font("Times New Roman", 18, FontStyle.Regular);

        }

        private void radArial_CheckedChanged(object sender, EventArgs e)
        {
            if (radArial.Checked)
            {
                rtbVanBan.Font = new Font("Arial", 18, FontStyle.Regular);
            }
        }

        private void radTahoma_CheckedChanged(object sender, EventArgs e)
        {
            if (radTahoma.Checked)
            {
                rtbVanBan.Font = new Font("Tahoma", 18, FontStyle.Regular);
            }
        }

        private void radCourierNew_CheckedChanged(object sender, EventArgs e)
        {
            if (radCourierNew.Checked)
            {
                rtbVanBan.Font = new Font("Courier New", 18, FontStyle.Regular, GraphicsUnit.Pixel);
            }
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
