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

        private void button1_Click(object sender, EventArgs e)
        {
            int n;

            int.TryParse(textBox1.Text, out n);

            switch (n) {
                case 1: // January
                case 3: // March
                case 5: // May
                case 7: // July
                case 8: // August
                case 10: // October
                case 12: //December
                    label1.Text = "31 days";
                    break;
                case 4: // April
                case 6: // June
                case 9: // September
                case 11: // November
                    label1.Text = "30 days";
                    break;
                case 2: /// February
                    label1.Text = "28 days";
                    break;
                default: //Invalid month number
                    label1.Text = "Invalid input, please enetr numbers between 1 and 12!";
                    break;
            }
        }
    }
}
