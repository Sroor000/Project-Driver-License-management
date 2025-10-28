namespace Project_Driver_License_management
{
    partial class FrmShowLicensesApplication
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.addnew = new System.Windows.Forms.ToolStripMenuItem();
            this.SechudaleTool = new System.Windows.Forms.ToolStripMenuItem();
            this.VisionTest = new System.Windows.Forms.ToolStripMenuItem();
            this.WrittienTest = new System.Windows.Forms.ToolStripMenuItem();
            this.StreetTest = new System.Windows.Forms.ToolStripMenuItem();
            this.IssueDrivingLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.cancel = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicense = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.uS_ShowTableData1 = new Project_Driver_License_management.US_ShowTableData();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PB_Image = new System.Windows.Forms.PictureBox();
            this.LB_TextHeader = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit,
            this.delete,
            this.addnew,
            this.SechudaleTool,
            this.IssueDrivingLicense,
            this.cancel,
            this.showLicense,
            this.showPersonLicense});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.contextMenuStrip1.Size = new System.Drawing.Size(297, 224);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // edit
            // 
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(296, 24);
            this.edit.Text = "Edit Application";
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(296, 24);
            this.delete.Text = "Delete Application";
            this.delete.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // addnew
            // 
            this.addnew.Name = "addnew";
            this.addnew.Size = new System.Drawing.Size(296, 24);
            this.addnew.Text = "Add new Application";
            this.addnew.Click += new System.EventHandler(this.addnewToolStripMenuItem_Click);
            // 
            // SechudaleTool
            // 
            this.SechudaleTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VisionTest,
            this.WrittienTest,
            this.StreetTest});
            this.SechudaleTool.Name = "SechudaleTool";
            this.SechudaleTool.Size = new System.Drawing.Size(296, 24);
            this.SechudaleTool.Text = "Sechudale Tools";
            // 
            // VisionTest
            // 
            this.VisionTest.Name = "VisionTest";
            this.VisionTest.Size = new System.Drawing.Size(237, 26);
            this.VisionTest.Text = "Sechdual Vision test";
            this.VisionTest.Click += new System.EventHandler(this.sechdualVisionTestToolStripMenuItem_Click);
            // 
            // WrittienTest
            // 
            this.WrittienTest.Enabled = false;
            this.WrittienTest.Name = "WrittienTest";
            this.WrittienTest.Size = new System.Drawing.Size(237, 26);
            this.WrittienTest.Text = "Sechdual Writtien test";
            this.WrittienTest.Click += new System.EventHandler(this.sechdualVisionTestToolStripMenuItem1_Click);
            // 
            // StreetTest
            // 
            this.StreetTest.Enabled = false;
            this.StreetTest.Name = "StreetTest";
            this.StreetTest.Size = new System.Drawing.Size(237, 26);
            this.StreetTest.Text = "Sechdual Street test";
            this.StreetTest.Click += new System.EventHandler(this.sechdualVisionTestToolStripMenuItem2_Click);
            // 
            // IssueDrivingLicense
            // 
            this.IssueDrivingLicense.Name = "IssueDrivingLicense";
            this.IssueDrivingLicense.Size = new System.Drawing.Size(296, 24);
            this.IssueDrivingLicense.Text = "Issue Driving  License (First Time)";
            this.IssueDrivingLicense.Click += new System.EventHandler(this.IssueDrivingLicense_Click);
            // 
            // cancel
            // 
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(296, 24);
            this.cancel.Text = "Cancel Application";
            this.cancel.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // showLicense
            // 
            this.showLicense.Name = "showLicense";
            this.showLicense.Size = new System.Drawing.Size(296, 24);
            this.showLicense.Text = "Show License";
            this.showLicense.Click += new System.EventHandler(this.showLicense_Click);
            // 
            // showPersonLicense
            // 
            this.showPersonLicense.Name = "showPersonLicense";
            this.showPersonLicense.Size = new System.Drawing.Size(296, 24);
            this.showPersonLicense.Text = "Show Person License history";
            this.showPersonLicense.Click += new System.EventHandler(this.showPersonLicense_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Black;
            this.groupBox1.Controls.Add(this.uS_ShowTableData1);
            this.groupBox1.Location = new System.Drawing.Point(12, 292);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1182, 488);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // uS_ShowTableData1
            // 
            this.uS_ShowTableData1.BackColor = System.Drawing.Color.Honeydew;
            this.uS_ShowTableData1.ContextMenuStrip = this.contextMenuStrip1;
            this.uS_ShowTableData1.Location = new System.Drawing.Point(18, 18);
            this.uS_ShowTableData1.Name = "uS_ShowTableData1";
            this.uS_ShowTableData1.Size = new System.Drawing.Size(1148, 464);
            this.uS_ShowTableData1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PB_Image);
            this.groupBox2.Controls.Add(this.LB_TextHeader);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1182, 254);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // PB_Image
            // 
            this.PB_Image.Image = global::Project_Driver_License_management.Properties.Resources.Application_Types_512;
            this.PB_Image.Location = new System.Drawing.Point(452, 21);
            this.PB_Image.Name = "PB_Image";
            this.PB_Image.Size = new System.Drawing.Size(285, 119);
            this.PB_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Image.TabIndex = 6;
            this.PB_Image.TabStop = false;
            // 
            // LB_TextHeader
            // 
            this.LB_TextHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TextHeader.Location = new System.Drawing.Point(178, 185);
            this.LB_TextHeader.Name = "LB_TextHeader";
            this.LB_TextHeader.Size = new System.Drawing.Size(800, 50);
            this.LB_TextHeader.TabIndex = 5;
            this.LB_TextHeader.Text = "Manage Local License Application ";
            this.LB_TextHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmShowLicensesApplication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1223, 792);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmShowLicensesApplication";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmShowLicensesApplication";
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem addnew;
        private System.Windows.Forms.ToolStripMenuItem SechudaleTool;
        private System.Windows.Forms.ToolStripMenuItem IssueDrivingLicense;
        private System.Windows.Forms.ToolStripMenuItem cancel;
        private System.Windows.Forms.ToolStripMenuItem showLicense;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicense;
        private System.Windows.Forms.ToolStripMenuItem VisionTest;
        private System.Windows.Forms.ToolStripMenuItem WrittienTest;
        private System.Windows.Forms.ToolStripMenuItem StreetTest;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox PB_Image;
        private System.Windows.Forms.Label LB_TextHeader;
        private US_ShowTableData uS_ShowTableData1;
    }
}