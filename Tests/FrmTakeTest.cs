using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Driver_License_management
{
    public partial class FrmTakeTest : Form
    {


        ClsTests test = null;
        public FrmTakeTest(int testAppointmentID,int TrialNumber)
        {
            InitializeComponent();
            RDBtn_Fail.Checked = true;
            test = new ClsTests(testAppointmentID);
            LB_TrialCount.Text = TrialNumber.ToString();
            LoadTestData();

      
        }
        void LoadTestData()
        {
            LB_D_L_AppID.Text = test.LocalDrivingLicenseApplicationID.ToString();
            LB_FeesApp.Text = test.PaidFees.ToString();
            LB_NameApplicant.Text = ClsLocalLicenseApplication.NameApplicant(test.LocalDrivingLicenseApplicationID);
            LB_D_Class.Text = ClsUtility.Get_ClassLicense_NameBYD_APPID(test.LocalDrivingLicenseApplicationID);
            LB_Date.Text = test.AppointmentDate.ToString();


        }
        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void AssignValueTestInfo()
        {
            test.IsLocked = true;
            test.TestResult = RDBtn_Pass.Checked;
            test.Notes = textBox1.Text;
        }
        void DisableItem()
        {
            Btn_Save.Enabled = false;
            RDBtn_Pass.Enabled = RDBtn_Fail.Checked = false;
            textBox1.Enabled = false;
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            AssignValueTestInfo();
            if (test.Save())
            {
                MessageBox.Show("Succed");
                LB_TestID.Text = test.TestID.ToString();
                DisableItem();
            }
        }
    }
}
