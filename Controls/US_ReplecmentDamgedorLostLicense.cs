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
    public partial class US_ReplecmentDamgedorLostLicense : UserControl
    {
        public US_ReplecmentDamgedorLostLicense()
        {
            InitializeComponent();
            LoadBasicApplicationINfo();
        }
        ClsLicense license = null;
        public EventHandler delClose = null;
     
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
                if (ClsLicense.IS_ExpireLicense(license.LicenseID))
                {
                    MessageBox.Show($"The Licesen IS Expired Can't Renew From Here You can From Page Renew Expired Licenses");


                }

                else if (license.IsActive && !ClsUtility.IsDetainedLicense(license.LicenseID))
                {
                    Btn_ReNew.Enabled = true;

                }
                else { MessageBox.Show($"The License With ID ={license.LicenseID} IS Not Active can't Do Any Opreation on It"); }

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
        
            LB_OldLicenseID.Text = license.LicenseID.ToString();
        }
        private void LKLB_ShowLIcenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowDriverLicenseInfoHistory licensehistory = new FrmShowDriverLicenseInfoHistory(ClsUtility.GetPersonIDBYDriverID(license.DriverID));
            licensehistory.ShowDialog();
        }

        private void LK_LB_ShowLinceseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowLicenseInfo frm = new FrmShowLicenseInfo(license.DriverID, license.LicenseID);
            frm.ShowDialog();
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
        
            LB_DateApp.Text = DateTime.Today.ToShortDateString();

        }

        private void LB_FeesApp_Click(object sender, EventArgs e)
        {

        }
        void AfterRenewLicense()
        {
            Btn_ReNew.Enabled = false;
            LK_LB_ShowLinceseInfo.Enabled = true;
            LB_I_LicenseApplication.Text = license.ApplicationID.ToString();
            LB_RLicenseID.Text = license.LicenseID.ToString();
            Txt_SearchLicense.Enabled = false;
            Btn_Search.Enabled = false;
        }

        private void Btn_ReNew_Click(object sender, EventArgs e)
        {
            ClsLocalLicenseApplication LocalApp=null;
            if(RDBtn_DamagedLicense.Checked)
             LocalApp = new ClsLocalLicenseApplication(ClsUtility.GetPersonIDBYDriverID(license.DriverID),ClsEnums.EnApplicationType.ReplacementForDamagedDrivingLicense,(ClsEnums.EnLicenseClass)license.LicenseClass);
            if(RDBtn_LostLicense.Checked)
                LocalApp = new ClsLocalLicenseApplication(ClsUtility.GetPersonIDBYDriverID(license.DriverID), ClsEnums.EnApplicationType.ReplacementForLostDrivingLicense, (ClsEnums.EnLicenseClass)license.LicenseClass);
          
            LocalApp.PassedTest = 3;
            LocalApp.ApplicationStatus = (int)ClsEnums.EnStateApplication.Compeleted;
            if (LocalApp.Save())
            {
                ClsLicense Newlicense = new ClsLicense(LocalApp.ApplicantPersonID, LocalApp.ApplicationID, ClsEnums.EnIssueReason.Renew);
          

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

        private void RDBtn_DamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            LB_FeesApp.Text = ClsUtility.GetFeesForApplicationType(ClsEnums.EnApplicationType.ReplacementForDamagedDrivingLicense).ToString();
        }

        private void RDBtn_LostLicense_CheckedChanged(object sender, EventArgs e)
        {
            LB_FeesApp.Text = ClsUtility.GetFeesForApplicationType(ClsEnums.EnApplicationType.ReplacementForLostDrivingLicense).ToString();
        }
    }
}
