using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = { 4, 6, 2, 10, 5 };
            int input, count = 0;
            input = int.Parse(textBox1.Text);
                       
            bool found = false;

            foreach (int i in a)
            {
                if (i == input)
                {
                    count++;
                    break;
                }
            
            }

            if (count > 0) label1.Text = "Yes";
            else label1.Text = "No";


        }
    }
}
