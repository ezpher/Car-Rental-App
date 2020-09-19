using CarRentalDesktopApp.CarRentalLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalDesktopApp.CarRentalUI
{
    public partial class Login : Form
    {
        private readonly CarRentalAppEntities _db;

        public Login()
        {
            InitializeComponent();
            _db = new CarRentalAppEntities();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string userName = textBoxUserName.Text.Trim();
            string password = textBoxPassword.Text;
            string hashedPassword = string.Empty;

            hashedPassword = Utils.HashPassword(password);

            //Check for matching username and password and isActive Status
            User user = _db.Users.FirstOrDefault(q => q.UserName == userName && q.Password == hashedPassword && q.IsActive == true);

            if (user == null)
            {
                MessageBox.Show("Credentials entered are not valid", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else 
            {
                // Check if retrieved user's password is default password
                if (user.Password == Utils.HashPassword())
                {
                    ResetPasswordOnLogin resetPWForm = new ResetPasswordOnLogin(user);
                    resetPWForm.ShowDialog(); // showDialog does not allow user to click anywhere until action is resolved in the dialog box i.e. modal-style box
                }

                MainWindow mainWindow = new MainWindow(this, user);
                mainWindow.Show();
                this.Hide();

            }
        }

        private void textBoxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                e.Handled = true;
            }
        }
    }
}
