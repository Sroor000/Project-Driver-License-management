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
    public partial class FrmAddorUpdate_ApplicationLocalLicense : Form
    {
        private List<double>Fees = new List<double>();
        int PersonID { get; set; } = -1;
        public FrmAddorUpdate_ApplicationLocalLicense()
        {
            InitializeComponent();
            uS_Find_PeopleData1.DEL_BtnNext += NextPage;
            LoadLicenseClassesName(ClsUtility.Get_LicenseClassesNameandFees());
            LB_LApplicationCreatedBY.Text = Current_User.CurrUser.UserName;
            LB_LApplicationDate.Text = DateTime.Now.ToString();
        }
        void LoadLicenseClassesName(DataTable Dt)
        {
            CMB_LicenseClass.Items.Add("None");
            Fees.Add(0);

            foreach (DataRow dr in Dt.Rows) {
                CMB_LicenseClass.Items.Add(dr["ClassName"]);
                Fees.Add(double.Parse(dr["ClassFees"].ToString()));
            }
        }
        private void uS_Find_PeopleData1_Load(object sender, EventArgs e)
        {

        }
        private void NextPage(object sender, EventArgs e)
        {
            PersonID = uS_Find_PeopleData1.DEL_IsPeopleFound();
            if (PersonID!=-1)
            {
                tabControl1.SelectedIndex = 1;
                Btn_Save.Enabled = true;
            }
            else
            {
                Btn_Save.Enabled = false;
                MessageBox.Show("Must Find People First ");
            }
        }

        private void CMB_LicenseClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_LApplicationFees.Text = Fees[CMB_LicenseClass.SelectedIndex].ToString();
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        bool Is_NewApplication()
        {
         

            ClsLocalLicenseApplication localapp = new ClsLocalLicenseApplication(PersonID,ClsEnums.EnApplicationType.NewLocalDrivingLicenseService,(ClsEnums.EnLicenseClass)CMB_LicenseClass.SelectedIndex);

            localapp.PaidFees = Fees[CMB_LicenseClass.SelectedIndex];
         
            localapp.CreatedByUserID=Current_User.CurrUser.UserID;
            localapp.ApplicationStatus = 1;//new
            localapp.ApplicationTypeID = 1; 


            if (!localapp.Save())
            {
                MessageBox.Show("Failed");
            }
            LB_LApplicationID.Text = localapp.LocalDrivingLicenseApplicationID != -1 ? localapp.LocalDrivingLicenseApplicationID.ToString() : "[???]";
            return localapp.LocalDrivingLicenseApplicationID != -1;
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (Is_NewApplication()) { 
                MessageBox.Show("Succeed "); 
           
            }
            else { MessageBox.Show("There is Already Application With this Person "); }
        }
    }
}
