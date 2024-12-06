namespace Bai2_3
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
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstLopA = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstLopB = new System.Windows.Forms.ListBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnKetThuc = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDanhSach.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDanhSach.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDanhSach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblDanhSach.Location = new System.Drawing.Point(0, 0);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(1077, 86);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "DANH SÁCH SINH VIÊN";
            this.lblDanhSach.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(232, 99);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(392, 44);
            this.txtHoVaTen.TabIndex = 2;
            this.txtHoVaTen.TextChanged += new System.EventHandler(this.txtHoVaTen_TextChanged);
            this.txtHoVaTen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtHoVaTen_KeyDown);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCapNhat.Location = new System.Drawing.Point(739, 94);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(250, 53);
            this.btnCapNhat.TabIndex = 3;
            this.btnCapNhat.Text = "&Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstLopA);
            this.groupBox1.Location = new System.Drawing.Point(86, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 422);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lớp A";
            // 
            // lstLopA
            // 
            this.lstLopA.FormattingEnabled = true;
            this.lstLopA.ItemHeight = 36;
            this.lstLopA.Location = new System.Drawing.Point(20, 59);
            this.lstLopA.Name = "lstLopA";
            this.lstLopA.Size = new System.Drawing.Size(299, 328);
            this.lstLopA.TabIndex = 0;
            this.lstLopA.SelectedIndexChanged += new System.EventHandler(this.lstLopA_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstLopB);
            this.groupBox2.Location = new System.Drawing.Point(691, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(349, 400);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp B";
            // 
            // lstLopB
            // 
            this.lstLopB.FormattingEnabled = true;
            this.lstLopB.ItemHeight = 36;
            this.lstLopB.Location = new System.Drawing.Point(18, 43);
            this.lstLopB.Name = "lstLopB";
            this.lstLopB.Size = new System.Drawing.Size(311, 328);
            this.lstLopB.TabIndex = 0;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn1.Location = new System.Drawing.Point(488, 224);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(162, 65);
            this.btn1.TabIndex = 6;
            this.btn1.Text = ">";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnXoa.Location = new System.Drawing.Point(122, 607);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(261, 58);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnKetThuc
            // 
            this.btnKetThuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnKetThuc.Location = new System.Drawing.Point(739, 607);
            this.btnKetThuc.Name = "btnKetThuc";
            this.btnKetThuc.Size = new System.Drawing.Size(219, 58);
            this.btnKetThuc.TabIndex = 8;
            this.btnKetThuc.Text = "&Kết thúc";
            this.btnKetThuc.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn3.Location = new System.Drawing.Point(488, 400);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(162, 59);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "<";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn4.Location = new System.Drawing.Point(488, 493);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(162, 59);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "<<";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn2.Location = new System.Drawing.Point(488, 318);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(162, 59);
            this.btn2.TabIndex = 9;
            this.btn2.Text = ">>";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 723);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btnKetThuc);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.txtHoVaTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblDanhSach);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmListSV";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnKetThuc;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.ListBox lstLopB;
    }
}

