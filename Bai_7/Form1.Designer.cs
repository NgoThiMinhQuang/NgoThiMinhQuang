namespace Bai_7
{
    partial class frmBai1_7
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtYourName = new System.Windows.Forms.TextBox();
            this.txtYearOfBirth = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.errDuLieu = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errDuLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Year of birth";
            // 
            // txtYourName
            // 
            this.txtYourName.Location = new System.Drawing.Point(212, 57);
            this.txtYourName.Name = "txtYourName";
            this.txtYourName.Size = new System.Drawing.Size(543, 44);
            this.txtYourName.TabIndex = 1;
            this.txtYourName.TextChanged += new System.EventHandler(this.txtYourName_TextChanged);
            // 
            // txtYearOfBirth
            // 
            this.txtYearOfBirth.Location = new System.Drawing.Point(212, 112);
            this.txtYearOfBirth.Name = "txtYearOfBirth";
            this.txtYearOfBirth.Size = new System.Drawing.Size(543, 44);
            this.txtYearOfBirth.TabIndex = 3;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(93, 180);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(144, 42);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "&Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(351, 180);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(154, 42);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(609, 180);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(146, 42);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // errDuLieu
            // 
            this.errDuLieu.ContainerControl = this;
            // 
            // frmBai1_7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(18F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 300);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtYearOfBirth);
            this.Controls.Add(this.txtYourName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmBai1_7";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmBai1_7_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errDuLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYourName;
        private System.Windows.Forms.TextBox txtYearOfBirth;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ErrorProvider errDuLieu;
    }
}

