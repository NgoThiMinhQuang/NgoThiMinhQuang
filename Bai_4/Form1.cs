using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radCong_CheckedChanged(object sender, EventArgs e)
        {
            if (radCong.Checked)
            {
                txtKetQua.Text = string.Format("{0}", (double.Parse(txtSo1.Text) + double.Parse(txtSo2.Text)));
            }

        }

        private void radTru_CheckedChanged(object sender, EventArgs e)
        {
            if (radTru.Checked)
            {
                txtKetQua.Text = string.Format("{0}", (double.Parse(txtSo1.Text) - double.Parse(txtSo2.Text)));
            }
        }

        private void radNhan_CheckedChanged(object sender, EventArgs e)
        {
            if (radNhan.Checked)
            {
                txtKetQua.Text = string.Format("{0}", (double.Parse(txtSo1.Text) * double.Parse(txtSo2.Text)));
            }
        }

        private void radChia_CheckedChanged(object sender, EventArgs e)
        {
            if (radChia.Checked)
            {
                txtKetQua.Text = string.Format("{0}", (double.Parse(txtSo1.Text) / double.Parse(txtSo2.Text)));
            }
        }
    }
}
