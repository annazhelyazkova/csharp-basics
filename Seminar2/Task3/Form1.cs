using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3Seminar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, i = 1;
            a = int.Parse(textBox1.Text);
            label1.Text = "The exact divisors are: ";

            while (i <= a)
            {
                if (a % i == 0) label1.Text = label1.Text + " " + i.ToString();
                i++;
            }



            /*
             int n = int.Parse(textBoxNumber.Text);
             int i = 1;
             string result = "";

            while (i <= n)
            {
                if (n % i == 0)
                {
                    result += i + ", ";
                }

                i++;
            }

            labelResult.Text = result.TrimEnd(',', ' ');*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
