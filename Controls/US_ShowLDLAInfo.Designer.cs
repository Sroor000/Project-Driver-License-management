namespace Project_Driver_License_management
{
    partial class US_ShowLDLAInfo
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
            this.CMS_TestAppointment = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uS_LDLinfo1 = new Project_Driver_License_management.US_LDLinfo();
            this.uS_BasicApplicationInfo1 = new Project_Driver_License_management.US_BasicApplicationInfo();
            this.uS_ShowTableData1 = new Project_Driver_License_management.US_ShowTableData();
            this.CMS_TestAppointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // CMS_TestAppointment
            // 
            this.CMS_TestAppointment.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMS_TestAppointment.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.takeTestToolStripMenuItem});
            this.CMS_TestAppointment.Name = "CMS_TestAppointment";
            this.CMS_TestAppointment.Size = new System.Drawing.Size(138, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.editToolStripMenuItem.Text = "Edit ";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // takeTestToolStripMenuItem
            // 
            this.takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            this.takeTestToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.takeTestToolStripMenuItem.Text = "Take Test";
            this.takeTestToolStripMenuItem.Click += new System.EventHandler(this.takeTestToolStripMenuItem_Click);
            // 
            // uS_LDLinfo1
            // 
            this.uS_LDLinfo1.Location = new System.Drawing.Point(0, 3);
            this.uS_LDLinfo1.Name = "uS_LDLinfo1";
            this.uS_LDLinfo1.Size = new System.Drawing.Size(805, 161);
            this.uS_LDLinfo1.TabIndex = 12;
            // 
            // uS_BasicApplicationInfo1
            // 
            this.uS_BasicApplicationInfo1.Location = new System.Drawing.Point(3, 161);
            this.uS_BasicApplicationInfo1.Name = "uS_BasicApplicationInfo1";
            this.uS_BasicApplicationInfo1.Size = new System.Drawing.Size(805, 205);
            this.uS_BasicApplicationInfo1.TabIndex = 13;
            // 
            // uS_ShowTableData1
            // 
            this.uS_ShowTableData1.Location = new System.Drawing.Point(16, 405);
            this.uS_ShowTableData1.Name = "uS_ShowTableData1";
            this.uS_ShowTableData1.Size = new System.Drawing.Size(779, 309);
            this.uS_ShowTableData1.TabIndex = 14;
            // 
            // US_ShowLDLAInfo
            // 
            this.BackColor = System.Drawing.Color.Honeydew;

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uS_ShowTableData1);
            this.Controls.Add(this.uS_BasicApplicationInfo1);
            this.Controls.Add(this.uS_LDLinfo1);
            this.Name = "US_ShowLDLAInfo";
            this.Size = new System.Drawing.Size(819, 714);
            this.CMS_TestAppointment.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip CMS_TestAppointment;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem takeTestToolStripMenuItem;
        private US_LDLinfo uS_LDLinfo1;
        private US_BasicApplicationInfo uS_BasicApplicationInfo1;
        private US_ShowTableData uS_ShowTableData1;
    }
}
