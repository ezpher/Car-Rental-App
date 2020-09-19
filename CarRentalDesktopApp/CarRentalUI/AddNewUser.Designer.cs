namespace CarRentalDesktopApp.CarRentalUI
{
    partial class AddNewUser
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
            this.labelRole = new System.Windows.Forms.Label();
            this.dropdownRoles = new System.Windows.Forms.ComboBox();
            this.textBoxNewUsername = new System.Windows.Forms.TextBox();
            this.labelNewUsername = new System.Windows.Forms.Label();
            this.addNewUserTitle = new System.Windows.Forms.Label();
            this.buttonAddNewUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(128, 244);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(46, 20);
            this.labelRole.TabIndex = 16;
            this.labelRole.Text = "Role:";
            // 
            // dropdownRoles
            // 
            this.dropdownRoles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdownRoles.FormattingEnabled = true;
            this.dropdownRoles.Location = new System.Drawing.Point(132, 267);
            this.dropdownRoles.Name = "dropdownRoles";
            this.dropdownRoles.Size = new System.Drawing.Size(243, 21);
            this.dropdownRoles.TabIndex = 15;
            // 
            // textBoxNewUsername
            // 
            this.textBoxNewUsername.Location = new System.Drawing.Point(132, 184);
            this.textBoxNewUsername.Multiline = true;
            this.textBoxNewUsername.Name = "textBoxNewUsername";
            this.textBoxNewUsername.Size = new System.Drawing.Size(243, 22);
            this.textBoxNewUsername.TabIndex = 14;
            // 
            // labelNewUsername
            // 
            this.labelNewUsername.AutoSize = true;
            this.labelNewUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNewUsername.Location = new System.Drawing.Point(128, 156);
            this.labelNewUsername.Name = "labelNewUsername";
            this.labelNewUsername.Size = new System.Drawing.Size(87, 20);
            this.labelNewUsername.TabIndex = 13;
            this.labelNewUsername.Text = "Username:";
            // 
            // addNewUserTitle
            // 
            this.addNewUserTitle.AutoSize = true;
            this.addNewUserTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewUserTitle.Location = new System.Drawing.Point(91, 56);
            this.addNewUserTitle.Name = "addNewUserTitle";
            this.addNewUserTitle.Size = new System.Drawing.Size(312, 47);
            this.addNewUserTitle.TabIndex = 12;
            this.addNewUserTitle.Text = "Add New User";
            // 
            // buttonAddNewUser
            // 
            this.buttonAddNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddNewUser.Location = new System.Drawing.Point(162, 341);
            this.buttonAddNewUser.Name = "buttonAddNewUser";
            this.buttonAddNewUser.Size = new System.Drawing.Size(166, 44);
            this.buttonAddNewUser.TabIndex = 17;
            this.buttonAddNewUser.Text = "Add User";
            this.buttonAddNewUser.UseVisualStyleBackColor = true;
            this.buttonAddNewUser.Click += new System.EventHandler(this.buttonAddNewUser_Click);
            // 
            // AddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 483);
            this.Controls.Add(this.buttonAddNewUser);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.dropdownRoles);
            this.Controls.Add(this.textBoxNewUsername);
            this.Controls.Add(this.labelNewUsername);
            this.Controls.Add(this.addNewUserTitle);
            this.Name = "AddNewUser";
            this.Text = "Add New User";
            this.Load += new System.EventHandler(this.AddNewUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.ComboBox dropdownRoles;
        private System.Windows.Forms.TextBox textBoxNewUsername;
        private System.Windows.Forms.Label labelNewUsername;
        private System.Windows.Forms.Label addNewUserTitle;
        private System.Windows.Forms.Button buttonAddNewUser;
    }
}