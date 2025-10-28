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
    public partial class US_FindLicense : UserControl
    {
        ClsLicense license = null;
     public  EventHandler delClose=null;
        public US_FindLicense()
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
            int LicenseID=ClsUtility.INT(Txt_SearchLicense.Text);
            license=ClsLicense.Find(LicenseID);
            if (license != null)
            {
                if (ClsInternationalLicenseApplication.IsHave_InterNationalLicense(license.LicenseID))
                {
                    MessageBox.Show("This Driver Is ALready Have InterNational License  ");
                  

                }

                else if (license.IsActive && !ClsUtility.IsDetainedLicense(license.LicenseID))
                {
                    uS_LicenseInfoCardcs1.LoadDataLicenseInfoCard(license.DriverID, license.LicenseID);
                    Btn_Issue.Enabled = true;
                    LKLB_ShowLIcenseHistory.Enabled = true;
                }
                else
                {
                    MessageBox.Show($"The License With ID ={license.LicenseID} Not Active  ");
                }

            }
            else
            {
                MessageBox.Show("No License With This License ID", "Not Found", default, MessageBoxIcon.Error);
            }
        }
    
    void LoadBasicApplicationINfo()
        {
            LB_CreatedBY.Text = Current_User.CurrUser.UserName;
            LB_IssueDate.Text = DateTime.Today.ToShortDateString();
            LB_ExpirationDateLicense.Text = DateTime.Today.AddYears(1).ToShortDateString();
            LB_DateApp.Text=DateTime.Today.ToShortDateString();

        }

        private void LKLB_ShowLIcenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowDriverLicenseInfoHistory licensehistory = new FrmShowDriverLicenseInfoHistory(ClsUtility.GetPersonIDBYDriverID (license.DriverID));
            licensehistory.ShowDialog();
        }

        private void LK_LB_ShowLinceseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmShowInternationalLicense frm = new FrmShowInternationalLicense(ClsUtility.INT(LB_ILicenseID.Text));
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            delClose?.Invoke(sender, e);
        }

        private void Btn_Issue_Click(object sender, EventArgs e)
        {
              ClsApplication internationalApp=new ClsApplication(ClsUtility.GetPersonIDBYDriverID(license.DriverID),ClsEnums.EnApplicationType.NewInternationalLicense);
           if(
            internationalApp.Save())
            {
                ClsInternationalLicenseApplication NewI_License = new ClsInternationalLicenseApplication(internationalApp.ApplicationID, license.LicenseID);
                if (NewI_License.Save())
                {
                    MessageBox.Show($"Created Internaational License with ID ={NewI_License.InternationalLicenseID}");
                    LB_I_LicenseApplication.Text = NewI_License.ApplicationID.ToString();
                    LB_LLicenseID.Text = NewI_License.InternationalLicenseID.ToString();
                    LK_LB_ShowLinceseInfo.Enabled = true;
                    UnenabledComponanetAfterIssueLicense();



                }

            }
            
        }
        void UnenabledComponanetAfterIssueLicense()
        {
            Btn_Issue.Enabled = false;
            Txt_SearchLicense.Enabled = false;
            Btn_Search.Enabled = false;
        }

        private void US_FindLicense_Load(object sender, EventArgs e)
        {

        }
    }

}
