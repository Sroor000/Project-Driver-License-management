using Project_Driver_License_management;

namespace DVLD_Presntation_Layer
{
    partial class FrmShowDriverLicenseInfoHistory
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
            this.uS_DriverLicense1 = new Project_Driver_License_management.US_DriverLicense();
            this.SuspendLayout();
            // 
            // uS_DriverLicense1
            // 
            this.uS_DriverLicense1.Location = new System.Drawing.Point(12, 12);
            this.uS_DriverLicense1.Name = "uS_DriverLicense1";
            this.uS_DriverLicense1.Size = new System.Drawing.Size(1162, 730);
            this.uS_DriverLicense1.TabIndex = 0;
            // 
            // FrmShowDriverLicenseInfoHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1187, 753);
            this.Controls.Add(this.uS_DriverLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmShowDriverLicenseInfoHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmShowLicenseInfoHistory";
            this.ResumeLayout(false);

        }

        #endregion

        private US_DriverLicense uS_DriverLicense1;
    }
}