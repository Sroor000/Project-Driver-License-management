using DVLD_Presntation_Layer;
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
    public partial class FrmDVDL : Form
    {
        public bool remember = false;
        public FrmDVDL(bool q)
        {
            InitializeComponent();
           remember = q;

        }
     



        private void Btn_People_Click(object sender, EventArgs e)
        {
            FrmManagePeople frmManagePeople = new FrmManagePeople();
       frmManagePeople.ShowDialog();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Application_Click(object sender, EventArgs e)
        {
     //  Current_User.CurrUser=ClsUser.Find();
        }

        private void Btn_Drivers_Click(object sender, EventArgs e)
        {
            FrmManageDrivers Drivers=new FrmManageDrivers();
            Drivers.ShowDialog();
        }

        private void Btn_Users_Click(object sender, EventArgs e)
        {
            FrmManageUsers frmShowDataTable = new FrmManageUsers();
            frmShowDataTable.ShowDialog();
        }

        private void Btn_AccountSettings_Click(object sender, EventArgs e)
        {

        }

        private void accToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowUserInfo frmShowUserInfo = new FrmShowUserInfo(Current_User.CurrUser.UserID);
            frmShowUserInfo.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
         this.Hide();
           if(remember) new Frmlogin(Current_User.CurrUser.UserName, Current_User.CurrUser.Password).ShowDialog();
        else new Frmlogin().ShowDialog();
        }

        private void drivingLicesnseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageApplicationsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowApplicationsTypes frm= new FrmShowApplicationsTypes();
           frm.ShowDialog();
        }

        private void manageTestsTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowTestTypes frm = new FrmShowTestTypes();
            frm.ShowDialog();
       
        }

        private void localDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowLicensesApplication frm = new FrmShowLicensesApplication();
           frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddorUpdate_ApplicationLocalLicense frm=new FrmAddorUpdate_ApplicationLocalLicense();
            frm.ShowDialog();
        }

        private void interNationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIssueinternationlLicense frm=new FrmIssueinternationlLicense();
            frm.ShowDialog();
        }

        private void internationalDrivingLiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowInternationalLicenses frm=new FrmShowInternationalLicenses();
            frm.ShowDialog();   
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReNewLicense frm=new FrmReNewLicense();
            frm.ShowDialog();
        }

        private void replacmentForDamgeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReplacmentDamagedorLostLicense frm=new FrmReplacmentDamagedorLostLicense();
            frm.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowDetainedLicenses frm =new FrmShowDetainedLicenses();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelease_DetainLicense frm=new FrmRelease_DetainLicense(-1,true);
            frm.ShowDialog();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelease_DetainLicense
                frm = new FrmRelease_DetainLicense(-1, false);
            frm.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword frm=new FrmChangePassword(Current_User.CurrUser.UserID);
            frm.ShowDialog();
        }
    }
}
