using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Project_Driver_License_management
{
    public class ClsPeople
    {
     
        public int   PersonID      { get; set; }
        public string FirstName  { get; set; }
        public string SecondName  { get; set; }
        public string ThirdName       { get; set; }
        public string LastName     { get; set; }
        public string National_No  { get; set; }
           public DateTime       DateOfBirth       { get; set; }
        public string Gender          { get; set; }
        public string Phone          { get; set; }
        public string Country     { get; set; }
        public string Address     { get; set; }
        public string Email       { get; set; }
        public string ImagePath   { get; set; }
      public enum enmode {enAddnew=0,enUpdate=1};
        public enmode Mode=enmode.enAddnew;

        public ClsPeople()
        {
           this. PersonID      =-1;
           this.  FirstName    =string.Empty;
           this.  SecondName   =string.Empty;
           this. ThirdName     =string.Empty;
           this.  LastName     =string.Empty;
           this. National_No   =string.Empty;
           this.  DateOfBirth  =DateTime.MinValue;
           this. Gender        =string.Empty;
           this.  Phone        =string.Empty;
           this. Country       =string.Empty;
           this. Address       =string.Empty;
           this. Email         =string.Empty;
           this. ImagePath     =string.Empty;
            this.Mode = enmode.enAddnew;
                 }





        protected ClsPeople(
            int personID, string firstName, string secondName, string thirdName,
            string lastName, string national_No, DateTime birthofDate, string gender,
            string phone, string country, string address, string email, string imagePath)
             {
      
            this.PersonID = personID;
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.ThirdName = thirdName;
            this.LastName = lastName;
            this.National_No = national_No;
            this.DateOfBirth = birthofDate;
            this.Gender = gender;
            this.Phone = phone;
            this.Country = country;
            this.Address = address;
            this.Email = email;
            this.ImagePath = imagePath;
            this.Mode=enmode.enUpdate;
        }

       
        public static ClsPeople Find(int PersonID)
        {
            string firstName="",  secondName="",  thirdName = "",
             lastName = "",  national_No = "",   gender = "",
             phone = "",  country = "",  address = "",  email = "",  imagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            if (ClsDataBase.Get_PeopleData_ByID(PersonID, ref firstName,ref secondName,ref thirdName,ref lastName,ref national_No,ref DateOfBirth
                ,ref gender,ref phone,ref country,ref address,ref email,ref imagePath)) {
                return new ClsPeople(
                    PersonID, firstName, secondName, thirdName,
                    lastName, national_No, DateOfBirth, gender,
                    phone, country, address, email, imagePath); }
        return null;
        }
        public static ClsPeople Find(string Nationalno)
        {
            int PersonID = -1;
            string firstName = "", secondName = "", thirdName = "",
             lastName = "", gender = "",
             phone = "", country = "", address = "", email = "", imagePath = "";
            DateTime DateOfBirth = DateTime.Now;
            if (ClsDataBase.Get_PeopleData_ByNationalNo(ref PersonID, ref firstName, ref secondName, ref thirdName, ref lastName, ref Nationalno, ref DateOfBirth
                , ref gender, ref phone, ref country, ref address, ref email, ref imagePath))
            {
                return new ClsPeople(
                    PersonID, firstName, secondName, thirdName,
                    lastName, Nationalno, DateOfBirth, gender,
                    phone, country, address, email, imagePath);
            }
            return null;
        }
        public static DataTable Get_Countries_Name()
        {
            return ClsDataBase.Get_Countries_Name();
        }
        public static DataTable Get_All_People_Info()
        {
            return ClsDataBase.Get_All_People_Info();
        }
        public static bool NationalNo_isExist(string NationalNo)
        {
            return ClsDataBase.NationalNO_isExist(NationalNo);
        }
        private bool AddNewUser()
        {
           return ClsDataBase.Insert_PeopleData(this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.National_No,
                this.DateOfBirth, this.Gender,
                this.Phone,this.Country ,this.Address,  this.Email,this.ImagePath);
        }
        private bool Update_People_Data()
        {
            return ClsDataBase.Update_PeopleData(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.National_No,
                this.DateOfBirth, this.Gender,
                this.Phone, this.Country, this.Address, this.Email, this.ImagePath);
        }
        public bool Save()
        {
            switch (Mode)
            {
                case enmode.enAddnew:
                    if (AddNewUser())
                    {
                        Mode = enmode.enUpdate;
                        return true;
                    }
                    else { return false; }

                    case enmode.enUpdate:
                    if ((Update_People_Data()))
                    {  
                        return true;
                    }
                    else return false;
                    

            }
            return false;
        }
        public static bool DeleteUser(int PersonID)
        {
            return ClsDataBase.DeletePersonData(PersonID);
        }
        public static bool IsPerson_Link_WithUser(int PersonID)
        {
            return ClsDataBase.IsPerson_Link_WithUser((int)PersonID);
        }
        public string GetFullName()
        {
            return this.FirstName + ' ' + this.SecondName + ' ' + this.ThirdName + ' ' + this.LastName;
        }
        public static string Get_PersonFullName(int PersonID)
        {
            return ClsDataBase.GenralQuery($"select FullName=FirstName+' '+SecondName+' '+ThirdName+' '+LastName from People where PersonID={PersonID}").Rows[0]["FullName"].ToString();
        }
    }
}
