namespace Bài_2_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblListBox = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.btnNhap = new System.Windows.Forms.Button();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnChonSoLe = new System.Windows.Forms.Button();
            this.btnChonSoChan = new System.Windows.Forms.Button();
            this.btnThayBangBinhPhuong = new System.Windows.Forms.Button();
            this.btnTangLen2 = new System.Windows.Forms.Button();
            this.btnXoaDangChon = new System.Windows.Forms.Button();
            this.btnXoaDauCuoi = new System.Windows.Forms.Button();
            this.btnTongCacPhanTu = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblListBox
            // 
            this.lblListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblListBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblListBox.Font = new System.Drawing.Font("Times New Roman", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblListBox.Location = new System.Drawing.Point(0, 0);
            this.lblListBox.Name = "lblListBox";
            this.lblListBox.Size = new System.Drawing.Size(963, 79);
            this.lblListBox.TabIndex = 2;
            this.lblListBox.Text = "LISTBOX";
            this.lblListBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstSo);
            this.groupBox1.Controls.Add(this.btnNhap);
            this.groupBox1.Controls.Add(this.txtNhap);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 554);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ListBox";
            // 
            // lstSo
            // 
            this.lstSo.ForeColor = System.Drawing.Color.Black;
            this.lstSo.FormattingEnabled = true;
            this.lstSo.ItemHeight = 42;
            this.lstSo.Location = new System.Drawing.Point(15, 186);
            this.lstSo.Name = "lstSo";
            this.lstSo.Size = new System.Drawing.Size(348, 340);
            this.lstSo.TabIndex = 2;
            // 
            // btnNhap
            // 
            this.btnNhap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNhap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNhap.Location = new System.Drawing.Point(15, 116);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(325, 61);
            this.btnNhap.TabIndex = 1;
            this.btnNhap.Text = "&Nhập";
            this.btnNhap.UseVisualStyleBackColor = false;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(15, 49);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(325, 50);
            this.txtNhap.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnChonSoLe);
            this.groupBox2.Controls.Add(this.btnChonSoChan);
            this.groupBox2.Controls.Add(this.btnThayBangBinhPhuong);
            this.groupBox2.Controls.Add(this.btnTangLen2);
            this.groupBox2.Controls.Add(this.btnXoaDangChon);
            this.groupBox2.Controls.Add(this.btnXoaDauCuoi);
            this.groupBox2.Controls.Add(this.btnTongCacPhanTu);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(433, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(498, 554);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xử lý ListBox";
            // 
            // btnChonSoLe
            // 
            this.btnChonSoLe.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnChonSoLe.Location = new System.Drawing.Point(29, 454);
            this.btnChonSoLe.Name = "btnChonSoLe";
            this.btnChonSoLe.Size = new System.Drawing.Size(436, 61);
            this.btnChonSoLe.TabIndex = 0;
            this.btnChonSoLe.Text = "Chọn số lẻ";
            this.btnChonSoLe.UseVisualStyleBackColor = false;
            this.btnChonSoLe.Click += new System.EventHandler(this.btnChonSoLe_Click);
            // 
            // btnChonSoChan
            // 
            this.btnChonSoChan.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnChonSoChan.Location = new System.Drawing.Point(29, 387);
            this.btnChonSoChan.Name = "btnChonSoChan";
            this.btnChonSoChan.Size = new System.Drawing.Size(435, 61);
            this.btnChonSoChan.TabIndex = 0;
            this.btnChonSoChan.Text = "Chọn số chẵn";
            this.btnChonSoChan.UseVisualStyleBackColor = false;
            this.btnChonSoChan.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnThayBangBinhPhuong
            // 
            this.btnThayBangBinhPhuong.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThayBangBinhPhuong.Location = new System.Drawing.Point(29, 320);
            this.btnThayBangBinhPhuong.Name = "btnThayBangBinhPhuong";
            this.btnThayBangBinhPhuong.Size = new System.Drawing.Size(436, 61);
            this.btnThayBangBinhPhuong.TabIndex = 0;
            this.btnThayBangBinhPhuong.Text = "Thay bằng bình phương";
            this.btnThayBangBinhPhuong.UseVisualStyleBackColor = false;
            this.btnThayBangBinhPhuong.Click += new System.EventHandler(this.btnThayBangBinhPhuong_Click);
            // 
            // btnTangLen2
            // 
            this.btnTangLen2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTangLen2.Location = new System.Drawing.Point(30, 253);
            this.btnTangLen2.Name = "btnTangLen2";
            this.btnTangLen2.Size = new System.Drawing.Size(435, 61);
            this.btnTangLen2.TabIndex = 0;
            this.btnTangLen2.Text = "Tăng mỗi phần tử lên 2";
            this.btnTangLen2.UseVisualStyleBackColor = false;
            this.btnTangLen2.Click += new System.EventHandler(this.btnTangLen2_Click);
            // 
            // btnXoaDangChon
            // 
            this.btnXoaDangChon.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnXoaDangChon.Location = new System.Drawing.Point(29, 186);
            this.btnXoaDangChon.Name = "btnXoaDangChon";
            this.btnXoaDangChon.Size = new System.Drawing.Size(436, 61);
            this.btnXoaDangChon.TabIndex = 0;
            this.btnXoaDangChon.Text = "Xóa Phần tử đang chọn";
            this.btnXoaDangChon.UseVisualStyleBackColor = false;
            this.btnXoaDangChon.Click += new System.EventHandler(this.btnXoaDangChon_Click);
            // 
            // btnXoaDauCuoi
            // 
            this.btnXoaDauCuoi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnXoaDauCuoi.Location = new System.Drawing.Point(29, 116);
            this.btnXoaDauCuoi.Name = "btnXoaDauCuoi";
            this.btnXoaDauCuoi.Size = new System.Drawing.Size(436, 61);
            this.btnXoaDauCuoi.TabIndex = 0;
            this.btnXoaDauCuoi.Text = "Xóa Phần tử đầu và cuối";
            this.btnXoaDauCuoi.UseVisualStyleBackColor = false;
            this.btnXoaDauCuoi.Click += new System.EventHandler(this.btnXoaDauCuoi_Click);
            // 
            // btnTongCacPhanTu
            // 
            this.btnTongCacPhanTu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTongCacPhanTu.Location = new System.Drawing.Point(29, 49);
            this.btnTongCacPhanTu.Name = "btnTongCacPhanTu";
            this.btnTongCacPhanTu.Size = new System.Drawing.Size(436, 61);
            this.btnTongCacPhanTu.TabIndex = 0;
            this.btnTongCacPhanTu.Text = "Tổng các phần tử trong List";
            this.btnTongCacPhanTu.UseVisualStyleBackColor = false;
            this.btnTongCacPhanTu.Click += new System.EventHandler(this.btnTongCacPhanTu_Click);
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnKetThuc.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetThuc.Location = new System.Drawing.Point(35, 682);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(896, 61);
            this.btnKetThuc.TabIndex = 5;
            this.btnKetThuc.Text = "&KẾT THÚC";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 778);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblListBox);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListBox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblListBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnChonSoLe;
        private System.Windows.Forms.Button btnChonSoChan;
        private System.Windows.Forms.Button btnThayBangBinhPhuong;
        private System.Windows.Forms.Button btnTangLen2;
        private System.Windows.Forms.Button btnXoaDangChon;
        private System.Windows.Forms.Button btnXoaDauCuoi;
        private System.Windows.Forms.Button btnTongCacPhanTu;
        private System.Windows.Forms.Button btnKetThuc;
    }
}

