using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        int sumit(int a, int b)
        {
            int c;
            c = a + b;
            return c;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            int d;
            d = sumit(3, 7) * 6;
            textBox1.Text = d.ToString();
        }
    }
}
