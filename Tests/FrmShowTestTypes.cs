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
    public partial class FrmShowTestTypes : Form
    {
        ClsTestTypes testType = null;

        public FrmShowTestTypes()
        {
            InitializeComponent();
            uS_ShowTableData1.DelID += GetSelectID;
            LoadData();
        }

        void LoadData()
        {
            uS_ShowTableData1.LoadData(ClsTestTypes.GetAllTestTypesInfo());
            uS_ShowTableData1.HideButtonAdd();
            uS_ShowTableData1.HideButtonFilter();
        }

        void GetSelectID(Hashtable ht)
        {
            testType = ClsTestTypes.Find(int.Parse(ht["TestTypeID"].ToString()));
        }

      

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUpdateTestType frm = new FrmUpdateTestType(testType.TestID);


          frm.FormClosed+=(se,ee)=>{ uS_ShowTableData1.LoadData(ClsTestTypes.GetAllTestTypesInfo()); };
            frm.Show();
        }
    }
}
