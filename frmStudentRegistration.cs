using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class frmStudentRegistration : Form
    {
        public frmStudentRegistration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 1; i <= 31; i++)
            {
                Day_combobx.Items.Add(i.ToString());
            }

            for(int i = 1; i <= 12; i++)
            {
                Month_combobx.Items.Add(i.ToString());
            }

           for(int i = 1900; i <= 2022; i++)
            {
                Year_combobx.Items.Add(i.ToString());
            }
        }


        private void Day_combobx_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Reg_button_Click(object sender, EventArgs e)
        {
            String FirstName = FirstName_txtbox.Text.ToString();
            String LastName = LastName_txtbox.Text.ToString();
            String MiddleName = MiddleName_txtbox.Text.ToString();
            String BirthDay = Day_combobx.Text.ToString();
            String BirthMonth = Month_combobx.Text.ToString();
            String BirthYear = Year_combobx.Text.ToString();

            if (male_radiobtn.Checked)
            {
                MessageBox.Show("Student Name: " + FirstName + " " + MiddleName + " " + LastName +
                    "\nGender: Male" +
                    "\nDate of Birth: " + BirthDay + "/" + BirthMonth + "/" + BirthYear);
            }
            else if(female_radiobtn.Checked)
            {
                MessageBox.Show("Student Name: " + FirstName + " " + MiddleName + " " + LastName +
                   "\nGender: Female" +
                   "\nDate of Birth: " + BirthDay + "/" + BirthMonth + "/" + BirthYear);
            }
            
        }

        private void male_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void female_radiobtn_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
