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
    public partial class US_RenewLicesne : UserControl
    {
        ClsLicense license = null;
        public EventHandler delClose = null;
        public US_RenewLicesne()
        {
            InitializeComponent();
            LoadBasicApplicationINfo();
        }
        private void Txt_SearchLicense_TextChanged(object sender, EventArgs e)
        {
            ClsUtility.ValidateNumber(Txt_SearchLicense, e);
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            int LicenseID = ClsUtility.INT(Txt_SearchLicense.Text);
            license = ClsLicense.Find(LicenseID);
            if (license != null)
            {
                  uS_LicenseInfoCardcs1.LoadDataLicenseInfoCard(license.DriverID, license.LicenseID);
                
                LoadDataRenewLicense();
                if (!ClsLicense.IS_ExpireLicense(license.LicenseID))
                {
                    MessageBox.Show($"The Licesen NOT Expired Yet ,It Will Expire in {license.ExpirationDate.ToShortDateString()}  ");
                  

                }

                else if (license.IsActive && !ClsUtility.IsDetainedLicense(license.LicenseID))
                {
                    Btn_ReNew.Enabled = true;
                   
                }
               

            }
            else
            {
                MessageBox.Show("No License With This License ID", "Not Found", default, MessageBoxIcon.Error);
            }
        }
        void LoadDataRenewLicense()
        {
            LKLB_ShowLIcenseHistory.Enabled = true;
            LB_FeesApp.Text = ClsUtility.GetFeesForApplicationType(ClsEnums.EnApplicationType.RenewDrivingLicenseService).ToString();
            LB_License_Fees.Text=ClsUtility.GetFeesLicense(license.LicenseClass).ToString();
            LB_TotalFees.Text=(ClsUtility.INT(LB_FeesApp.Text)+ClsUtility.INT(LB_License_Fees.Text)).ToString();
            LB_OldLicenseID.Text = license.LicenseID.ToString();
        }
        private void LKLB_ShowLIcenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowDriverLicenseInfoHistory licensehistory = new FrmShowDriverLicenseInfoHistory(ClsUtility.GetPersonIDBYDriverID(license.DriverID));
            licensehistory.ShowDialog();
        }

        private void LK_LB_ShowLinceseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowLicenseInfo frm = new FrmShowLicenseInfo(license.DriverID,license.LicenseID);
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            delClose?.Invoke(sender, e);
        }
        void UnenabledComponanetAfterIssueLicense()
        {
            Btn_ReNew.Enabled = false;
        
        }
        void LoadBasicApplicationINfo()
        {
            LB_CreatedBY.Text = Current_User.CurrUser.UserName;
            LB_IssueDate.Text = DateTime.Today.ToShortDateString();
            LB_ExpirationDateLicense.Text = DateTime.Today.AddYears(1).ToShortDateString();
            LB_DateApp.Text = DateTime.Today.ToShortDateString();

        }

        private void LB_FeesApp_Click(object sender, EventArgs e)
        {

        }
        void AfterRenewLicense()
        {
            Btn_ReNew.Enabled = false;
            LK_LB_ShowLinceseInfo.Enabled = true;
            LB_I_LicenseApplication.Text=license.ApplicationID.ToString();
            LB_RLicenseID.Text=license.LicenseID.ToString();
            Txt_SearchLicense.Enabled = false;
            Btn_Search.Enabled = false;
        }

        private void Btn_ReNew_Click(object sender, EventArgs e)
        {

            ClsLocalLicenseApplication LocalApp = new ClsLocalLicenseApplication(ClsUtility.GetPersonIDBYDriverID(license.DriverID), ClsEnums.EnApplicationType.NewLocalDrivingLicenseService, (ClsEnums.EnLicenseClass)license.LicenseClass);
          
            LocalApp.PassedTest = 3;
           
            LocalApp.ApplicationStatus=(int)ClsEnums.EnStateApplication.Compeleted;
            if (LocalApp.Save()) 
            {
                ClsLicense Newlicense = new ClsLicense(LocalApp.ApplicantPersonID,LocalApp.ApplicationID,ClsEnums.EnIssueReason.Renew);
               Newlicense.Notes=Txt_Notes.Text!=""?Txt_Notes.Text:null;
                Newlicense.PaidFees = ClsUtility.INT(LB_TotalFees.Text);

                if (Newlicense.Save())
                {

                    MessageBox.Show($"Succed Creation new Local Diriving License with ID {Newlicense.LicenseID}");

                    ActiveLessOldLicense();

                    license = Newlicense;

                    AfterRenewLicense();

                }
            } 
        }
        void ActiveLessOldLicense()
        {
            license.IsActive = false;
            if (license.Save())
            {
                MessageBox.Show($"ActiveLess The Old license Is Done ");
            }
        }
    }
}
