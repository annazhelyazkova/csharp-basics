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

        void increace(ref int a)
        {
            a = 5000;
            textBox1.Text = a.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int salary = 3000;
            increace(ref salary);
            textBox1.Text = salary.ToString();
        }
    }
}
