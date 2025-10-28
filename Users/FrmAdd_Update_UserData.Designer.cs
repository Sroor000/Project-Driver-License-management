namespace Project_Driver_License_management
{
    partial class FrmAdd_Update_UserData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdd_Update_UserData));
            this.uS_Add_Update_UserData1 = new Project_Driver_License_management.US_Add_Update_UserData();
            this.SuspendLayout();
            // 
            // uS_Add_Update_UserData1
            // 
            resources.ApplyResources(this.uS_Add_Update_UserData1, "uS_Add_Update_UserData1");
            this.uS_Add_Update_UserData1.Name = "uS_Add_Update_UserData1";
            // 
            // FrmAdd_Update_UserData
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.uS_Add_Update_UserData1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmAdd_Update_UserData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private US_Add_Update_UserData uS_Add_Update_UserData1;
    }
}