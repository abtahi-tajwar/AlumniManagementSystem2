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
    public partial class AdminSettings : Form
    {
        DatabaseManager manager;
        public AdminSettings()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            manager = new DatabaseManager();

            UsernameText.Text = AdminSession.fname + " " + AdminSession.lname;
            EmailText.Text = AdminSession.email;
            if (!AdminSession.picture.Equals("") || !AdminSession.picture.Equals(" "))
            {
                ProfilePicture.ImageLocation = AdminSession.picture;
                ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            var text = (sender as TextBox).Text;
            if (String.IsNullOrEmpty(text))
            {
                e.Cancel = true;
                NewPassoword.Focus();
                errorProvider1.SetError(NewPassoword, $"Enter password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(NewPassoword, "");
            }
           
        }

        //Change password button click
        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (NewPassoword.Text.Equals(RetypeNewPassword.Text))
            {
                if (OldPassword.Text.Equals(AdminSession.password))
                {
                    AdminSession.password = NewPassoword.Text;
                    manager.updateAdmin(AdminSession.id, "Password", NewPassoword.Text);
                    warning.Text = "Password changed successfully!";
                }
                else
                {
                    warning.Text = "Old password is not correct!";
                }
            }
            else
            {
                warning.Text = "Both password doesn't match";
            }
        }

        //Dashboard Icon clicked
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminDasboard dashboard = new AdminDasboard();
            dashboard.Show();
            this.Hide();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            AdminSession.picture = openFileDialog1.FileName;
            ProfilePicture.ImageLocation = AdminSession.picture;
            ProfilePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            manager.updateAdmin(AdminSession.id, "ProfilePicture", AdminSession.picture);
        }
    }
}
