namespace Project_Driver_License_management
{
    partial class FrmReNewLicense
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
            this.uS_RenewLicesne1 = new Project_Driver_License_management.US_RenewLicesne();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(206, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "ReNew Local Driving  License ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uS_RenewLicesne1
            // 
            this.uS_RenewLicesne1.AutoSize = true;
            this.uS_RenewLicesne1.Location = new System.Drawing.Point(12, 79);
            this.uS_RenewLicesne1.Name = "uS_RenewLicesne1";
            this.uS_RenewLicesne1.Size = new System.Drawing.Size(1044, 933);
            this.uS_RenewLicesne1.TabIndex = 0;
            // 
            // FrmReNewLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1074, 1055);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uS_RenewLicesne1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmReNewLicense";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReNewLicense";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private US_RenewLicesne uS_RenewLicesne1;
        private System.Windows.Forms.Label label1;
    }
}