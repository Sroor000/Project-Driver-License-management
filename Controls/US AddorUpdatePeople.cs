using Project_Driver_License_management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DVLD_Presntation_Layer
{
    public partial class US_AddorUpdatePeople : UserControl
    {
        public event EventHandler CloseRequested;
        public event EventHandler SaveRequest;

        public US_AddorUpdatePeople()
        {
            InitializeComponent();
            LoadCountriesName();
            openFileDialog1.FileName = "C:\\Users\\user\\source\\repos\\Amr135\\Resturant\\Resturant\\Resources\\download.jpeg";
        }

        public   void Get_PersonDataByID(int PersonID) {
            ClsPeople Person = ClsPeople.Find(PersonID);
            if (Person == null) return;
            Txt_PersonID.Text = Person.PersonID.ToString();
            Txt_FirstName.Text = Person.FirstName;
            Txt_SecondName.Text = Person.SecondName;
            Txt_ThirdName.Text = Person.ThirdName;
            Txt_LastName.Text = Person.LastName;
            Txt_Address.Text = Person.Address;
            Txt_Phone.Text = Person.Phone;
            Txt_Email.Text = Person.Email;
            Get_Image(Person.ImagePath);
            DTP_DateOfBirth.Value= Person.DateOfBirth;
            if (Person.Gender == "0") RBtn_Male.Select(); else RBtn_Female.Select();
            comboBox1.SelectedIndex=int.Parse(Person.Country)-1;
        }
        public void LoadPersonData(
    int personID,
    string firstName,
    string secondName,
    string thirdName,
    string lastName,
    string nationalno,
    string address,
    string phone,
    string imagePath,
    DateTime dateOfBirth,
    string gender,
    string country
    ,string email        )
        {
            Txt_PersonID.Text = personID.ToString();
            Txt_FirstName.Text = firstName;
            Txt_SecondName.Text = secondName;
            Txt_ThirdName.Text = thirdName;
            Txt_LastName.Text = lastName;
            Txt_Address.Text = address;
            Txt_Phone.Text = phone;
            Txt_Email.Text = email;
            Txt_NationalNO.Text = nationalno;
            Get_Image(imagePath);


          //  DTP_DateOfBirth.Value = DateTime.Parse(dateOfBirth);
            if (gender == "0")
                RBtn_Male.Select();
            else
                RBtn_Female.Select();

            comboBox1.SelectedIndex = int.Parse(country) - 1;
        }
        void LoadCountriesName()
        {
            DataTable dt = ClsPeople.Get_Countries_Name();
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["countryName"]);
            }
            comboBox1.SelectedIndex = 50;//Egypt
        }
         void Get_Image(string ImagePath)
        {
            pictureBox1.Image=Image.FromFile(ImagePath);
        }
        private void Txt_NationalNO_Validating(object sender, CancelEventArgs e)
        {
            if (ClsPeople.NationalNo_isExist(Txt_NationalNO.Text))
            {
                e.Cancel = true;
                Txt_FirstName.Focus();
                errorProvider1.SetError(Txt_NationalNO, "This NationalNO is Already Exist");
            }
            else { 
            e.Cancel = false;
                errorProvider1.SetError(Txt_NationalNO, "");
            }
        }
        private void Txt_Email_Validating(object sender, CancelEventArgs e)
        {
            if (!Txt_Email.Text.Contains("@gmail.com"))
            {
                e.Cancel = true;
                Txt_FirstName.Focus();
                errorProvider1.SetError(Txt_Email, "This Not Valid Email");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Txt_NationalNO, "");
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            CloseRequested?.Invoke(sender, e);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (validating_Form())
                SaveRequest.Invoke(sender, EventArgs.Empty);
            else MessageBox.Show("Please Fill all Fields ");
        }
        private bool validating_Form()
        {
            return (AreRequiredFieldsFilled());
            

            
        }
        public bool AreRequiredFieldsFilled()
        {

            TextBox[] requiredTextBoxes =
            {
        Txt_FirstName,Txt_LastName,Txt_Address,Txt_Email,Txt_Phone,Txt_SecondName,Txt_ThirdName,Txt_NationalNO

    };

            return requiredTextBoxes.All(tb => !string.IsNullOrWhiteSpace(tb.Text));
        }
        private void LK_SetPicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Title = "Select Picture Profile";
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.Multiselect = false;
            openFileDialog1.InitialDirectory = "C:\\Users\\user\\OneDrive - Benha University (Faculty Of Computers & Information Technolgy)\\Pictures";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                 LK_RemovePicture.Visible = true;
                Get_Image(openFileDialog1.FileName);
            }
        }

        private void LK_RemovePicture_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Get_Image("C:\\Users\\user\\source\\repos\\Amr135\\Resturant\\Resturant\\Resources\\download.jpeg");
            LK_RemovePicture.Visible= false;
        }
        public void ReturnPersonData( ClsPeople User)
        {
            int PersonID = -1;
          string  FirstName="",
          SecondName="",
          ThirdName = "",
          LastName = "",
          Address = "",
          Phone = "",
          ImagePath = "",
        
          Gender = "",
          Country = "",
         Email = "",
         NationalNO="";
            DateTime DateOfBirth = DateTime.MinValue;
            ReturnPersonData(
          ref PersonID,
          ref FirstName,
          ref SecondName,
          ref ThirdName,
          ref LastName,
          ref Address,
          ref Phone,
          ref ImagePath,
          ref DateOfBirth,
          ref Gender,
          ref Country,
          ref Email,
          ref NationalNO);
            User.PersonID = PersonID;
            User.FirstName = FirstName;
            User.SecondName = SecondName;
            User.ThirdName = ThirdName; 
            User.LastName= LastName;
            User.Address= Address;
            User.Phone= Phone;
            User.ImagePath= ImagePath;
            User.DateOfBirth= DateOfBirth;
            User.Gender=    Gender;
            User.Country= Country;
            User.Email=Email;
            User.National_No= NationalNO;
            }

        public void ReturnPersonData(
ref int personID,
ref string firstName,
ref string secondName,
ref string thirdName,
ref string lastName,
ref string address,
ref string phone,
ref string imagePath,
ref DateTime dateOfBirth,
ref string gender,
ref string country,
ref string email,
ref string NationalNO
            )
        {
            personID = int.TryParse(Txt_PersonID.Text, out int pid) ? pid : 0;
            firstName = Txt_FirstName.Text;
            secondName = Txt_SecondName.Text;
            thirdName = Txt_ThirdName.Text;
            lastName = Txt_LastName.Text;
            address = Txt_Address.Text;
            phone = Txt_Phone.Text;
            imagePath = openFileDialog1.FileName ?? null;
            dateOfBirth = dateOfBirth; 
            gender = RBtn_Male.Checked ? "0" : "1";
            country = (comboBox1.SelectedIndex + 1).ToString();
            email=Txt_Email.Text;
            NationalNO=Txt_NationalNO.Text;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
          void ValidateChar(TextBox textBox, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text)) return;

            char lastChar = textBox.Text[textBox.TextLength - 1];

            bool isValid = char.IsLetter(lastChar);

            if (!isValid)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
          void ValidateNumber(TextBox textBox,EventArgs e)
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

        private void ValidateCharInput(object sender, EventArgs e)
        {
            
            ValidateChar((TextBox)sender,e);
        }

        private void ValidateNumberInput(object sender, EventArgs e)
        {
           

            ValidateNumber((TextBox)sender,e);
        }
    }
}
