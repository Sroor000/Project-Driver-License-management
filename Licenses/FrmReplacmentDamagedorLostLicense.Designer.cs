namespace Project_Driver_License_management
{
    partial class FrmReplacmentDamagedorLostLicense
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
            this.uS_ReplecmentDamgedorLostLicense1 = new Project_Driver_License_management.US_ReplecmentDamgedorLostLicense();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uS_ReplecmentDamgedorLostLicense1
            // 
            this.uS_ReplecmentDamgedorLostLicense1.Location = new System.Drawing.Point(12, 102);
            this.uS_ReplecmentDamgedorLostLicense1.Name = "uS_ReplecmentDamgedorLostLicense1";
            this.uS_ReplecmentDamgedorLostLicense1.Size = new System.Drawing.Size(1060, 788);
            this.uS_ReplecmentDamgedorLostLicense1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(228, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Replacement Damaged  License";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmReplacmentDamagedorLostLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;

            this.ClientSize = new System.Drawing.Size(1083, 923);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uS_ReplecmentDamgedorLostLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReplacmentDamagedorLostLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReplacmentDamagedorLostLicense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private US_ReplecmentDamgedorLostLicense uS_ReplecmentDamgedorLostLicense1;
        private System.Windows.Forms.Label label1;
    }
}