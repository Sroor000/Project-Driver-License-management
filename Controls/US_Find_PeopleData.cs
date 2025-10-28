using DVLD_Presntation_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project_Driver_License_management.US_Card_People_Info;

namespace Project_Driver_License_management
{
    public partial class US_Find_PeopleData : UserControl
    {
        public EventHandler DEL_BtnNext=null;
        ClsPeople people = null;
       public delegate int PeopleChoose();
        public PeopleChoose DEL_IsPeopleFound = null;
        public US_Find_PeopleData()
        {
            InitializeComponent();
            DEL_IsPeopleFound += ISPersonChooose;
        }
        void UnEnabledPanel(int PersonID)
        {
            Cmb_Filter.SelectedIndex = 0;
           Txt_Search.Text = PersonID.ToString();
            Btn_AddPerson.Enabled = false;
            Btn_SearchPerson.Enabled = false;
            Txt_Search.Enabled = false;
            Cmb_Filter.Enabled = false;
           
        }
        public void LoadData(int personID)
        {
            uS_Card_People_Info1.LoadData(personID);
            UnEnabledPanel(personID);

        }
       
        private void Btn_AddPerson_Click(object sender, EventArgs e)
        {
            FrmAddorUpdatePeopleInfo frm = new FrmAddorUpdatePeopleInfo();
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
        int ISPersonChooose()
        {
            if (people == null) return -1;
           return people.PersonID ;
        }
        private void Btn_SearchPerson_Click(object sender, EventArgs e)
        {
           
            if (Cmb_Filter.SelectedItem.ToString() == "PersonID")
            {
                people = ClsPeople.Find(int.Parse(Txt_Search.Text));
            }
            else if (Cmb_Filter.SelectedItem.ToString() == "NationalNo")
            {
                people = ClsPeople.Find(Txt_Search.Text);

            }


            uS_Card_People_Info1.LoadData(people);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void HideButton()
        {
            Btn_NextPage.Visible = false;
        }
        private void Btn_NextPage_Click(object sender, EventArgs e)
        {
            DEL_BtnNext?.Invoke(this, e);
            DEL_IsPeopleFound?.Invoke();
        }
    }
}
