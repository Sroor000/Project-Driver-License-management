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

namespace DVLD_Presntation_Layer
{
    public partial class FrmShowApplicationsTypes : Form
    {
       ClsApplicationsTypes apptype = null;
        public FrmShowApplicationsTypes()
        {
            InitializeComponent();
            uS_ShowTableData1.DelID += GetSelectID;
            LoadData();
        }
        void LoadData()
        {
            
            uS_ShowTableData1.LoadData(ClsApplicationsTypes.GetAllApplicationTypesInfo());
            uS_ShowTableData1.HideButtonAdd();
            uS_ShowTableData1.HideButtonFilter();


        }
        void GetSelectID(Hashtable ht)
        {
            apptype = ClsApplicationsTypes.Find(int.Parse(ht["ApplicationTypeID"].ToString()));
        }
        private void editAppLicatioTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateApplicationType frm = new FrmUpdateApplicationType(apptype.ApplicationID);
       frm.FormClosed+= (se,ee)=> uS_ShowTableData1.LoadData(ClsApplicationsTypes.GetAllApplicationTypesInfo());
            frm.Show();

        }
    }
}
