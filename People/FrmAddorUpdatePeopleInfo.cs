using Project_Driver_License_management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presntation_Layer
{
    public partial class FrmAddorUpdatePeopleInfo : Form
    {
        private ClsPeople User=new ClsPeople();
        public FrmAddorUpdatePeopleInfo()
        {
            InitializeComponent();
          
        }
        public FrmAddorUpdatePeopleInfo(int PersonID)
        {
            InitializeComponent();
            LoadData(PersonID);
        }
        public void LoadData(int PersonID)
        {
        User= ClsPeople.Find(PersonID);
            if (User.PersonID!=-1)
            {
                
            uS_AddorUpdate_Data_User1.LoadPersonData(
                User.PersonID,
                User.FirstName,
                User.SecondName,
                User.ThirdName,
                User.LastName,
                User.National_No,
                User.Address,
                User.Phone,
                User.ImagePath,
                User.DateOfBirth,
                User.Gender,
                User.Country,
                User.Email
                );
            }
        
        }

        private void FrmAddorUpdateData_Load(object se, EventArgs ee)
        {
            uS_AddorUpdate_Data_User1.CloseRequested +=(s,e)=>this.Close();
            uS_AddorUpdate_Data_User1.SaveRequest += Save_Click;
        }
        private void Save_Click(object sender,EventArgs e)
        {
           
           
           
            if (User.Save())
            {
                MessageBox.Show("succeeded");
            }
            else
            {
                MessageBox.Show("Faild Operation");

            }
            this.Close();
        }

        bool Validate_All_Data()
        {
            return false;
        }
        private void uS_AddorUpdate_Data_User1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

