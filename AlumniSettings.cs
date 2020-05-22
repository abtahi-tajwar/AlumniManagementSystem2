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
    public partial class AlumniSettings : Form
    {
        DatabaseManager manager;
        public AlumniSettings()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            manager = new DatabaseManager();
            if (!Session.picture.Equals("no"))
            {
                ProfilePicture.ImageLocation = Session.picture;
                ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        // Close button click
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Change password button clicked
        private void changePassword_Click(object sender, EventArgs e)
        {
            if (NewPassoword.Text.Equals(RetypeNewPassword.Text))
            {
                if (OldPassword.Text.Equals(Session.password))
                {
                    Session.password = NewPassoword.Text;
                    manager.updateAlumni(Session.id, "Password", NewPassoword.Text);
                    warning.Text = "Password changed successfully!";
                }
                else {
                    warning.Text = "Old password is not correct!";
                }
            }
            else {
                warning.Text = "Both password doesn't match";
            }
        }

        //Dashboard button clicked
        private void DashboardButton_Click(object sender, EventArgs e)
        {
            AlumniDashboard dashboard = new AlumniDashboard();
            dashboard.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Session.picture = openFileDialog1.FileName;
            ProfilePicture.ImageLocation = Session.picture;
            ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            manager.updateAlumni(Session.id, "ProfilePicture", Session.picture);
        }

        //Edit profile button clicked
        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            EditProfile editProfile = new EditProfile();
            editProfile.Show();
            this.Hide();
        }
    }
}
