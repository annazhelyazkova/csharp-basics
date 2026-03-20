using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2Seminar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, i = 1, f = 1;
            a = int.Parse(textBox1.Text);

            while (i <= a)
            {
                f = f * i;
                i++;
            }
            label1.Text = "The factorial is: " + f.ToString();
        }
    }
}
