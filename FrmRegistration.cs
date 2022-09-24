using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AccountRegistration.FrmConfirm;

public delegate long DelegateNumber(long number);
public delegate string DelegateText(string txt);

namespace AccountRegistration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        public class StudentInfoClass
        {
            public static string FirstName = " ";
            public static string LastName = " ";
            public static string MiddleName = " ";
            public static string Address = " ";
            public static string Program = " ";
            public static long Age = 0;
            public static long ContactNo = 0;
            public static long StudentNo = 0;

            public static string GetFirstName(string FirstName)
            {
                return FirstName;
            }
            public static string GetLastName(string LastName)
            {
                return LastName;
            }
            public static string GetMiddleName(string MiddleName)
            {
                return MiddleName;
            }
            public static string GetAddress(string Address)
            {
                return Address;
            }
            public static string GetProgram(string Program)
            {
                return Program;
            }
            public static long GetAge(long Age)
            {
                return Age;
            }
            public static long GetContactNo(long ContactNo)
            {
                return ContactNo;
            }
            public static long GetStudentNo(long StudentNo)
            {
                return StudentNo;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = textBox3.Text.ToString();
            StudentInfoClass.LastName = textBox2.Text.ToString();
            StudentInfoClass.MiddleName = textBox4.Text.ToString();
            StudentInfoClass.Address = textBox7.Text.ToString();
            StudentInfoClass.Program = comboBox1.Text.ToString();
            StudentInfoClass.Age = Convert.ToInt32(textBox5.Text);
            StudentInfoClass.ContactNo = Convert.ToInt64(textBox6.Text);
            StudentInfoClass.StudentNo = Convert.ToInt32(textBox1.Text);

            FrmConfirm form2 = new FrmConfirm();
            form2.Show();
            this.Hide();
        }

    }
}
