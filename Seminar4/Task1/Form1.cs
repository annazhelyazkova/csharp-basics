using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = {4, 6, 2, 10, 5};
            int sum = 0;

            /*
            for (int i = 0; i < a.Length; i++)
            {
                textBox1.Text += a[i] + " ";
                sum += a[i];
            }
            */

            foreach (int i in a)
            {
                textBox1.Text += i + " ";
                sum += i;
            }
            
            label1.Text = "Sum: " + sum;
        }
    }
}
