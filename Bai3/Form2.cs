using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form2 : Form
    {
        private int[] arrB;
        public Form2(int[]arr)
        {
            InitializeComponent();
            arrB = new int[arr.Length];
            Array.Copy(arr, arrB, arr.Length);
        }
        public int tinhTong(int[] arrB)
        {
            int sum = 0;
            for (int i = 0; i < arrB.Length; i++)
                sum += arrB[i];
            return sum;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lbTong.Text += $"{tinhTong(arrB).ToString()}";
        }
    }
}
