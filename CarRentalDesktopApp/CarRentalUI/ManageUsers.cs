using CarRentalDesktopApp.CarRentalLibrary;
using CarRentalDesktopApp.CarRentalLibrary.ViewModels;
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
    public partial class ManageUsers : Form
    {
        private readonly CarRentalAppEntities _db;

        public void PopulateUsersGrid()
        {
            var users = _db.Users.Select(u =>
                new UserRoleViewModel
                {
                    UserID = u.ID,
                    Username = u.UserName,
                    IsActive = u.IsActive.ToString(),
                    RoleID = u.UserRoles.FirstOrDefault().RoleID, // TODO: to retrieve many roles if present, for the user instead of the first
                    Role = u.UserRoles.FirstOrDefault().Role.Role1 // TODO: to retrieve many roles if present, for the user instead of the first

                }).ToList();

            dataGridViewManageUsers.DataSource = users;
            dataGridViewManageUsers.Columns["UserID"].HeaderText = "User ID";
            dataGridViewManageUsers.Columns["IsActive"].HeaderText = "Is Active";
            dataGridViewManageUsers.Columns["RoleID"].Visible = false;

        }

        public ManageUsers()
        {
            InitializeComponent();
            _db = new CarRentalAppEntities();
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateUsersGrid();

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonResetPassword_Click(object sender, EventArgs e)
        {
            try
            {
                int userID = (int)dataGridViewManageUsers.SelectedRows[0].Cells["UserID"].Value;
                User selectedUser = _db.Users.Where(u => u.ID == userID).FirstOrDefault();

                if (selectedUser != null)
                {
                    selectedUser.Password = Utils.HashPassword();
                }

                _db.SaveChanges();

                MessageBox.Show($"{selectedUser.UserName}'s password has been reset");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonActivateDeactivateUser_Click(object sender, EventArgs e)
        {
            try
            {
                int userID = (int)dataGridViewManageUsers.SelectedRows[0].Cells["UserID"].Value;
                User selectedUser = _db.Users.Where(u => u.ID == userID).FirstOrDefault();

                if (selectedUser != null)
                {
                    selectedUser.IsActive = selectedUser.IsActive == true ? false : true; // handle nulls if needed
                }

                _db.SaveChanges();

                PopulateUsersGrid();

                string userStatusDisplayString = selectedUser.IsActive ? "activated" : "deactivated";
                MessageBox.Show($"{selectedUser.UserName}'s account has been {userStatusDisplayString}");
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddNewUser"))
            {
                AddNewUser addNewUserForm = new AddNewUser(this);
                addNewUserForm.MdiParent = this.MdiParent;
                addNewUserForm.Show();
            }
        }
    }
}
