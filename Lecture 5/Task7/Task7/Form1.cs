using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            int factorial (int n)
            {
                int i, f = 1;
                for (i = 0; i <= n; i++) f *= i;
                return f;
            }

            int number, result;
            number = int.Parse(textBox1.Text);
            result = factorial(number);
            label1.Text = result.ToString();
            */

            int factorial(int n)
            {
                if (n == 0) return 1;
                else return n*factorial(n-1);
            }

            int number, result;
            number = int.Parse(textBox1.Text);
            result = factorial(number);
            label1.Text = result.ToString();
            
        }
    }
}
