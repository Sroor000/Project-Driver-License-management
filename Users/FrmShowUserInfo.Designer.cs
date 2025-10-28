namespace Project_Driver_License_management
{
    partial class FrmShowUserInfo
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
            this.uS_Card_User_info1 = new Project_Driver_License_management.US_Card_User_info();
            this.SuspendLayout();
            // 
            // uS_Card_User_info1
            // 
            this.uS_Card_User_info1.BackColor = System.Drawing.Color.Honeydew;
            this.uS_Card_User_info1.Location = new System.Drawing.Point(12, 12);
            this.uS_Card_User_info1.Name = "uS_Card_User_info1";
            this.uS_Card_User_info1.Size = new System.Drawing.Size(920, 357);
            this.uS_Card_User_info1.TabIndex = 0;
            // 
            // FrmShowUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(944, 381);
            this.Controls.Add(this.uS_Card_User_info1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmShowUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Show User Info";
            this.ResumeLayout(false);

        }

        #endregion

        private US_Card_User_info uS_Card_User_info1;
    }
}