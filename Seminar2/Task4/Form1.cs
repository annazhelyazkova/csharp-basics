using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4Seminar2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, i = 1, count;

            n = int.Parse(textBox1.Text);

            count = 0;

            while (i <= n)
            {
                if (n % i == 0) count++;
                i++;

            }

            if (count == 2)
                
                label1.Text = "Yes";
            
            else
                
                label1.Text = "No";

        }
    }
}
