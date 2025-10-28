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
    public partial class US_CardInternationalLicenseInfo : US_CardLicenseInfo
    {
        public US_CardInternationalLicenseInfo()
        {
            InitializeComponent();

      
        }
       public  void LoadDatainternationallicense( int InternationallicenseID)
        {
            ClsInternationalLicenseApplication Ilicense=ClsInternationalLicenseApplication.Find(InternationallicenseID);
            base.LoadDataLicenseInfoCard(Ilicense.DriverID, Ilicense.IssuedUsingLocalLicenseID);
           LB_I_LicenseID.Text=Ilicense.InternationalLicenseID.ToString();
            LB_ApplicationID.Text=Ilicense.ApplicationID.ToString();


        }

    }
}
