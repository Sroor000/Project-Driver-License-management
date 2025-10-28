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
    public partial class US_LDLinfo : UserControl
    {
        public US_LDLinfo()
        {
            InitializeComponent();
        }
        public void LoadData(int LDL_ApplicationID)
        {

            ClsLocalLicenseApplication localApp = ClsLocalLicenseApplication.Find(LDL_ApplicationID);
            LB_DLAppID.Text = localApp.LocalDrivingLicenseApplicationID.ToString();
            LB_TypeOFLicense.Text = ClsUtility.Get_ClassLicense_NameBYClassLicenseID(localApp.LicenseClassID)+"/3";
            LB_PassedTests.Text = localApp.PassedTest.ToString();
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LB_Title_Click(object sender, EventArgs e)
        {

        }
    }
}
