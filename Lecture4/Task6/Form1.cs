using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int factorial(int n)
        {
            int i, f = 1;
            for (i = 1; i <= n; i++) f *= i;
            return f;
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            int number, result;
            number = int.Parse(textBox6.Text);
            result = factorial(number);
            textBox7.Text = result.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
