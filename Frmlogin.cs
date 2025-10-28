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
    public partial class Frmlogin : Form
    {
        public static string Password{get;set;}
        public static string UserName{get;set; }
        public Frmlogin()
        {
            InitializeComponent();
        }
        public Frmlogin(string UserName,string Password)
        {
            InitializeComponent();
            Txt_Password.Text = Password;
            Txt_UserName.Text = UserName;
            Txt_UserName.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }
      
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            Current_User.CurrUser = ClsUser.Find( Txt_UserName.Text, ClsUtility.ComputeHash(Txt_Password.Text));
            if (Current_User.CurrUser != null ) {
               

                this.Hide();
            FrmDVDL frmDVDL = new FrmDVDL(checkBox1.Checked);
                frmDVDL.ShowDialog();
                
              

            }
            else
            {
                Txt_Password.Text = "";
                Txt_UserName.Text = "";
                Txt_UserName.Focus();
                MessageBox.Show("Not Exist Username Or Password");
            }
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
