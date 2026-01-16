namespace Project_Driver_License_management
{
    partial class FrmChangePassword
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_CurPassword = new System.Windows.Forms.TextBox();
            this.Txt_NewPassword = new System.Windows.Forms.TextBox();
            this.Txt_ConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.uS_Card_User_info1 = new Project_Driver_License_management.US_Card_User_info();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "New Password :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(248, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Confirm New Password :";
            // 
            // Txt_CurPassword
            // 
            this.Txt_CurPassword.Location = new System.Drawing.Point(367, 364);
            this.Txt_CurPassword.Name = "Txt_CurPassword";
            this.Txt_CurPassword.Size = new System.Drawing.Size(206, 22);
            this.Txt_CurPassword.TabIndex = 2;
            this.Txt_CurPassword.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_ConfirmNewPassword_Validating);
            this.Txt_CurPassword.Validated += new System.EventHandler(this.Txt_CurPassword_Validated);
            // 
            // Txt_NewPassword
            // 
            this.Txt_NewPassword.Location = new System.Drawing.Point(367, 404);
            this.Txt_NewPassword.Name = "Txt_NewPassword";
            this.Txt_NewPassword.Size = new System.Drawing.Size(206, 22);
            this.Txt_NewPassword.TabIndex = 2;
            // 
            // Txt_ConfirmNewPassword
            // 
            this.Txt_ConfirmNewPassword.Location = new System.Drawing.Point(367, 446);
            this.Txt_ConfirmNewPassword.Name = "Txt_ConfirmNewPassword";
            this.Txt_ConfirmNewPassword.Size = new System.Drawing.Size(206, 22);
            this.Txt_ConfirmNewPassword.TabIndex = 2;
            this.Txt_ConfirmNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_ConfirmNewPassword_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.AutoRoundedCorners = true;
            this.Btn_Exit.CheckedState.ForeColor = System.Drawing.Color.Red;
            this.Btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Exit.FillColor = System.Drawing.Color.Red;
            this.Btn_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.Btn_Exit.Location = new System.Drawing.Point(654, 482);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(114, 45);
            this.Btn_Exit.TabIndex = 5;
            this.Btn_Exit.Text = "Exit";
            this.Btn_Exit.Click += new System.EventHandler(this.Btn_Exit_Click);
            // 
            // Btn_Save
            // 
            this.Btn_Save.AutoRoundedCorners = true;
            this.Btn_Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Save.ForeColor = System.Drawing.Color.Black;
            this.Btn_Save.Location = new System.Drawing.Point(784, 482);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(114, 45);
            this.Btn_Save.TabIndex = 6;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // uS_Card_User_info1
            // 
            this.uS_Card_User_info1.BackColor = System.Drawing.Color.Honeydew;
            this.uS_Card_User_info1.Location = new System.Drawing.Point(12, 12);
            this.uS_Card_User_info1.Name = "uS_Card_User_info1";
            this.uS_Card_User_info1.Size = new System.Drawing.Size(886, 328);
            this.uS_Card_User_info1.TabIndex = 0;
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(910, 539);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.Txt_ConfirmNewPassword);
            this.Controls.Add(this.Txt_NewPassword);
            this.Controls.Add(this.Txt_CurPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uS_Card_User_info1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmChangePassword";
            this.Text = "Change Password";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private US_Card_User_info uS_Card_User_info1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_CurPassword;
        private System.Windows.Forms.TextBox Txt_NewPassword;
        private System.Windows.Forms.TextBox Txt_ConfirmNewPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button Btn_Exit;
        private Guna.UI2.WinForms.Guna2Button Btn_Save;
    }
}