namespace Bai2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnTaoMang = new System.Windows.Forms.Button();
            this.lblKQ = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnInmang = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập số phần tử của mảng";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(251, 31);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(85, 30);
            this.txtNhap.TabIndex = 1;
            // 
            // btnTaoMang
            // 
            this.btnTaoMang.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnTaoMang.Location = new System.Drawing.Point(344, 31);
            this.btnTaoMang.Margin = new System.Windows.Forms.Padding(4);
            this.btnTaoMang.Name = "btnTaoMang";
            this.btnTaoMang.Size = new System.Drawing.Size(181, 33);
            this.btnTaoMang.TabIndex = 2;
            this.btnTaoMang.Text = "Tạo mảng Random";
            this.btnTaoMang.UseVisualStyleBackColor = true;
            this.btnTaoMang.Click += new System.EventHandler(this.btnTaoMang_Click);
            // 
            // lblKQ
            // 
            this.lblKQ.AutoSize = true;
            this.lblKQ.BackColor = System.Drawing.Color.NavajoWhite;
            this.lblKQ.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblKQ.Location = new System.Drawing.Point(13, 71);
            this.lblKQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKQ.Name = "lblKQ";
            this.lblKQ.Size = new System.Drawing.Size(0, 23);
            this.lblKQ.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnThoat.Location = new System.Drawing.Point(324, 129);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(181, 33);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnInmang
            // 
            this.btnInmang.Enabled = false;
            this.btnInmang.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnInmang.Location = new System.Drawing.Point(58, 129);
            this.btnInmang.Margin = new System.Windows.Forms.Padding(4);
            this.btnInmang.Name = "btnInmang";
            this.btnInmang.Size = new System.Drawing.Size(181, 33);
            this.btnInmang.TabIndex = 5;
            this.btnInmang.Text = "In Mảng";
            this.btnInmang.UseVisualStyleBackColor = true;
            this.btnInmang.Click += new System.EventHandler(this.btnInmang_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 186);
            this.Controls.Add(this.btnInmang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.lblKQ);
            this.Controls.Add(this.btnTaoMang);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnTaoMang;
        private System.Windows.Forms.Label lblKQ;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnInmang;
    }
}

