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
    public partial class AddNewUser : Form
    {
        private readonly CarRentalAppEntities _db;
        private readonly ManageUsers _manageUserForm;

        public AddNewUser()
        {
            InitializeComponent();
        }

        public AddNewUser(ManageUsers manageUsersForm)
        {
            InitializeComponent();
            _db = new CarRentalAppEntities();
            _manageUserForm = manageUsersForm;
        }

        private void AddNewUser_Load(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Role> roles = _db.Roles.ToList();
                dropdownRoles.DataSource = roles;
                dropdownRoles.DisplayMember = "Role1";
                dropdownRoles.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddNewUser_Click(object sender, EventArgs e)
        {
            try
            {
                string newUsername = textBoxNewUsername.Text.Trim();
                string selectedRole = dropdownRoles.Text;
                int selectedRoleValue = (int)dropdownRoles.SelectedValue;

                if (!string.IsNullOrEmpty(newUsername))
                {
                    if (_db.Users.Where(u => u.UserName == newUsername).FirstOrDefault() == null)
                    {
                        User newUser = new User
                        {
                            UserName = newUsername,
                            Password = Utils.HashPassword(),
                            IsActive = true
                        };

                        _db.Users.Add(newUser);
                        _db.SaveChanges();

                        _db.UserRoles.Add(new UserRole
                        {
                            UserID = newUser.ID,
                            RoleID = selectedRoleValue
                        });

                        _db.SaveChanges();

                        _manageUserForm.PopulateUsersGrid();
                        MessageBox.Show($"A new account has been created for {newUsername} with role: {selectedRole}");
                    }
                    else
                    {
                        MessageBox.Show($"There is already a username: {newUsername}. Please provide another username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                else
                {
                    MessageBox.Show("Please provide a valid input for username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
