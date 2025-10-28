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
    public partial class FrmShowInternationalLicenses : Form
    {
        public FrmShowInternationalLicenses()
        {
            InitializeComponent();
            LoadData();
        }
  
        ClsInternationalLicenseApplication Ilicense=null;
        void LoadData()
        {
            uS_ShowTableData1.DelID += GetDriverID;
            uS_ShowTableData1.LoadData(ClsInternationalLicenseApplication.GetAllInternationalLicenses());
            uS_ShowTableData1.Btn_AddAction +=( Se,  ee)=> AddNewApplication();

        }
        void AddNewApplication()
        {
            FrmIssueinternationlLicense frm = new FrmIssueinternationlLicense();
            frm.ShowDialog();
        }
        void GetDriverID(Hashtable HT)
        {
          int   I_LiceseID = ClsUtility.INT(HT["InternationalLicenseID"].ToString());
            Ilicense=ClsInternationalLicenseApplication.Find(I_LiceseID);
        }
        private void showLicenseHistroyToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmShowDriverLicenseInfoHistory frm = new FrmShowDriverLicenseInfoHistory(ClsUtility.GetPersonIDBYDriverID(Ilicense.DriverID));
            frm.ShowDialog();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowPersonInfo frm = new FrmShowPersonInfo(ClsUtility.GetPersonIDBYDriverID(Ilicense.DriverID));
            frm.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowInternationalLicense frm = new FrmShowInternationalLicense(Ilicense.InternationalLicenseID);
            frm.ShowDialog();
        }
    }
}
