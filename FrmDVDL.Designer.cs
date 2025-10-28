namespace Project_Driver_License_management
{
    partial class FrmDVDL
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_AccountSettings = new Guna.UI2.WinForms.Guna2Button();
            this.CMS_AccountSettings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.accToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.signOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Users = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Drivers = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_People = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Application = new Guna.UI2.WinForms.Guna2Button();
            this.CMS_Applications = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.drivingLicesnseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interNationalLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.renewDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replacmentForDamgeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseDetainedLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.retakeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.internationalDrivingLiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageApplicationsTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTestsTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageDetainedLicensesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detainLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox4 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.CentralPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.CMS_AccountSettings.SuspendLayout();
            this.CMS_Applications.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.Btn_AccountSettings);
            this.panel1.Controls.Add(this.Btn_Users);
            this.panel1.Controls.Add(this.Btn_Drivers);
            this.panel1.Controls.Add(this.Btn_People);
            this.panel1.Controls.Add(this.Btn_Application);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1393, 118);
            this.panel1.TabIndex = 0;
            // 
            // Btn_AccountSettings
            // 
            this.Btn_AccountSettings.AutoRoundedCorners = true;
            this.Btn_AccountSettings.BackColor = System.Drawing.Color.Teal;
            this.Btn_AccountSettings.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Btn_AccountSettings.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_AccountSettings.ContextMenuStrip = this.CMS_AccountSettings;
            this.Btn_AccountSettings.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_AccountSettings.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_AccountSettings.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_AccountSettings.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_AccountSettings.FillColor = System.Drawing.Color.Teal;
            this.Btn_AccountSettings.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_AccountSettings.ForeColor = System.Drawing.Color.Black;
            this.Btn_AccountSettings.Location = new System.Drawing.Point(832, 40);
            this.Btn_AccountSettings.Name = "Btn_AccountSettings";
            this.Btn_AccountSettings.Size = new System.Drawing.Size(167, 45);
            this.Btn_AccountSettings.TabIndex = 0;
            this.Btn_AccountSettings.Text = "Account Settings";
            this.Btn_AccountSettings.Click += new System.EventHandler(this.Btn_AccountSettings_Click);
            // 
            // CMS_AccountSettings
            // 
            this.CMS_AccountSettings.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMS_AccountSettings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.signOutToolStripMenuItem});
            this.CMS_AccountSettings.Name = "contextMenuStrip1";
            this.CMS_AccountSettings.Size = new System.Drawing.Size(198, 76);
            // 
            // accToolStripMenuItem
            // 
            this.accToolStripMenuItem.Name = "accToolStripMenuItem";
            this.accToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.accToolStripMenuItem.Text = "Currenet User Info";
            this.accToolStripMenuItem.Click += new System.EventHandler(this.accToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // signOutToolStripMenuItem
            // 
            this.signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            this.signOutToolStripMenuItem.Size = new System.Drawing.Size(197, 24);
            this.signOutToolStripMenuItem.Text = "Sign Out";
            this.signOutToolStripMenuItem.Click += new System.EventHandler(this.signOutToolStripMenuItem_Click);
            // 
            // Btn_Users
            // 
            this.Btn_Users.AutoRoundedCorners = true;
            this.Btn_Users.BackColor = System.Drawing.Color.Teal;
            this.Btn_Users.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Btn_Users.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Users.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Users.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Users.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Users.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Users.FillColor = System.Drawing.Color.Teal;
            this.Btn_Users.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Users.ForeColor = System.Drawing.Color.Black;
            this.Btn_Users.Location = new System.Drawing.Point(635, 40);
            this.Btn_Users.Name = "Btn_Users";
            this.Btn_Users.Size = new System.Drawing.Size(167, 45);
            this.Btn_Users.TabIndex = 0;
            this.Btn_Users.Text = "Users";
            this.Btn_Users.Click += new System.EventHandler(this.Btn_Users_Click);
            // 
            // Btn_Drivers
            // 
            this.Btn_Drivers.AutoRoundedCorners = true;
            this.Btn_Drivers.BackColor = System.Drawing.Color.Teal;
            this.Btn_Drivers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Btn_Drivers.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Drivers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Drivers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Drivers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Drivers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Drivers.FillColor = System.Drawing.Color.Teal;
            this.Btn_Drivers.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Drivers.ForeColor = System.Drawing.Color.Black;
            this.Btn_Drivers.Location = new System.Drawing.Point(413, 40);
            this.Btn_Drivers.Name = "Btn_Drivers";
            this.Btn_Drivers.Size = new System.Drawing.Size(167, 45);
            this.Btn_Drivers.TabIndex = 0;
            this.Btn_Drivers.Text = "Drivers";
            this.Btn_Drivers.Click += new System.EventHandler(this.Btn_Drivers_Click);
            // 
            // Btn_People
            // 
            this.Btn_People.AutoRoundedCorners = true;
            this.Btn_People.BackColor = System.Drawing.Color.Teal;
            this.Btn_People.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Btn_People.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_People.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_People.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_People.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_People.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_People.FillColor = System.Drawing.Color.Teal;
            this.Btn_People.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_People.ForeColor = System.Drawing.Color.Black;
            this.Btn_People.Location = new System.Drawing.Point(217, 40);
            this.Btn_People.Name = "Btn_People";
            this.Btn_People.Size = new System.Drawing.Size(167, 45);
            this.Btn_People.TabIndex = 0;
            this.Btn_People.Text = "People";
            this.Btn_People.Click += new System.EventHandler(this.Btn_People_Click);
            // 
            // Btn_Application
            // 
            this.Btn_Application.AutoRoundedCorners = true;
            this.Btn_Application.BackColor = System.Drawing.Color.Teal;
            this.Btn_Application.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Btn_Application.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Btn_Application.ContextMenuStrip = this.CMS_Applications;
            this.Btn_Application.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Application.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Application.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Application.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Application.FillColor = System.Drawing.Color.Teal;
            this.Btn_Application.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Application.ForeColor = System.Drawing.Color.Black;
            this.Btn_Application.Location = new System.Drawing.Point(12, 40);
            this.Btn_Application.Name = "Btn_Application";
            this.Btn_Application.Size = new System.Drawing.Size(167, 45);
            this.Btn_Application.TabIndex = 0;
            this.Btn_Application.Text = "Application";
            this.Btn_Application.Click += new System.EventHandler(this.Btn_Application_Click);
            // 
            // CMS_Applications
            // 
            this.CMS_Applications.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMS_Applications.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drivingLicesnseToolStripMenuItem,
            this.manageApplicationsToolStripMenuItem,
            this.manageApplicationsTypesToolStripMenuItem,
            this.manageTestsTypeToolStripMenuItem,
            this.detainLicensesToolStripMenuItem});
            this.CMS_Applications.Name = "CMS_Applications";
            this.CMS_Applications.Size = new System.Drawing.Size(261, 124);
            // 
            // drivingLicesnseToolStripMenuItem
            // 
            this.drivingLicesnseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDrivingLicenseToolStripMenuItem,
            this.renewDrivingLicenseToolStripMenuItem,
            this.replacmentForDamgeToolStripMenuItem,
            this.releaseDetainedLicenseToolStripMenuItem,
            this.retakeTestToolStripMenuItem});
            this.drivingLicesnseToolStripMenuItem.Name = "drivingLicesnseToolStripMenuItem";
            this.drivingLicesnseToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.drivingLicesnseToolStripMenuItem.Text = "Driving Licenses";
            this.drivingLicesnseToolStripMenuItem.Click += new System.EventHandler(this.drivingLicesnseToolStripMenuItem_Click);
            // 
            // newDrivingLicenseToolStripMenuItem
            // 
            this.newDrivingLicenseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localLicenseToolStripMenuItem,
            this.interNationalLicenseToolStripMenuItem});
            this.newDrivingLicenseToolStripMenuItem.Name = "newDrivingLicenseToolStripMenuItem";
            this.newDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(353, 26);
            this.newDrivingLicenseToolStripMenuItem.Text = "New Driving License";
            // 
            // localLicenseToolStripMenuItem
            // 
            this.localLicenseToolStripMenuItem.Name = "localLicenseToolStripMenuItem";
            this.localLicenseToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.localLicenseToolStripMenuItem.Text = "Local License ";
            this.localLicenseToolStripMenuItem.Click += new System.EventHandler(this.localLicenseToolStripMenuItem_Click);
            // 
            // interNationalLicenseToolStripMenuItem
            // 
            this.interNationalLicenseToolStripMenuItem.Name = "interNationalLicenseToolStripMenuItem";
            this.interNationalLicenseToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.interNationalLicenseToolStripMenuItem.Text = "Inter National License";
            this.interNationalLicenseToolStripMenuItem.Click += new System.EventHandler(this.interNationalLicenseToolStripMenuItem_Click);
            // 
            // renewDrivingLicenseToolStripMenuItem
            // 
            this.renewDrivingLicenseToolStripMenuItem.Name = "renewDrivingLicenseToolStripMenuItem";
            this.renewDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(353, 26);
            this.renewDrivingLicenseToolStripMenuItem.Text = "Renew Driving License";
            this.renewDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.renewDrivingLicenseToolStripMenuItem_Click);
            // 
            // replacmentForDamgeToolStripMenuItem
            // 
            this.replacmentForDamgeToolStripMenuItem.Name = "replacmentForDamgeToolStripMenuItem";
            this.replacmentForDamgeToolStripMenuItem.Size = new System.Drawing.Size(353, 26);
            this.replacmentForDamgeToolStripMenuItem.Text = "Replacment For Damge or Lose License";
            this.replacmentForDamgeToolStripMenuItem.Click += new System.EventHandler(this.replacmentForDamgeToolStripMenuItem_Click);
            // 
            // releaseDetainedLicenseToolStripMenuItem
            // 
            this.releaseDetainedLicenseToolStripMenuItem.Name = "releaseDetainedLicenseToolStripMenuItem";
            this.releaseDetainedLicenseToolStripMenuItem.Size = new System.Drawing.Size(353, 26);
            this.releaseDetainedLicenseToolStripMenuItem.Text = "Release Detained Driving License";
            // 
            // retakeTestToolStripMenuItem
            // 
            this.retakeTestToolStripMenuItem.Name = "retakeTestToolStripMenuItem";
            this.retakeTestToolStripMenuItem.Size = new System.Drawing.Size(353, 26);
            this.retakeTestToolStripMenuItem.Text = "Retake Test";
            // 
            // manageApplicationsToolStripMenuItem
            // 
            this.manageApplicationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localDrivingLicenseToolStripMenuItem,
            this.internationalDrivingLiToolStripMenuItem});
            this.manageApplicationsToolStripMenuItem.Name = "manageApplicationsToolStripMenuItem";
            this.manageApplicationsToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.manageApplicationsToolStripMenuItem.Text = "Manage Applications";
            // 
            // localDrivingLicenseToolStripMenuItem
            // 
            this.localDrivingLicenseToolStripMenuItem.Name = "localDrivingLicenseToolStripMenuItem";
            this.localDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.localDrivingLicenseToolStripMenuItem.Text = "Local Driving License ";
            this.localDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.localDrivingLicenseToolStripMenuItem_Click);
            // 
            // internationalDrivingLiToolStripMenuItem
            // 
            this.internationalDrivingLiToolStripMenuItem.Name = "internationalDrivingLiToolStripMenuItem";
            this.internationalDrivingLiToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.internationalDrivingLiToolStripMenuItem.Text = "International Driving License";
            this.internationalDrivingLiToolStripMenuItem.Click += new System.EventHandler(this.internationalDrivingLiToolStripMenuItem_Click);
            // 
            // manageApplicationsTypesToolStripMenuItem
            // 
            this.manageApplicationsTypesToolStripMenuItem.Name = "manageApplicationsTypesToolStripMenuItem";
            this.manageApplicationsTypesToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.manageApplicationsTypesToolStripMenuItem.Text = "Manage ApplicationsTypes ";
            this.manageApplicationsTypesToolStripMenuItem.Click += new System.EventHandler(this.manageApplicationsTypesToolStripMenuItem_Click);
            // 
            // manageTestsTypeToolStripMenuItem
            // 
            this.manageTestsTypeToolStripMenuItem.Name = "manageTestsTypeToolStripMenuItem";
            this.manageTestsTypeToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.manageTestsTypeToolStripMenuItem.Text = "Manage Tests Type";
            this.manageTestsTypeToolStripMenuItem.Click += new System.EventHandler(this.manageTestsTypeToolStripMenuItem_Click);
            // 
            // detainLicensesToolStripMenuItem
            // 
            this.detainLicensesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageDetainedLicensesToolStripMenuItem,
            this.detainLicenseToolStripMenuItem,
            this.releaseLicenseToolStripMenuItem});
            this.detainLicensesToolStripMenuItem.Name = "detainLicensesToolStripMenuItem";
            this.detainLicensesToolStripMenuItem.Size = new System.Drawing.Size(260, 24);
            this.detainLicensesToolStripMenuItem.Text = "Detain Licenses";
            // 
            // manageDetainedLicensesToolStripMenuItem
            // 
            this.manageDetainedLicensesToolStripMenuItem.Name = "manageDetainedLicensesToolStripMenuItem";
            this.manageDetainedLicensesToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.manageDetainedLicensesToolStripMenuItem.Text = "Manage Detained Licenses";
            this.manageDetainedLicensesToolStripMenuItem.Click += new System.EventHandler(this.manageDetainedLicensesToolStripMenuItem_Click);
            // 
            // detainLicenseToolStripMenuItem
            // 
            this.detainLicenseToolStripMenuItem.Name = "detainLicenseToolStripMenuItem";
            this.detainLicenseToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.detainLicenseToolStripMenuItem.Text = "Detain License";
            this.detainLicenseToolStripMenuItem.Click += new System.EventHandler(this.detainLicenseToolStripMenuItem_Click);
            // 
            // releaseLicenseToolStripMenuItem
            // 
            this.releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
            this.releaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(269, 26);
            this.releaseLicenseToolStripMenuItem.Text = "Release License";
            this.releaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseLicenseToolStripMenuItem_Click);
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1336, 12);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 1;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox2.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox2.Location = new System.Drawing.Point(1285, 12);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox2.TabIndex = 1;
            // 
            // guna2ControlBox4
            // 
            this.guna2ControlBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox4.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox4.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox4.Location = new System.Drawing.Point(1234, 12);
            this.guna2ControlBox4.Name = "guna2ControlBox4";
            this.guna2ControlBox4.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox4.TabIndex = 1;
            // 
            // CentralPanel
            // 
            this.CentralPanel.BackColor = System.Drawing.Color.Honeydew;
            this.CentralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CentralPanel.Location = new System.Drawing.Point(0, 118);
            this.CentralPanel.Name = "CentralPanel";
            this.CentralPanel.Size = new System.Drawing.Size(1393, 454);
            this.CentralPanel.TabIndex = 2;
            // 
            // FrmDVDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 572);
            this.Controls.Add(this.CentralPanel);
            this.Controls.Add(this.guna2ControlBox4);
            this.Controls.Add(this.guna2ControlBox2);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmDVDL";
            this.Text = "FrmDVDL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.CMS_AccountSettings.ResumeLayout(false);
            this.CMS_Applications.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Btn_Application;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox4;
        private Guna.UI2.WinForms.Guna2Button Btn_AccountSettings;
        private Guna.UI2.WinForms.Guna2Button Btn_Users;
        private Guna.UI2.WinForms.Guna2Button Btn_Drivers;
        private Guna.UI2.WinForms.Guna2Button Btn_People;
        private System.Windows.Forms.Panel CentralPanel;
        private System.Windows.Forms.ContextMenuStrip CMS_AccountSettings;
        private System.Windows.Forms.ToolStripMenuItem accToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem signOutToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMS_Applications;
        private System.Windows.Forms.ToolStripMenuItem drivingLicesnseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageApplicationsTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageTestsTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interNationalLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renewDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replacmentForDamgeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseDetainedLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem retakeTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem internationalDrivingLiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageDetainedLicensesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detainLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseLicenseToolStripMenuItem;
    }
}