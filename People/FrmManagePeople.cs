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
    public partial class FrmManagePeople : Form
    {
       
        int PersonID {  get; set; }
        public FrmManagePeople()
        {
            InitializeComponent();
            
       
            uS_ShowTableData1.Btn_AddAction += guna2Button1_Click;
            uS_ShowTableData1.DelID += Selected_Row_Index;
            Load_AllPeople_Data();
              uS_ShowTableData1.SetImageButtonAdd(Properties.Resources.AddPerson_32);
        }

        private void FrmManagePeople_Load(object sender, EventArgs e)
        {
           

        }
        void Load_AllPeople_Data()
        { 
            DataTable dt = ClsPeople.Get_All_People_Info();
       
  
            dt.Columns.Add("Gendor", typeof(string));
            int counter= 0;
            foreach (DataRow row in dt.Rows) { row["Gendor"] = row["Gender"].ToString() == "0" ? "Male" : "Female"; }
         uS_ShowTableData1.LoadData(dt);
            uS_ShowTableData1.HideColumn("ImagePath");
            uS_ShowTableData1.HideColumn("NationalityCountryID");
            uS_ShowTableData1.HideColumn("Gender");


        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            FrmAddorUpdatePeopleInfo frm = new FrmAddorUpdatePeopleInfo();
            frm.ShowDialog();
            Load_AllPeople_Data();
        }

      

      
  
        void Selected_Row_Index(Hashtable HT)
        {
            this.PersonID = (int)HT["PersonID"];
         
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
        FrmAddorUpdatePeopleInfo frm= new FrmAddorUpdatePeopleInfo(PersonID);
            frm.ShowDialog();
            Load_AllPeople_Data();
        }
      
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        
          
           if(ClsPeople.DeleteUser(PersonID))
            {
                MessageBox.Show("Succeed Delete");
                Load_AllPeople_Data();
            }
           else
            {
                MessageBox.Show("Failed Delete");

            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmShowPersonInfo frm = new FrmShowPersonInfo(PersonID))
            {
                frm.ShowDialog();
            }
                    }
    }

}
