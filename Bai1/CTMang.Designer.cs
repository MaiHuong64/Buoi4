namespace Bai1
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
            this.btnNhap = new System.Windows.Forms.Button();
            this.lbKQ = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnSXGiam = new System.Windows.Forms.Button();
            this.btnSXTang = new System.Windows.Forms.Button();
            this.btnSum = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnSHH = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSNT = new System.Windows.Forms.Button();
            this.btnTBM = new System.Windows.Forms.Button();
            this.btnSL = new System.Windows.Forms.Button();
            this.btnSC = new System.Windows.Forms.Button();
            this.btnUCLN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNhap
            // 
            this.btnNhap.Location = new System.Drawing.Point(16, 16);
            this.btnNhap.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhap.Name = "btnNhap";
            this.btnNhap.Size = new System.Drawing.Size(176, 62);
            this.btnNhap.TabIndex = 0;
            this.btnNhap.Text = "Nhập 1 Phần Tử";
            this.btnNhap.UseVisualStyleBackColor = true;
            this.btnNhap.Click += new System.EventHandler(this.btnNhap_Click);
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.lbKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.ForeColor = System.Drawing.SystemColors.Control;
            this.lbKQ.Location = new System.Drawing.Point(13, 87);
            this.lbKQ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbKQ.MinimumSize = new System.Drawing.Size(685, 140);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(685, 140);
            this.lbKQ.TabIndex = 1;
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(201, 18);
            this.txtNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhap.Multiline = true;
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(198, 59);
            this.txtNhap.TabIndex = 2;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(408, 18);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(153, 60);
            this.btnIn.TabIndex = 3;
            this.btnIn.Text = "In Mảng";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(569, 18);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(132, 60);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(710, 18);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(190, 60);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSXGiam
            // 
            this.btnSXGiam.Location = new System.Drawing.Point(710, 87);
            this.btnSXGiam.Margin = new System.Windows.Forms.Padding(4);
            this.btnSXGiam.Name = "btnSXGiam";
            this.btnSXGiam.Size = new System.Drawing.Size(190, 66);
            this.btnSXGiam.TabIndex = 6;
            this.btnSXGiam.Text = "Sắp Xếp Giảm";
            this.btnSXGiam.UseVisualStyleBackColor = true;
            this.btnSXGiam.Click += new System.EventHandler(this.btnSXGiam_Click);
            // 
            // btnSXTang
            // 
            this.btnSXTang.Location = new System.Drawing.Point(710, 161);
            this.btnSXTang.Margin = new System.Windows.Forms.Padding(4);
            this.btnSXTang.Name = "btnSXTang";
            this.btnSXTang.Size = new System.Drawing.Size(190, 56);
            this.btnSXTang.TabIndex = 7;
            this.btnSXTang.Text = "Sắp Xếp Tăng";
            this.btnSXTang.UseVisualStyleBackColor = true;
            this.btnSXTang.Click += new System.EventHandler(this.btnSXTang_Click);
            // 
            // btnSum
            // 
            this.btnSum.Location = new System.Drawing.Point(710, 235);
            this.btnSum.Margin = new System.Windows.Forms.Padding(4);
            this.btnSum.Name = "btnSum";
            this.btnSum.Size = new System.Drawing.Size(190, 58);
            this.btnSum.TabIndex = 8;
            this.btnSum.Text = "Tổng Mảng";
            this.btnSum.UseVisualStyleBackColor = true;
            this.btnSum.Click += new System.EventHandler(this.btnSum_Click);
            // 
            // btnMax
            // 
            this.btnMax.Location = new System.Drawing.Point(710, 301);
            this.btnMax.Margin = new System.Windows.Forms.Padding(4);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(190, 60);
            this.btnMax.TabIndex = 9;
            this.btnMax.Text = "Số Lớn Nhất";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnSHH
            // 
            this.btnSHH.Location = new System.Drawing.Point(540, 235);
            this.btnSHH.Margin = new System.Windows.Forms.Padding(4);
            this.btnSHH.Name = "btnSHH";
            this.btnSHH.Size = new System.Drawing.Size(161, 58);
            this.btnSHH.TabIndex = 10;
            this.btnSHH.Text = "Số Hoàn Hảo";
            this.btnSHH.UseVisualStyleBackColor = true;
            this.btnSHH.Click += new System.EventHandler(this.btnSHH_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(540, 301);
            this.btnMin.Margin = new System.Windows.Forms.Padding(4);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(161, 60);
            this.btnMin.TabIndex = 11;
            this.btnMin.Text = "Số Nhỏ Nhất";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnSNT
            // 
            this.btnSNT.Location = new System.Drawing.Point(366, 235);
            this.btnSNT.Margin = new System.Windows.Forms.Padding(4);
            this.btnSNT.Name = "btnSNT";
            this.btnSNT.Size = new System.Drawing.Size(166, 58);
            this.btnSNT.TabIndex = 12;
            this.btnSNT.Text = "Số Nguyên Tố";
            this.btnSNT.UseVisualStyleBackColor = true;
            this.btnSNT.Click += new System.EventHandler(this.btnSNT_Click);
            // 
            // btnTBM
            // 
            this.btnTBM.Location = new System.Drawing.Point(366, 301);
            this.btnTBM.Margin = new System.Windows.Forms.Padding(4);
            this.btnTBM.Name = "btnTBM";
            this.btnTBM.Size = new System.Drawing.Size(166, 60);
            this.btnTBM.TabIndex = 13;
            this.btnTBM.Text = "Trung Bình Mảng";
            this.btnTBM.UseVisualStyleBackColor = true;
            this.btnTBM.Click += new System.EventHandler(this.btnTBM_Click);
            // 
            // btnSL
            // 
            this.btnSL.Location = new System.Drawing.Point(190, 235);
            this.btnSL.Margin = new System.Windows.Forms.Padding(4);
            this.btnSL.Name = "btnSL";
            this.btnSL.Size = new System.Drawing.Size(168, 58);
            this.btnSL.TabIndex = 14;
            this.btnSL.Text = "Đếm Số Lẻ";
            this.btnSL.UseVisualStyleBackColor = true;
            this.btnSL.Click += new System.EventHandler(this.btnSL_Click);
            // 
            // btnSC
            // 
            this.btnSC.Location = new System.Drawing.Point(14, 235);
            this.btnSC.Margin = new System.Windows.Forms.Padding(4);
            this.btnSC.Name = "btnSC";
            this.btnSC.Size = new System.Drawing.Size(168, 60);
            this.btnSC.TabIndex = 15;
            this.btnSC.Text = "Đếm Số Chẵn";
            this.btnSC.UseVisualStyleBackColor = true;
            this.btnSC.Click += new System.EventHandler(this.btnSC_Click);
            // 
            // btnUCLN
            // 
            this.btnUCLN.Location = new System.Drawing.Point(13, 301);
            this.btnUCLN.Margin = new System.Windows.Forms.Padding(4);
            this.btnUCLN.Name = "btnUCLN";
            this.btnUCLN.Size = new System.Drawing.Size(345, 60);
            this.btnUCLN.TabIndex = 16;
            this.btnUCLN.Text = "UCLN 2 Phần Tử Đầu Tiên";
            this.btnUCLN.UseVisualStyleBackColor = true;
            this.btnUCLN.Click += new System.EventHandler(this.btnUCLN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 364);
            this.Controls.Add(this.btnUCLN);
            this.Controls.Add(this.btnSC);
            this.Controls.Add(this.btnSL);
            this.Controls.Add(this.btnTBM);
            this.Controls.Add(this.btnSNT);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnSHH);
            this.Controls.Add(this.btnMax);
            this.Controls.Add(this.btnSum);
            this.Controls.Add(this.btnSXTang);
            this.Controls.Add(this.btnSXGiam);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.btnNhap);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mảng số nguyên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhap;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnSXGiam;
        private System.Windows.Forms.Button btnSXTang;
        private System.Windows.Forms.Button btnSum;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Button btnSHH;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnSNT;
        private System.Windows.Forms.Button btnTBM;
        private System.Windows.Forms.Button btnSL;
        private System.Windows.Forms.Button btnSC;
        private System.Windows.Forms.Button btnUCLN;
    }
}

