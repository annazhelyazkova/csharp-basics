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

        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            int.TryParse(textBox1.Text, out n);
            switch (n)
            {
                case 12:
                case 1:
                case 2:
                    label1.Text = "Winter";
                    break;
                case 3:
                case 4:
                case 5:
                    label1.Text = "Spring";
                    break;
                case 6:
                case 7:
                case 8:
                    label1.Text = "Summer";
                    break;
                case 9:
                case 10:
                case 11:    
                    label1.Text = "Autumn";
                    break;
                default:
                    label1.Text = "Wrong input! Enter integer value from 1 to 12!";
                    break;
            }

        }
    }
}
