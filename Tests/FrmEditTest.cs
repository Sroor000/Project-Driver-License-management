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
    public partial class FrmEditTest : Form
    {
      
        ClsTestAppointments test = null;
        public FrmEditTest(int testAppointmentID,int TrialNumber)
        {
            InitializeComponent();
            test = ClsTestAppointments.Find(testAppointmentID);
            LB_TrialCount.Text=TrialNumber.ToString();
            LoadTestData();
            SetDateTimePicker();
            if (TrialNumber > 1)
            {
                LoadRetakeTestInfo();
                
                  
                
            }
        }
        public FrmEditTest(int localAppID,int testType,int TrialNumber )
        {
            InitializeComponent();
 test = new  ClsTestAppointments(localAppID,testType);
            
            LB_TrialCount.Text =TrialNumber.ToString();
            LoadTestData();
          
        }
        void LoadTestData()
        {
            
            LB_D_L_AppID.Text=test.LocalDrivingLicenseApplicationID.ToString();
             LB_FeesApp.Text=test.PaidFees.ToString();
            LB_NameApplicant.Text = ClsLocalLicenseApplication.NameApplicant(test.LocalDrivingLicenseApplicationID);
            LB_D_Class.Text = ClsUtility.Get_ClassLicense_NameBYD_APPID(test.LocalDrivingLicenseApplicationID);
            LB_TotalFees.Text = test.PaidFees.ToString();
            

        }
        void LoadRetakeTestInfo()
        {
            LB_TotalFees.Text = (ClsUtility.INT(LB_TotalFees.Text)+5).ToString();
            LB_RAppFees.Text = "5";
            LB_RTestAppID.Text = test.TestAppointmentID.ToString();
        }
        void SetDateTimePicker()
        {
            dateTimePicker1.MinDate =DateTime.Today ;
            dateTimePicker1.Value = test.AppointmentDate;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (test != null)
            {
                test.AppointmentDate = dateTimePicker1.Value;
                if (test.Save())
                {
                    MessageBox.Show("Succed");
                }
            }
            else
            {
              
                
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
