namespace CarRentalDesktopApp.CarRentalUI
{
    partial class ManageUsers
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
            this.dataGridViewManageUsers = new System.Windows.Forms.DataGridView();
            this.buttonActivateDeactivateUser = new System.Windows.Forms.Button();
            this.buttonResetPassword = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.manageUsersTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewManageUsers
            // 
            this.dataGridViewManageUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewManageUsers.Location = new System.Drawing.Point(176, 126);
            this.dataGridViewManageUsers.Name = "dataGridViewManageUsers";
            this.dataGridViewManageUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewManageUsers.Size = new System.Drawing.Size(442, 199);
            this.dataGridViewManageUsers.TabIndex = 30;
            // 
            // buttonActivateDeactivateUser
            // 
            this.buttonActivateDeactivateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonActivateDeactivateUser.Location = new System.Drawing.Point(570, 371);
            this.buttonActivateDeactivateUser.Name = "buttonActivateDeactivateUser";
            this.buttonActivateDeactivateUser.Size = new System.Drawing.Size(159, 53);
            this.buttonActivateDeactivateUser.TabIndex = 28;
            this.buttonActivateDeactivateUser.Text = "Activate/Deactivate User";
            this.buttonActivateDeactivateUser.UseVisualStyleBackColor = true;
            this.buttonActivateDeactivateUser.Click += new System.EventHandler(this.buttonActivateDeactivateUser_Click);
            // 
            // buttonResetPassword
            // 
            this.buttonResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResetPassword.Location = new System.Drawing.Point(330, 371);
            this.buttonResetPassword.Name = "buttonResetPassword";
            this.buttonResetPassword.Size = new System.Drawing.Size(166, 53);
            this.buttonResetPassword.TabIndex = 29;
            this.buttonResetPassword.Text = "Reset Password";
            this.buttonResetPassword.UseVisualStyleBackColor = true;
            this.buttonResetPassword.Click += new System.EventHandler(this.buttonResetPassword_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddUser.Location = new System.Drawing.Point(86, 371);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(166, 53);
            this.buttonAddUser.TabIndex = 27;
            this.buttonAddUser.Text = "Add New User";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // manageUsersTitle
            // 
            this.manageUsersTitle.AutoSize = true;
            this.manageUsersTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageUsersTitle.Location = new System.Drawing.Point(255, 56);
            this.manageUsersTitle.Name = "manageUsersTitle";
            this.manageUsersTitle.Size = new System.Drawing.Size(280, 47);
            this.manageUsersTitle.TabIndex = 26;
            this.manageUsersTitle.Text = "Manage Users";
            // 
            // ManageUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewManageUsers);
            this.Controls.Add(this.buttonActivateDeactivateUser);
            this.Controls.Add(this.buttonResetPassword);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.manageUsersTitle);
            this.Name = "ManageUsers";
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewManageUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewManageUsers;
        private System.Windows.Forms.Button buttonActivateDeactivateUser;
        private System.Windows.Forms.Button buttonResetPassword;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Label manageUsersTitle;
    }
}