using DVLD_Presntation_Layer;
using System;
using System.Collections;
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
    public partial class FrmShowDetainedLicenses : Form
    {
        int licenseID = -1;
        public FrmShowDetainedLicenses()
        {
            InitializeComponent();
            uS_ShowTableData1.Btn_AddAction+=(se,ee)=> { ShowDetainForm_Click(); };
            uS_ShowTableData1.DelID += GetLicenseID;

            LoadData();
        }
   void      LoadData()
        {
            uS_ShowTableData1.LoadData(ClsLicense.GetDetainedLicenses());
        }
        void GetLicenseID(Hashtable HT)
        {
            licenseID = ClsUtility.INT(HT["LicenseID"].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRelease_DetainLicense frm = new FrmRelease_DetainLicense(-1, false);
            frm.FormClosed+=(se,ee)=> { LoadData(); };
            frm.ShowDialog();
        }
        private void ShowDetainForm_Click()
        {
            FrmRelease_DetainLicense frm = new FrmRelease_DetainLicense(-1, true);
            frm.FormClosed += (se, ee) => { LoadData(); };
            frm.ShowDialog();

        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClsLicense license = ClsLicense.Find(licenseID);
            FrmShowPersonInfo frm = new FrmShowPersonInfo(ClsUtility.GetPersonIDBYDriverID(license.DriverID));
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmShowLicenseInfo frm = new FrmShowLicenseInfo(licenseID,ClsLicense.Find(licenseID).DriverID);
            frm.FormClosed += (se, ee) => { LoadData(); };
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowDriverLicenseInfoHistory frm = new FrmShowDriverLicenseInfoHistory(ClsUtility.GetPersonIDBYDriverID(ClsLicense.Find(licenseID).DriverID));
            frm.ShowDialog();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRelease_DetainLicense frm = new FrmRelease_DetainLicense(licenseID, false);
            frm.FormClosed += (se, ee) => { LoadData(); };
            frm.ShowDialog();
        }
    }
}
