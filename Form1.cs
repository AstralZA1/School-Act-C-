using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentGradeApplication
{
    public partial class Form1 : Form
    {
        double num1;
        double num2;
        double num3;
        double num4;
        double num5;
        String name;
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
             num1 = double.Parse(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
             num2 = double.Parse(textBox3.Text);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
             num3 = double.Parse(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
             num4 = double.Parse(textBox5.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
             num5 = double.Parse(textBox6.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = num1 + num2 + num3 + num4 + num5;
            double average = sum / 5;
            if (average >= 75)
            {
                label8.Text = "The student passed.";
                label9.Text = "The general average of " + name + " is " + average.ToString("#,0.00")+".";
            }
            else
                label8.Text = "The student failed.";
                label9.Text = "The general average of " + name + " is " + average.ToString("#,0.00")+ ".";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            name = textBox1.Text;
        }
    }
}
