using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ThemDL()
        {
            if (!string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                lstLopA.Items.Add(txtHoVaTen.Text);
                txtHoVaTen.Text = "";
                txtHoVaTen.Focus();
            }
        }

        private void txtHoVaTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            ThemDL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtHoVaTen.Focus();
        }

        private void txtHoVaTen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ThemDL();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            var selectedItems = new List<object>(lstLopA.SelectedItems.Cast<object>());
            foreach (var item in selectedItems)
            {
                // Lấy từng mục đã chọn và xử lý
                string selectedItem = item.ToString();
                lstLopB.Items.Add(selectedItem);
                //Xóa mục đã chọn
                lstLopA.Items.Remove(item);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            var selectedItems = new List<object>(lstLopA.Items.Cast<object>());
            foreach (var item in selectedItems)
            {
                // Lấy từng mục đã chọn và xử lý
                
                lstLopB.Items.Add(item.ToString());
                //Xóa mục đã chọn
                lstLopA.Items.Remove(item);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            var selectedItems = new List<object>(lstLopA.SelectedItems.Cast<object>());
            foreach (var item in selectedItems)
            {
                // Lấy từng mục đã chọn và xử lý
                string selectedItem = item.ToString();
                lstLopB.Items.Add(selectedItem);
                //Xóa mục đã chọn
                lstLopA.Items.Remove(item);
            }
        }

        private void lstLopA_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
