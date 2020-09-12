using CarRentalDesktopApp.CarRentalLibrary.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalDesktopApp.CarRentalUI
{
    public partial class ManageCars : Form
    {
        public ManageCars()
        {
            InitializeComponent();
        }

        public void populateGrid()
        {
            // 1. set up sql connection to db (Add System.Configuration reference to winforms project and use configuration manager) to retrieve connection string from app config file
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CarRentalDb"].ConnectionString);

            // 2. set up data adapter for retrieving data from db using stored proc 
            SqlDataAdapter da = new SqlDataAdapter("[dbo].[SP_GetCarRecords]", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            // 3. fill dataset with retrieved data, and assign table name i.e. Cars (opening and closing of connection automatically handled by fill method of data adapter unlike sqlCommand object)
            DataSet ds = new DataSet();
            da.Fill(ds, "Cars");

            // Project each row of the table to a ManageCarViewModel; use AsEnumerable to enable working with linq
            IEnumerable<ManageCarViewModel> cars = ds.Tables["Cars"]
                .AsEnumerable()
                .Select(c => new ManageCarViewModel
                {
                    ID = Convert.ToInt32(c["ID"]),
                    Make = c["Make"].ToString(),
                    Model = c["Model"].ToString(),
                    Year = c["Year"].ToString(),
                    LicensePlate = c["LicensePlate"].ToString(),
                    VIN = c["VIN"].ToString()

                }).ToList();

            dataGridViewManageCars.DataSource = cars;
            dataGridViewManageCars.Columns["LicensePlate"].HeaderText = "License Plate";
            dataGridViewManageCars.Columns["ID"].Visible = false;
        }

        private void ManageCars_Load(object sender, EventArgs e)
        {
            try
            {
                populateGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddCar_Click(object sender, EventArgs e)
        {
            if (!Utils.FormIsOpen("AddEditCar"))
            {
                AddEditCar addEditCarForm = new AddEditCar(isEdit: false, manageCarsForm: this);
                addEditCarForm.MdiParent = this.MdiParent;
                addEditCarForm.Show();
            }
            else
            {
                MessageBox.Show("Info: An instance of the Add/Edit Car Window is open.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void buttonUpdateCar_Click(object sender, EventArgs e)
        {

            if (!Utils.FormIsOpen("AddEditCar") && dataGridViewManageCars.SelectedRows.Count > 0)
            {
                // get the values of the selected row for pre-populating edit form
                DataGridViewRow selectedRow = dataGridViewManageCars.SelectedRows[0];

                int carID = (int)selectedRow.Cells["ID"].Value;
                string make = selectedRow.Cells["Make"].Value.ToString();
                string model = selectedRow.Cells["Model"].Value.ToString();
                string year = selectedRow.Cells["Year"].Value.ToString();
                string vin = selectedRow.Cells["VIN"].Value.ToString();
                string licensePlate = selectedRow.Cells["LicensePlate"].Value.ToString();

                var manageCarVM = new ManageCarViewModel
                {
                    ID = carID,
                    Make = make,
                    Model = model,
                    Year = year,
                    VIN = vin,
                    LicensePlate = licensePlate,
                };

                AddEditCar addEditCarForm = new AddEditCar(isEdit: true, manageCarVM: manageCarVM, manageCarsForm: this);
                addEditCarForm.MdiParent = this.MdiParent;
                addEditCarForm.Show();
            }
            else
            {
                MessageBox.Show("Info: An instance of the Add/Edit Car Window is open.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void buttonRemoveCar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewManageCars.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridViewManageCars.SelectedRows[0];
                    int carID = (int)selectedRow.Cells["ID"].Value;
                    string make = selectedRow.Cells["Make"].Value.ToString();
                    string model = selectedRow.Cells["Model"].Value.ToString();
                    string year = selectedRow.Cells["Year"].Value.ToString();

                    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["CarRentalDb"].ConnectionString);

                    // Create a SqlDataAdapter based on a SELECT query/stored procedure.
                    SqlDataAdapter da = new SqlDataAdapter("[dbo].[SP_GetCarRecords]", conn);

                    // Create a SqlCommand to execute the DELETE stored procedure.
                    // Need SqlCommand for data adapter delete command
                    da.DeleteCommand = new SqlCommand("[dbo].[SP_DeleteCarRecord]", conn);
                    da.DeleteCommand.CommandType = CommandType.StoredProcedure;

                    // Create input and return parameters
                    SqlParameter parameter = da.DeleteCommand.Parameters.Add("@ID", SqlDbType.Int, 0, "ID");
                    parameter.SourceVersion = DataRowVersion.Original;

                    parameter = da.DeleteCommand.Parameters.Add("@RowCount", SqlDbType.Int);
                    parameter.Direction = ParameterDirection.ReturnValue;

                    // Create datatable to fill up records based on select stored proc 
                    // Need select query/stored proc to use fill method
                    DataTable carRecords = new DataTable();
                    da.Fill(carRecords);

                    // find row to delete and persist changes to db
                    DataRow[] carRows = carRecords.Select($"ID = {carID}");
                    carRows[0].Delete();

                    da.Update(carRecords);

                    // Retrieve return parameter value
                    int rowCount = (int)da.DeleteCommand.Parameters["@RowCount"].Value;

                    // refresh grid
                    populateGrid();

                    MessageBox.Show($"{rowCount} Car: {make} {model} {year} has been successfully removed");


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}