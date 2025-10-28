namespace Project_Driver_License_management
{
    partial class FrmShowInternationalLicenses
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
            this.uS_ShowTableData1 = new Project_Driver_License_management.US_ShowTableData();
            this.label1 = new System.Windows.Forms.Label();
            this.PB_InternationalLicenses = new System.Windows.Forms.PictureBox();
            this.CMS_InternationlLincesesTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseHistroyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PB_InternationalLicenses)).BeginInit();
            this.CMS_InternationlLincesesTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // uS_ShowTableData1
            // 
            this.uS_ShowTableData1.ContextMenuStrip = this.CMS_InternationlLincesesTable;
            this.uS_ShowTableData1.Location = new System.Drawing.Point(12, 248);
            this.uS_ShowTableData1.Name = "uS_ShowTableData1";
            this.uS_ShowTableData1.Size = new System.Drawing.Size(889, 480);
            this.uS_ShowTableData1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(241, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "InterNaional Licenses";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PB_InternationalLicenses
            // 
            this.PB_InternationalLicenses.Location = new System.Drawing.Point(157, 12);
            this.PB_InternationalLicenses.Name = "PB_InternationalLicenses";
            this.PB_InternationalLicenses.Size = new System.Drawing.Size(530, 169);
            this.PB_InternationalLicenses.TabIndex = 2;
            this.PB_InternationalLicenses.TabStop = false;
            // 
            // CMS_InternationlLincesesTable
            // 
            this.CMS_InternationlLincesesTable.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMS_InternationlLincesesTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseHistroyToolStripMenuItem,
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem});
            this.CMS_InternationlLincesesTable.Name = "CMS_InternationlLincesesTable";
            this.CMS_InternationlLincesesTable.Size = new System.Drawing.Size(265, 104);
            // 
            // showLicenseHistroyToolStripMenuItem
            // 
            this.showLicenseHistroyToolStripMenuItem.Name = "showLicenseHistroyToolStripMenuItem";
            this.showLicenseHistroyToolStripMenuItem.Size = new System.Drawing.Size(264, 24);
            this.showLicenseHistroyToolStripMenuItem.Text = "Show Person License Histroy";
            this.showLicenseHistroyToolStripMenuItem.Click += new System.EventHandler(this.showLicenseHistroyToolStripMenuItem_Click);
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
            // FrmShowInternationalLicenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 740);
            this.Controls.Add(this.PB_InternationalLicenses);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uS_ShowTableData1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmShowInternationalLicenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmShowInternationalLicenses";
            ((System.ComponentModel.ISupportInitialize)(this.PB_InternationalLicenses)).EndInit();
            this.CMS_InternationlLincesesTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private US_ShowTableData uS_ShowTableData1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PB_InternationalLicenses;
        private System.Windows.Forms.ContextMenuStrip CMS_InternationlLincesesTable;
        private System.Windows.Forms.ToolStripMenuItem showLicenseHistroyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
    }
}