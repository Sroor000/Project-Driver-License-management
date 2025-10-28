namespace Project_Driver_License_management
{
    partial class FrmRelease_DetainLicense
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
            this.LB_Header = new System.Windows.Forms.Label();
            this.uS_Detainor_ReleaseLicenses1 = new Project_Driver_License_management.US_Detainor_ReleaseLicenses();
            this.SuspendLayout();
            // 
            // LB_Header
            // 
            this.LB_Header.AutoSize = true;
            this.LB_Header.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_Header.ForeColor = System.Drawing.Color.Red;
            this.LB_Header.Location = new System.Drawing.Point(346, 21);
            this.LB_Header.Name = "LB_Header";
            this.LB_Header.Size = new System.Drawing.Size(257, 39);
            this.LB_Header.TabIndex = 1;
            this.LB_Header.Text = "Detain License";
            this.LB_Header.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uS_Detainor_ReleaseLicenses1
            // 
            this.uS_Detainor_ReleaseLicenses1.Location = new System.Drawing.Point(14, 93);
            this.uS_Detainor_ReleaseLicenses1.Name = "uS_Detainor_ReleaseLicenses1";
            this.uS_Detainor_ReleaseLicenses1.Size = new System.Drawing.Size(1054, 844);
            this.uS_Detainor_ReleaseLicenses1.TabIndex = 0;
            // 
            // FrmRelease_DetainLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1098, 927);
            this.Controls.Add(this.LB_Header);
            this.Controls.Add(this.uS_Detainor_ReleaseLicenses1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmRelease_DetainLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Release License";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private US_Detainor_ReleaseLicenses uS_Detainor_ReleaseLicenses1;
        private System.Windows.Forms.Label LB_Header;
    }
}