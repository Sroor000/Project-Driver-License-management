namespace Project_Driver_License_management
{
    partial class US_Detainor_ReleaseLicenses
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_Detainor_ReleaseLicenses));
            this.Btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.Txt_SearchLicense = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_Fine = new System.Windows.Forms.TextBox();
            this.LB_GetFineFees = new System.Windows.Forms.Label();
            this.LB_DetainDate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_CreatedBY = new System.Windows.Forms.Label();
            this.LB_TotalFees = new System.Windows.Forms.Label();
            this.LB_License_Fees = new System.Windows.Forms.Label();
            this.LB_FeesApp = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LB_ShowTotalFees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LB_ShowApplicationFees = new System.Windows.Forms.Label();
            this.LB_DetainID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_LicenseID = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_ReNew = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2Button();
            this.LK_LB_ShowLinceseInfo = new System.Windows.Forms.LinkLabel();
            this.LKLB_ShowLIcenseHistory = new System.Windows.Forms.LinkLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LB_ShowAppID = new System.Windows.Forms.Label();
            this.LB_ShowFineFees = new System.Windows.Forms.Label();
            this.LB_AppID = new System.Windows.Forms.Label();
            this.LB_FineFees = new System.Windows.Forms.Label();
            this.uS_LicenseInfoCardcs1 = new Project_Driver_License_management.US_CardLicenseInfo();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Search
            // 
            this.Btn_Search.Animated = true;
            this.Btn_Search.AutoRoundedCorners = true;
            this.Btn_Search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Search.FillColor = System.Drawing.Color.Gainsboro;
            this.Btn_Search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Search.ForeColor = System.Drawing.Color.White;
            this.Btn_Search.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Search.Image")));
            this.Btn_Search.Location = new System.Drawing.Point(592, 31);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(56, 45);
            this.Btn_Search.TabIndex = 2;
            // 
            // Txt_SearchLicense
            // 
            this.Txt_SearchLicense.Location = new System.Drawing.Point(267, 46);
            this.Txt_SearchLicense.Name = "Txt_SearchLicense";
            this.Txt_SearchLicense.Size = new System.Drawing.Size(304, 30);
            this.Txt_SearchLicense.TabIndex = 1;
            this.Txt_SearchLicense.TextChanged += new System.EventHandler(this.Txt_SearchLicense_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Search);
            this.groupBox1.Controls.Add(this.Txt_SearchLicense);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(989, 100);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "License ID :";
            // 
            // Txt_Fine
            // 
            this.Txt_Fine.Location = new System.Drawing.Point(186, 134);
            this.Txt_Fine.Multiline = true;
            this.Txt_Fine.Name = "Txt_Fine";
            this.Txt_Fine.Size = new System.Drawing.Size(148, 29);
            this.Txt_Fine.TabIndex = 39;
            this.Txt_Fine.Visible = false;
            this.Txt_Fine.TextChanged += new System.EventHandler(this.Txt_Fine_TextChanged);
            // 
            // LB_GetFineFees
            // 
            this.LB_GetFineFees.AutoSize = true;
            this.LB_GetFineFees.Location = new System.Drawing.Point(26, 143);
            this.LB_GetFineFees.Name = "LB_GetFineFees";
            this.LB_GetFineFees.Size = new System.Drawing.Size(104, 20);
            this.LB_GetFineFees.TabIndex = 38;
            this.LB_GetFineFees.Text = "Fine Fees :";
            this.LB_GetFineFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_GetFineFees.Visible = false;
            // 
            // LB_DetainDate
            // 
            this.LB_DetainDate.AutoSize = true;
            this.LB_DetainDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DetainDate.Location = new System.Drawing.Point(182, 91);
            this.LB_DetainDate.Name = "LB_DetainDate";
            this.LB_DetainDate.Size = new System.Drawing.Size(51, 20);
            this.LB_DetainDate.TabIndex = 32;
            this.LB_DetainDate.Text = "[???]";
            this.LB_DetainDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Detain Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_CreatedBY
            // 
            this.LB_CreatedBY.AutoSize = true;
            this.LB_CreatedBY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CreatedBY.Location = new System.Drawing.Point(764, 91);
            this.LB_CreatedBY.Name = "LB_CreatedBY";
            this.LB_CreatedBY.Size = new System.Drawing.Size(51, 20);
            this.LB_CreatedBY.TabIndex = 28;
            this.LB_CreatedBY.Text = "[???]";
            this.LB_CreatedBY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_TotalFees
            // 
            this.LB_TotalFees.AutoSize = true;
            this.LB_TotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TotalFees.Location = new System.Drawing.Point(182, 175);
            this.LB_TotalFees.Name = "LB_TotalFees";
            this.LB_TotalFees.Size = new System.Drawing.Size(51, 20);
            this.LB_TotalFees.TabIndex = 27;
            this.LB_TotalFees.Text = "[???]";
            this.LB_TotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_TotalFees.Visible = false;
            // 
            // LB_License_Fees
            // 
            this.LB_License_Fees.AutoSize = true;
            this.LB_License_Fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_License_Fees.Location = new System.Drawing.Point(283, 217);
            this.LB_License_Fees.Name = "LB_License_Fees";
            this.LB_License_Fees.Size = new System.Drawing.Size(0, 20);
            this.LB_License_Fees.TabIndex = 27;
            this.LB_License_Fees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_FeesApp
            // 
            this.LB_FeesApp.AutoSize = true;
            this.LB_FeesApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FeesApp.Location = new System.Drawing.Point(182, 143);
            this.LB_FeesApp.Name = "LB_FeesApp";
            this.LB_FeesApp.Size = new System.Drawing.Size(51, 20);
            this.LB_FeesApp.TabIndex = 27;
            this.LB_FeesApp.Text = "[???]";
            this.LB_FeesApp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_FeesApp.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(556, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "Created BY : ";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_ShowTotalFees
            // 
            this.LB_ShowTotalFees.AutoSize = true;
            this.LB_ShowTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ShowTotalFees.Location = new System.Drawing.Point(26, 175);
            this.LB_ShowTotalFees.Name = "LB_ShowTotalFees";
            this.LB_ShowTotalFees.Size = new System.Drawing.Size(110, 20);
            this.LB_ShowTotalFees.TabIndex = 25;
            this.LB_ShowTotalFees.Text = "Total Fees :";
            this.LB_ShowTotalFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_ShowTotalFees.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 217);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 20);
            this.label8.TabIndex = 25;
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_ShowApplicationFees
            // 
            this.LB_ShowApplicationFees.AutoSize = true;
            this.LB_ShowApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ShowApplicationFees.Location = new System.Drawing.Point(26, 143);
            this.LB_ShowApplicationFees.Name = "LB_ShowApplicationFees";
            this.LB_ShowApplicationFees.Size = new System.Drawing.Size(161, 20);
            this.LB_ShowApplicationFees.TabIndex = 25;
            this.LB_ShowApplicationFees.Text = "Application Fees :";
            this.LB_ShowApplicationFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_ShowApplicationFees.Visible = false;
            // 
            // LB_DetainID
            // 
            this.LB_DetainID.AutoSize = true;
            this.LB_DetainID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DetainID.Location = new System.Drawing.Point(182, 49);
            this.LB_DetainID.Name = "LB_DetainID";
            this.LB_DetainID.Size = new System.Drawing.Size(51, 20);
            this.LB_DetainID.TabIndex = 23;
            this.LB_DetainID.Text = "[???]";
            this.LB_DetainID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Detain ID :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_LicenseID
            // 
            this.LB_LicenseID.AutoSize = true;
            this.LB_LicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LicenseID.Location = new System.Drawing.Point(764, 47);
            this.LB_LicenseID.Name = "LB_LicenseID";
            this.LB_LicenseID.Size = new System.Drawing.Size(51, 20);
            this.LB_LicenseID.TabIndex = 23;
            this.LB_LicenseID.Text = "[???]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(556, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "License ID :";
            // 
            // Btn_ReNew
            // 
            this.Btn_ReNew.AutoRoundedCorners = true;
            this.Btn_ReNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_ReNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_ReNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_ReNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_ReNew.Enabled = false;
            this.Btn_ReNew.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_ReNew.ForeColor = System.Drawing.Color.White;
            this.Btn_ReNew.Location = new System.Drawing.Point(903, 780);
            this.Btn_ReNew.Name = "Btn_ReNew";
            this.Btn_ReNew.Size = new System.Drawing.Size(138, 45);
            this.Btn_ReNew.TabIndex = 32;
            this.Btn_ReNew.Text = "Detain";
            // 
            // Btn_Close
            // 
            this.Btn_Close.AutoRoundedCorners = true;
            this.Btn_Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Close.FillColor = System.Drawing.Color.Red;
            this.Btn_Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Close.ForeColor = System.Drawing.Color.White;
            this.Btn_Close.Location = new System.Drawing.Point(704, 780);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(119, 45);
            this.Btn_Close.TabIndex = 31;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // LK_LB_ShowLinceseInfo
            // 
            this.LK_LB_ShowLinceseInfo.AutoSize = true;
            this.LK_LB_ShowLinceseInfo.Enabled = false;
            this.LK_LB_ShowLinceseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LK_LB_ShowLinceseInfo.Location = new System.Drawing.Point(241, 794);
            this.LK_LB_ShowLinceseInfo.Name = "LK_LB_ShowLinceseInfo";
            this.LK_LB_ShowLinceseInfo.Size = new System.Drawing.Size(163, 20);
            this.LK_LB_ShowLinceseInfo.TabIndex = 29;
            this.LK_LB_ShowLinceseInfo.TabStop = true;
            this.LK_LB_ShowLinceseInfo.Text = "Show License Info";
            this.LK_LB_ShowLinceseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LK_LB_ShowLinceseInfo_LinkClicked);
            // 
            // LKLB_ShowLIcenseHistory
            // 
            this.LKLB_ShowLIcenseHistory.AutoSize = true;
            this.LKLB_ShowLIcenseHistory.Enabled = false;
            this.LKLB_ShowLIcenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LKLB_ShowLIcenseHistory.Location = new System.Drawing.Point(31, 794);
            this.LKLB_ShowLIcenseHistory.Name = "LKLB_ShowLIcenseHistory";
            this.LKLB_ShowLIcenseHistory.Size = new System.Drawing.Size(193, 20);
            this.LKLB_ShowLIcenseHistory.TabIndex = 30;
            this.LKLB_ShowLIcenseHistory.TabStop = true;
            this.LKLB_ShowLIcenseHistory.Text = "Show LIcense History";
            this.LKLB_ShowLIcenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LKLB_ShowLIcenseHistory_LinkClicked);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Txt_Fine);
            this.groupBox2.Controls.Add(this.LB_ShowAppID);
            this.groupBox2.Controls.Add(this.LB_ShowFineFees);
            this.groupBox2.Controls.Add(this.LB_GetFineFees);
            this.groupBox2.Controls.Add(this.LB_DetainDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.LB_CreatedBY);
            this.groupBox2.Controls.Add(this.LB_TotalFees);
            this.groupBox2.Controls.Add(this.LB_AppID);
            this.groupBox2.Controls.Add(this.LB_License_Fees);
            this.groupBox2.Controls.Add(this.LB_FineFees);
            this.groupBox2.Controls.Add(this.LB_FeesApp);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.LB_ShowTotalFees);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.LB_ShowApplicationFees);
            this.groupBox2.Controls.Add(this.LB_DetainID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.LB_LicenseID);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(35, 536);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1006, 233);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Baisc application Info : ";
            // 
            // LB_ShowAppID
            // 
            this.LB_ShowAppID.AutoSize = true;
            this.LB_ShowAppID.Location = new System.Drawing.Point(556, 163);
            this.LB_ShowAppID.Name = "LB_ShowAppID";
            this.LB_ShowAppID.Size = new System.Drawing.Size(133, 20);
            this.LB_ShowAppID.TabIndex = 38;
            this.LB_ShowAppID.Text = "Application ID:";
            this.LB_ShowAppID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_ShowAppID.Visible = false;
            // 
            // LB_ShowFineFees
            // 
            this.LB_ShowFineFees.AutoSize = true;
            this.LB_ShowFineFees.Location = new System.Drawing.Point(556, 134);
            this.LB_ShowFineFees.Name = "LB_ShowFineFees";
            this.LB_ShowFineFees.Size = new System.Drawing.Size(104, 20);
            this.LB_ShowFineFees.TabIndex = 38;
            this.LB_ShowFineFees.Text = "Fine Fees :";
            this.LB_ShowFineFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_ShowFineFees.Visible = false;
            // 
            // LB_AppID
            // 
            this.LB_AppID.AutoSize = true;
            this.LB_AppID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_AppID.Location = new System.Drawing.Point(764, 163);
            this.LB_AppID.Name = "LB_AppID";
            this.LB_AppID.Size = new System.Drawing.Size(51, 20);
            this.LB_AppID.TabIndex = 27;
            this.LB_AppID.Text = "[???]";
            this.LB_AppID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_AppID.Visible = false;
            // 
            // LB_FineFees
            // 
            this.LB_FineFees.AutoSize = true;
            this.LB_FineFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FineFees.Location = new System.Drawing.Point(764, 134);
            this.LB_FineFees.Name = "LB_FineFees";
            this.LB_FineFees.Size = new System.Drawing.Size(51, 20);
            this.LB_FineFees.TabIndex = 27;
            this.LB_FineFees.Text = "[???]";
            this.LB_FineFees.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LB_FineFees.Visible = false;
            // 
            // uS_LicenseInfoCardcs1
            // 
            this.uS_LicenseInfoCardcs1.Location = new System.Drawing.Point(11, 109);
            this.uS_LicenseInfoCardcs1.Name = "uS_LicenseInfoCardcs1";
            this.uS_LicenseInfoCardcs1.Size = new System.Drawing.Size(1030, 421);
            this.uS_LicenseInfoCardcs1.TabIndex = 33;
            // 
            // US_Detainor_ReleaseLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uS_LicenseInfoCardcs1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_ReNew);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.LK_LB_ShowLinceseInfo);
            this.Controls.Add(this.LKLB_ShowLIcenseHistory);
            this.Controls.Add(this.groupBox2);
            this.Name = "US_Detainor_ReleaseLicenses";
            this.Size = new System.Drawing.Size(1054, 844);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private US_CardLicenseInfo uS_LicenseInfoCardcs1;
        private Guna.UI2.WinForms.Guna2Button Btn_Search;
        private System.Windows.Forms.TextBox Txt_SearchLicense;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Fine;
        private System.Windows.Forms.Label LB_GetFineFees;
        private System.Windows.Forms.Label LB_DetainDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_CreatedBY;
        private System.Windows.Forms.Label LB_TotalFees;
        private System.Windows.Forms.Label LB_License_Fees;
        private System.Windows.Forms.Label LB_FeesApp;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label LB_ShowTotalFees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LB_ShowApplicationFees;
        private System.Windows.Forms.Label LB_DetainID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LB_LicenseID;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button Btn_ReNew;
        private Guna.UI2.WinForms.Guna2Button Btn_Close;
        private System.Windows.Forms.LinkLabel LK_LB_ShowLinceseInfo;
        private System.Windows.Forms.LinkLabel LKLB_ShowLIcenseHistory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label LB_ShowFineFees;
        private System.Windows.Forms.Label LB_FineFees;
        private System.Windows.Forms.Label LB_ShowAppID;
        private System.Windows.Forms.Label LB_AppID;
    }
}
