using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] a = new int[0];

        private void button1_Click(object sender, EventArgs e)
        {
            Array.Resize(ref a, a.Length + 1);

            a[a.Length - 1] = int.Parse(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Array.Sort(a);
            Array.Reverse(a);
            label1.Text = "Descending sort ";

            foreach (int i in a)
            {
                label1.Text += i + " ";
            }
            
        }
    }
}
