using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public delegate T Formula<T>(T txtBoxInput1, T txtBoxInput2);

    public partial class FrmCalculator : Form
    {
        CalculatorClass cal;
        double num1, num2;
        string arithmetic;
        class CalculatorClass
        {
            public Formula<double> info;

            public double GetSum(double txtBoxInput1, double txtBoxInput2)
            {
                return txtBoxInput1 + txtBoxInput2;
            }

            public double GetDifference(double txtBoxInput1, double txtBoxInput2)
            {
                return txtBoxInput1 - txtBoxInput2;
            }

            public double GetProduct(double txtBoxInput1, double txtBoxInput2)
            {
                return txtBoxInput1 * txtBoxInput2;
            }

            public double GetQuotient(double txtBoxInput1, double txtBoxInput2)
            {
                if (txtBoxInput1 == 0)
                {
                    throw new DivideByZeroException();
                }
                return txtBoxInput1 / txtBoxInput2;
            }

            public event Formula<double> CalculateEvent
            {
                add
                {
                    Console.WriteLine("Added the Delegate");
                }
                remove
                {
                    Console.WriteLine("Remove the Delegate");
                }
            }
        }
        public FrmCalculator()
        {
            InitializeComponent();
            cal = new CalculatorClass();
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtBoxInput1.Text);
            num2 = double.Parse(txtBoxInput2.Text);
            arithmetic = cbOperator.Text;

            switch (arithmetic)
            {
                case "+":
                    cal.CalculateEvent += new Formula<double>(cal.GetSum);
                    lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetSum);
                    break;

                case "-":
                    cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                    lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
                    break;

                case "*":
                    cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                    lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
                    break;

                case "/":
                    cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                    lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                    cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
                    break;

                default:
                    lblDisplayTotal.Text = "Error!";
                    break;
            }
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }
    }
}
