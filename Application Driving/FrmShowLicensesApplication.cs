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
    public partial class FrmShowLicensesApplication : Form
    {
        int LLApplication {  get; set; }
        public FrmShowLicensesApplication()
        {
            InitializeComponent();
            uS_ShowTableData1.DelID += SelectIndex;
            uS_ShowTableData1.Btn_AddAction += AddNewLLicenseApplication;
           LoadData();

        }
        void LoadData()
        {
            uS_ShowTableData1.LoadData(ClsLocalLicenseApplication.GetAllLocalLicenseApplicationsView());
        }
        void SelectIndex(Hashtable HT)
        {
            LLApplication = int.Parse(HT["LocalDrivingLicenseApplicationID"].ToString());
        }
        void AddNewLLicenseApplication(object sender,EventArgs e)
        {
            FrmAddorUpdate_ApplicationLocalLicense frm=new FrmAddorUpdate_ApplicationLocalLicense();
            frm.FormClosed += (se, ee) => Reload();
            frm.ShowDialog();
        }

        private void addnewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewLLicenseApplication(sender, e);

        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cancel_Application();
            Reload();
            uS_ShowTableData1.FocusRow("LocalDrivingLicenseApplicationID",LLApplication.ToString());
        }
        void Reload()
        {
            uS_ShowTableData1.ReLoadData(ClsLocalLicenseApplication.GetAllLocalLicenseApplicationsView());
        }
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteApplication();
            Reload();
            

        }
        void Cancel_Application()
        {
            ClsLocalLicenseApplication localapp = ClsLocalLicenseApplication.Find(LLApplication);
          
            
          
            if (localapp != null)
            {
                localapp.ApplicationStatus = 2;
                localapp.Save();
            }
            else { MessageBox.Show("No Application with This ID"); }
        }
        void DeleteApplication()
        {
            ClsLocalLicenseApplication localapp = ClsLocalLicenseApplication.Find(LLApplication);
            if (localapp != null && localapp.Delete())
            {
              
            }
            else
            {
                { MessageBox.Show("No Application with This ID"); return; }
              
            }
           
        }

        private void uS_ShowTableData1_Load(object sender, EventArgs e)
        {

        }

      
        int WhichTestStart()
        {if (ClsLocalLicenseApplication.Find(LLApplication).ApplicationStatus == (int)ClsEnums.EnStateApplication.Compeleted) return 3;

            if (!ClsTests.IsPassVisionTest(LLApplication))
                return 0;
            else if(!ClsTests.IsPassWrittenTest(LLApplication))
                return 1;
            else if (!ClsTests.IsPassStreetTest(LLApplication)) return 2;
            return 3;
        }
        void ApplicationISNotComplete()
        {
            contextMenuStrip1.Items["Edit"].Enabled = true;
            contextMenuStrip1.Items["delete"].Enabled = true;
            contextMenuStrip1.Items["cancel"].Enabled = true;
            contextMenuStrip1.Items["addnew"].Enabled = true;
        }
        bool IS_Driver()
        {
            if (ClsUtility.GetDirverIDBYPersonID(ClsLocalLicenseApplication.Find(LLApplication).ApplicantPersonID) != -1) return true;
             return false;
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            DisableAllMenuItems(contextMenuStrip1);
        
            int wichtestopen = WhichTestStart();
            if (wichtestopen == 3)
            {
                if (ISCompeleteApp())
                {
                    contextMenuStrip1.Items["showLicense"].Enabled = true;
                    if (IS_Driver())
                    {
                        contextMenuStrip1.Items["showPersonLicense"].Enabled = true;
                    }

                }
                else
                {
                    
                    contextMenuStrip1.Items["IssueDrivingLicense"].Enabled = true;
                }
            }
            else if(IsApplicationVailed())
            {
                ApplicationISNotComplete();
                WhichTestEnabled(wichtestopen);
            }
         
        }
        bool ISCompeleteApp()
        {
            ClsLocalLicenseApplication DLDAPP = ClsLocalLicenseApplication.Find(LLApplication);
            if ((ClsEnums.EnStateApplication)DLDAPP.ApplicationStatus==ClsEnums.EnStateApplication.Compeleted)
            {
                return true;
            }
            return false;
        }
        bool IsApplicationVailed()
        {
            ClsLocalLicenseApplication DLDAPP = ClsLocalLicenseApplication.Find(LLApplication);
            return DLDAPP.ApplicationStatus == (int)ClsEnums.EnStateApplication.New;
        }
        void DisableAllMenuItems(ContextMenuStrip menu)
        {
            foreach (ToolStripItem item in menu.Items)
            {
                
                if (item is ToolStripMenuItem menuItem)
                {
                    menuItem.Enabled = false;


                    DisableDropDownItems(menuItem);
                }
                else
                {

                    item.Enabled = false;
                }
            }
        }

        void DisableDropDownItems(ToolStripMenuItem parentItem)
        {
            foreach (ToolStripItem subItem in parentItem.DropDownItems)
            {
                if (subItem is ToolStripMenuItem subMenu)
                {
                    subMenu.Enabled = false;
                
                    DisableDropDownItems(subMenu);
                }
                else
                {
                    subItem.Enabled = false;
                }
            }
        }

      
        void WhichTestEnabled(int whichtestopen)
        {
            contextMenuStrip1.Items["SechudaleTool"].Enabled = true;
            switch (whichtestopen)
            {

                case 0:
                    EnabledDropDownListItem("SechudaleTool","VisionTest");
                    break;
                case 1:
                    EnabledDropDownListItem("SechudaleTool", "WrittienTest");

                    break;
                case 2:
                    EnabledDropDownListItem("SechudaleTool", "StreetTest");

                    break;
                case 3:
                    break;
            }
        }
        void EnabledDropDownListItem(string Menu,string Item)
        {
            ToolStripMenuItem fileMenu = (ToolStripMenuItem)contextMenuStrip1.Items[Menu];
            fileMenu.DropDownItems[Item].Enabled = true;
        }
        private void sechdualVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShowLDLTestInfo LDLtestInfo = new FrmShowLDLTestInfo(LLApplication, "Vision Test ", null, 1);
            LDLtestInfo.ShowDialog();
        }

        private void sechdualVisionTestToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmShowLDLTestInfo LDLtestInfo = new FrmShowLDLTestInfo(LLApplication, "Written Test ", null, 2);
            LDLtestInfo.ShowDialog();

        }

        private void sechdualVisionTestToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FrmShowLDLTestInfo LDLtestInfo = new FrmShowLDLTestInfo(LLApplication, "Street Test ", null, 3);
            LDLtestInfo.ShowDialog();

        }

        private void showLicense_Click(object sender, EventArgs e)
        {

            ClsLicense license=ClsLicense.FindByAppID(ClsLocalLicenseApplication.Find(LLApplication).ApplicationID);
            FrmShowLicenseInfo licenseinfo = new FrmShowLicenseInfo(license.DriverID, license.LicenseID);
            licenseinfo.ShowDialog();
        }

        private void IssueDrivingLicense_Click(object sender, EventArgs e)
        {
           ClsApplication DAPP = ClsApplication.Find(LLApplication);
            ClsLicense newLicense = new ClsLicense(DAPP.ApplicantPersonID, DAPP.ApplicationID, ClsEnums.EnIssueReason.FirstTime);
            if (newLicense.Save())
            {
                DAPP.ApplicationStatus = (int)ClsEnums.EnStateApplication.Compeleted;
                DAPP.Save();
                MessageBox.Show("Succeed");

            }
        }

        private void showPersonLicense_Click(object sender, EventArgs e)
        {
            FrmShowDriverLicenseInfoHistory Linfo=new FrmShowDriverLicenseInfoHistory(ClsLocalLicenseApplication.Find(LLApplication).ApplicantPersonID);
            Linfo.ShowDialog();

        }

        private void edit_Click(object sender, EventArgs e)
        {

        }
    }
}
