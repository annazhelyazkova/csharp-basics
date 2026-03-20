using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForStatement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a, b;
            textBox1.Text = string.Empty;

            for (a = 2, b = 3; a < 10; a+=3, b++)
            {
                textBox1.Text += a.ToString() + " " + b.ToString() + " ";
            }
        }
    }
}
