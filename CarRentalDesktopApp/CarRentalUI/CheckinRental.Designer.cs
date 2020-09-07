namespace CarRentalDesktopApp.CarRentalUI
{
    partial class CheckinRental
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
            this.labelRentalCarReturn = new System.Windows.Forms.Label();
            this.dateTimePickerDateReturned = new System.Windows.Forms.DateTimePicker();
            this.labelDateReturned = new System.Windows.Forms.Label();
            this.labelCustName = new System.Windows.Forms.Label();
            this.checkinRentalCarTitle = new System.Windows.Forms.Label();
            this.buttonCheckinCar = new System.Windows.Forms.Button();
            this.dropdownCustName = new System.Windows.Forms.ComboBox();
            this.dropdownCarToReturn = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelRentalCarReturn
            // 
            this.labelRentalCarReturn.AutoSize = true;
            this.labelRentalCarReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRentalCarReturn.Location = new System.Drawing.Point(451, 141);
            this.labelRentalCarReturn.Name = "labelRentalCarReturn";
            this.labelRentalCarReturn.Size = new System.Drawing.Size(113, 20);
            this.labelRentalCarReturn.TabIndex = 19;
            this.labelRentalCarReturn.Text = "Car To Return:";
            // 
            // dateTimePickerDateReturned
            // 
            this.dateTimePickerDateReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerDateReturned.Location = new System.Drawing.Point(115, 260);
            this.dateTimePickerDateReturned.Name = "dateTimePickerDateReturned";
            this.dateTimePickerDateReturned.Size = new System.Drawing.Size(243, 22);
            this.dateTimePickerDateReturned.TabIndex = 18;
            // 
            // labelDateReturned
            // 
            this.labelDateReturned.AutoSize = true;
            this.labelDateReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateReturned.Location = new System.Drawing.Point(111, 233);
            this.labelDateReturned.Name = "labelDateReturned";
            this.labelDateReturned.Size = new System.Drawing.Size(119, 20);
            this.labelDateReturned.TabIndex = 17;
            this.labelDateReturned.Text = "Date Returned:";
            // 
            // labelCustName
            // 
            this.labelCustName.AutoSize = true;
            this.labelCustName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustName.Location = new System.Drawing.Point(111, 141);
            this.labelCustName.Name = "labelCustName";
            this.labelCustName.Size = new System.Drawing.Size(128, 20);
            this.labelCustName.TabIndex = 15;
            this.labelCustName.Text = "Customer Name:";
            // 
            // checkinRentalCarTitle
            // 
            this.checkinRentalCarTitle.AutoSize = true;
            this.checkinRentalCarTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinRentalCarTitle.Location = new System.Drawing.Point(195, 44);
            this.checkinRentalCarTitle.Name = "checkinRentalCarTitle";
            this.checkinRentalCarTitle.Size = new System.Drawing.Size(364, 47);
            this.checkinRentalCarTitle.TabIndex = 14;
            this.checkinRentalCarTitle.Text = "Check-in Rental Car";
            // 
            // buttonCheckinCar
            // 
            this.buttonCheckinCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckinCar.Location = new System.Drawing.Point(455, 238);
            this.buttonCheckinCar.Name = "buttonCheckinCar";
            this.buttonCheckinCar.Size = new System.Drawing.Size(166, 44);
            this.buttonCheckinCar.TabIndex = 21;
            this.buttonCheckinCar.Text = "Check-in Car";
            this.buttonCheckinCar.UseVisualStyleBackColor = true;
            this.buttonCheckinCar.Click += new System.EventHandler(this.buttonCheckinCar_Click);
            // 
            // dropdownCustName
            // 
            this.dropdownCustName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownCustName.FormattingEnabled = true;
            this.dropdownCustName.Location = new System.Drawing.Point(115, 170);
            this.dropdownCustName.Name = "dropdownCustName";
            this.dropdownCustName.Size = new System.Drawing.Size(243, 21);
            this.dropdownCustName.TabIndex = 22;
            this.dropdownCustName.SelectedIndexChanged += new System.EventHandler(this.dropdownCustName_SelectedIndexChanged);
            // 
            // dropdownCarToReturn
            // 
            this.dropdownCarToReturn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownCarToReturn.FormattingEnabled = true;
            this.dropdownCarToReturn.Location = new System.Drawing.Point(455, 170);
            this.dropdownCarToReturn.Name = "dropdownCarToReturn";
            this.dropdownCarToReturn.Size = new System.Drawing.Size(243, 21);
            this.dropdownCarToReturn.TabIndex = 23;
            // 
            // CheckinRental
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dropdownCarToReturn);
            this.Controls.Add(this.dropdownCustName);
            this.Controls.Add(this.buttonCheckinCar);
            this.Controls.Add(this.labelRentalCarReturn);
            this.Controls.Add(this.dateTimePickerDateReturned);
            this.Controls.Add(this.labelDateReturned);
            this.Controls.Add(this.labelCustName);
            this.Controls.Add(this.checkinRentalCarTitle);
            this.Name = "CheckinRental";
            this.Text = "Check-in Rental";
            this.Load += new System.EventHandler(this.CheckinRental_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRentalCarReturn;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateReturned;
        private System.Windows.Forms.Label labelDateReturned;
        private System.Windows.Forms.Label labelCustName;
        private System.Windows.Forms.Label checkinRentalCarTitle;
        private System.Windows.Forms.Button buttonCheckinCar;
        private System.Windows.Forms.ComboBox dropdownCustName;
        private System.Windows.Forms.ComboBox dropdownCarToReturn;
    }
}