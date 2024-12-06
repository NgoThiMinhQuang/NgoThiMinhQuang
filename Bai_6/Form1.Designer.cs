namespace Bai_6
{
    partial class FrmBai1_6
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
            this.rtbVanBan = new System.Windows.Forms.RichTextBox();
            this.radArial = new System.Windows.Forms.RadioButton();
            this.radTahoma = new System.Windows.Forms.RadioButton();
            this.radCourierNew = new System.Windows.Forms.RadioButton();
            this.btnThoat = new System.Windows.Forms.Button();
            this.radTimesNewRoman = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập văn bản:";
            // 
            // rtbVanBan
            // 
            this.rtbVanBan.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbVanBan.Location = new System.Drawing.Point(49, 88);
            this.rtbVanBan.Name = "rtbVanBan";
            this.rtbVanBan.Size = new System.Drawing.Size(261, 272);
            this.rtbVanBan.TabIndex = 1;
            this.rtbVanBan.Text = "";
            // 
            // radArial
            // 
            this.radArial.AutoSize = true;
            this.radArial.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radArial.Location = new System.Drawing.Point(342, 165);
            this.radArial.Name = "radArial";
            this.radArial.Size = new System.Drawing.Size(120, 46);
            this.radArial.TabIndex = 2;
            this.radArial.TabStop = true;
            this.radArial.Text = "Arial";
            this.radArial.UseVisualStyleBackColor = true;
            this.radArial.CheckedChanged += new System.EventHandler(this.radArial_CheckedChanged);
            // 
            // radTahoma
            // 
            this.radTahoma.AutoSize = true;
            this.radTahoma.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTahoma.Location = new System.Drawing.Point(342, 211);
            this.radTahoma.Name = "radTahoma";
            this.radTahoma.Size = new System.Drawing.Size(167, 46);
            this.radTahoma.TabIndex = 2;
            this.radTahoma.TabStop = true;
            this.radTahoma.Text = "Tahoma";
            this.radTahoma.UseVisualStyleBackColor = true;
            this.radTahoma.CheckedChanged += new System.EventHandler(this.radTahoma_CheckedChanged);
            // 
            // radCourierNew
            // 
            this.radCourierNew.AutoSize = true;
            this.radCourierNew.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCourierNew.Location = new System.Drawing.Point(342, 257);
            this.radCourierNew.Name = "radCourierNew";
            this.radCourierNew.Size = new System.Drawing.Size(239, 46);
            this.radCourierNew.TabIndex = 2;
            this.radCourierNew.TabStop = true;
            this.radCourierNew.Text = "Courier New";
            this.radCourierNew.UseVisualStyleBackColor = true;
            this.radCourierNew.CheckedChanged += new System.EventHandler(this.radCourierNew_CheckedChanged);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Location = new System.Drawing.Point(230, 380);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 50);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // radTimesNewRoman
            // 
            this.radTimesNewRoman.AutoSize = true;
            this.radTimesNewRoman.Font = new System.Drawing.Font("Times New Roman", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTimesNewRoman.Location = new System.Drawing.Point(342, 113);
            this.radTimesNewRoman.Name = "radTimesNewRoman";
            this.radTimesNewRoman.Size = new System.Drawing.Size(334, 46);
            this.radTimesNewRoman.TabIndex = 2;
            this.radTimesNewRoman.TabStop = true;
            this.radTimesNewRoman.Text = "Times New Roman";
            this.radTimesNewRoman.UseVisualStyleBackColor = true;
            this.radTimesNewRoman.CheckedChanged += new System.EventHandler(this.radTimesNewRoman_CheckedChanged);
            // 
            // FrmBai1_6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 534);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.radCourierNew);
            this.Controls.Add(this.radTahoma);
            this.Controls.Add(this.radTimesNewRoman);
            this.Controls.Add(this.radArial);
            this.Controls.Add(this.rtbVanBan);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmBai1_6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFont";
            this.Load += new System.EventHandler(this.FrmBai1_6_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbVanBan;
        private System.Windows.Forms.RadioButton radArial;
        private System.Windows.Forms.RadioButton radTahoma;
        private System.Windows.Forms.RadioButton radCourierNew;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.RadioButton radTimesNewRoman;
    }
}

