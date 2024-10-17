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
    public partial class Form3 : Form
    {
        private int[] arrC;
        public Form3(int[]arr)
        {
            InitializeComponent();
            arrC = new int[arr.Length];
            Array.Copy(arr, arrC, arr.Length);
        }
        public int timMax()
        {
            int max = arrC[0];
            for (int i = 0;i< arrC.Length;i++) 
                if(arrC[i] > max)
                    max = arrC[i];
            return max;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            lbMax.Text +=$"{timMax().ToString()}";
        }
    }
}
