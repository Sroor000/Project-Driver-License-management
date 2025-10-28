
using Project_Driver_License_management;

namespace DVLD_Presntation_Layer

{
    partial class FrmAddorUpdatePeopleInfo
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
            this.uS_AddorUpdate_Data_User1 = new US_AddorUpdatePeople();
            this.addorUpdateUser1 = new US_AddorUpdatePeople();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(585, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 1;
            // 
            // uS_AddorUpdate_Data_User1
            // 
            this.uS_AddorUpdate_Data_User1.Location = new System.Drawing.Point(12, 25);
            this.uS_AddorUpdate_Data_User1.Name = "uS_AddorUpdate_Data_User1";
            this.uS_AddorUpdate_Data_User1.Size = new System.Drawing.Size(903, 438);
            this.uS_AddorUpdate_Data_User1.TabIndex = 2;
            this.uS_AddorUpdate_Data_User1.Load += new System.EventHandler(this.uS_AddorUpdate_Data_User1_Load);
            // 
            // addorUpdateUser1
            // 
            this.addorUpdateUser1.Location = new System.Drawing.Point(165, 63);
            this.addorUpdateUser1.Name = "addorUpdateUser1";
            this.addorUpdateUser1.Size = new System.Drawing.Size(1301, 595);
            this.addorUpdateUser1.TabIndex = 2;
            // 
            // FrmAddorUpdateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(936, 475);
            this.Controls.Add(this.uS_AddorUpdate_Data_User1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAddorUpdateData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddorUpdateData";
            this.Load += new System.EventHandler(this.FrmAddorUpdateData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private US_AddorUpdatePeople addorUpdateUser1;
        private US_AddorUpdatePeople uS_AddorUpdate_Data_User1;
    }
}