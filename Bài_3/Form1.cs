using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            cboSo.Items.Add(txtSo.Text);   // Cần thêm 1 câu lệnh kiểm tra txtSo.Text có phải là số không
            cboSo.SelectedIndex = cboSo.Items.Count - 1;
        
        }

        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstSo.Items.Clear();
            int So = int.Parse(cboSo.SelectedItem.ToString());
            for (int i = 0; i <= So; i++)
            {
                if (So % i == 0)
                {
                    lstSo.Items.Add(i);
                }
            }
        }

        private void btnTongCacUocSo_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (int a in lstSo.Items)
            {
                tong += a;
            }
            MessageBox.Show("Tổng các ước số là: " + tong, "Thông báo");
        }

        private void btnSoLuongCacUocSoChan_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (int i in lstSo.Items)
            {
                if ((i % 2) == 0)
                { count++; }
            }
            MessageBox.Show("Số lượng ước chẵn: " + count, "Thông báo");
        }
        private bool Ktra_SNT(int a)
        {
            if (a < 2) return false;
            for (int j = 2; j < a; j++)
            {
                if (a % j == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private void SoLuongCacUocSoNguyenTo_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(int i in lstSo.Items)
            {
                if (Ktra_SNT(i))
                    count++;

            }
            MessageBox.Show("Số lượng ước số nguyên tố: " + count, "Thông báo");

        }
    }
}
