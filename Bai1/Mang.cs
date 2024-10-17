﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Mang : Form
    {
        public Mang()
        {
            InitializeComponent();
        }
        int[] arr = new int[10];
        int count = 0;

        public Boolean isEmpty(int count)
        {
            if(count == 0)
                return true;
            return false;
        }

        public String display(int[] arr)
        {
            string res = "";
            for(int i = 0; i < count; i++)
                res += arr[i] + " ";
            return res;
        }
        public int [] SXTang()
        {
            int[] arrB = new int[count];
            Array.Copy(arr, arrB, count);
            Array.Sort(arrB); 
            return arrB;
        }
        public int [] SXGiam()
        {
            int[] arrG = new int[count];
            Array.Copy (arr, arrG, count);

            Array.Sort (arrG);
            Array.Reverse (arrG);

            return arrG;
        }
        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
                sum += arr[i];
            return sum;
        }
        public Boolean timUC(int n)
        {
            int tong = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                if (n % i == 0)
                    tong += i;
            }
            return tong == n;
        }
        public String SHH()
        {
            String chuoi = " ";
            for (int i = 0; i < count; i++)
                if (timUC(arr[i]))
                    chuoi += arr[i] + " ";
            return chuoi;
        }
        public int DemSHH()
        {
            int dem = 0;
            for (int i = 0; i < count; i++)
            {
                if (timUC(arr[i]))
                    dem++;
            }
            return dem;
        }
        public Boolean KTSNT(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= n / 2; i++)
                if (arr[i] % i == 0)
                    return false;
            return true;
        }
        public String SNT()
        {
            String chuoi = " ";
            for (int i = 0; i < count; i++)
                if (KTSNT(arr[i]))
                    chuoi += arr[i] + " ";
            return chuoi;
        }
        public int DemSNT()
        {
            int dem = 0;
            for (int i = 0; i < count; i++)
            {
                if (KTSNT(arr[i]))
                    dem++;
            }
            return dem;
        }
        public int timMax()
        {
            int max = arr[0];
            for (int i = 0; i < count; i++)
                if (arr[i] > max)
                    max = arr[i];
            return max;
        }

        public int timMin()
        {
            int min = arr[0];
            for (int i = 0; i < count; i++)
                if (arr[i] < min)
                    min = arr[i];
            return min;
        }
        public String DemSL()
        {
            String chuoi = " ";
            for (int i = 0; i < count; i++)
                if (arr[i] % 2 != 0)
                    chuoi += arr[i] + " ";
            return chuoi;
        }
        public String DemSC()
        {
            String chuoi = " ";
            for (int i = 0; i < count; i++)
                if (arr[i] % 2 == 0) chuoi += arr[i] + " ";
            return chuoi;
        }
        public double TBM()
        {
            double res = 0.0;
            for (int i = 0; i < count; i++)
                res += arr[i];
            return res / count * 1.0;
        }
        public int timUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (a > b)
                a -= b;
            else
                b -= a;
            return a;
        }
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if(this.count == 10)
            {
                MessageBox.Show("Mảng đầy", "Thông báo");
                txtNhap.Focus();
            }
            else
            {
                if(string.IsNullOrEmpty(txtNhap.Text))
                    MessageBox.Show("Hãy nhập phần tử!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    try
                    {
                        arr[count] = int.Parse(txtNhap.Text);
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Vui lòng nhập số nguyên!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtNhap.Text = " ";
                        return;
                    }
                    count++;
                    lbKQ.Text += txtNhap.Text + " ";
                    txtNhap.Clear();
                    txtNhap.Focus();
                    if (count < 0)
                        btnIn.Enabled = false;
                }
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (isEmpty(count))
                lbKQ.Text = "Mảng rỗng";
            else
            {
                lbKQ.Text = $"Mảng hiện tại \n {display(arr)}";
                txtNhap.Clear();
                txtNhap.Focus();
            }
        }
        private void btnSXTang_Click(object sender, EventArgs e)
        {
            if (!isEmpty(count))
            {
                int[] arrT = SXTang();
                lbKQ.Text = $"Mảng sau khi sắp xếp tăng dần\n {display(arrT)}";
            }

        }
        private void btnSXGiam_Click(object sender, EventArgs e)
        {
            if (!isEmpty(count))
            {
                int[] arrG = SXGiam();
                lbKQ.Text = $"Mảng sau khi sắp xếp giảm dần\n {display(arrG)}";
            }
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            if(isEmpty(count)) lbKQ.Text = "Mảng rỗng";
            else lbKQ.Text = $"Tổng mảng: {Sum()}";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (isEmpty(count)) lbKQ.Text = "Mảng rỗng";
            else lbKQ.Text = $"Số lớn nhất trong mảng: {timMax()}";
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (isEmpty(count)) lbKQ.Text = "Mảng rỗng";
            else lbKQ.Text = $"Số nhỏ nhất trong mảng: {timMin()}";
        }

        private void btnTBM_Click(object sender, EventArgs e)
        {
            if (isEmpty(count)) lbKQ.Text = "Mảng rỗng";
            else
                lbKQ.Text = $"Trung bình mảng: {TBM().ToString()}";
        }

        private void btnSNT_Click(object sender, EventArgs e)
        {
            if (isEmpty(count)) lbKQ.Text = "Mảng rỗng";
            else
            {
                if (string.IsNullOrEmpty(SNT()))
                    lbKQ.Text = "Mảng không có số nguyên tố";
                else
                    lbKQ.Text = $"Mảng có {DemSNT().ToString()} số nguyên tố là: {SNT()}";
            }
        }
        private void btnSHH_Click(object sender, EventArgs e)
        {
            if (isEmpty(count)) lbKQ.Text = "Mảng rỗng";
            else
            {
                if (string.IsNullOrEmpty(SHH()))
                    lbKQ.Text = "Mảng không có số hoàn hảo";
                else
                    lbKQ.Text = $"Mảng có {DemSHH().ToString()} số hoàn hảo là: {SHH()}";
            }
                
        }
        private void btnSL_Click(object sender, EventArgs e)
        {
            if (isEmpty(count)) lbKQ.Text = "Mảng rỗng";
            else
            {
                if (!string.IsNullOrEmpty(DemSC()))
                    lbKQ.Text = $"Các số lẻ trong mảng là: {DemSL()}";
                else
                    lbKQ.Text = "Không tồn tại số lẻ trong mảng";
            }
        }
        private void btnSC_Click(object sender, EventArgs e)
        {
            if (isEmpty(count)) lbKQ.Text = "Mảng rỗng";
            else
            {
                if (!string.IsNullOrEmpty(DemSC()))
                    lbKQ.Text = $"Các số chẵn trong mảng là: {DemSC()}";
                else
                    lbKQ.Text = "Không tồn tại số chẵn trong mảng";
            }
                
        }

        private void btnUCLN_Click(object sender, EventArgs e)
        {
            if (isEmpty(count)) lbKQ.Text = "Mảng rỗng";
            else
                lbKQ.Text = $"Ước chung lớn nhất của 2 phần tử đầu {arr[0]} và {arr[1]} là: {timUCLN(arr[0], arr[1]).ToString()}";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa mảng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            lbKQ.Text = " ";
            Array.Clear(arr, 0, count);
            count = 0;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đóng chương trình không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK) 
                Application.Exit();
        }
    }
}
