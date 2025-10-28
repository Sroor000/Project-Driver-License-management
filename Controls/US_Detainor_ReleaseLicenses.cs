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
    public partial class US_Detainor_ReleaseLicenses : UserControl
    { 
        ClsLicense license = null;
        public EventHandler delClose =null;
        public US_Detainor_ReleaseLicenses()
        {
            InitializeComponent();
            LoadBasicApplicationINfo();
        }
      
     public   void LoadDetainForm()
        {
            Btn_Search.Click += Btn_SearchforDetain_Click;
            Btn_ReNew.Click += Btn_DetanLicense_Click;
            VisibleDetainForm();

        }
        public void LoadDetainForm(int LicenseID)
        {
            Txt_SearchLicense.Text = LicenseID.ToString();
            unEnableTextsearch(LicenseID.ToString());
            Btn_Search.Click += Btn_SearchforDetain_Click;
            Btn_ReNew.Click += Btn_DetanLicense_Click;
            VisibleDetainForm();
         
        }
        public void LoadReleaseForm()
        {
            Btn_Search.Click += Btn_SearchforRelease_Click;
            Btn_ReNew.Click += Btn_ReleaseLicense_Click;
            VisibleReleaseForm();
        
  
        }
        public void LoadReleaseForm(int LicenseID)
        {
            Txt_SearchLicense.Text = LicenseID.ToString();
            unEnableTextsearch(LicenseID.ToString());
            Btn_Search.Click += Btn_SearchforRelease_Click;
            Btn_ReNew.Click += Btn_ReleaseLicense_Click;
            Btn_Search.PerformClick();
            VisibleReleaseForm();

        
        }
        void VisibleDetainForm()
        {
            LB_GetFineFees.Visible = true;
            Txt_Fine.Visible = true;
            Btn_ReNew.Text = "Detain";

        }
        void VisibleReleaseForm()
        {
            LB_FineFees.Visible = true;
            LB_ShowFineFees.Visible = true;
            LB_ShowApplicationFees.Visible = true;
            LB_AppID.Visible = true;
            LB_ShowAppID.Visible = true;
            LB_FeesApp.Visible = true;
            LB_ShowTotalFees.Visible = true;
            LB_TotalFees.Visible = true;
            Btn_ReNew.Text = "Release";
             


        }
        private void Txt_SearchLicense_TextChanged(object sender, EventArgs e)
        {
            ClsUtility.ValidateNumber(Txt_SearchLicense, e);
        }

        private void Btn_SearchforRelease_Click(object sender, EventArgs e)
        {
            int LicenseID = ClsUtility.INT(Txt_SearchLicense.Text);
            license = ClsLicense.Find(LicenseID);
            if (license != null)
            {
                uS_LicenseInfoCardcs1.LoadDataLicenseInfoCard(license.DriverID, license.LicenseID);

                LoadDataRenewLicense();
                if (!ClsLicense.IsDetainedLicense(license.LicenseID))
                {
                    MessageBox.Show($"The License Not Detained So Can't Released  it   ");


                }

                else if (license.IsActive && ClsUtility.IsDetainedLicense(license.LicenseID))
                {
                    Btn_ReNew.Enabled = true;
                    LB_DetainID.Text = ClsLicense.GetDetainID(license.LicenseID).ToString();
                    LB_FineFees.Text = license.GetFineFees().ToString();
                    LB_FeesApp.Text = ClsUtility.GetFeesForApplicationType(ClsEnums.EnApplicationType.ReleaseDetainedDrivingLicense).ToString();
                    LB_TotalFees.Text = (ClsUtility.DOUBLE(LB_FineFees.Text) + ClsUtility.DOUBLE(LB_FeesApp.Text)).ToString();
                }


            }
            else
            {
                MessageBox.Show("No License With This License ID", "Not Found", default, MessageBoxIcon.Error);
            }
        }
        private void Btn_SearchforDetain_Click(object sender, EventArgs e)
        {
            int LicenseID = ClsUtility.INT(Txt_SearchLicense.Text);
            license = ClsLicense.Find(LicenseID);
            if (license != null)
            {
                uS_LicenseInfoCardcs1.LoadDataLicenseInfoCard(license.DriverID, license.LicenseID);

                LoadDataRenewLicense();
                if (ClsLicense.IsDetainedLicense(license.LicenseID))
                {
                    MessageBox.Show($"The Licesen Is Already Detained    ");


                }
                else
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
           
            LB_LicenseID.Text = license.LicenseID.ToString();
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
            LB_DetainDate.Text = DateTime.Today.ToShortDateString();
          

        }

        private void LB_FeesApp_Click(object sender, EventArgs e)
        {

        }
        void AfterReleaseLicense()
        {
            Btn_ReNew.Enabled = false;
            LK_LB_ShowLinceseInfo.Enabled = true;
           
           unEnableTextsearch(license.LicenseID.ToString());
        }
        void AfterDetainLicense()
        {
            Btn_ReNew.Enabled = false;
            LK_LB_ShowLinceseInfo.Enabled = true;
            LB_DetainID.Text = license.GetDetainID().ToString();

            unEnableTextsearch(license.LicenseID.ToString());
        }
        void unEnableTextsearch(string text)
        {
            Txt_SearchLicense.Text = text;
            Txt_SearchLicense.Enabled = false;
            Btn_Search.Enabled = false;
        }
        private void Btn_DetanLicense_Click(object sender, EventArgs e)
        {
            if(double.TryParse(Txt_Fine.Text,out double fees))
            {
                if(fees<=0)
                {
                    MessageBox.Show("The Total Fees Must Be Greater Than Zero");
                    return;
                }
            }
            else
            {
                MessageBox.Show("The Total Fees Must Be Number");
                return;
            }
            double DoubleFees = ClsUtility.DOUBLE(Txt_Fine.Text);

           
            if (ClsLicense.DetainLicense(license.LicenseID, DoubleFees)!=-1)
            {
                AfterDetainLicense();
                uS_LicenseInfoCardcs1.LoadDataLicenseInfoCard(license.DriverID, license.LicenseID);

                LoadDataRenewLicense();
            }
            ;

        }

        private void Btn_ReleaseLicense_Click(object sender, EventArgs e)
        {
            ClsApplication app=new ClsApplication(ClsUtility.GetPersonIDBYDriverID(license.DriverID),ClsEnums.EnApplicationType.ReleaseDetainedDrivingLicense );
            if (app.Save())
            {

                if (ClsLicense.ReleaseLicense(license.GetDetainID(), license.LicenseID, app.ApplicationID))
                {
                    MessageBox.Show("The License Released Successfully");
                    AfterReleaseLicense();
                    LB_AppID.Text = app.ApplicationID.ToString();
                }
                else
                {
                    MessageBox.Show("Error In Release The License");
                }
                
            }
        }

        private void Txt_Fine_TextChanged(object sender, EventArgs e)
        {
            ClsUtility.ValidateNumber(this.Txt_Fine,e);
        }
    }
}
