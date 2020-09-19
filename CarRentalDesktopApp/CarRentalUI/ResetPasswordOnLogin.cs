using CarRentalDesktopApp.CarRentalLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalDesktopApp.CarRentalUI
{
    public partial class ResetPasswordOnLogin : Form
    {
        private readonly CarRentalAppEntities _db;
        private User _user;

        public ResetPasswordOnLogin()
        {
            InitializeComponent();
            this.ControlBox = false; // set control box to false to prevent user from bypassing resetting password by clicking the close button at the top right of window

            _db = new CarRentalAppEntities();
        }

        public ResetPasswordOnLogin(User user)
        {
            InitializeComponent();
            this.ControlBox = false;

            _db = new CarRentalAppEntities();
            _user = user;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxResetPassword.Text == textBoxConfirmPassword.Text)
                {
                    User user = _db.Users.Where(u => u.ID == _user.ID).First();
                    user.Password = Utils.HashPassword(textBoxConfirmPassword.Text);

                    _db.SaveChanges();

                    MessageBox.Show("You have reset your password successfully", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The passwords provided do not match. Please try again.", "Password Reset", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxResetPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
            }
        }

        private void textBoxConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
            }
        }
    }
}
