namespace Project_Driver_License_management
{
    partial class US_Add_Update_UserData
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_Add_Update_UserData));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TB_Personalinfo = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_SearchPerson = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_AddPerson = new Guna.UI2.WinForms.Guna2Button();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.Cmb_Filter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.uS_Card_People_Info1 = new Project_Driver_License_management.US_Card_People_Info();
            this.Btn_NextPage = new Guna.UI2.WinForms.Guna2Button();
            this.TB_Logininfo = new System.Windows.Forms.TabPage();
            this.CHKB_UserActive = new System.Windows.Forms.CheckBox();
            this.Txt_UserName = new System.Windows.Forms.TextBox();
            this.Txt_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.Txt_Password = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_UserID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.TB_Personalinfo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TB_Logininfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TB_Personalinfo);
            this.tabControl1.Controls.Add(this.TB_Logininfo);
            this.tabControl1.Location = new System.Drawing.Point(27, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(855, 437);
            this.tabControl1.TabIndex = 2;
            // 
            // TB_Personalinfo
            // 
            this.TB_Personalinfo.Controls.Add(this.panel1);
            this.TB_Personalinfo.Controls.Add(this.uS_Card_People_Info1);
            this.TB_Personalinfo.Controls.Add(this.Btn_NextPage);
            this.TB_Personalinfo.Location = new System.Drawing.Point(4, 25);
            this.TB_Personalinfo.Name = "TB_Personalinfo";
            this.TB_Personalinfo.Padding = new System.Windows.Forms.Padding(3);
            this.TB_Personalinfo.Size = new System.Drawing.Size(847, 408);
            this.TB_Personalinfo.TabIndex = 0;
            this.TB_Personalinfo.Text = "Personalinfo";
            this.TB_Personalinfo.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_SearchPerson);
            this.panel1.Controls.Add(this.Btn_AddPerson);
            this.panel1.Controls.Add(this.Txt_Search);
            this.panel1.Controls.Add(this.Cmb_Filter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(9, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 51);
            this.panel1.TabIndex = 2;
            // 
            // Btn_SearchPerson
            // 
            this.Btn_SearchPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_SearchPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_SearchPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_SearchPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_SearchPerson.FillColor = System.Drawing.Color.White;
            this.Btn_SearchPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_SearchPerson.ForeColor = System.Drawing.Color.White;
            this.Btn_SearchPerson.Image = ((System.Drawing.Image)(resources.GetObject("Btn_SearchPerson.Image")));
            this.Btn_SearchPerson.Location = new System.Drawing.Point(529, 18);
            this.Btn_SearchPerson.Name = "Btn_SearchPerson";
            this.Btn_SearchPerson.Size = new System.Drawing.Size(32, 25);
            this.Btn_SearchPerson.TabIndex = 7;
            this.Btn_SearchPerson.Click += new System.EventHandler(this.Btn_SearchPerson_Click);
            // 
            // Btn_AddPerson
            // 
            this.Btn_AddPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_AddPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_AddPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_AddPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_AddPerson.FillColor = System.Drawing.Color.White;
            this.Btn_AddPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_AddPerson.ForeColor = System.Drawing.Color.White;
            this.Btn_AddPerson.Image = ((System.Drawing.Image)(resources.GetObject("Btn_AddPerson.Image")));
            this.Btn_AddPerson.Location = new System.Drawing.Point(473, 16);
            this.Btn_AddPerson.Name = "Btn_AddPerson";
            this.Btn_AddPerson.Size = new System.Drawing.Size(32, 25);
            this.Btn_AddPerson.TabIndex = 7;
            this.Btn_AddPerson.Click += new System.EventHandler(this.Btn_AddPerson_Click);
            // 
            // Txt_Search
            // 
            this.Txt_Search.Location = new System.Drawing.Point(281, 19);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(156, 22);
            this.Txt_Search.TabIndex = 6;
            this.Txt_Search.Visible = false;
            this.Txt_Search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Cmb_Filter
            // 
            this.Cmb_Filter.FormattingEnabled = true;
            this.Cmb_Filter.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo"});
            this.Cmb_Filter.Location = new System.Drawing.Point(115, 19);
            this.Cmb_Filter.Name = "Cmb_Filter";
            this.Cmb_Filter.Size = new System.Drawing.Size(151, 24);
            this.Cmb_Filter.TabIndex = 5;
            this.Cmb_Filter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Find by";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // uS_Card_People_Info1
            // 
            this.uS_Card_People_Info1.Location = new System.Drawing.Point(6, 92);
            this.uS_Card_People_Info1.Name = "uS_Card_People_Info1";
            this.uS_Card_People_Info1.PersonID = 0;
            this.uS_Card_People_Info1.Size = new System.Drawing.Size(816, 259);
            this.uS_Card_People_Info1.TabIndex = 1;
            // 
            // Btn_NextPage
            // 
            this.Btn_NextPage.AutoRoundedCorners = true;
            this.Btn_NextPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_NextPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_NextPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_NextPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_NextPage.FillColor = System.Drawing.Color.Teal;
            this.Btn_NextPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_NextPage.ForeColor = System.Drawing.Color.Black;
            this.Btn_NextPage.Location = new System.Drawing.Point(724, 357);
            this.Btn_NextPage.Name = "Btn_NextPage";
            this.Btn_NextPage.Size = new System.Drawing.Size(108, 45);
            this.Btn_NextPage.TabIndex = 0;
            this.Btn_NextPage.Text = "Next";
            this.Btn_NextPage.Click += new System.EventHandler(this.Btn_NextPage_Click_1);
            // 
            // TB_Logininfo
            // 
            this.TB_Logininfo.Controls.Add(this.CHKB_UserActive);
            this.TB_Logininfo.Controls.Add(this.Txt_UserName);
            this.TB_Logininfo.Controls.Add(this.Txt_ConfirmPassword);
            this.TB_Logininfo.Controls.Add(this.Txt_Password);
            this.TB_Logininfo.Controls.Add(this.label5);
            this.TB_Logininfo.Controls.Add(this.label4);
            this.TB_Logininfo.Controls.Add(this.label3);
            this.TB_Logininfo.Controls.Add(this.LB_UserID);
            this.TB_Logininfo.Controls.Add(this.label2);
            this.TB_Logininfo.Location = new System.Drawing.Point(4, 25);
            this.TB_Logininfo.Name = "TB_Logininfo";
            this.TB_Logininfo.Padding = new System.Windows.Forms.Padding(3);
            this.TB_Logininfo.Size = new System.Drawing.Size(847, 408);
            this.TB_Logininfo.TabIndex = 1;
            this.TB_Logininfo.Text = "LoginInfo";
            this.TB_Logininfo.UseVisualStyleBackColor = true;
            // 
            // CHKB_UserActive
            // 
            this.CHKB_UserActive.AutoSize = true;
            this.CHKB_UserActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CHKB_UserActive.Location = new System.Drawing.Point(320, 304);
            this.CHKB_UserActive.Name = "CHKB_UserActive";
            this.CHKB_UserActive.Size = new System.Drawing.Size(83, 24);
            this.CHKB_UserActive.TabIndex = 2;
            this.CHKB_UserActive.Text = "Active";
            this.CHKB_UserActive.UseVisualStyleBackColor = true;
            // 
            // Txt_UserName
            // 
            this.Txt_UserName.Location = new System.Drawing.Point(320, 150);
            this.Txt_UserName.Name = "Txt_UserName";
            this.Txt_UserName.Size = new System.Drawing.Size(245, 22);
            this.Txt_UserName.TabIndex = 1;
            // 
            // Txt_ConfirmPassword
            // 
            this.Txt_ConfirmPassword.Location = new System.Drawing.Point(320, 247);
            this.Txt_ConfirmPassword.Name = "Txt_ConfirmPassword";
            this.Txt_ConfirmPassword.Size = new System.Drawing.Size(245, 22);
            this.Txt_ConfirmPassword.TabIndex = 1;
            this.Txt_ConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_ConfirmPassword_Validating);
            // 
            // Txt_Password
            // 
            this.Txt_Password.Location = new System.Drawing.Point(320, 194);
            this.Txt_Password.Name = "Txt_Password";
            this.Txt_Password.Size = new System.Drawing.Size(245, 22);
            this.Txt_Password.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(207, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Confirm Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(195, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Name :";
            // 
            // LB_UserID
            // 
            this.LB_UserID.AutoSize = true;
            this.LB_UserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_UserID.Location = new System.Drawing.Point(316, 91);
            this.LB_UserID.Name = "LB_UserID";
            this.LB_UserID.Size = new System.Drawing.Size(51, 20);
            this.LB_UserID.TabIndex = 0;
            this.LB_UserID.Text = "[???]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "User ID :";
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.AutoRoundedCorners = true;
            this.Btn_Exit.CheckedState.ForeColor = System.Drawing.Color.Red;
            this.Btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Exit.FillColor = System.Drawing.Color.Teal;
            this.Btn_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.Btn_Exit.Location = new System.Drawing.Point(634, 468);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(114, 45);
            this.Btn_Exit.TabIndex = 3;
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
            this.Btn_Save.FillColor = System.Drawing.Color.Teal;
            this.Btn_Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Save.ForeColor = System.Drawing.Color.Black;
            this.Btn_Save.Location = new System.Drawing.Point(764, 468);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(114, 45);
            this.Btn_Save.TabIndex = 4;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // US_Add_Update_UserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.tabControl1);
            this.Name = "US_Add_Update_UserData";
            this.Size = new System.Drawing.Size(909, 516);
            this.tabControl1.ResumeLayout(false);
            this.TB_Personalinfo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TB_Logininfo.ResumeLayout(false);
            this.TB_Logininfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TB_Personalinfo;
        private Guna.UI2.WinForms.Guna2Button Btn_NextPage;
        private System.Windows.Forms.TabPage TB_Logininfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.ComboBox Cmb_Filter;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button Btn_SearchPerson;
        private Guna.UI2.WinForms.Guna2Button Btn_AddPerson;
        private US_Card_People_Info uS_Card_People_Info1;
        private System.Windows.Forms.TextBox Txt_Password;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_UserName;
        private System.Windows.Forms.TextBox Txt_ConfirmPassword;
        private System.Windows.Forms.Label LB_UserID;
        private System.Windows.Forms.CheckBox CHKB_UserActive;
        private Guna.UI2.WinForms.Guna2Button Btn_Exit;
        private Guna.UI2.WinForms.Guna2Button Btn_Save;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
