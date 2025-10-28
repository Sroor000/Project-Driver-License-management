namespace Project_Driver_License_management
{
    partial class FrmIssueinternationlLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.uS_FindLicense1 = new Project_Driver_License_management.US_FindLicense();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(242, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "InterNational Licenses Applications";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uS_FindLicense1
            // 
            this.uS_FindLicense1.Location = new System.Drawing.Point(12, 76);
            this.uS_FindLicense1.Name = "uS_FindLicense1";
            this.uS_FindLicense1.Size = new System.Drawing.Size(1043, 863);
            this.uS_FindLicense1.TabIndex = 0;
            // 
            // FrmIssueinternationlLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1066, 959);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uS_FindLicense1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmIssueinternationlLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmIssueinternationlLicense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private US_FindLicense uS_FindLicense1;
        private System.Windows.Forms.Label label1;
    }
}