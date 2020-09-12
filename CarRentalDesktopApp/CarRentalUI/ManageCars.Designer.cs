namespace CarRentalDesktopApp.CarRentalUI
{
    partial class ManageCars
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
            this.buttonAddCar = new System.Windows.Forms.Button();
            this.checkinRentalCarTitle = new System.Windows.Forms.Label();
            this.buttonUpdateCar = new System.Windows.Forms.Button();
            this.buttonRemoveCar = new System.Windows.Forms.Button();
            this.dataGridViewManageCars = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageCars)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddCar
            // 
            this.buttonAddCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddCar.Location = new System.Drawing.Point(599, 132);
            this.buttonAddCar.Name = "buttonAddCar";
            this.buttonAddCar.Size = new System.Drawing.Size(166, 44);
            this.buttonAddCar.TabIndex = 23;
            this.buttonAddCar.Text = "Add Car";
            this.buttonAddCar.UseVisualStyleBackColor = true;
            this.buttonAddCar.Click += new System.EventHandler(this.buttonAddCar_Click);
            // 
            // checkinRentalCarTitle
            // 
            this.checkinRentalCarTitle.AutoSize = true;
            this.checkinRentalCarTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkinRentalCarTitle.Location = new System.Drawing.Point(256, 47);
            this.checkinRentalCarTitle.Name = "checkinRentalCarTitle";
            this.checkinRentalCarTitle.Size = new System.Drawing.Size(255, 47);
            this.checkinRentalCarTitle.TabIndex = 22;
            this.checkinRentalCarTitle.Text = "Manage Cars";
            // 
            // buttonUpdateCar
            // 
            this.buttonUpdateCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateCar.Location = new System.Drawing.Point(599, 208);
            this.buttonUpdateCar.Name = "buttonUpdateCar";
            this.buttonUpdateCar.Size = new System.Drawing.Size(166, 44);
            this.buttonUpdateCar.TabIndex = 24;
            this.buttonUpdateCar.Text = "Update Car";
            this.buttonUpdateCar.UseVisualStyleBackColor = true;
            this.buttonUpdateCar.Click += new System.EventHandler(this.buttonUpdateCar_Click);
            // 
            // buttonRemoveCar
            // 
            this.buttonRemoveCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRemoveCar.Location = new System.Drawing.Point(599, 287);
            this.buttonRemoveCar.Name = "buttonRemoveCar";
            this.buttonRemoveCar.Size = new System.Drawing.Size(166, 44);
            this.buttonRemoveCar.TabIndex = 24;
            this.buttonRemoveCar.Text = "Remove Car";
            this.buttonRemoveCar.UseVisualStyleBackColor = true;
            this.buttonRemoveCar.Click += new System.EventHandler(this.buttonRemoveCar_Click);
            // 
            // dataGridViewManageCars
            // 
            this.dataGridViewManageCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageCars.Location = new System.Drawing.Point(28, 132);
            this.dataGridViewManageCars.Name = "dataGridViewManageCars";
            this.dataGridViewManageCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewManageCars.Size = new System.Drawing.Size(542, 199);
            this.dataGridViewManageCars.TabIndex = 25;
            // 
            // ManageCars
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewManageCars);
            this.Controls.Add(this.buttonRemoveCar);
            this.Controls.Add(this.buttonUpdateCar);
            this.Controls.Add(this.buttonAddCar);
            this.Controls.Add(this.checkinRentalCarTitle);
            this.Name = "ManageCars";
            this.Text = "Manage Cars";
            this.Load += new System.EventHandler(this.ManageCars_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddCar;
        private System.Windows.Forms.Label checkinRentalCarTitle;
        private System.Windows.Forms.Button buttonUpdateCar;
        private System.Windows.Forms.Button buttonRemoveCar;
        private System.Windows.Forms.DataGridView dataGridViewManageCars;
    }
}