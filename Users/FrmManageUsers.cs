using Project_Driver_License_management;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace DVLD_Presntation_Layer
{
    public partial class FrmManageUsers : Form
    {
       
        int UserID {  get; set; }
        public FrmManageUsers()
        {
            InitializeComponent();
      LoadTableData();


        }
        void LoadTableData()
        {
            uS_ShowTableData1.Btn_AddAction += AddUser;
            uS_ShowTableData1.DelID += GetUserID;
            LoadData();
 
            uS_ShowTableData1.HideColumn("Password");
        }
    void    GetUserID(Hashtable ht)
        {
            this.UserID = int.Parse(ht["UserID"].ToString());
        }
        void LoadData()
        {
            uS_ShowTableData1.LoadData(ClsUser.GetAllUserData());   
        }
        void AddUser(object sender,EventArgs e)
        {
            FrmAdd_Update_UserData f=new FrmAdd_Update_UserData();
            f.Show();
            LoadData();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowUserInfo frm=new FrmShowUserInfo(UserID);
            frm.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdd_Update_UserData frm=new FrmAdd_Update_UserData(UserID);
            frm.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser(sender,e);
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsUser.DeleteUserData(UserID);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ClsUser.IsExist_User(UserID) == false)
            {
                MessageBox.Show($"This UserID: {UserID}  Not Exist In System");
                return;  
            }
            FrmChangePassword frm=new FrmChangePassword(UserID);
            frm.Show();
        }
    }
}
