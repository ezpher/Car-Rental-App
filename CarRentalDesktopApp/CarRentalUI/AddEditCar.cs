using CarRentalDesktopApp.CarRentalLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalDesktopApp.CarRentalUI
{
    public partial class AddEditCar : Form
    {
        private readonly bool isEdit;
        private readonly ManageCarViewModel manageCarVM;
        private readonly ManageCars manageCarsForm;

        public AddEditCar()
        {
            InitializeComponent();
        }

        public AddEditCar(bool isEdit, ManageCarViewModel manageCarVM = null, ManageCars manageCarsForm = null)
        {
            this.isEdit = isEdit;
            this.manageCarsForm = manageCarsForm;

            InitializeComponent();

            if (this.isEdit)
            {
                addEditCarTitle.Text = "Edit Car";
                this.Text = "Edit Car";
                buttonAddEditCar.Text = "Edit Car";

                textBoxMake.Text = manageCarVM.Make;
                textBoxModel.Text = manageCarVM.Model;
                textBoxYear.Text = manageCarVM.Year;
                textBoxVIN.Text = manageCarVM.VIN;
                textBoxLicense.Text = manageCarVM.LicensePlate;

                this.manageCarVM = manageCarVM;

            }
            else
            {
                addEditCarTitle.Text = "Add Car";
                this.Text = "Add Car";
                buttonAddEditCar.Text = "Add Car";
            }
        }

        private void buttonAddEditCar_Click(object sender, EventArgs e)
        {
            try
            {
                // get values from form controls
                string carMake = textBoxMake.Text;
                string carModel = textBoxModel.Text;
                string rawCarYear = textBoxYear.Text;
                string carVIN = textBoxVIN.Text;
                string carlicensePlate = textBoxLicense.Text;

                // declare local variables
                string errorMessage = string.Empty;

                // form control validation
                if (string.IsNullOrWhiteSpace(carMake))
                {
                    errorMessage += "Error: Please select a valid input for Car Make \n\r";
                }

                if (string.IsNullOrWhiteSpace(carModel))
                {
                    errorMessage += "Error: Please select a valid input for Car Model \n\r";
                }

                if (!int.TryParse(rawCarYear, out int carYear))
                {
                    errorMessage += "Error: Please select a valid input for Car Year \n\r";
                }

                if (string.IsNullOrWhiteSpace(carVIN))
                {
                    errorMessage += "Error: Please select a valid input for Car VIN \n\r";
                }

                if (string.IsNullOrWhiteSpace(carlicensePlate))
                {
                    errorMessage += "Error: Please select a valid input for Car License \n\r";
                }

                // display error message or save valid input
                if (!string.IsNullOrWhiteSpace(errorMessage))
                {
                    MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CarRentalDb"].ConnectionString);

                    // Create a SqlDataAdapter based on a SELECT query/stored procedure.
                    SqlDataAdapter da = new SqlDataAdapter("[dbo].[SP_GetCarRecords]", conn);

                    if (isEdit)
                    {
                        // Create a SqlCommand to execute the UPDATE stored procedure.
                        // Need SqlCommand for data adapter update command
                        da.UpdateCommand = new SqlCommand("[dbo].[SP_UpdateCarRecord]", conn);
                        da.UpdateCommand.CommandType = CommandType.StoredProcedure;

                        // Create input and return parameters
                        SqlParameter parameter = da.UpdateCommand.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");
                        parameter.SourceVersion = DataRowVersion.Original;

                        da.UpdateCommand.Parameters.Add("@Make", SqlDbType.NVarChar, 50, "Make");
                        da.UpdateCommand.Parameters.Add("@Model", SqlDbType.NVarChar, 50, "Model");
                        da.UpdateCommand.Parameters.Add("@Year", SqlDbType.Int, 0, "Year");
                        da.UpdateCommand.Parameters.Add("@VIN", SqlDbType.NVarChar, 50, "VIN");
                        da.UpdateCommand.Parameters.Add("@LicensePlate", SqlDbType.NVarChar, 50, "LicensePlate");

                        parameter = da.UpdateCommand.Parameters.Add("@RowCount", SqlDbType.Int);
                        parameter.Direction = ParameterDirection.ReturnValue;

                        // Create datatable to fill up records based on select stored proc 
                        // Need select query/stored proc to use fill method
                        DataTable carRecords = new DataTable();
                        da.Fill(carRecords);

                        // find row to update and persist changes to db
                        DataRow[] carRows = carRecords.Select($"ID = {manageCarVM.ID}");
                        carRows[0]["ID"] = manageCarVM.ID;
                        carRows[0]["Make"] = carMake;
                        carRows[0]["Model"] = carModel;
                        carRows[0]["Year"] = carYear;
                        carRows[0]["VIN"] = carVIN;
                        carRows[0]["LicensePlate"] = carlicensePlate;

                        da.Update(carRecords);

                        // Retrieve return parameter value
                        int rowCount = (int)da.UpdateCommand.Parameters["@RowCount"].Value;

                        MessageBox.Show($"{rowCount} Car: {carMake} {carModel} {carYear} has been successfully edited");
                    }
                    else
                    {
                        // Create a SqlCommand to execute the INSERT stored procedure.
                        // Need SqlCommand for data adapter insert command
                        da.InsertCommand = new SqlCommand("[dbo].[SP_InsertCarRecord]", conn);
                        da.InsertCommand.CommandType = CommandType.StoredProcedure;

                        // Create input, output and return parameters
                        da.InsertCommand.Parameters.Add("@Make", SqlDbType.NVarChar, 50, "Make");
                        da.InsertCommand.Parameters.Add("@Model", SqlDbType.NVarChar, 50, "Model");
                        da.InsertCommand.Parameters.Add("@Year", SqlDbType.Int, 0, "Year");
                        da.InsertCommand.Parameters.Add("@VIN", SqlDbType.NVarChar, 50, "VIN");
                        da.InsertCommand.Parameters.Add("@LicensePlate", SqlDbType.NVarChar, 50, "LicensePlate");

                        SqlParameter parameter = da.InsertCommand.Parameters.Add("@RowCount", SqlDbType.Int);
                        parameter.Direction = ParameterDirection.ReturnValue;

                        parameter = da.InsertCommand.Parameters.Add("@RowID", SqlDbType.Int);
                        parameter.Direction = ParameterDirection.Output;

                        // Create datatable to fill up records based on select stored proc 
                        // Need select query/stored proc to use fill method
                        DataTable carRecords = new DataTable();
                        da.Fill(carRecords);

                        // Insert new row, then update db
                        DataRow carRow = carRecords.NewRow();
                        carRow["Make"] = carMake;
                        carRow["Model"] = carModel;
                        carRow["Year"] = carYear;
                        carRow["VIN"] = carVIN;
                        carRow["LicensePlate"] = carlicensePlate;
                        carRecords.Rows.Add(carRow);

                        da.Update(carRecords);

                        // Retrieve return and output parameter values
                        int rowCount = (int)da.InsertCommand.Parameters["@RowCount"].Value;
                        int rowID = (int)da.InsertCommand.Parameters["@RowID"].Value;

                        MessageBox.Show($"{rowCount} Car: {carMake} {carModel} {carYear} has been successfully added");
                    }

                    // refresh parent form grid view i.e. list of car records in manage cars form
                    if (Utils.FormIsOpen("ManageCars"))
                    {
                        manageCarsForm.populateGrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
