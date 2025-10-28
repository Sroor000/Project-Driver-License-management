namespace DVLD_Presntation_Layer
{
    partial class FrmUpdateApplicationType
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
            this.LB_ApptypeID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LB_ShowID = new System.Windows.Forms.Label();
            this.Txt_Title = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn_Exit = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Save = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // LB_ApptypeID
            // 
            this.LB_ApptypeID.AutoSize = true;
            this.LB_ApptypeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ApptypeID.Location = new System.Drawing.Point(117, 35);
            this.LB_ApptypeID.Name = "LB_ApptypeID";
            this.LB_ApptypeID.Size = new System.Drawing.Size(40, 20);
            this.LB_ApptypeID.TabIndex = 0;
            this.LB_ApptypeID.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Title :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fees :";
            // 
            // LB_ShowID
            // 
            this.LB_ShowID.AutoSize = true;
            this.LB_ShowID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_ShowID.Location = new System.Drawing.Point(186, 35);
            this.LB_ShowID.Name = "LB_ShowID";
            this.LB_ShowID.Size = new System.Drawing.Size(59, 20);
            this.LB_ShowID.TabIndex = 0;
            this.LB_ShowID.Text = "label1";
            // 
            // Txt_Title
            // 
            this.Txt_Title.Location = new System.Drawing.Point(190, 68);
            this.Txt_Title.Name = "Txt_Title";
            this.Txt_Title.Size = new System.Drawing.Size(147, 22);
            this.Txt_Title.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(190, 110);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(147, 22);
            this.textBox2.TabIndex = 1;
            // 
            // Btn_Exit
            // 
            this.Btn_Exit.AutoRoundedCorners = true;
            this.Btn_Exit.CheckedState.ForeColor = System.Drawing.Color.Red;
            this.Btn_Exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Btn_Exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Btn_Exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Btn_Exit.FillColor = System.Drawing.Color.Black;
            this.Btn_Exit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Exit.ForeColor = System.Drawing.Color.Teal;
            this.Btn_Exit.Location = new System.Drawing.Point(95, 169);
            this.Btn_Exit.Name = "Btn_Exit";
            this.Btn_Exit.Size = new System.Drawing.Size(87, 45);
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
            this.Btn_Save.FillColor = System.Drawing.Color.Black;
            this.Btn_Save.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Btn_Save.ForeColor = System.Drawing.Color.Teal;
            this.Btn_Save.Location = new System.Drawing.Point(225, 169);
            this.Btn_Save.Name = "Btn_Save";
            this.Btn_Save.Size = new System.Drawing.Size(87, 45);
            this.Btn_Save.TabIndex = 6;
            this.Btn_Save.Text = "Save";
            this.Btn_Save.Click += new System.EventHandler(this.Btn_Save_Click);
            // 
            // FrmUpdateApplicationType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(372, 238);
            this.Controls.Add(this.Btn_Exit);
            this.Controls.Add(this.Btn_Save);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Txt_Title);
            this.Controls.Add(this.LB_ShowID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_ApptypeID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FrmUpdateApplicationType";
            this.Text = "Update Application Type";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_ApptypeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LB_ShowID;
        private System.Windows.Forms.TextBox Txt_Title;
        private System.Windows.Forms.TextBox textBox2;
        private Guna.UI2.WinForms.Guna2Button Btn_Save;
        private Guna.UI2.WinForms.Guna2Button Btn_Exit;
    }
}