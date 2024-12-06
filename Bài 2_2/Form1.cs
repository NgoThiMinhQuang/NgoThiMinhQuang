using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bài_2_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1;  // tự bỏ chọn toàn bộ các dòng
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                if (x % 2 == 0)
                {
                    lstSo.SelectedIndex = i;
                }
            }
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtNhap.Text);
            lstSo.Items.Add(x);
        }

        private void btnTongCacPhanTu_Click(object sender, EventArgs e)
        {
            int sum = 0;
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                sum += x;
            }
            MessageBox.Show("Tổng các phần tử trong List là: " + sum);
        }

        private void btnXoaDauCuoi_Click(object sender, EventArgs e)
        {
            lstSo.Items.RemoveAt(0);
            lstSo.Items.RemoveAt(lstSo.Items.Count - 1);
        }

        private void btnXoaDangChon_Click(object sender, EventArgs e)
        {
            while (lstSo.SelectedIndices.Count > 0)
            {
                lstSo.Items.RemoveAt(lstSo.SelectedIndices[0]);
            }
        }

        private void btnTangLen2_Click(object sender, EventArgs e)
        {
            for(int i = 0;i < lstSo.Items.Count;i++)
            {
                int x= (int)lstSo.Items[i];
                lstSo.Items[i] = x + 2;
            }    
        }

        private void btnThayBangBinhPhuong_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                x = x * x;
                lstSo.Items[i] = x;
            }
        }

        private void btnChonSoLe_Click(object sender, EventArgs e)
        {
            lstSo.SelectedIndex = -1;  // tự bỏ chọn toàn bộ các dòng
            for (int i = 0; i < lstSo.Items.Count; i++)
            {
                int x = (int)lstSo.Items[i];
                if (x % 2 != 0)
                {
                    lstSo.SelectedIndex = i;
                }
            }
        }
    }
}
