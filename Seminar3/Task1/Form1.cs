using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number, i;
            string result = "";

            if (!int.TryParse(textBox1.Text, out number))
            {
                label1.Text = "Please enter a valid integer!";
                return;
            }

            if (number < 1 || number > 100)
            {
                label1.Text = "Please enter a number between 1 and 100!";
                return;
            }

            for (i = 1; i <= 100; i++)
            {
                if (i % number == 0)
                {
                    result += i + " ";
                }
            }

            label1.Text = result;
        }
    }
}        
