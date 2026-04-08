using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = { 4, 6, 2, 10, 5 };
            int i, min = 0, max = 0;
            int sum = 0;
            double average = 0;
            for ( i = 0; i < a.Length; i++)
            {
                textBox1.Text += a[i] + " ";
                sum += a[i];
                if(i==0)
                {
                    max = a[i];
                    min= a[i];
                    continue;
                }
                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
               
            label1.Text = "The sum is :" + sum;

            average = (double)sum / a.Length;

            label2.Text = "The average is :" + average;
                       
            label3.Text = "The highest number is :" + max;
                      
            label4.Text = "The lowest number is :" + min;
        }
    }
}
