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
    public partial class DoWhileStatement : Form
    {
        public DoWhileStatement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int a = 4;
            int a = int.Parse(textBox2.Text); // if we enter 0 for input it will cycle to minus infinity
            textBox1.Text = "";

            do
            {
                textBox1.Text += a.ToString() + " ";
                a--;    
            } while (a != 0);
        }
    }
}
