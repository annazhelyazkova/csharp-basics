using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int number, i, counter;
            number = int.Parse(textBox1.Text);
            counter = 0;

            if (!int.TryParse(textBox1.Text, out number))
            {
                label1.Text = "Please enter a valid integer!";
                return;
            }

            for (i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    counter++;
                }
            }

            if (counter == 2)
            {
                label1.Text = "Yes";
            }
            else
            {
                label1.Text = "No";
            }
        }
    }
}
