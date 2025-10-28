namespace Project_Driver_License_management
{
    partial class FrmAddorUpdate_ApplicationLocalLicense
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
            this.Btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TB_Personalinfo = new System.Windows.Forms.TabPage();
            this.uS_Find_PeopleData1 = new Project_Driver_License_management.US_Find_PeopleData();
            this.TB_Logininfo = new System.Windows.Forms.TabPage();
            this.CMB_LicenseClass = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_LApplicationCreatedBY = new System.Windows.Forms.Label();
            this.LB_LApplicationFees = new System.Windows.Forms.Label();
            this.LB_LApplicationDate = new System.Windows.Forms.Label();
            this.LB_LApplicationID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LB_TextHeader = new System.Windows.Forms.Label();
            this.PB_Image = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1.SuspendLayout();
            this.TB_Personalinfo.SuspendLayout();
            this.TB_Logininfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.AutoRoundedCorners = true;
            this.Btn_Exit.CheckedState.ForeColor = System.Drawing.Color.Red;
            this.Btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Exit.FillColor = System.Drawing.Color.Black;
            this.Btn_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Exit.ForeColor = System.Drawing.Color.Teal;
            this.Btn_Exit.Location = new System.Drawing.Point(534, 632);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(114, 45);
            this.Btn_Exit.TabIndex = 6;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.AutoRoundedCorners = true;
            this.Btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Save.FillColor = System.Drawing.Color.Black;
            this.Btn_Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Save.ForeColor = System.Drawing.Color.Teal;
            this.Btn_Save.Location = new System.Drawing.Point(664, 632);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(114, 45);
            this.Btn_Save.TabIndex = 7;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TB_Personalinfo);
            this.tabControl1.Controls.Add(this.TB_Logininfo);
            this.tabControl1.Location = new System.Drawing.Point(133, 189);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(679, 437);
            this.tabControl1.TabIndex = 5;
            // 
            // TB_Personalinfo
            // 
            this.TB_Personalinfo.Controls.Add(this.uS_Find_PeopleData1);
            this.TB_Personalinfo.Location = new System.Drawing.Point(4, 25);
            this.TB_Personalinfo.Name = "TB_Personalinfo";
            this.TB_Personalinfo.Padding = new System.Windows.Forms.Padding(3);
            this.TB_Personalinfo.Size = new System.Drawing.Size(671, 408);
            this.TB_Personalinfo.TabIndex = 0;
            this.TB_Personalinfo.Text = "Personalinfo";
            this.TB_Personalinfo.UseVisualStyleBackColor = true;
            // 
            // uS_Find_PeopleData1
            // 
            this.uS_Find_PeopleData1.AutoSize = true;
            this.BackColor= System.Drawing.Color.Honeydew;
            this.uS_Find_PeopleData1.BackColor = System.Drawing.SystemColors.MenuText;
            this.uS_Find_PeopleData1.Location = new System.Drawing.Point(2, 16);
            this.uS_Find_PeopleData1.Name = "uS_Find_PeopleData1";
            this.uS_Find_PeopleData1.Size = new System.Drawing.Size(669, 403);
            this.uS_Find_PeopleData1.TabIndex = 0;
            this.uS_Find_PeopleData1.Load += new System.EventHandler(this.uS_Find_PeopleData1_Load);
            // 
            // TB_Logininfo
            // 
            this.TB_Logininfo.BackColor = System.Drawing.Color.Honeydew;
            this.TB_Logininfo.Controls.Add(this.CMB_LicenseClass);
            this.TB_Logininfo.Controls.Add(this.label5);
            this.TB_Logininfo.Controls.Add(this.label1);
            this.TB_Logininfo.Controls.Add(this.label4);
            this.TB_Logininfo.Controls.Add(this.label3);
            this.TB_Logininfo.Controls.Add(this.LB_LApplicationCreatedBY);
            this.TB_Logininfo.Controls.Add(this.LB_LApplicationFees);
            this.TB_Logininfo.Controls.Add(this.LB_LApplicationDate);
            this.TB_Logininfo.Controls.Add(this.LB_LApplicationID);
            this.TB_Logininfo.Controls.Add(this.label2);
            this.TB_Logininfo.Location = new System.Drawing.Point(4, 25);
            this.TB_Logininfo.Name = "TB_Logininfo";
            this.TB_Logininfo.Padding = new System.Windows.Forms.Padding(3);
            this.TB_Logininfo.Size = new System.Drawing.Size(671, 408);
            this.TB_Logininfo.TabIndex = 1;
            this.TB_Logininfo.Text = "LoginInfo";
            // 
            // CMB_LicenseClass
            // 
            this.CMB_LicenseClass.FormattingEnabled = true;
            this.CMB_LicenseClass.Location = new System.Drawing.Point(330, 204);
            this.CMB_LicenseClass.Name = "CMB_LicenseClass";
            this.CMB_LicenseClass.Size = new System.Drawing.Size(249, 24);
            this.CMB_LicenseClass.TabIndex = 1;
            this.CMB_LicenseClass.SelectedIndexChanged += new System.EventHandler(this.CMB_LicenseClass_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(82, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "License Class :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Created By : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Application Fees :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(82, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 20);
            this.label3.TabIndex = 0;
            this.label3.Tag = "";
            this.label3.Text = "Application Date :";
            // 
            // LB_LApplicationCreatedBY
            // 
            this.LB_LApplicationCreatedBY.AutoSize = true;
            this.LB_LApplicationCreatedBY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LApplicationCreatedBY.Location = new System.Drawing.Point(326, 260);
            this.LB_LApplicationCreatedBY.Name = "LB_LApplicationCreatedBY";
            this.LB_LApplicationCreatedBY.Size = new System.Drawing.Size(51, 20);
            this.LB_LApplicationCreatedBY.TabIndex = 0;
            this.LB_LApplicationCreatedBY.Text = "[???]";
            // 
            // LB_LApplicationFees
            // 
            this.LB_LApplicationFees.AutoSize = true;
            this.LB_LApplicationFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LApplicationFees.Location = new System.Drawing.Point(326, 231);
            this.LB_LApplicationFees.Name = "LB_LApplicationFees";
            this.LB_LApplicationFees.Size = new System.Drawing.Size(51, 20);
            this.LB_LApplicationFees.TabIndex = 0;
            this.LB_LApplicationFees.Text = "[???]";
            // 
            // LB_LApplicationDate
            // 
            this.LB_LApplicationDate.AutoSize = true;
            this.LB_LApplicationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LApplicationDate.Location = new System.Drawing.Point(326, 163);
            this.LB_LApplicationDate.Name = "LB_LApplicationDate";
            this.LB_LApplicationDate.Size = new System.Drawing.Size(51, 20);
            this.LB_LApplicationDate.TabIndex = 0;
            this.LB_LApplicationDate.Text = "[???]";
            // 
            // LB_LApplicationID
            // 
            this.LB_LApplicationID.AutoSize = true;
            this.LB_LApplicationID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_LApplicationID.Location = new System.Drawing.Point(326, 120);
            this.LB_LApplicationID.Name = "LB_LApplicationID";
            this.LB_LApplicationID.Size = new System.Drawing.Size(51, 20);
            this.LB_LApplicationID.TabIndex = 0;
            this.LB_LApplicationID.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "License Application ID :";
            // 
            // LB_TextHeader
            // 
            this.LB_TextHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TextHeader.Location = new System.Drawing.Point(25, 118);
            this.LB_TextHeader.Name = "LB_TextHeader";
            this.LB_TextHeader.Size = new System.Drawing.Size(740, 50);
            this.LB_TextHeader.TabIndex = 5;
            this.LB_TextHeader.Text = "New local License Application";
            this.LB_TextHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_Image
            // 
            this.PB_Image.Image = global::Project_Driver_License_management.Properties.Resources.Application_Types_512;
            this.PB_Image.Location = new System.Drawing.Point(302, 21);
            this.PB_Image.Name = "PB_Image";
            this.PB_Image.Size = new System.Drawing.Size(225, 84);
            this.PB_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Image.TabIndex = 6;
            this.PB_Image.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PB_Image);
            this.groupBox2.Controls.Add(this.LB_TextHeader);
            this.groupBox2.Location = new System.Drawing.Point(32, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(780, 171);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // FrmAddorUpdate_ApplicationLocalLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(861, 685);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddorUpdate_ApplicationLocalLicense";
            this.Text = "New local License Application";
            this.tabControl1.ResumeLayout(false);
            this.TB_Personalinfo.ResumeLayout(false);
            this.TB_Personalinfo.PerformLayout();
            this.TB_Logininfo.ResumeLayout(false);
            this.TB_Logininfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Btn_Exit;
        private Guna.UI2.WinForms.Guna2Button Btn_Save;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TB_Personalinfo;
        private System.Windows.Forms.TabPage TB_Logininfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_LApplicationID;
        private System.Windows.Forms.Label label2;
        private US_Find_PeopleData uS_Find_PeopleData1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CMB_LicenseClass;
        private System.Windows.Forms.Label LB_LApplicationCreatedBY;
        private System.Windows.Forms.Label LB_LApplicationFees;
        private System.Windows.Forms.Label LB_LApplicationDate;
        private System.Windows.Forms.Label LB_TextHeader;
        private System.Windows.Forms.PictureBox PB_Image;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}