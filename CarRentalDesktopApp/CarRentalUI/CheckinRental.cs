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
    public partial class CheckinRental : Form
    {
        private readonly CarRentalAppEntities _db;

        public CheckinRental()
        {
            InitializeComponent();
            _db = new CarRentalAppEntities();
        }

        private void PopulateCustNameAndCarToReturnDropdowns(string selectedCustID = null)
        {
            // get customers on loan for "customer name" dropdown
            var customers = _db.CarRentalRecords
                .Where(c => c.CarRecord.OnLoan == true)
                .Select(c => new CustomerViewModel { ID = c.ID, CustomerName = c.CustomerName }).ToList();

            // declare local variables and assign selectedCustName default or selected value
            var selectedCustName = string.Empty;
            if (string.IsNullOrEmpty(selectedCustID))
            {
                selectedCustName = customers.FirstOrDefault()?.CustomerName;
                dropdownCustName.DisplayMember = "CustomerName";
                dropdownCustName.ValueMember = "ID";
                dropdownCustName.DataSource = customers;
            }
            else
            {
                selectedCustName = customers.First(c => c.ID == int.Parse(selectedCustID)).CustomerName;
            }

            // get current cars on loan for selected customer for "car to return" dropdown
            var carsOnLoan = _db.CarRentalRecords
                .Where(c => c.CarRecord.OnLoan == true && !string.IsNullOrEmpty(selectedCustName) && c.CustomerName == selectedCustName)
                .Select(c => new CarViewModel { ID = c.ID, Make = c.CarRecord.Make, Description = c.CarRecord.Make + " " + c.CarRecord.Model + " " + c.CarRecord.Year })
                .ToList();

            dropdownCarToReturn.DisplayMember = "Description";
            dropdownCarToReturn.ValueMember = "ID";
            dropdownCarToReturn.DataSource = carsOnLoan;
        }

        private void CheckinRental_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateCustNameAndCarToReturnDropdowns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dropdownCustName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedCustID = ((int)dropdownCustName.SelectedValue).ToString();
                PopulateCustNameAndCarToReturnDropdowns(selectedCustID);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonCheckinCar_Click(object sender, EventArgs e)
        {
            try
            {
                // get values from form controls
                string custName = dropdownCustName.Text;
                int custID = (int)dropdownCustName.SelectedValue;
                string carToReturn = dropdownCarToReturn.Text;
                var dateReturned = dateTimePickerDateReturned.Value;

                // declare local variables
                string errorMessage = string.Empty;

                // form control validation
                if (string.IsNullOrWhiteSpace(custName))
                {
                    errorMessage += "Error: Please select a valid input for customer name \n\r";
                }

                if (string.IsNullOrWhiteSpace(carToReturn))
                {
                    errorMessage += "Error: Please select a valid input for car to return \n\r";
                }

                if (dateReturned == null)
                {
                    errorMessage += "Error: Please enter valid date \n\r";
                }

                // form control business validation
                if (!string.IsNullOrWhiteSpace(custName) && !string.IsNullOrWhiteSpace(carToReturn) && dateReturned != null)
                {
                    CarRentalRecord selectedCarRecord = _db.CarRentalRecords.First(c => c.ID == custID);

                    if (selectedCarRecord.DateToReturn == null)
                    {
                        throw new NoNullAllowedException();
                    }
                    else if (selectedCarRecord.DateToReturn != null && dateReturned.Date < selectedCarRecord.DateToReturn.Value.Date)
                    {
                        errorMessage += $"Error: date returned: {dateReturned.Date} cannot be less than date to return: {selectedCarRecord.DateToReturn.Value.Date} \n\r";
                    }
                }

                // display error message or save valid input
                if (!string.IsNullOrWhiteSpace(errorMessage))
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    CarRentalRecord selectedCarRecord = _db.CarRentalRecords.First(c => c.ID == custID);
                    selectedCarRecord.DateReturned = selectedCarRecord.DateToReturn.Value;
                    selectedCarRecord.CarRecord.OnLoan = false;

                    _db.SaveChanges();

                    MessageBox.Show($"Customer Name: {custName} \n\r" + $"Car: {carToReturn} \n\r" + $"Date Returned: {dateReturned.Date} \n\r");

                    // refresh dropdowns
                    PopulateCustNameAndCarToReturnDropdowns();

                }
            }
            catch (NoNullAllowedException nex)
            {
                MessageBox.Show($"Error: {nex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
