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
    public partial class US_CardLicenseInfo : UserControl
    {
        ClsDrivers driver = null;
        ClsLicense license = null;
      
        public US_CardLicenseInfo()
        {
            InitializeComponent();
      
         
        }
        public virtual void  LoadDataLicenseInfoCard(int DriverID,int LicenseID)
        {
            driver = ClsDrivers.Find(DriverID);
            license = ClsLicense.Find(LicenseID);

            LB_Class.Text = ClsUtility.Get_ClassLicense_NameBYClassLicenseID(license.LicenseClass);
            LB_LicenseID.Text = license.LicenseID.ToString();
            LB_IsActive.Text = license.IsActive ? "Yes" : "No";
            LB_IssueDate.Text = license.IssueDate.ToString("dd/MMM/yyyy");
            LB_ExpirationDate.Text = license.ExpirationDate.ToString("dd/MMM/yyyy");
            LB_IssueReason.Text =ClsUtility.GetNameIssueReason((ClsEnums.EnIssueReason)license.IssueReason);
            LB_IsDetained.Text = ClsUtility.IsDetainedLicense(license.LicenseID)==true?"YES":"NO";
            LB_Notes.Text = string.IsNullOrEmpty(license.Notes) ? "No Notes" : license.Notes;

           
            LB_Name.Text = driver.GetFullName();
            LB_NationalNo.Text = driver.National_No;
            LB_DateOfBirth.Text = driver.DateOfBirth.ToShortDateString();
            LB_Gender.Text = driver.Gender=="0"?"Male":"Female";
            LB_DriverID.Text = driver.DriverID.ToString();
            PB_PersonalImage.Image=Image.FromFile(driver.ImagePath);
         
          
        }

        private void LB_IssueDate_Click(object sender, EventArgs e)
        {

        }
    }
}
