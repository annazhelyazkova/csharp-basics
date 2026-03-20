using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lecture2
{
    public partial class ForStatement : Form
    {
        public ForStatement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Task 1

            textBox1.Text = string.Empty;

            for (int i = 0; i < 10; i++)
            {
                textBox1.Text += i.ToString() + " ";
            }
        }
    }
}
