namespace Project_Driver_License_management
{
    partial class US_FindLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_FindLicense));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Search = new Guna.UI2.WinForms.Guna2Button();
            this.Txt_SearchLicense = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LB_IssueDate = new System.Windows.Forms.Label();
            this.LB_ExpirationDateLicense = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.LB_CreatedBY = new System.Windows.Forms.Label();
            this.LB_FeesApp = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LB_DateApp = new System.Windows.Forms.Label();
            this.LB_I_LicenseApplication = new System.Windows.Forms.Label();
            this.LB_LLicenseID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_ILicenseID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LKLB_ShowLIcenseHistory = new System.Windows.Forms.LinkLabel();
            this.LK_LB_ShowLinceseInfo = new System.Windows.Forms.LinkLabel();
            this.Btn_Issue = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Close = new Guna.UI2.WinForms.Guna2Button();
            this.uS_LicenseInfoCardcs1 = new Project_Driver_License_management.US_CardLicenseInfo();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Search);
            this.groupBox1.Controls.Add(this.Txt_SearchLicense);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1026, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
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
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Txt_SearchLicense
            // 
            this.Txt_SearchLicense.Location = new System.Drawing.Point(267, 46);
            this.Txt_SearchLicense.Name = "Txt_SearchLicense";
            this.Txt_SearchLicense.Size = new System.Drawing.Size(304, 30);
            this.Txt_SearchLicense.TabIndex = 1;
            this.Txt_SearchLicense.TextChanged += new System.EventHandler(this.Txt_SearchLicense_TextChanged);
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.LB_IssueDate);
            this.groupBox2.Controls.Add(this.LB_ExpirationDateLicense);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.LB_CreatedBY);
            this.groupBox2.Controls.Add(this.LB_FeesApp);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.LB_DateApp);
            this.groupBox2.Controls.Add(this.LB_I_LicenseApplication);
            this.groupBox2.Controls.Add(this.LB_LLicenseID);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.LB_ILicenseID);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(27, 550);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1006, 237);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Baisc application Info : ";
            // 
            // LB_IssueDate
            // 
            this.LB_IssueDate.AutoSize = true;
            this.LB_IssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_IssueDate.Location = new System.Drawing.Point(275, 129);
            this.LB_IssueDate.Name = "LB_IssueDate";
            this.LB_IssueDate.Size = new System.Drawing.Size(51, 20);
            this.LB_IssueDate.TabIndex = 32;
            this.LB_IssueDate.Text = "[???]";
            // 
            // LB_ExpirationDateLicense
            // 
            this.LB_ExpirationDateLicense.AutoSize = true;
            this.LB_ExpirationDateLicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ExpirationDateLicense.Location = new System.Drawing.Point(764, 153);
            this.LB_ExpirationDateLicense.Name = "LB_ExpirationDateLicense";
            this.LB_ExpirationDateLicense.Size = new System.Drawing.Size(51, 20);
            this.LB_ExpirationDateLicense.TabIndex = 32;
            this.LB_ExpirationDateLicense.Text = "[???]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Issue Date:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(557, 153);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(145, 20);
            this.label17.TabIndex = 37;
            this.label17.Text = "Expiration Date:";
            // 
            // LB_CreatedBY
            // 
            this.LB_CreatedBY.AutoSize = true;
            this.LB_CreatedBY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_CreatedBY.Location = new System.Drawing.Point(764, 200);
            this.LB_CreatedBY.Name = "LB_CreatedBY";
            this.LB_CreatedBY.Size = new System.Drawing.Size(51, 20);
            this.LB_CreatedBY.TabIndex = 28;
            this.LB_CreatedBY.Text = "[???]";
            // 
            // LB_FeesApp
            // 
            this.LB_FeesApp.AutoSize = true;
            this.LB_FeesApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_FeesApp.Location = new System.Drawing.Point(275, 169);
            this.LB_FeesApp.Name = "LB_FeesApp";
            this.LB_FeesApp.Size = new System.Drawing.Size(29, 20);
            this.LB_FeesApp.TabIndex = 27;
            this.LB_FeesApp.Text = "51";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(557, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(123, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "Created BY : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(26, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 25;
            this.label7.Text = "Fees :";
            // 
            // LB_DateApp
            // 
            this.LB_DateApp.AutoSize = true;
            this.LB_DateApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_DateApp.Location = new System.Drawing.Point(275, 89);
            this.LB_DateApp.Name = "LB_DateApp";
            this.LB_DateApp.Size = new System.Drawing.Size(51, 20);
            this.LB_DateApp.TabIndex = 24;
            this.LB_DateApp.Text = "[???]";
            // 
            // LB_I_LicenseApplication
            // 
            this.LB_I_LicenseApplication.AutoSize = true;
            this.LB_I_LicenseApplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_I_LicenseApplication.Location = new System.Drawing.Point(275, 49);
            this.LB_I_LicenseApplication.Name = "LB_I_LicenseApplication";
            this.LB_I_LicenseApplication.Size = new System.Drawing.Size(51, 20);
            this.LB_I_LicenseApplication.TabIndex = 23;
            this.LB_I_LicenseApplication.Text = "[???]";
            // 
            // LB_LLicenseID
            // 
            this.LB_LLicenseID.AutoSize = true;
            this.LB_LLicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LLicenseID.Location = new System.Drawing.Point(764, 106);
            this.LB_LLicenseID.Name = "LB_LLicenseID";
            this.LB_LLicenseID.Size = new System.Drawing.Size(51, 20);
            this.LB_LLicenseID.TabIndex = 23;
            this.LB_LLicenseID.Text = "[???]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = " I.License AppLicantion ID :";
            // 
            // LB_ILicenseID
            // 
            this.LB_ILicenseID.AutoSize = true;
            this.LB_ILicenseID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ILicenseID.Location = new System.Drawing.Point(764, 59);
            this.LB_ILicenseID.Name = "LB_ILicenseID";
            this.LB_ILicenseID.Size = new System.Drawing.Size(51, 20);
            this.LB_ILicenseID.TabIndex = 23;
            this.LB_ILicenseID.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(557, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Local License ID :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(26, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = "Application Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(557, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = " I.License ID :";
            // 
            // LKLB_ShowLIcenseHistory
            // 
            this.LKLB_ShowLIcenseHistory.AutoSize = true;
            this.LKLB_ShowLIcenseHistory.Enabled = false;
            this.LKLB_ShowLIcenseHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LKLB_ShowLIcenseHistory.Location = new System.Drawing.Point(23, 807);
            this.LKLB_ShowLIcenseHistory.Name = "LKLB_ShowLIcenseHistory";
            this.LKLB_ShowLIcenseHistory.Size = new System.Drawing.Size(193, 20);
            this.LKLB_ShowLIcenseHistory.TabIndex = 3;
            this.LKLB_ShowLIcenseHistory.TabStop = true;
            this.LKLB_ShowLIcenseHistory.Text = "Show LIcense History";
            this.LKLB_ShowLIcenseHistory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LKLB_ShowLIcenseHistory_LinkClicked);
            // 
            // LK_LB_ShowLinceseInfo
            // 
            this.LK_LB_ShowLinceseInfo.AutoSize = true;
            this.LK_LB_ShowLinceseInfo.Enabled = false;
            this.LK_LB_ShowLinceseInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LK_LB_ShowLinceseInfo.Location = new System.Drawing.Point(233, 807);
            this.LK_LB_ShowLinceseInfo.Name = "LK_LB_ShowLinceseInfo";
            this.LK_LB_ShowLinceseInfo.Size = new System.Drawing.Size(163, 20);
            this.LK_LB_ShowLinceseInfo.TabIndex = 3;
            this.LK_LB_ShowLinceseInfo.TabStop = true;
            this.LK_LB_ShowLinceseInfo.Text = "Show License Info";
            this.LK_LB_ShowLinceseInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LK_LB_ShowLinceseInfo_LinkClicked);
            // 
            // Btn_Issue
            // 
            this.Btn_Issue.AutoRoundedCorners = true;
            this.Btn_Issue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Issue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Issue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Issue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Issue.Enabled = false;
            this.Btn_Issue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Issue.ForeColor = System.Drawing.Color.White;
            this.Btn_Issue.Location = new System.Drawing.Point(895, 793);
            this.Btn_Issue.Name = "Btn_Issue";
            this.Btn_Issue.Size = new System.Drawing.Size(138, 45);
            this.Btn_Issue.TabIndex = 19;
            this.Btn_Issue.Text = "Issue";
            this.Btn_Issue.Click += new System.EventHandler(this.Btn_Issue_Click);
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
            this.Btn_Close.Location = new System.Drawing.Point(696, 793);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(119, 45);
            this.Btn_Close.TabIndex = 18;
            this.Btn_Close.Text = "Close";
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // uS_LicenseInfoCardcs1
            // 
            this.uS_LicenseInfoCardcs1.Location = new System.Drawing.Point(7, 123);
            this.uS_LicenseInfoCardcs1.Name = "uS_LicenseInfoCardcs1";
            this.uS_LicenseInfoCardcs1.Size = new System.Drawing.Size(1030, 421);
            this.uS_LicenseInfoCardcs1.TabIndex = 20;
            // 
            // US_FindLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uS_LicenseInfoCardcs1);
            this.Controls.Add(this.Btn_Issue);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.LK_LB_ShowLinceseInfo);
            this.Controls.Add(this.LKLB_ShowLIcenseHistory);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "US_FindLicense";
            this.Size = new System.Drawing.Size(1143, 863);
            this.Load += new System.EventHandler(this.US_FindLicense_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.GroupBox groupBox1;
        protected Guna.UI2.WinForms.Guna2Button Btn_Search;
        protected System.Windows.Forms.TextBox Txt_SearchLicense;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.GroupBox groupBox2;
        protected System.Windows.Forms.Label LB_ExpirationDateLicense;
        protected System.Windows.Forms.Label label17;
        protected System.Windows.Forms.Label LB_CreatedBY;
        protected System.Windows.Forms.Label LB_FeesApp;
        protected System.Windows.Forms.Label label15;
        protected System.Windows.Forms.Label label7;
        protected System.Windows.Forms.Label LB_I_LicenseApplication;
        protected System.Windows.Forms.Label LB_LLicenseID;
        protected System.Windows.Forms.Label label4;
        protected System.Windows.Forms.Label LB_ILicenseID;
        protected System.Windows.Forms.Label label2;
        protected System.Windows.Forms.Label label5;
        protected System.Windows.Forms.Label LB_IssueDate;
        protected System.Windows.Forms.Label label3;
        protected System.Windows.Forms.Label LB_DateApp;
        protected System.Windows.Forms.Label label13;
        protected System.Windows.Forms.LinkLabel LKLB_ShowLIcenseHistory;
        protected System.Windows.Forms.LinkLabel LK_LB_ShowLinceseInfo;
        protected Guna.UI2.WinForms.Guna2Button Btn_Issue;
        protected Guna.UI2.WinForms.Guna2Button Btn_Close;
        protected US_CardLicenseInfo uS_LicenseInfoCardcs1;
    }
}
