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
    public partial class EditProfile : Form
    {
        bool isEditable;
        DatabaseManager manager;
        public EditProfile()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            isEditable = false;
            manager = new DatabaseManager();
        }       

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Application.Exit();               
                
        }

        //Go back button click
        private void pictureBox16_Click(object sender, EventArgs e)
        {
            AlumniSettings settings = new AlumniSettings();
            settings.Show();
            this.Hide();
        }
        //Edit profile Button click
        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            if (!isEditable)
            {
                fname.Enabled = lname.Enabled = sid.Enabled = age.Enabled = pyear.Enabled = present_address.Enabled = permanent_address.Enabled = father.Enabled = mother.Enabled = work.Enabled = true;
                EditProfileButtonText.Text = "Save Profile";
                isEditable = true;
            }
            else {
                fname.Enabled = lname.Enabled = sid.Enabled = age.Enabled = pyear.Enabled = present_address.Enabled = permanent_address.Enabled = father.Enabled = mother.Enabled = work.Enabled = false;
                EditProfileButtonText.Text = "Edit Profile";
                manager.updateAlumni(Session.id, "FirstName", fname.Text);
                manager.updateAlumni(Session.id, "LastName", lname.Text);
                manager.updateAlumni(Session.id, "StudentID", sid.Text);
                manager.updateAlumni(Session.id, "Age", age.Text);
                manager.updateAlumni(Session.id, "PassingYear", pyear.Text);
                manager.updateAlumni(Session.id, "PresentAddress", present_address.Text);
                manager.updateAlumni(Session.id, "PermanentAddress", permanent_address.Text);
                manager.updateAlumni(Session.id, "FathersName", father.Text);
                manager.updateAlumni(Session.id, "MothersName", mother.Text);
                manager.updateAlumni(Session.id, "WorkPlace", work.Text);

                Session.updateSession();
                isEditable = false;
            }
        }

        //Dashbaord Button clicked
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AlumniDashboard dashboard = new AlumniDashboard();
            dashboard.Show();
            this.Hide();
        }
        
        //Settings button click
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AlumniSettings settings = new AlumniSettings();
            settings.Show();
            this.Hide();
        }
    }
}
