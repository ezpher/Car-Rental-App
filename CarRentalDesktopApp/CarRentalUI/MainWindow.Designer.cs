namespace CarRentalDesktopApp
{
    partial class MainWindow
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
            this.mainWindowTitle = new System.Windows.Forms.Label();
            this.panelMainWindowTitle = new System.Windows.Forms.Panel();
            this.menuStripMainWindow = new System.Windows.Forms.MenuStrip();
            this.manageRentalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkoutCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkinCarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCarsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCarsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMainWindow = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelLoginUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMainWindow.SuspendLayout();
            this.statusStripMainWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainWindowTitle
            // 
            this.mainWindowTitle.AutoSize = true;
            this.mainWindowTitle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.mainWindowTitle.Font = new System.Drawing.Font("Matura MT Script Capitals", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainWindowTitle.Location = new System.Drawing.Point(398, 9);
            this.mainWindowTitle.Name = "mainWindowTitle";
            this.mainWindowTitle.Size = new System.Drawing.Size(569, 47);
            this.mainWindowTitle.TabIndex = 1;
            this.mainWindowTitle.Text = "Rental Car Management System";
            // 
            // panelMainWindowTitle
            // 
            this.panelMainWindowTitle.BackColor = System.Drawing.SystemColors.MenuBar;
            this.panelMainWindowTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMainWindowTitle.Location = new System.Drawing.Point(0, 24);
            this.panelMainWindowTitle.Name = "panelMainWindowTitle";
            this.panelMainWindowTitle.Size = new System.Drawing.Size(979, 48);
            this.panelMainWindowTitle.TabIndex = 3;
            // 
            // menuStripMainWindow
            // 
            this.menuStripMainWindow.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStripMainWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageRentalsToolStripMenuItem,
            this.manageCarsToolStripMenuItem,
            this.AdminToolStripMenuItem});
            this.menuStripMainWindow.Location = new System.Drawing.Point(0, 0);
            this.menuStripMainWindow.Name = "menuStripMainWindow";
            this.menuStripMainWindow.Size = new System.Drawing.Size(979, 24);
            this.menuStripMainWindow.TabIndex = 4;
            this.menuStripMainWindow.Text = "menuStrip1";
            // 
            // manageRentalsToolStripMenuItem
            // 
            this.manageRentalsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkoutCarToolStripMenuItem,
            this.checkinCarToolStripMenuItem});
            this.manageRentalsToolStripMenuItem.Name = "manageRentalsToolStripMenuItem";
            this.manageRentalsToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.manageRentalsToolStripMenuItem.Text = "Manage Rentals";
            // 
            // checkoutCarToolStripMenuItem
            // 
            this.checkoutCarToolStripMenuItem.Name = "checkoutCarToolStripMenuItem";
            this.checkoutCarToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.checkoutCarToolStripMenuItem.Text = "Checkout Car";
            this.checkoutCarToolStripMenuItem.Click += new System.EventHandler(this.checkoutCarToolStripMenuItem_Click);
            // 
            // checkinCarToolStripMenuItem
            // 
            this.checkinCarToolStripMenuItem.Name = "checkinCarToolStripMenuItem";
            this.checkinCarToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.checkinCarToolStripMenuItem.Text = "Check-in Car";
            this.checkinCarToolStripMenuItem.Click += new System.EventHandler(this.checkinCarToolStripMenuItem_Click);
            // 
            // manageCarsToolStripMenuItem
            // 
            this.manageCarsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCarsToolStripMenuItem1});
            this.manageCarsToolStripMenuItem.Name = "manageCarsToolStripMenuItem";
            this.manageCarsToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.manageCarsToolStripMenuItem.Text = "Manage Cars";
            // 
            // manageCarsToolStripMenuItem1
            // 
            this.manageCarsToolStripMenuItem1.Name = "manageCarsToolStripMenuItem1";
            this.manageCarsToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.manageCarsToolStripMenuItem1.Text = "Manage Cars";
            this.manageCarsToolStripMenuItem1.Click += new System.EventHandler(this.manageCarsToolStripMenuItem1_Click);
            // 
            // AdminToolStripMenuItem
            // 
            this.AdminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUsersToolStripMenuItem});
            this.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem";
            this.AdminToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.AdminToolStripMenuItem.Text = "Administration";
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            this.manageUsersToolStripMenuItem.Click += new System.EventHandler(this.manageUsersToolStripMenuItem_Click);
            // 
            // statusStripMainWindow
            // 
            this.statusStripMainWindow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelLoginUser});
            this.statusStripMainWindow.Location = new System.Drawing.Point(0, 428);
            this.statusStripMainWindow.Name = "statusStripMainWindow";
            this.statusStripMainWindow.Size = new System.Drawing.Size(979, 22);
            this.statusStripMainWindow.TabIndex = 6;
            this.statusStripMainWindow.Text = "statusStripMainWindow";
            // 
            // toolStripStatusLabelLoginUser
            // 
            this.toolStripStatusLabelLoginUser.Name = "toolStripStatusLabelLoginUser";
            this.toolStripStatusLabelLoginUser.Size = new System.Drawing.Size(165, 17);
            this.toolStripStatusLabelLoginUser.Text = "toolStripStatusLabelLoginUser";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 450);
            this.Controls.Add(this.statusStripMainWindow);
            this.Controls.Add(this.mainWindowTitle);
            this.Controls.Add(this.panelMainWindowTitle);
            this.Controls.Add(this.menuStripMainWindow);
            this.IsMdiContainer = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Car Rental Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.menuStripMainWindow.ResumeLayout(false);
            this.menuStripMainWindow.PerformLayout();
            this.statusStripMainWindow.ResumeLayout(false);
            this.statusStripMainWindow.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label mainWindowTitle;
        private System.Windows.Forms.Panel panelMainWindowTitle;
        private System.Windows.Forms.MenuStrip menuStripMainWindow;
        private System.Windows.Forms.ToolStripMenuItem manageRentalsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkoutCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkinCarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCarsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCarsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStripMainWindow;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLoginUser;
    }
}

