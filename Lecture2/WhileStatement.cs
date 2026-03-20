using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2
{
    public partial class WhileStatement : Form
    {
        public WhileStatement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Task 1

            //int a = 1;
            //textBox1.Text = "";

            //while (a <= 10)
            //{
            //    textBox1.Text += a.ToString() + " ";
            //    a++;
            //}

            // Task 2
            //int a = 4;
            //textBox1.Text = "";

            //while (a != 0)
            //{
            //    textBox1.Text += a.ToString() + " ";
            //    a--;
            //}

            // Task 3

            //int a = int.Parse(textBox2.Text);
            //textBox1.Text = "";

            //while (a != 0)
            //{
            //    textBox1.Text += a.ToString() + " ";
            //    a--;
            //}


            // Task 4

            int a = 1, s = 0;

            while (a <= 10)
            {
                s += a;
                a++;
            }

            textBox1.Text = s.ToString();
        }
    }
}
