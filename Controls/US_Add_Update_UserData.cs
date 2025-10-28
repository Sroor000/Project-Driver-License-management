using DVLD_Presntation_Layer;
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
    public partial class US_Add_Update_UserData : UserControl
    {
        int PersonID {  get; set; }
        int UserID { get; set; }
        public event EventHandler CloseRequested;
        public event EventHandler SaveRequest;
        public US_Add_Update_UserData()
        {
            InitializeComponent();
            uS_Card_People_Info1.delPersonID +=GetPersonID;
            this.UserID = -1;
        }

    
        void GetPersonID(int PersonID)
        {
            this.PersonID = PersonID;
        }
        public void LoadData(int UserID)
        {
           ClsUser User= ClsUser.Find(UserID);
            if (User == null) return;
            uS_Card_People_Info1.LoadData(User.PersonID);
            Txt_UserName.Text = User.UserName;
            Txt_Password.Text = User.Password;
            Txt_ConfirmPassword.Text = User.Password;
            CHKB_UserActive.Checked = User.Active;
            LB_UserID.Text=User.UserID.ToString();
            this.UserID = User.UserID;
            this.PersonID=User.PersonID;
            UnEnabledPanel(User.PersonID);
        }
        void UnEnabledPanel(int PersonId)
        {
            Cmb_Filter.SelectedIndex = 0;
            Txt_Search.Text=PersonID.ToString();
            panel1.Enabled = false;
        }
        private void Btn_NextPage_Click_1(object sender, EventArgs e)
        {
            if (uS_Card_People_Info1.enState == US_Card_People_Info.EnState.Fill) 
            {
                if (ClsPeople.IsPerson_Link_WithUser(PersonID)&&panel1.Enabled)
                {
                    MessageBox.Show("This Person is Alerady with User");
                }
                
                else { 
                    tabControl1.SelectedIndex = 1;
                }
            
            }
          
            else
            {
                MessageBox.Show("Please Choose Person To Link User That is Mandatory");

            }
        }

        private void Btn_AddPerson_Click(object sender, EventArgs e)
        {
            FrmAddorUpdatePeopleInfo frm=new FrmAddorUpdatePeopleInfo();
            frm.Show();

        }
        void ValidateNumber(TextBox textBox, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text)) return;
            char lastChar = textBox.Text[textBox.TextLength - 1];

            bool isValid = char.IsDigit(lastChar);

            if (!isValid)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                 Txt_Search.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Cmb_Filter.SelectedItem.ToString() == "PersonID")
            {
                ValidateNumber(Txt_Search, e);
            }
        }

        private void Btn_SearchPerson_Click(object sender, EventArgs e)
        {
            ClsPeople people=null;
            if (Cmb_Filter.SelectedItem.ToString() == "PersonID")
            {
                people = ClsPeople.Find(int.Parse(Txt_Search.Text));
            }
            else if(Cmb_Filter.SelectedItem.ToString() == "NationalNo")
            {
               people = ClsPeople.Find(Txt_Search.Text);

            }
           
            
                uS_Card_People_Info1.LoadData(people);
            
          
        }

       
        private ClsUser AssignDataUser(ClsUser user)
        {
           if(user==null)user = new ClsUser();


            user.UserID = this.UserID;
                user.PersonID = this.PersonID;
                user.Active = CHKB_UserActive.Checked;
                user.Password = Txt_Password.Text;
            user.UserName = Txt_UserName.Text;
               return user;
            
        }
       
        bool PersonIDnotLink(int personID)
        {
            return ClsPeople.IsPerson_Link_WithUser(personID);
        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (this.PersonIDnotLink(PersonID)&&Cmb_Filter.Enabled)
            {
                MessageBox.Show("this Person Is Already Link with User");
            }
            
            if (Validate_Form())
            {
                ClsUser user = ClsUser.Find(this.UserID);
                 user= AssignDataUser(user);
                user.Save();
                LoadData(ClsUser.Get_UserIDBy_PersonID( user.PersonID));
                SaveRequest?.Invoke(sender, e);
            }
            else MessageBox.Show("Please Sure You Fill Fields With Right Data Or Sure Password Match Confirm Password");
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            CloseRequested?.Invoke(sender, e);
        }
        bool Validate_Form()
        {
            bool IsFIll=false,EqualFiledsofPassword=false;
            IsFIll=Txt_UserName.Text.Length > 0&& Txt_ConfirmPassword.Text.Length > 0&& Txt_Password.Text.Length > 0;
            EqualFiledsofPassword = Txt_ConfirmPassword.Text == Txt_Password.Text;

            return IsFIll && EqualFiledsofPassword;
        }

        private void Txt_ConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (Txt_ConfirmPassword.Text!=Txt_Password.Text)
            {
               
              
                errorProvider1.SetError(Txt_ConfirmPassword, "This Not  Match Password");
            }
            else
            {
             
                errorProvider1.SetError(Txt_ConfirmPassword,"");
            }
        }
    }
}
