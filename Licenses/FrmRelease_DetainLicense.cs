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
    public partial class FrmRelease_DetainLicense : Form
    {
        public FrmRelease_DetainLicense(int LicenseID,bool DetainForm)
        {
            InitializeComponent();
            uS_Detainor_ReleaseLicenses1.delClose += (s, e) => { this.Close(); };
            if (LicenseID != -1 && DetainForm)
            {
                this.Text = "Detain License";
                LB_Header.Text = "Detain License";
                uS_Detainor_ReleaseLicenses1.LoadDetainForm(LicenseID);
            }
            else if (LicenseID != -1 && !DetainForm)
            { 
                this.Text = "Release License";
                LB_Header.Text = "Release License";
                uS_Detainor_ReleaseLicenses1.LoadReleaseForm(LicenseID);
            }
            else if (LicenseID == -1 && DetainForm)
            {
                this.Text = "Detain License";
                LB_Header.Text = "Detain License";
                uS_Detainor_ReleaseLicenses1.LoadDetainForm();
            }
            else 
            {   this.Text = "Release License";
                LB_Header.Text = "Release License";
                uS_Detainor_ReleaseLicenses1.LoadReleaseForm();
            }

        }
    }
}
