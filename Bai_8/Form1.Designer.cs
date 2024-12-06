namespace Bai_8
{
    partial class FrmBai1_8
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNhapA = new System.Windows.Forms.Label();
            this.lblNhapB = new System.Windows.Forms.Label();
            this.txtNhapA = new System.Windows.Forms.TextBox();
            this.txtNhapB = new System.Windows.Forms.TextBox();
            this.lblNghiem = new System.Windows.Forms.Label();
            this.txtNghiem = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1107, 90);
            this.label1.TabIndex = 0;
            this.label1.Text = "GIẢI PHƯƠNG TRÌNH BẬC NHẤT AX + B = 0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.UseMnemonic = false;
            // 
            // lblNhapA
            // 
            this.lblNhapA.AutoSize = true;
            this.lblNhapA.Location = new System.Drawing.Point(245, 102);
            this.lblNhapA.Name = "lblNhapA";
            this.lblNhapA.Size = new System.Drawing.Size(111, 36);
            this.lblNhapA.TabIndex = 1;
            this.lblNhapA.Text = "Nhập A";
            // 
            // lblNhapB
            // 
            this.lblNhapB.AutoSize = true;
            this.lblNhapB.Location = new System.Drawing.Point(245, 157);
            this.lblNhapB.Name = "lblNhapB";
            this.lblNhapB.Size = new System.Drawing.Size(112, 36);
            this.lblNhapB.TabIndex = 1;
            this.lblNhapB.Text = "Nhập B";
            // 
            // txtNhapA
            // 
            this.txtNhapA.Location = new System.Drawing.Point(363, 99);
            this.txtNhapA.Name = "txtNhapA";
            this.txtNhapA.Size = new System.Drawing.Size(524, 44);
            this.txtNhapA.TabIndex = 2;
            this.txtNhapA.TextChanged += new System.EventHandler(this.txtNhapA_TextChanged);
            // 
            // txtNhapB
            // 
            this.txtNhapB.Location = new System.Drawing.Point(363, 146);
            this.txtNhapB.Name = "txtNhapB";
            this.txtNhapB.Size = new System.Drawing.Size(524, 44);
            this.txtNhapB.TabIndex = 3;
            this.txtNhapB.TextChanged += new System.EventHandler(this.txtNhapB_TextChanged);
            // 
            // lblNghiem
            // 
            this.lblNghiem.AutoSize = true;
            this.lblNghiem.Location = new System.Drawing.Point(168, 204);
            this.lblNghiem.Name = "lblNghiem";
            this.lblNghiem.Size = new System.Drawing.Size(284, 36);
            this.lblNghiem.TabIndex = 4;
            this.lblNghiem.Text = "Nghiệm phương trình";
            // 
            // txtNghiem
            // 
            this.txtNghiem.Location = new System.Drawing.Point(363, 196);
            this.txtNghiem.Name = "txtNghiem";
            this.txtNghiem.Size = new System.Drawing.Size(524, 44);
            this.txtNghiem.TabIndex = 5;
            // 
            // btnGiai
            // 
            this.btnGiai.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnGiai.Location = new System.Drawing.Point(229, 285);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(118, 47);
            this.btnGiai.TabIndex = 6;
            this.btnGiai.Text = "&Giải";
            this.btnGiai.UseVisualStyleBackColor = false;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnXoa.Location = new System.Drawing.Point(502, 285);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(126, 47);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThoat.Location = new System.Drawing.Point(778, 285);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 47);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "&Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmBai1_8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 372);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.txtNghiem);
            this.Controls.Add(this.lblNghiem);
            this.Controls.Add(this.txtNhapB);
            this.Controls.Add(this.txtNhapA);
            this.Controls.Add(this.lblNhapB);
            this.Controls.Add(this.lblNhapA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmBai1_8";
            this.Text = "Giải phương trình bậc nhất";
            this.Load += new System.EventHandler(this.FrmBai1_8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNhapA;
        private System.Windows.Forms.Label lblNhapB;
        private System.Windows.Forms.TextBox txtNhapA;
        private System.Windows.Forms.TextBox txtNhapB;
        private System.Windows.Forms.Label lblNghiem;
        private System.Windows.Forms.TextBox txtNghiem;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

