using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Driver_License_management
{
    public partial class FrmChangePassword : Form
    {
        ClsUser User = null;
        public FrmChangePassword(int UserID)
        {
            InitializeComponent();
            uS_Card_User_info1.LoadData(UserID);
            User = ClsUser.Find(UserID);
            Reset();

        }
        public FrmChangePassword()
        {
            InitializeComponent();

        }

        private void Txt_CurPassword_Validated(object sender, EventArgs e)
        {
            if (ClsUtility.ComputeHash(Txt_CurPassword.Text) != User.Password&& Txt_CurPassword.Text.Length>0) {
                errorProvider1.SetError(Txt_CurPassword, "This not Current Password");
            }
            else
            {
                errorProvider1.SetError(Txt_CurPassword,"");

            }
        }

        private void Txt_ConfirmNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (Txt_ConfirmNewPassword.Text != Txt_NewPassword.Text)
            {
                errorProvider1.SetError(Txt_ConfirmNewPassword, "This not Match Password");
            }
            else
            {
                errorProvider1.SetError(Txt_ConfirmNewPassword, "");

            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool IsRight()
        {
            return ClsUtility.ComputeHash(Txt_CurPassword.Text)==User.Password&&Txt_NewPassword.Text==Txt_ConfirmNewPassword.Text;
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (IsRight())
            {
                User.Password = ClsUtility.ComputeHash(Txt_NewPassword.Text);

                if (User.Save())
                {
                    MessageBox.Show("Saved Successfuly");
                    Reset();
                }
                else
                {
                    MessageBox.Show("Failed");

                }
            }
            else
            {
                MessageBox.Show("Sure From Password or new Password Match Confirm Password");
            }
        }
        void Reset()
        {
            Txt_ConfirmNewPassword.Text = Txt_CurPassword.Text = Txt_NewPassword.Text = "";
            Txt_CurPassword.Focus();
        }
    }
}
