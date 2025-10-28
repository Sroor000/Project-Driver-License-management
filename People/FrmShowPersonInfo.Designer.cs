namespace Project_Driver_License_management
{
    partial class FrmShowPersonInfo
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
            this.uS_Card_People_Info1 = new Project_Driver_License_management.US_Card_People_Info();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // uS_Card_People_Info1
            // 
            this.uS_Card_People_Info1.BackColor = System.Drawing.Color.Honeydew;
            this.uS_Card_People_Info1.Location = new System.Drawing.Point(12, 12);
            this.uS_Card_People_Info1.Name = "uS_Card_People_Info1";
            this.uS_Card_People_Info1.PersonID = 0;
            this.uS_Card_People_Info1.Size = new System.Drawing.Size(877, 283);
            this.uS_Card_People_Info1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_Driver_License_management.Properties.Resources.Address_32;
            this.pictureBox1.Location = new System.Drawing.Point(116, 217);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // FrmShowPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(903, 307);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uS_Card_People_Info1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmShowPersonInfo";
            this.Text = "FrmShowPersonIndo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private US_Card_People_Info uS_Card_People_Info1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}