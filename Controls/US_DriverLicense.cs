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
    public partial class US_DriverLicense : UserControl
    {
        int DriverID {  get; set; }
        public US_DriverLicense()
        {
            InitializeComponent();
            uS_Find_PeopleData1.HideButton();
        }
      public  void LoadData(int PersonID)

        {
            this.DriverID = ClsUtility.GetDirverIDBYPersonID(PersonID);
            uS_Find_PeopleData1.LoadData(PersonID);
            LoadDataLocalLicense();

        }
        void LoadDataLocalLicense()
        {
         DGV_LocalLicenses.DataSource=ClsDrivers.GetAllLicensesInfoByDriverID(this.DriverID);
        }
        void LoadDataInterNaitonalLicense()
        {
            DGV_InternationalLicenses.DataSource = ClsDrivers.GetAllInternationalLicensesInfoByDriverID(this.DriverID);
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                LoadDataLocalLicense();
            }
            else 
            {
                LoadDataInterNaitonalLicense();
            }
        }
    }
}
