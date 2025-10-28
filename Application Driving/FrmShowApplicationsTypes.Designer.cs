using Project_Driver_License_management;

namespace DVLD_Presntation_Layer
{
    partial class FrmShowApplicationsTypes
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
            this.uS_ShowTableData1 = new US_ShowTableData();
            this.CMS_ApllicationManageTypes = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editAppLicatioTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_ApllicationManageTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // uS_ShowTableData1
            // 
            this.uS_ShowTableData1.AutoSize = true;
            this.uS_ShowTableData1.BackColor=System.Drawing.Color.Honeydew;
            this.uS_ShowTableData1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.uS_ShowTableData1.Location = new System.Drawing.Point(12, 41);
            this.uS_ShowTableData1.Name = "uS_ShowTableData1";
            this.uS_ShowTableData1.Size = new System.Drawing.Size(1088, 467);
            this.uS_ShowTableData1.TabIndex = 0;
            // 
            // CMS_ApllicationManageTypes
            // 
            this.CMS_ApllicationManageTypes.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CMS_ApllicationManageTypes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editAppLicatioTypeToolStripMenuItem});
            this.CMS_ApllicationManageTypes.Name = "CMS_ApllicationManageTypes";
            this.CMS_ApllicationManageTypes.Size = new System.Drawing.Size(212, 28);
            // 
            // editAppLicatioTypeToolStripMenuItem
            // 
            this.editAppLicatioTypeToolStripMenuItem.Name = "editAppLicatioTypeToolStripMenuItem";
            this.editAppLicatioTypeToolStripMenuItem.Size = new System.Drawing.Size(211, 24);
            this.editAppLicatioTypeToolStripMenuItem.Text = "Edit AppLicatioType";
            this.editAppLicatioTypeToolStripMenuItem.Click += new System.EventHandler(this.editAppLicatioTypeToolStripMenuItem_Click);
            // 
            // FrmShowApplicationsTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.BackColor= System.Drawing.Color.Teal;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 520);
            this.ContextMenuStrip = this.CMS_ApllicationManageTypes;
            this.Controls.Add(this.uS_ShowTableData1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmShowApplicationsTypes";
            this.Text = "Show Applications Types";
            this.CMS_ApllicationManageTypes.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private US_ShowTableData uS_ShowTableData1;
        private System.Windows.Forms.ContextMenuStrip CMS_ApllicationManageTypes;
        private System.Windows.Forms.ToolStripMenuItem editAppLicatioTypeToolStripMenuItem;
    }
}