using DVLD_Presntation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Project_Driver_License_management
{
    public partial class US_Card_People_Info : UserControl
    {
        public US_Card_People_Info()
        {
            InitializeComponent();
        }
        public delegate void DelPersonID(int PersonID);
        public DelPersonID delPersonID=null;
        public enum EnState { Fill=0, Unfill=1 }
      public  EnState enState = EnState.Unfill;
        public int PersonID { get; set; }
        public US_Card_People_Info(int PersonID )
        {
            InitializeComponent();
            this.PersonID = PersonID;
            LoadData();
        }
         void LoadData()
        {
            LoadData(this.PersonID);
        }
        public void LoadData(int personID)
        {
            ClsPeople People=ClsPeople.Find(personID);
            if (People == null)
            {
                Reset();
                return;
            } 
            LKL_EditPerson_info.Enabled = true;
            LB_PersonID.Text=People.PersonID.ToString();
            LB_Name.Text=People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName;
            LB_NationalNo.Text=People.National_No;
            LB_Gender.Text=People.Gender=="0"?"Male":"Female";
            LB_Phone.Text=People.Phone;
            LB_Email.Text=People.Email;
            LB_DateofBirth.Text=People.DateOfBirth.ToShortDateString();
            LB_Address.Text=People.Address;
            LB_Country.Text = Get_CountryName(int.Parse(People.Country));
            pictureBox1.Image=Image.FromFile(People.ImagePath);
            enState = EnState.Fill;
            delPersonID?.Invoke(People.PersonID);

        }
        private void Reset()
        {
            LKL_EditPerson_info.Enabled = false;
            LB_PersonID.Text = "[???]";
            LB_Name.Text =        "[???]";
            LB_NationalNo.Text =  "[???]";
            LB_Gender.Text =      "[???]";
            LB_Phone.Text =       "[???]";
            LB_Email.Text =       "[???]";
            LB_DateofBirth.Text = "[???]";
            LB_Address.Text =     "[???]";
            LB_Country.Text =     "[???]";
            pictureBox1.Image = default ;
            enState=EnState.Unfill;
        }
        public void LoadData(ClsPeople People)
        {

            if (People == null)
            {
                Reset();
                return;
            }
            LKL_EditPerson_info.Enabled = true;
            LB_PersonID.Text = People.PersonID.ToString();
            LB_Name.Text = People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName;
            LB_NationalNo.Text = People.National_No;
            LB_Gender.Text = People.Gender == "0" ? "Male" : "Female";
            LB_Phone.Text = People.Phone;
            LB_Email.Text = People.Email;
            LB_DateofBirth.Text = People.DateOfBirth.ToShortDateString();
            LB_Address.Text = People.Address;
            LB_Country.Text = Get_CountryName(int.Parse(People.Country));
            pictureBox1.Image = Image.FromFile(People.ImagePath);
            enState = EnState.Fill;
            delPersonID?.Invoke(People.PersonID);

        }
       
        string Get_CountryName(int CountryID)
        {
            return ClsUtility.Get_Name_Country(CountryID);
        }

        private void LKL_EditPerson_info_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAddorUpdatePeopleInfo FrmAdd=new FrmAddorUpdatePeopleInfo(int.Parse(LB_PersonID.Text));
          
            FrmAdd.FormClosed +=(se,ee)=> LoadData(ClsUtility.INT(LB_PersonID.Text));
            FrmAdd.ShowDialog();

        }

        private void LB_Country_Click(object sender, EventArgs e)
        {

        }
    }
}
