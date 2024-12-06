using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            cboSo.Items.Add(txtNhapSo.Text);
            cboSo.SelectedIndex = cboSo.Items.Count - 1;
        }

        private void cboSo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstDanhSach.Items.Clear();
            int So = int.Parse(cboSo.SelectedItem.ToString());
            for (int i = 1; i <= So; i++)
            {
                if (So % i == 0)
                {
                    lstDanhSach.Items.Add(i);
                }
            }
        }

        private void btnTongUocSo_Click(object sender, EventArgs e)
        {
            int tong = 0;

            foreach(int a in lstDanhSach.Items)
            {
                tong += a;
            }
            MessageBox.Show("Tổng là: " + tong, "Thông báo");
        }

        private void btnSoLuongCacUocChan_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (int i in lstDanhSach.Items)
            {
                if ((i % 2) == 0)
                { count++; }
            }
            MessageBox.Show("Số lượng ước chẵn: " + count, "Thông báo);");
        }

        private bool Ktra_SNT(int a)
        {
            if (a < 2) return false;
            for (int j = 2; j < a; j++)
            {
                if (a % j == 0)
                {
                    return false; }
            }
            return true; }
        



        private void btnSoLuongSoNguyenTo_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach(int i in lstDanhSach.Items)
            {
                if(Ktra_SNT(i))
                {
                    count++;
                }
                MessageBox.Show("Số lượng ước số nguyên tố: " + count, "Thông báo");
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
