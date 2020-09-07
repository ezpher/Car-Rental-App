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
    public partial class CheckoutRental : Form
    {
        private readonly CarRentalAppEntities _db;

        public CheckoutRental()
        {
            InitializeComponent();
            _db = new CarRentalAppEntities();
        }

        private void CheckoutRental_Load(object sender, EventArgs e)
        {
            var cars = _db.CarRecords
                .Where(c => c.OnLoan == false)
                .Select(c => new CarViewModel { ID = c.ID, Make = c.Make, Description = c.Make + " " + c.Model + " " + c.Year }).ToList();

            dropdownCarRented.DisplayMember = "Description";
            dropdownCarRented.ValueMember = "ID";
            dropdownCarRented.DataSource = cars;
        }

        private void buttonAddRentalRecord_Click(object sender, EventArgs e)
        {
            try
            {
                // get values from form controls
                string custName = textBoxCustName.Text.Trim();
                string carType = dropdownCarRented.Text;
                var dateRented = dateTimePickerDateRented.Value;
                var dateToReturn = dateTimePickerDateToReturn.Value;
                Decimal.TryParse(textBoxCarCost.Text.Trim(), out decimal carRentalCost);

                // declare local variables
                string errorMessage = string.Empty;

                // form control validation
                if (string.IsNullOrWhiteSpace(custName))
                {
                    errorMessage += "Error: Please enter input value for Customer Name \n\r";
                }

                if (carRentalCost == 0)
                {
                    errorMessage += "Error: Please enter input value for Car Rental Cost \n\r";
                }

                if ((dateRented == null || dateToReturn == null) || dateRented.Date > dateToReturn.Date)
                {
                    errorMessage += "Error: Please enter valid date(s) \n\r";
                }

                if (string.IsNullOrWhiteSpace(carType))
                {
                    errorMessage += "Error: Please enter input value for Car Type \n\r";
                }

                // display error message or save valid input
                if (!string.IsNullOrWhiteSpace(errorMessage))
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CarRentalRecord newCarRentalRecord = new CarRentalRecord
                    {
                        CustomerName = custName,
                        Cost = carRentalCost,
                        DateRented = dateRented,
                        DateToReturn = dateToReturn,
                        CarID = (int)dropdownCarRented.SelectedValue,
                    };

                    _db.CarRentalRecords.Add(newCarRentalRecord);

                    CarRecord carRented = _db.CarRecords.Where(c => c.ID == (int)dropdownCarRented.SelectedValue).First();
                    carRented.OnLoan = true;

                    _db.SaveChanges();

                    MessageBox.Show($"Customer Name: {custName} \n\r" + $"Date Rented: {dateRented.Date} \n\r" +
                                    $"Date To Return: {dateToReturn.Date} \n\r" + $"Cost: {carRentalCost} \n\r" + $"Car: {carType} \n\r");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
