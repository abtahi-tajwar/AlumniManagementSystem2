using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSFinalProject_University_
{
    public partial class RegistrationPageOne : Form
    {
       // bool place = true;
        private string fname, lname, sid, age, pyear, present_address, permanent_address, father, mother, work;

        public RegistrationPageOne(string fname, string lname, string sid, string age, string pyear, string present_address, string permanent_address, string father, string mother, string work)
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            firstName.Text = fname;
            lastName.Text = lname;
            StudentID.Text = sid;
            Age.Text = age;
            PassingYear.Text = pyear;
            PresentAddress.Text = present_address;
            PermanentAddress.Text = permanent_address;
            FatherName.Text = father;
            MotherName.Text = mother;
            Work.Text = work;
        }

        private void Age_Click(object sender, EventArgs e)
        {
            if (Age.Text.Equals("Age")) {
                Age.Clear();
            }
            
        }
        private void Age_Leave(object sender, EventArgs e)
        {
            if (Age.Text == "")
            {
                Age.Text = "Age";
               //lace = true;
            }

        }
        private void firstName_Click(object sender, EventArgs e)
        {
            if (firstName.Text.Equals("FirstName"))
            {
                firstName.Clear();
            }
            
        }
        
        private void firstName_Leave(object sender, EventArgs e)
        {
            if (firstName.Text == "")
            {
               firstName.Text= "FirstName";
               // firstName.Text = null;
                
               //lace = true;
            }

        }

       
        private void lastName_Click(object sender, EventArgs e)
        {
            if (lastName.Text.Equals("Last Name"))
            {
                lastName.Clear();
            }
            
        }

        private void lastName_Leave(object sender, EventArgs e)
        {
            if (lastName.Text == "")
            {                
                lastName.Text = "Last Name";
                
            }
        }

       
        private void StudentID_Click(object sender, EventArgs e)
        {
            if (StudentID.Text.Equals("Student ID"))
            {
                StudentID.Clear();
            }
        }

        private void StudentID_Leave(object sender, EventArgs e)
        {
            if (StudentID.Text == "")
            {
                StudentID.Text = "Student ID";
                
            }
        }

       
        private void PassingYear_Click(object sender, EventArgs e)
        {
            if (PassingYear.Text.Equals("Passing Year"))
            {
                PassingYear.Clear();
            }
        }
        private void PassingYear_Leave(object sender, EventArgs e)
        {
            if (PassingYear.Text == "")
            {
                PassingYear.Text = "Passing Year";
                
            }
        }

        
        private void PresentAddress_Click(object sender, EventArgs e)
        {
            if (PresentAddress.Text.Equals("Present Address"))
            {
                PresentAddress.Clear();
            }
        }

        private void PresentAddress_Leave(object sender, EventArgs e)
        {
            if (PresentAddress.Text == "")
            {
                PresentAddress.Text = "Present Address";
                
            }
        }

        
        private void PermanentAddress_Click(object sender, EventArgs e)
        {
            if (PermanentAddress.Text.Equals("Permanent Address"))
            {
                PermanentAddress.Clear();
            }
        }
        private void PermanentAddress_Leave(object sender, EventArgs e)
        {
            if (PermanentAddress.Text == "")
            {
                PermanentAddress.Text = "Permanent Address";
                
            }
        }

       
        private void FatherName_Click(object sender, EventArgs e)
        {
            if (FatherName.Text.Equals("Father's Name"))
            {
                FatherName.Clear();
            }
        }

        private void FatherName_Leave(object sender, EventArgs e)
        {
            if (FatherName.Text == "")
            {
                FatherName.Text = "Father's Name";
                
            }
        }

       
        private void MotherName_Click(object sender, EventArgs e)
        {
            if (MotherName.Text.Equals("Mother's Name"))
            {
                MotherName.Clear();
            }
        }

        private void MotherName_Leave(object sender, EventArgs e)
        {
            if (MotherName.Text == "")
            {
                MotherName.Text = "Mother's Name";
                
            }
        }

        private void Work_Click(object sender, EventArgs e)
        {
            if (Work.Text.Equals("Add Work"))
            {
                Work.Clear();
            }
        }

        private void firstName_Enter(object sender, EventArgs e)
        {
            if (firstName.Text.Equals("First Name"))
            {
                firstName.Clear();
            }
        }

        private void lastName_Enter(object sender, EventArgs e)
        {
            if (lastName.Text.Equals("Last Name"))
            {
                lastName.Clear();
            }
        }

        private void StudentID_Enter(object sender, EventArgs e)
        {
            if (StudentID.Text.Equals("Student ID"))
            {
                StudentID.Clear();
            }
        }

        private void Age_Enter(object sender, EventArgs e)
        {
            if (Age.Text.Equals("Age"))
            {
                Age.Clear();
            }
        }

        private void PassingYear_Enter(object sender, EventArgs e)
        {
            if (PassingYear.Text.Equals("Passing Year"))
            {
                PassingYear.Clear();
            }
        }

        private void PresentAddress_Enter(object sender, EventArgs e)
        {
            if (PresentAddress.Text.Equals("Present Address"))
            {
                PresentAddress.Clear();
            }
        }

        private void PermanentAddress_Enter(object sender, EventArgs e)
        {
            if (PermanentAddress.Text.Equals("Permanent Address"))
            {
                PermanentAddress.Clear();
            }
        }

        private void FatherName_Enter(object sender, EventArgs e)
        {
            if (FatherName.Text.Equals("Father's Name"))
            {
                FatherName.Clear();
            }
        }

        private void MotherName_Enter(object sender, EventArgs e)
        {
            if (MotherName.Text.Equals("Mother's Name"))
            {
                MotherName.Clear();
            }
        }

        private void Work_Enter(object sender, EventArgs e)
        {
            if (Work.Text.Equals("Add Work"))
            {
                Work.Clear();
            }
        }

        private void Work_Leave(object sender, EventArgs e)
        {
            if (Work.Text == "")
            {
                Work.Text = "Add Work";
               
            }
        }











        private void StudentID_Validating(object sender, CancelEventArgs e)
        {
            { var text = (sender as TextBox).Text;
                if (String.IsNullOrEmpty(text))
                {
                    e.Cancel = true;
                    StudentID.Focus();
                    errorProvider3.SetError(StudentID, $"Give Your ID!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider3.SetError(StudentID, "");
                }
            }

        }

        private void lastName_Validating(object sender, CancelEventArgs e)
        {
            var text = (sender as TextBox).Text;
            if (String.IsNullOrEmpty(text))
            {
                e.Cancel = true;
                lastName.Focus();
                errorProvider2.SetError(lastName, $"Give Last Name!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(lastName, "");
            }
        }

     
        
        private void firstName_Validating(object sender, CancelEventArgs e)
        {

            var text = (sender as TextBox).Text;
            if (String.IsNullOrEmpty(text))
            {
                e.Cancel = true;
                firstName.Focus();
                errorProvider1.SetError(firstName, $"Give First Name!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(firstName, "");
            }

        }
        

        
    

        private void backButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public RegistrationPageOne()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
        

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            fname = firstName.Text;
            lname = lastName.Text;
            sid = StudentID.Text;
            age = Age.Text;
            pyear = PassingYear.Text;
            present_address = PresentAddress.Text;
            permanent_address = PermanentAddress.Text;
            father = FatherName.Text;
            mother = MotherName.Text;
            work = Work.Text;

            if (fname == "" || lname == "" || sid == "" || age == "" || pyear == "" || father == "" || mother == "")
            {
                warning.Visible = true;
            }
            else {
                this.Hide();
                RegistrationFormTwo rFormTwo = new RegistrationFormTwo(fname, lname, sid, age, pyear, present_address, permanent_address, father, mother, work);
                rFormTwo.Show();
            }

        }

    }
}
