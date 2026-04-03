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

        string chance ()
            {
            Random r = new Random();
            if (r.Next(0, 2) == 0) return "Heads";
            else return "Tails";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = chance();
        }
    }
}
