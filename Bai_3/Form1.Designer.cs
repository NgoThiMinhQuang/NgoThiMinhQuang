namespace Bai_3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboSo = new System.Windows.Forms.ComboBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.txtNhapSo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstDanhSach = new System.Windows.Forms.ListBox();
            this.btnTongUocSo = new System.Windows.Forms.Button();
            this.btnSoLuongCacUocChan = new System.Windows.Forms.Button();
            this.btnSoLuongSoNguyenTo = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSo);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.txtNhapSo);
            this.groupBox1.Location = new System.Drawing.Point(101, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 259);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Số";
            // 
            // cboSo
            // 
            this.cboSo.FormattingEnabled = true;
            this.cboSo.Location = new System.Drawing.Point(27, 170);
            this.cboSo.Name = "cboSo";
            this.cboSo.Size = new System.Drawing.Size(398, 44);
            this.cboSo.TabIndex = 2;
            this.cboSo.SelectedIndexChanged += new System.EventHandler(this.cboSo_SelectedIndexChanged);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCapNhat.Location = new System.Drawing.Point(281, 56);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(144, 62);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // txtNhapSo
            // 
            this.txtNhapSo.Location = new System.Drawing.Point(27, 74);
            this.txtNhapSo.Name = "txtNhapSo";
            this.txtNhapSo.Size = new System.Drawing.Size(248, 44);
            this.txtNhapSo.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstDanhSach);
            this.groupBox2.Location = new System.Drawing.Point(595, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(487, 259);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // lstDanhSach
            // 
            this.lstDanhSach.FormattingEnabled = true;
            this.lstDanhSach.ItemHeight = 36;
            this.lstDanhSach.Location = new System.Drawing.Point(31, 56);
            this.lstDanhSach.Name = "lstDanhSach";
            this.lstDanhSach.Size = new System.Drawing.Size(423, 184);
            this.lstDanhSach.TabIndex = 0;
            // 
            // btnTongUocSo
            // 
            this.btnTongUocSo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTongUocSo.Location = new System.Drawing.Point(595, 338);
            this.btnTongUocSo.Name = "btnTongUocSo";
            this.btnTongUocSo.Size = new System.Drawing.Size(487, 54);
            this.btnTongUocSo.TabIndex = 2;
            this.btnTongUocSo.Text = "&Tổng các ước số";
            this.btnTongUocSo.UseVisualStyleBackColor = false;
            this.btnTongUocSo.Click += new System.EventHandler(this.btnTongUocSo_Click);
            // 
            // btnSoLuongCacUocChan
            // 
            this.btnSoLuongCacUocChan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSoLuongCacUocChan.Location = new System.Drawing.Point(595, 413);
            this.btnSoLuongCacUocChan.Name = "btnSoLuongCacUocChan";
            this.btnSoLuongCacUocChan.Size = new System.Drawing.Size(487, 47);
            this.btnSoLuongCacUocChan.TabIndex = 3;
            this.btnSoLuongCacUocChan.Text = "&Số lượng các ước số chẵn";
            this.btnSoLuongCacUocChan.UseVisualStyleBackColor = false;
            this.btnSoLuongCacUocChan.Click += new System.EventHandler(this.btnSoLuongCacUocChan_Click);
            // 
            // btnSoLuongSoNguyenTo
            // 
            this.btnSoLuongSoNguyenTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSoLuongSoNguyenTo.Location = new System.Drawing.Point(595, 480);
            this.btnSoLuongSoNguyenTo.Name = "btnSoLuongSoNguyenTo";
            this.btnSoLuongSoNguyenTo.Size = new System.Drawing.Size(487, 54);
            this.btnSoLuongSoNguyenTo.TabIndex = 4;
            this.btnSoLuongSoNguyenTo.Text = "Số lượng các ước số &nguyên tố";
            this.btnSoLuongSoNguyenTo.UseVisualStyleBackColor = false;
            this.btnSoLuongSoNguyenTo.Click += new System.EventHandler(this.btnSoLuongSoNguyenTo_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnThoat.Location = new System.Drawing.Point(405, 480);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(136, 54);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 606);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSoLuongSoNguyenTo);
            this.Controls.Add(this.btnSoLuongCacUocChan);
            this.Controls.Add(this.btnTongUocSo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboSo;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtNhapSo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lstDanhSach;
        private System.Windows.Forms.Button btnTongUocSo;
        private System.Windows.Forms.Button btnSoLuongCacUocChan;
        private System.Windows.Forms.Button btnSoLuongSoNguyenTo;
        private System.Windows.Forms.Button btnThoat;
    }
}

