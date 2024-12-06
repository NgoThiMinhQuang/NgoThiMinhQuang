namespace Bài_3
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSo = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.cboSo = new System.Windows.Forms.ComboBox();
            this.lstSo = new System.Windows.Forms.ListBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTongCacUocSo = new System.Windows.Forms.Button();
            this.btnSoLuongCacUocSoChan = new System.Windows.Forms.Button();
            this.SoLuongCacUocSoNguyenTo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboSo);
            this.groupBox1.Controls.Add(this.btnCapNhat);
            this.groupBox1.Controls.Add(this.txtSo);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(83, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập Số";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstSo);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(601, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 254);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách các ước số";
            // 
            // txtSo
            // 
            this.txtSo.Location = new System.Drawing.Point(21, 65);
            this.txtSo.Name = "txtSo";
            this.txtSo.Size = new System.Drawing.Size(220, 50);
            this.txtSo.TabIndex = 0;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(259, 54);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(173, 60);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // cboSo
            // 
            this.cboSo.FormattingEnabled = true;
            this.cboSo.Location = new System.Drawing.Point(21, 156);
            this.cboSo.Name = "cboSo";
            this.cboSo.Size = new System.Drawing.Size(411, 50);
            this.cboSo.TabIndex = 2;
            this.cboSo.SelectedIndexChanged += new System.EventHandler(this.cboSo_SelectedIndexChanged);
            // 
            // lstSo
            // 
            this.lstSo.FormattingEnabled = true;
            this.lstSo.ItemHeight = 42;
            this.lstSo.Location = new System.Drawing.Point(29, 54);
            this.lstSo.Name = "lstSo";
            this.lstSo.Size = new System.Drawing.Size(477, 172);
            this.lstSo.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(382, 522);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(174, 49);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Th&oát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnTongCacUocSo
            // 
            this.btnTongCacUocSo.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTongCacUocSo.Location = new System.Drawing.Point(630, 330);
            this.btnTongCacUocSo.Name = "btnTongCacUocSo";
            this.btnTongCacUocSo.Size = new System.Drawing.Size(477, 60);
            this.btnTongCacUocSo.TabIndex = 0;
            this.btnTongCacUocSo.Text = "&Tổng các ước số";
            this.btnTongCacUocSo.UseVisualStyleBackColor = true;
            this.btnTongCacUocSo.Click += new System.EventHandler(this.btnTongCacUocSo_Click);
            // 
            // btnSoLuongCacUocSoChan
            // 
            this.btnSoLuongCacUocSoChan.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoLuongCacUocSoChan.Location = new System.Drawing.Point(630, 419);
            this.btnSoLuongCacUocSoChan.Name = "btnSoLuongCacUocSoChan";
            this.btnSoLuongCacUocSoChan.Size = new System.Drawing.Size(477, 63);
            this.btnSoLuongCacUocSoChan.TabIndex = 1;
            this.btnSoLuongCacUocSoChan.Text = "&Số lượng các ước số chẵn";
            this.btnSoLuongCacUocSoChan.UseVisualStyleBackColor = true;
            this.btnSoLuongCacUocSoChan.Click += new System.EventHandler(this.btnSoLuongCacUocSoChan_Click);
            // 
            // SoLuongCacUocSoNguyenTo
            // 
            this.SoLuongCacUocSoNguyenTo.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoLuongCacUocSoNguyenTo.Location = new System.Drawing.Point(630, 500);
            this.SoLuongCacUocSoNguyenTo.Name = "SoLuongCacUocSoNguyenTo";
            this.SoLuongCacUocSoNguyenTo.Size = new System.Drawing.Size(477, 71);
            this.SoLuongCacUocSoNguyenTo.TabIndex = 2;
            this.SoLuongCacUocSoNguyenTo.Text = "Số lượng các ước số &nguyên tố";
            this.SoLuongCacUocSoNguyenTo.UseVisualStyleBackColor = true;
            this.SoLuongCacUocSoNguyenTo.Click += new System.EventHandler(this.SoLuongCacUocSoNguyenTo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 662);
            this.Controls.Add(this.SoLuongCacUocSoNguyenTo);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSoLuongCacUocSoChan);
            this.Controls.Add(this.btnTongCacUocSo);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Combobox";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboSo;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.TextBox txtSo;
        private System.Windows.Forms.ListBox lstSo;
        private System.Windows.Forms.Button SoLuongCacUocSoNguyenTo;
        private System.Windows.Forms.Button btnSoLuongCacUocSoChan;
        private System.Windows.Forms.Button btnTongCacUocSo;
        private System.Windows.Forms.Button btnThoat;
    }
}

