namespace CarRentalDesktopApp.CarRentalUI
{
    partial class ResetPasswordOnLogin
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
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxResetPassword = new System.Windows.Forms.TextBox();
            this.labelResetPassword = new System.Windows.Forms.Label();
            this.resetPasswordTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(197, 226);
            this.textBoxConfirmPassword.Multiline = true;
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '*';
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(242, 22);
            this.textBoxConfirmPassword.TabIndex = 20;
            this.textBoxConfirmPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxConfirmPassword_KeyPress);
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConfirmPassword.Location = new System.Drawing.Point(50, 228);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(141, 20);
            this.labelConfirmPassword.TabIndex = 19;
            this.labelConfirmPassword.Text = "Confirm Password:";
            // 
            // buttonReset
            // 
            this.buttonReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReset.Location = new System.Drawing.Point(177, 302);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(96, 43);
            this.buttonReset.TabIndex = 21;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxResetPassword
            // 
            this.textBoxResetPassword.Location = new System.Drawing.Point(197, 166);
            this.textBoxResetPassword.Multiline = true;
            this.textBoxResetPassword.Name = "textBoxResetPassword";
            this.textBoxResetPassword.PasswordChar = '*';
            this.textBoxResetPassword.Size = new System.Drawing.Size(242, 22);
            this.textBoxResetPassword.TabIndex = 18;
            this.textBoxResetPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxResetPassword_KeyPress);
            // 
            // labelResetPassword
            // 
            this.labelResetPassword.AutoSize = true;
            this.labelResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResetPassword.Location = new System.Drawing.Point(50, 168);
            this.labelResetPassword.Name = "labelResetPassword";
            this.labelResetPassword.Size = new System.Drawing.Size(129, 20);
            this.labelResetPassword.TabIndex = 17;
            this.labelResetPassword.Text = "Reset Password:";
            // 
            // resetPasswordTitle
            // 
            this.resetPasswordTitle.AutoSize = true;
            this.resetPasswordTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPasswordTitle.Location = new System.Drawing.Point(100, 62);
            this.resetPasswordTitle.Name = "resetPasswordTitle";
            this.resetPasswordTitle.Size = new System.Drawing.Size(300, 47);
            this.resetPasswordTitle.TabIndex = 16;
            this.resetPasswordTitle.Text = "Reset Password";
            // 
            // ResetPasswordOnLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 483);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.textBoxResetPassword);
            this.Controls.Add(this.labelResetPassword);
            this.Controls.Add(this.resetPasswordTitle);
            this.Name = "ResetPasswordOnLogin";
            this.Text = "Reset Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxResetPassword;
        private System.Windows.Forms.Label labelResetPassword;
        private System.Windows.Forms.Label resetPasswordTitle;
    }
}