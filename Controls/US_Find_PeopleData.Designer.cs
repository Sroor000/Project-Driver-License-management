namespace Project_Driver_License_management
{
    partial class US_Find_PeopleData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(US_Find_PeopleData));
            this.panel1 = new System.Windows.Forms.Panel();
            this.uS_Card_People_Info1 = new Project_Driver_License_management.US_Card_People_Info();
            this.Btn_NextPage = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_SearchPerson = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_AddPerson = new Guna.UI2.WinForms.Guna2Button();
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.Cmb_Filter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.uS_Card_People_Info1);
            this.panel1.Controls.Add(this.Btn_NextPage);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 397);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // uS_Card_People_Info1
            // 
            this.uS_Card_People_Info1.Location = new System.Drawing.Point(0, 72);
            this.uS_Card_People_Info1.Name = "uS_Card_People_Info1";
            this.uS_Card_People_Info1.Size = new System.Drawing.Size(657, 259);
            this.uS_Card_People_Info1.TabIndex = 7;
            // 
            // Btn_NextPage
            // 
            this.Btn_NextPage.AutoRoundedCorners = true;
            this.Btn_NextPage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_NextPage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_NextPage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_NextPage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_NextPage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_NextPage.ForeColor = System.Drawing.Color.Black;
            this.Btn_NextPage.Location = new System.Drawing.Point(548, 337);
            this.Btn_NextPage.Name = "Btn_NextPage";
            this.Btn_NextPage.Size = new System.Drawing.Size(108, 45);
            this.Btn_NextPage.TabIndex = 6;
            this.Btn_NextPage.Text = "Next";
            this.Btn_NextPage.Click += new System.EventHandler(this.Btn_NextPage_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_SearchPerson);
            this.groupBox1.Controls.Add(this.Btn_AddPerson);
            this.groupBox1.Controls.Add(this.Txt_Search);
            this.groupBox1.Controls.Add(this.Cmb_Filter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 63);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter";
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
            this.Btn_SearchPerson.Location = new System.Drawing.Point(539, 20);
            this.Btn_SearchPerson.Name = "Btn_SearchPerson";
            this.Btn_SearchPerson.Size = new System.Drawing.Size(32, 25);
            this.Btn_SearchPerson.TabIndex = 11;
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
            this.Btn_AddPerson.Location = new System.Drawing.Point(483, 18);
            this.Btn_AddPerson.Name = "Btn_AddPerson";
            this.Btn_AddPerson.Size = new System.Drawing.Size(32, 25);
            this.Btn_AddPerson.TabIndex = 12;
            this.Btn_AddPerson.Click += new System.EventHandler(this.Btn_AddPerson_Click);
            // 
            // Txt_Search
            // 
            this.Txt_Search.Location = new System.Drawing.Point(291, 21);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(156, 22);
            this.Txt_Search.TabIndex = 10;
            this.Txt_Search.Visible = false;
            this.Txt_Search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Cmb_Filter
            // 
            this.Cmb_Filter.FormattingEnabled = true;
            this.Cmb_Filter.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo"});
            this.Cmb_Filter.Location = new System.Drawing.Point(125, 21);
            this.Cmb_Filter.Name = "Cmb_Filter";
            this.Cmb_Filter.Size = new System.Drawing.Size(151, 24);
            this.Cmb_Filter.TabIndex = 9;
            this.Cmb_Filter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Find by";
            // 
            // US_Find_PeopleData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.Controls.Add(this.panel1);
            this.Name = "US_Find_PeopleData";
            this.Size = new System.Drawing.Size(669, 403);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private US_Card_People_Info uS_Card_People_Info1;
        private Guna.UI2.WinForms.Guna2Button Btn_NextPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button Btn_SearchPerson;
        private Guna.UI2.WinForms.Guna2Button Btn_AddPerson;
        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.ComboBox Cmb_Filter;
        private System.Windows.Forms.Label label1;
    }
}
