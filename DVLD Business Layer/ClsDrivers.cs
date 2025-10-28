using System;

using System.Data;
using System.Linq;

using System.Windows.Forms;

namespace Project_Driver_License_management
{
    public class ClsDrivers : ClsPeople
    {
        public int DriverID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public enum enMode { enAddNew = 0, enUpdate = 1 };
        public enMode Mode = enMode.enAddNew;

        public ClsDrivers(int personID)
        {
    
            this.DriverID = -1;
            this.PersonID = personID;
            this.CreatedByUserID = -1;
            this.CreatedDate = DateTime.Now;
            this.Mode = enMode.enAddNew;
            this.CreatedByUserID = Current_User.CurrUser.UserID;
     
            ClsPeople person = ClsPeople.Find(personID);

            if (person == null)
            {
                 
                MessageBox.Show($"No person found with PersonID = {personID}");
            }

          

            this.FirstName = person.FirstName;
            this.SecondName= person.SecondName;
            this.ThirdName = person.ThirdName;
            this.LastName = person.LastName;
            this.National_No = person.National_No;
            this.DateOfBirth = person.DateOfBirth;
            this.Address = person.Address;
            this.Phone = person.Phone;
            this.Email = person.Email;
            this.Gender = person.Gender;
            this.Country = person.Country;
           this.ImagePath = person.ImagePath;
          
      
        }
      
        private ClsDrivers(
            int driverID, int personID, string firstName, string secondName, string thirdName,
            string lastName, string national_No, DateTime birthOfDate, string gender,
            string phone, string country, string address, string email, string imagePath,
            int createdByUserID, DateTime createdDate)
            : base(personID, firstName, secondName, thirdName, lastName,
                   national_No, birthOfDate, gender, phone, country, address, email, imagePath)
        {
            this.DriverID = driverID;
            this.CreatedByUserID = createdByUserID;
            this.CreatedDate = createdDate;
            this.Mode = enMode.enUpdate;
        }

        public static ClsDrivers Find(int driverID)
        {
            int personID = -1;
            int createdByUserID = -1;
            DateTime createdDate = DateTime.MinValue;

           
            if (!ClsDataBase.GetDriverByID(driverID, ref personID, ref createdByUserID, ref createdDate))
                return null; 

       
            ClsPeople person = ClsPeople.Find(personID);
            if (person == null)
                return null; // Person data missing

      
            return new ClsDrivers(
                driverID,
                person.PersonID,
                person.FirstName,
                person.SecondName,
                person.ThirdName,
                person.LastName,
                person.National_No,
                person.DateOfBirth,
                person.Gender,
                person.Phone,
                person.Country,
                person.Address,
                person.Email,
                person.ImagePath,
                createdByUserID,
                createdDate
            );
        }


        private bool AddNewDriver()
        {
       
           int driverID = -1;
           ClsDataBase.Insert_Driver(ref driverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
          this.DriverID = driverID;
            return this.DriverID != -1;
       
        }
       
        private bool UpdateDriver()
        {
            // Update person info
            if (base.Save())
            {
                return ClsDataBase.Update_Driver(this.DriverID, this.PersonID, this.CreatedByUserID, this.CreatedDate);
            }
            return false;
        }

        public new bool Save()
        {
            switch (Mode)
            {
                case enMode.enAddNew:
                    if (AddNewDriver())
                    {
                        this.Mode = enMode.enUpdate;
                        return true;
                    }
                    return false;

                case enMode.enUpdate:
                    return UpdateDriver();
            }
            return false;
        }
        public static DataTable GetAllDriversInfo_View()
        {
            return ClsDataBase.GetAllDriversInfo_View();
        }
        public static DataTable GetAllLicensesInfoByDriverID(int DriverID )
        {
            return ClsDataBase.GetAllLicenseByDriverID(DriverID);
        }
        public static DataTable GetAllInternationalLicensesInfoByDriverID(int DriverID)
        {
            return ClsDataBase.GetAllInternationalLicensesInfoByDriverID(DriverID);
        }
    }

}
