using CarRentalDesktopApp.CarRentalLibrary;
using CarRentalDesktopApp.CarRentalUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalDesktopApp
{
    public partial class MainWindow : Form
    {
        private readonly CarRentalAppEntities _db;
        private Login _loginWindow;
        private User _user;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(Login loginWindow, User user)
        {
            InitializeComponent();
            _db = new CarRentalAppEntities();
            _loginWindow = loginWindow;
            _user = user;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (_user != null)
            {
                string role = _db.Roles.Where(r => r.UserRoles.Where(ur => ur.User.ID == _user.ID).FirstOrDefault().RoleID == r.ID).FirstOrDefault().Role1;

                if (role != null && role != "Admin")
                {
                    AdminToolStripMenuItem.Visible = false;
                }

                toolStripStatusLabelLoginUser.Text = $"Logged In As: {_user.UserName}";
            }
        }

        private void checkoutCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("CheckoutRental"))
            {
                CheckoutRental checkoutRentalForm = new CheckoutRental();
                checkoutRentalForm.MdiParent = this;
                checkoutRentalForm.Show();
            }
        }

        private void checkinCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("CheckinRental"))
            {
                CheckinRental checkinRentalForm = new CheckinRental();
                checkinRentalForm.MdiParent = this;
                checkinRentalForm.Show();
            }
        }

        private void manageCarsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageCars"))
            {
                ManageCars managerCarsForm = new ManageCars();
                managerCarsForm.MdiParent = this;
                managerCarsForm.Show();
            }
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("ManageUsers"))
            {
                ManageUsers managerCarsForm = new ManageUsers();
                managerCarsForm.MdiParent = this;
                managerCarsForm.Show();
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginWindow.Close();
        }


    }
}
