namespace CarRentalDesktopApp.CarRentalUI
{
    partial class CheckoutRental
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkoutRentalCarTitle = new System.Windows.Forms.Label();
            this.labelCustName = new System.Windows.Forms.Label();
            this.textBoxCustName = new System.Windows.Forms.TextBox();
            this.labelDateRented = new System.Windows.Forms.Label();
            this.dateTimePickerDateRented = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDateToReturn = new System.Windows.Forms.DateTimePicker();
            this.labelDateToReturn = new System.Windows.Forms.Label();
            this.buttonAddRentalRecord = new System.Windows.Forms.Button();
            this.dropdownCarRented = new System.Windows.Forms.ComboBox();
            this.labelCarRented = new System.Windows.Forms.Label();
            this.textBoxCarCost = new System.Windows.Forms.TextBox();
            this.labelRentalCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkoutRentalCarTitle
            // 
            this.checkoutRentalCarTitle.AutoSize = true;
            this.checkoutRentalCarTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkoutRentalCarTitle.Location = new System.Drawing.Point(195, 45);
            this.checkoutRentalCarTitle.Name = "checkoutRentalCarTitle";
            this.checkoutRentalCarTitle.Size = new System.Drawing.Size(373, 47);
            this.checkoutRentalCarTitle.TabIndex = 2;
            this.checkoutRentalCarTitle.Text = "Checkout Rental Car";
            // 
            // labelCustName
            // 
            this.labelCustName.AutoSize = true;
            this.labelCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustName.Location = new System.Drawing.Point(111, 142);
            this.labelCustName.Name = "labelCustName";
            this.labelCustName.Size = new System.Drawing.Size(128, 20);
            this.labelCustName.TabIndex = 3;
            this.labelCustName.Text = "Customer Name:";
            // 
            // textBoxCustName
            // 
            this.textBoxCustName.Location = new System.Drawing.Point(115, 170);
            this.textBoxCustName.Multiline = true;
            this.textBoxCustName.Name = "textBoxCustName";
            this.textBoxCustName.Size = new System.Drawing.Size(243, 22);
            this.textBoxCustName.TabIndex = 4;
            // 
            // labelDateRented
            // 
            this.labelDateRented.AutoSize = true;
            this.labelDateRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateRented.Location = new System.Drawing.Point(111, 234);
            this.labelDateRented.Name = "labelDateRented";
            this.labelDateRented.Size = new System.Drawing.Size(105, 20);
            this.labelDateRented.TabIndex = 5;
            this.labelDateRented.Text = "Date Rented:";
            // 
            // dateTimePickerDateRented
            // 
            this.dateTimePickerDateRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateRented.Location = new System.Drawing.Point(115, 261);
            this.dateTimePickerDateRented.Name = "dateTimePickerDateRented";
            this.dateTimePickerDateRented.Size = new System.Drawing.Size(243, 22);
            this.dateTimePickerDateRented.TabIndex = 6;
            // 
            // dateTimePickerDateToReturn
            // 
            this.dateTimePickerDateToReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateToReturn.Location = new System.Drawing.Point(455, 261);
            this.dateTimePickerDateToReturn.Name = "dateTimePickerDateToReturn";
            this.dateTimePickerDateToReturn.Size = new System.Drawing.Size(243, 22);
            this.dateTimePickerDateToReturn.TabIndex = 8;
            // 
            // labelDateToReturn
            // 
            this.labelDateToReturn.AutoSize = true;
            this.labelDateToReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateToReturn.Location = new System.Drawing.Point(451, 234);
            this.labelDateToReturn.Name = "labelDateToReturn";
            this.labelDateToReturn.Size = new System.Drawing.Size(123, 20);
            this.labelDateToReturn.TabIndex = 7;
            this.labelDateToReturn.Text = "Date To Return:";
            // 
            // buttonAddRentalRecord
            // 
            this.buttonAddRentalRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddRentalRecord.Location = new System.Drawing.Point(455, 325);
            this.buttonAddRentalRecord.Name = "buttonAddRentalRecord";
            this.buttonAddRentalRecord.Size = new System.Drawing.Size(166, 44);
            this.buttonAddRentalRecord.TabIndex = 9;
            this.buttonAddRentalRecord.Text = "Add Rental Record";
            this.buttonAddRentalRecord.UseVisualStyleBackColor = true;
            this.buttonAddRentalRecord.Click += new System.EventHandler(this.buttonAddRentalRecord_Click);
            // 
            // dropdownCarRented
            // 
            this.dropdownCarRented.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownCarRented.FormattingEnabled = true;
            this.dropdownCarRented.Location = new System.Drawing.Point(115, 348);
            this.dropdownCarRented.Name = "dropdownCarRented";
            this.dropdownCarRented.Size = new System.Drawing.Size(243, 21);
            this.dropdownCarRented.TabIndex = 10;
            // 
            // labelCarRented
            // 
            this.labelCarRented.AutoSize = true;
            this.labelCarRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCarRented.Location = new System.Drawing.Point(111, 325);
            this.labelCarRented.Name = "labelCarRented";
            this.labelCarRented.Size = new System.Drawing.Size(38, 20);
            this.labelCarRented.TabIndex = 11;
            this.labelCarRented.Text = "Car:";
            // 
            // textBoxCarCost
            // 
            this.textBoxCarCost.Location = new System.Drawing.Point(455, 170);
            this.textBoxCarCost.Multiline = true;
            this.textBoxCarCost.Name = "textBoxCarCost";
            this.textBoxCarCost.Size = new System.Drawing.Size(243, 22);
            this.textBoxCarCost.TabIndex = 13;
            // 
            // labelRentalCost
            // 
            this.labelRentalCost.AutoSize = true;
            this.labelRentalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRentalCost.Location = new System.Drawing.Point(451, 142);
            this.labelRentalCost.Name = "labelRentalCost";
            this.labelRentalCost.Size = new System.Drawing.Size(46, 20);
            this.labelRentalCost.TabIndex = 12;
            this.labelRentalCost.Text = "Cost:";
            // 
            // CheckoutRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxCarCost);
            this.Controls.Add(this.labelRentalCost);
            this.Controls.Add(this.labelCarRented);
            this.Controls.Add(this.dropdownCarRented);
            this.Controls.Add(this.buttonAddRentalRecord);
            this.Controls.Add(this.dateTimePickerDateToReturn);
            this.Controls.Add(this.labelDateToReturn);
            this.Controls.Add(this.dateTimePickerDateRented);
            this.Controls.Add(this.labelDateRented);
            this.Controls.Add(this.textBoxCustName);
            this.Controls.Add(this.labelCustName);
            this.Controls.Add(this.checkoutRentalCarTitle);
            this.Name = "CheckoutRental";
            this.Text = "Checkout Rental Car";
            this.Load += new System.EventHandler(this.CheckoutRental_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label checkoutRentalCarTitle;
        private System.Windows.Forms.Label labelCustName;
        private System.Windows.Forms.TextBox textBoxCustName;
        private System.Windows.Forms.Label labelDateRented;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateRented;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateToReturn;
        private System.Windows.Forms.Label labelDateToReturn;
        private System.Windows.Forms.Button buttonAddRentalRecord;
        private System.Windows.Forms.ComboBox dropdownCarRented;
        private System.Windows.Forms.Label labelCarRented;
        private System.Windows.Forms.TextBox textBoxCarCost;
        private System.Windows.Forms.Label labelRentalCost;
    }
}