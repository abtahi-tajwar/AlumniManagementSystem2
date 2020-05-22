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
    public partial class AlumniDashboard : Form
    {
        DatabaseManager manager = new DatabaseManager();
        public AlumniDashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            manager = new DatabaseManager();

            UserNameText.Text = Session.fname + " " + Session.lname;
            SubtitleText.Text = Session.subtitle;
            EmailText.Text = Session.email;
            DescriptionText.Text = Session.desc;
            EventNameText.Text = manager.getLastEvent("name");
            EventDateText.Text = manager.getLastEvent("date");
            if (!Session.picture.Equals("no")) {
                ProfilePicture.ImageLocation = Session.picture;
                ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            if (Session.verified == 0)
            {
                unapproved.Visible = true;
            }
            else {
                unapproved.Visible = false;
            }

            if (manager.checkEventGoing(Session.id))
            {
                GoingTrue.Visible = true;
            }
            else {
                GoingFalse.Visible = true;
            }

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Going button Clicked
        private void GoingFalse_Click(object sender, EventArgs e)
        {
            manager.updateEventCount(Session.id);
            GoingFalse.Visible = false;
            GoingTrue.Visible = true;
        }

        //Setting button click
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AlumniSettings settings = new AlumniSettings();
            settings.Show();
            this.Hide();
        }

        //Logout button click
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Session.resetSession();
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        //Edit profile picture button clicked
        private void SelectPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            Session.picture = openFileDialog1.FileName;
            ProfilePicture.ImageLocation = Session.picture;
            ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            manager.updateAlumni(Session.id, "ProfilePicture", Session.picture);
        }
    }
}
