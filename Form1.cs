using Simple_calculator.Interface;
using Simple_calculator.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_calculator
{
    public partial class Form1 : Form
    {
        private readonly ICalculator _calculator;
        public Form1()
        {
            InitializeComponent();
            _calculator = new Calculator();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==null&&textBox2.Text==null)
            {
                MessageBox.Show("لطفا مقادیری وارد کنید");
            }
            else
            {
                int number1 = int.Parse(textBox1.Text);
                int number2 = int.Parse(textBox2.Text);
                string Result = Convert.ToString(_calculator.Sum(number1, number2));
                MessageBox.Show(Result);
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null && textBox2.Text == null)
            {
                MessageBox.Show("لطفا مقادیری وارد کنید");
            }
            else
            {
                int number1 = int.Parse(textBox1.Text);
                int number2 = int.Parse(textBox2.Text);
                string Result = Convert.ToString(_calculator.Minus(number1, number2));
                MessageBox.Show(Result);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null && textBox2.Text == null)
            {
                MessageBox.Show("لطفا مقادیری وارد کنید");
            }
            else
            {
                int number1 = int.Parse(textBox1.Text);
                int number2 = int.Parse(textBox2.Text);
                string Result = Convert.ToString(_calculator.Multiplication(number1, number2));
                MessageBox.Show(Result);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null && textBox2.Text == null)
            {
                MessageBox.Show("لطفا مقادیری وارد کنید");
            }
            else
            {
                int number1 = int.Parse(textBox1.Text);
                int number2 = int.Parse(textBox2.Text);
                string Result = Convert.ToString(_calculator.Division(number1, number2));
                MessageBox.Show(Result);
            }
        }
    }
}
