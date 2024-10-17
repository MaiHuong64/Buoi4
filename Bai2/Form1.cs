﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        int[] arr;
        int n;
        public Form1()
        {
            InitializeComponent();
        }

        public void TaoMang()
        {
            arr = new int[n];
            int num;
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                num = random.Next(-10, 100);
                arr[i] = num;
            }
        }
        public String InMang()
        {
            String chuoi = " ";
            for (int i = 0; i < arr.Length; i++)
                chuoi+= arr[i]+" ";
            return chuoi;
        }
        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == " ")
            {
                MessageBox.Show("Hãy nhập số phần tử mảng", "Thông báo");
                txtNhap.Focus();
            }
            else
            {
                n = Convert.ToInt32(txtNhap.Text);
                if(n < 0)
                {
                    MessageBox.Show($"Bạn vừa nhập n = {n}. Số phần tử mảng phải > 0.", "Thông báo");
                    txtNhap.Focus();
                }
                else
                {
                    TaoMang();
                    lblKQ.Text = "Mảng với các phần tử phát sinh ngẫu nhiên vừa tạo xong";
                    btnInmang.Enabled = true;
                }
            }
                
        }

        private void btnInmang_Click(object sender, EventArgs e)
        {
            lblKQ.Text = $"Các phần tử của mảng: {InMang()}"; 
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
