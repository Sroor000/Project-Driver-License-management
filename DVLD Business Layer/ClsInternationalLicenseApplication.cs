using Project_Driver_License_management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DVLD_Presntation_Layer
{
    public class ClsInternationalLicenseApplication
    {
        public int InternationalLicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        private enum EnMode { AddNew, Update }
        private EnMode Mode = EnMode.AddNew;

        // Public Constructor for new license (Add)
        public ClsInternationalLicenseApplication(int applicationID, int localLicenseID)
        {
            
            InternationalLicenseID = -1;
            ApplicationID = applicationID;
            IssuedUsingLocalLicenseID = localLicenseID;
            DriverID = ClsLicense.Find(localLicenseID).DriverID; 
            IssueDate = DateTime.Now;
            ExpirationDate = IssueDate.AddYears(1); 
            IsActive = true;
            CreatedByUserID = Current_User.CurrUser.UserID;

            Mode = EnMode.AddNew;
        }

        
        private ClsInternationalLicenseApplication(
            int internationalLicenseID,
            int applicationID,
            int driverID,
            int issuedUsingLocalLicenseID,
            DateTime issueDate,
            DateTime expirationDate,
            bool isActive,
            int createdByUserID)
        {
            InternationalLicenseID = internationalLicenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            IssuedUsingLocalLicenseID = issuedUsingLocalLicenseID;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            IsActive = isActive;
            CreatedByUserID = createdByUserID;

            Mode = EnMode.Update;
        }


        public static ClsInternationalLicenseApplication Find(int internationalLicenseID)
        {
            int applicationID = -1, driverID = -1, issuedLocalLicenseID = -1, createdByUserID = -1;
            DateTime issueDate = DateTime.MinValue, expirationDate = DateTime.MinValue;
            bool isActive = false;

            if (!ClsDataBase.Get_InternationalLicenseInfo(
                   ref internationalLicenseID,
                    ref applicationID,
                    ref driverID,
                    ref issuedLocalLicenseID,
                    ref issueDate,
                    ref expirationDate,
                    ref isActive,
                    ref createdByUserID))
                return null;

            return new ClsInternationalLicenseApplication(
                internationalLicenseID,
                applicationID,
                driverID,
                issuedLocalLicenseID,
                issueDate,
                expirationDate,
                isActive,
                createdByUserID
            );
        }

        // 🔹 Save (Insert or Update)
        public bool Save()
        {
            switch (Mode)
            {
                case EnMode.AddNew:
                    return Insert_InternationalLicense();
                //case EnMode.Update:
                //    return Update_InternationalLicense();
                default:
                    return false;
            }
        }

        private bool Insert_InternationalLicense()
        {

            this.InternationalLicenseID = ClsDataBase.Insert_InternationalLicenseInfo(
                this.ApplicationID,
                this.DriverID,
                this.IssuedUsingLocalLicenseID,
                this.IssueDate,
                this.ExpirationDate,
                this.IsActive,
                this.CreatedByUserID
            );

            return (this.InternationalLicenseID != -1);
        }
        public static bool IsHave_InterNationalLicense(int localLIcenseID)
        {
            return ClsDataBase.IsHave_InterNationalLicense(localLIcenseID);
        }
        //private bool Update_InternationalLicense()
        //{
        //    //return ClsDataInternationalLicense.Update_InternationalLicense_Info(
        //    //    this.InternationalLicenseID,
        //    //    this.ApplicationID,
        //    //    this.DriverID,
        //    //    this.IssuedUsingLocalLicenseID,
        //    //    this.IssueDate,
        //    //    this.ExpirationDate,
        //    //    this.IsActive,
        //    //    this.CreatedByUserID
        //    //);
        //}

        // 🔹 Get All
        public static DataTable GetAllInternationalLicenses()
        {
            return ClsDataBase.Get_AllInternationalLicenses();
        }
}

}
