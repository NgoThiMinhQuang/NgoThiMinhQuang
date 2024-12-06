namespace Bai_4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCong = new System.Windows.Forms.RadioButton();
            this.radTru = new System.Windows.Forms.RadioButton();
            this.radNhan = new System.Windows.Forms.RadioButton();
            this.radChia = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số 2:";
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(151, 37);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(557, 44);
            this.txtSo1.TabIndex = 2;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(151, 87);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(557, 44);
            this.txtSo2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radChia);
            this.groupBox1.Controls.Add(this.radNhan);
            this.groupBox1.Controls.Add(this.radTru);
            this.groupBox1.Controls.Add(this.radCong);
            this.groupBox1.Location = new System.Drawing.Point(58, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 138);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phép tính";
            // 
            // radCong
            // 
            this.radCong.AutoSize = true;
            this.radCong.Location = new System.Drawing.Point(33, 66);
            this.radCong.Name = "radCong";
            this.radCong.Size = new System.Drawing.Size(113, 40);
            this.radCong.TabIndex = 0;
            this.radCong.TabStop = true;
            this.radCong.Text = "Cộng";
            this.radCong.UseVisualStyleBackColor = true;
            this.radCong.CheckedChanged += new System.EventHandler(this.radCong_CheckedChanged);
            // 
            // radTru
            // 
            this.radTru.AutoSize = true;
            this.radTru.Location = new System.Drawing.Point(189, 66);
            this.radTru.Name = "radTru";
            this.radTru.Size = new System.Drawing.Size(92, 40);
            this.radTru.TabIndex = 1;
            this.radTru.TabStop = true;
            this.radTru.Text = "Trừ";
            this.radTru.UseVisualStyleBackColor = true;
            this.radTru.CheckedChanged += new System.EventHandler(this.radTru_CheckedChanged);
            // 
            // radNhan
            // 
            this.radNhan.AutoSize = true;
            this.radNhan.Location = new System.Drawing.Point(345, 66);
            this.radNhan.Name = "radNhan";
            this.radNhan.Size = new System.Drawing.Size(113, 40);
            this.radNhan.TabIndex = 2;
            this.radNhan.TabStop = true;
            this.radNhan.Text = "Nhân";
            this.radNhan.UseVisualStyleBackColor = true;
            this.radNhan.CheckedChanged += new System.EventHandler(this.radNhan_CheckedChanged);
            // 
            // radChia
            // 
            this.radChia.AutoSize = true;
            this.radChia.Location = new System.Drawing.Point(511, 66);
            this.radChia.Name = "radChia";
            this.radChia.Size = new System.Drawing.Size(105, 40);
            this.radChia.TabIndex = 3;
            this.radChia.TabStop = true;
            this.radChia.Text = "Chia";
            this.radChia.UseVisualStyleBackColor = true;
            this.radChia.CheckedChanged += new System.EventHandler(this.radChia_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 36);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kết quả:";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(196, 298);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(512, 44);
            this.txtKetQua.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 382);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Phép tính";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radChia;
        private System.Windows.Forms.RadioButton radNhan;
        private System.Windows.Forms.RadioButton radTru;
        private System.Windows.Forms.RadioButton radCong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}

