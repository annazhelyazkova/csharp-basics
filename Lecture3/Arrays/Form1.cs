using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arrays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Array declaration and creation

            //int[] grades = new int[10];
            //or ->
            //int[] numbers = {4, 5, 6, 10};

            //grades[0] = 1;
            //...
            //grades[9] = 10;

            // Multi-dimensional arrays

            //int[,] studentsGrades = new int[7, 5];
            //studentsGrades[0, 0] = 4;
            //...
            //studentsGrades[7, 5] = 6;

            //or ->
            //int[,] sGrades = { { 4, 5, 5, 6, 7}, { 5, 6, 7, 8, 9 } };

            textBox1.Text = string.Empty;
            int[] ints = { 2, 4, 6, 3 };
            
            // Sorting array
            Array.Sort(ints);

            // Reversing array
            Array.Reverse(ints);
            Array.Reverse(ints, 1, 2); // it will reverse 2 elements, starting from the element with position index 1 (second element)

            int a = ints.Rank; // shows the rank of the array, in the case 1

            //for (int i = 0; i < ints.Length; i++)
            //{
            //    textBox1.Text += ints[i].ToString() + " ";
            //}

            //or ->
            foreach (var i in ints)
            {
                textBox1.Text += i.ToString() + " ";
            }
        }
    }
}
