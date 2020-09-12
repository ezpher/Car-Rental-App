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
        private Login _loginWindow;

        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(Login loginWindow)
        {
            InitializeComponent();
            _loginWindow = loginWindow;
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

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _loginWindow.Close();
        }
    }
}
