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
    public partial class US_BasicApplicationInfo : UserControl
    {
        ClsLocalLicenseApplication localApp = null;
        public US_BasicApplicationInfo()
        {
            InitializeComponent();
        }
        public void LoadData(int localAppID)
        {
          localApp = ClsLocalLicenseApplication.Find(localAppID);
            if (localApp == null) { return; }
            LB_ApplicationID.Text = localApp.ApplicationID.ToString();
            LB_StatusApp.Text = ClsApplication.GetType(localApp.ApplicationStatus);
            LB_FeesApp.Text = localApp.PaidFees.ToString();
            LB_TypeApp.Text = ClsUtility.Get_ClassLicense_NameBYClassLicenseID(localApp.LicenseClassID);
            LB_NameApplicant.Text = ClsPeople.Get_PersonFullName(localApp.ApplicantPersonID);
            LB_DateApp.Text =localApp.ApplicationDate.ToString();
            LB_StatusDateApp.Text = localApp.LastStatusDate.ToString();
            LB_CreatedBY.Text = ClsUser.GetUserName(localApp.CreatedByUserID);
        }

        private void LLB_ViewPersonalInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowPersonInfo person = new FrmShowPersonInfo(localApp.ApplicantPersonID);
            person.ShowDialog();
        }

       

        private void LB_TypeApp_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void LB_NameApplicant_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void LB_StatusDateApp_Click(object sender, EventArgs e)
        {

        }

        private void LB_StatusApp_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void LB_CreatedBY_Click(object sender, EventArgs e)
        {

        }

        private void LB_FeesApp_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void LB_DateApp_Click(object sender, EventArgs e)
        {

        }

        private void LB_ApplicationID_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
