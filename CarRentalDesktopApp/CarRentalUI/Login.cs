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

            using (SHA256 sha256Hash = SHA256.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));


                // Create a new Stringbuilder to collect the bytes and create a string
                StringBuilder builder = new StringBuilder();

                // Loop through each byte of the hashed data and format each one as a hexadecimal string.
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }

                string hashedPassword = builder.ToString();


                //Check for matching username and password
                var user = _db.Users.FirstOrDefault(q => q.UserName == userName && q.Password == hashedPassword);

                if (user == null)
                {
                    MessageBox.Show("Credentials entered are not valid", "Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MainWindow mainWindow = new MainWindow(this);
                    mainWindow.Show();
                    this.Hide();

                }

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
