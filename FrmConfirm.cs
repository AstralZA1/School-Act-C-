using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AccountRegistration.FrmRegistration;

namespace AccountRegistration
{
    public partial class FrmConfirm : Form
    {
        private static DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        
        public FrmConfirm()
        {
            InitializeComponent();

            DelProgram = new DelegateText(StudentInfoClass.GetProgram);
            DelLastName = new DelegateText(StudentInfoClass.GetLastName);
            DelFirstName = new DelegateText(StudentInfoClass.GetFirstName);
            DelMiddleName = new DelegateText(StudentInfoClass.GetMiddleName);
            DelAddress = new DelegateText(StudentInfoClass.GetAddress);
            DelNumAge = new DelegateNumber(StudentInfoClass.GetAge);
            DelNumContactNo = new DelegateNumber(StudentInfoClass.GetContactNo);
            DelStudNo = new DelegateNumber(StudentInfoClass.GetStudentNo);

            label9.Text = Convert.ToString(DelStudNo(StudentInfoClass.StudentNo));
            label10.Text = DelProgram(StudentInfoClass.Program);
            label11.Text = DelProgram(StudentInfoClass.LastName);
            label12.Text = DelProgram(StudentInfoClass.FirstName);
            label13.Text = DelProgram(StudentInfoClass.MiddleName);
            label14.Text = Convert.ToString(DelNumAge(StudentInfoClass.Age));
            label15.Text = Convert.ToString(DelNumContactNo(StudentInfoClass.ContactNo));
            label16.Text = DelProgram(StudentInfoClass.Address);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("SUBMITTED SUCCESSFULLY!");
            this.DialogResult = DialogResult.OK;
            this.Close();
            System.Windows.Forms.Application.Exit();
        }
    }
}
