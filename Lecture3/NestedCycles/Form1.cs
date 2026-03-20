using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedCycles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, j;
            textBox1.Text = string.Empty;

            for (i = 1; i <= 7; i++)
            {
                for (j = 1; j <= 5; j++)
                {
                    textBox1.Text += i.ToString() + " " + j.ToString() + " ";
                }
            }
        }
    }
}
