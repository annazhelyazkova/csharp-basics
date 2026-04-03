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

        private void button1_Click(object sender, EventArgs e)
        {
             textBox1.Text = "";

            int[] grades = new int[10];

            Random r = new Random();

            double sum = 0;

            for (int i = 0; i < 10; i++)
            {
                grades[i] = r.Next(2, 7);
                sum += grades[i];

            }

            for (int i = 0; i <= 10; i++)
            {
                textBox1.Text += grades[i].ToString() + " ";

                textBox2.Text = (sum / 10).ToString();
            }
        }
    }
}
