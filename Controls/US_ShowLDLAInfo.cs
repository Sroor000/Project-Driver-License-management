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
    internal partial  class US_ShowLDLAInfo : UserControl
    {
        ClsLocalLicenseApplication localApp = null;
       public int TestAppointmentID { get; set; }
    public    EventHandler Btn_Adddel = null;
        public US_ShowLDLAInfo()
        {
            InitializeComponent();
            uS_ShowTableData1.DelID += GetIDTestAppointment;
            uS_ShowTableData1.Btn_AddAction+=AddTestAppinment;
        }
        void GetIDTestAppointment(Hashtable HT)
        {
            if(HT.Count!=0) TestAppointmentID = int.Parse(HT["TestAppointmentID"].ToString());
        }
    void AddTestAppinment(object sender, EventArgs e)
        {
            Btn_Adddel.Invoke(sender, e);
        }
       public  void LoadData(int LocalAppID,int TestTypeID)
        {
            this.localApp=ClsLocalLicenseApplication.Find(LocalAppID);
            uS_LDLinfo1.LoadData(localApp.LocalDrivingLicenseApplicationID);
            uS_BasicApplicationInfo1.LoadData(localApp.LocalDrivingLicenseApplicationID);
            LoadDataTableTestAppoinments(TestTypeID);

        }
  
          public int RowCounts()
        {
          return  uS_ShowTableData1.RowsCount();
        }

      
        void LoadDataTableTestAppoinments(int testType)
        {

            switch (testType) {
                case 1:
                    uS_ShowTableData1.LoadData(ClsTestAppointments.GetAppiointMents_forVision(localApp.LocalDrivingLicenseApplicationID));
                    break;
                case 2:
                    uS_ShowTableData1.LoadData(ClsTestAppointments.GetAppiointMents_forWritten(localApp.LocalDrivingLicenseApplicationID));
                    break;
                case 3:
                    uS_ShowTableData1.LoadData(ClsTestAppointments.GetAppiointMents_forStreet(localApp.LocalDrivingLicenseApplicationID));
                    break;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

                }

        private void uS_ShowTableData1_Load(object sender, EventArgs e)
        {

        }
    }
    }
