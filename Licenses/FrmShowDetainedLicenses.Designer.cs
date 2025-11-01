namespace Project_Driver_License_management
{
    partial class FrmShowDetainedLicenses
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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CMS_ManageDetaindLicense = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Release = new System.Windows.Forms.Button();
            this.uS_ShowTableData1 = new Project_Driver_License_management.US_ShowTableData();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CMS_ManageDetaindLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(235, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Managed Detained Licenses";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(169, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(550, 158);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CMS_ManageDetaindLicense
            // 
            this.CMS_ManageDetaindLicense.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMS_ManageDetaindLicense.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem,
            this.releaseLicenseToolStripMenuItem});
            this.CMS_ManageDetaindLicense.Name = "contextMenuStrip1";
            this.CMS_ManageDetaindLicense.Size = new System.Drawing.Size(265, 100);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // releaseLicenseToolStripMenuItem
            // 
            this.releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
            this.releaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.releaseLicenseToolStripMenuItem.Text = "Release  License ";
            this.releaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseLicenseToolStripMenuItem_Click);
            // 
            // Btn_Release
            // 
            this.Btn_Release.Location = new System.Drawing.Point(983, 233);
            this.Btn_Release.Name = "Btn_Release";
            this.Btn_Release.Size = new System.Drawing.Size(101, 62);
            this.Btn_Release.TabIndex = 4;
            this.Btn_Release.Text = "Release";
            this.Btn_Release.UseVisualStyleBackColor = true;
            this.Btn_Release.Click += new System.EventHandler(this.button1_Click);
            // 
            // uS_ShowTableData1
            // 
            this.uS_ShowTableData1.AutoSize = true;
            this.uS_ShowTableData1.ContextMenuStrip = this.CMS_ManageDetaindLicense;
            this.uS_ShowTableData1.Location = new System.Drawing.Point(12, 301);
            this.uS_ShowTableData1.Name = "uS_ShowTableData1";
            this.uS_ShowTableData1.Size = new System.Drawing.Size(1088, 476);
            this.uS_ShowTableData1.TabIndex = 5;
            // 
            // FrmShowDetainedLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;

            this.ClientSize = new System.Drawing.Size(1111, 804);
            this.Controls.Add(this.uS_ShowTableData1);
            this.Controls.Add(this.Btn_Release);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmShowDetainedLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmShowDetainedLicenses";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CMS_ManageDetaindLicense.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip CMS_ManageDetaindLicense;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem releaseLicenseToolStripMenuItem;
        private System.Windows.Forms.Button Btn_Release;
        private US_ShowTableData uS_ShowTableData1;
    }
}