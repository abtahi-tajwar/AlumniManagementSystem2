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
    public partial class AdminDasboard : Form
    {
        DatabaseManager manager;
        public AdminDasboard()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            manager = new DatabaseManager();

            UsernameText.Text = AdminSession.fname + " " + AdminSession.lname;
            EmailText.Text = AdminSession.email;
            DescriptionText.Text = AdminSession.desc;
            if (!AdminSession.picture.Equals("") || !AdminSession.picture.Equals(" "))
            {
                ProfilePicture.ImageLocation = AdminSession.picture;
                ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }

            updateAlumniVerifier();
        }

        //Create Event button clicked
        private void pictureBox24_Click(object sender, EventArgs e)
        {
            DateTime date = System.DateTime.Now;
            manager.createEvent(EventText.Text, date.ToString("MM/dd/yyyy HH:mm:ss"));
            EventText.Text = "";
        }

        //Update Alumni verified
        private void updateAlumniVerifier()
        {
            AlumniName.Text = manager.getUnverifiedAlumni("FirstName") + " " + manager.getUnverifiedAlumni("LastName");
            AlumniSubtitle.Text = manager.getUnverifiedAlumni("ProfileSubtitle");
            AlumniEmail.Text = manager.getUnverifiedAlumni("Email");
            AlumniWork.Text = manager.getUnverifiedAlumni("WorkPlace");
            AlumniPicture.ImageLocation = manager.getUnverifiedAlumni("ProfilePicture");
            AlumniPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Close Button clicked
        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Logout Button clicked
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            AdminSession.resetSession();
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        //Change profile picture
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            AdminSession.picture = openFileDialog1.FileName;
            ProfilePicture.ImageLocation = AdminSession.picture;
            ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            manager.updateAdmin(AdminSession.id, "ProfilePicture", AdminSession.picture);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AdminSettings settings = new AdminSettings();
            settings.Show();
            this.Hide();
        }

        //Alumni verify button click
        private void pictureBox21_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(manager.getUnverifiedAlumni("Id"));
            manager.updateAlumni(id, "Verified", "1");
            updateAlumniVerifier();
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(manager.getUnverifiedAlumni("Id"));
            manager.deleteAlumni(id);
            updateAlumniVerifier();
        }
    }
}
