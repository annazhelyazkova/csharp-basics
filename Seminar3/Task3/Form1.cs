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
            int n, i, counter, number;

            if (!int.TryParse(textBox1.Text, out number) || number < 2)
            {
                label1.Text = "Please enter a number greater than 1!";
                return;
            }

            label1.Text = "The prime numbers from 2 to " + number + " are:";

            for (n = 2; n <= number; n++)
            {
                counter = 0;

                for (i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        counter++;
                        break;
                    }
                }

                if (counter == 0)
                {
                    label1.Text += " " + n;
                }
            }
        }
    }
}