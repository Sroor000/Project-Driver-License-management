using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace Project_Driver_License_management
{
    public class ClsLicense
    {
        public int LicenseID { get; set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseClass { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public double PaidFees { get; set; }
        public bool IsActive { get; set; }
        public int IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public enum enMode { enAddNew = 0, enUpdate = 1 }
        public enMode Mode = enMode.enAddNew;


        public ClsLicense(int personID, int applicationID, ClsEnums.EnIssueReason enIssueReason)
        {
            this.LicenseID = -1;
            this.ApplicationID = applicationID;


            this.DriverID = GetDriverID(personID);


            ClsApplication app = ClsApplication.Find(applicationID);
            if (app != null)
            {
                this.PaidFees = app.PaidFees;
                this.LicenseClass = ClsUtility.Get_ClassLicense_IDBYD_APPID(ApplicationID);
            }

            this.IssueDate = DateTime.Now;
            this.ExpirationDate = this.IssueDate.AddYears(10);
            this.CreatedByUserID = Current_User.CurrUser.UserID;
            this.IsActive = true;
            this.IssueReason = WhichIssueReason(enIssueReason);

            this.Notes = null;
            this.Mode = enMode.enAddNew;
        }


        private ClsLicense(int licenseID, int applicationID, int driverID, int licenseClass,
                           DateTime issueDate, DateTime expirationDate, string notes,
                           double paidFees, bool isActive, int issueReason, int createdByUserID)
        {
            this.LicenseID = licenseID;
            this.ApplicationID = applicationID;
            this.DriverID = driverID;
            this.LicenseClass = licenseClass;
            this.IssueDate = issueDate;
            this.ExpirationDate = expirationDate;
            this.Notes = notes;
            this.PaidFees = paidFees;
            this.IsActive = isActive;
            this.IssueReason = issueReason;
            this.CreatedByUserID = createdByUserID;
            this.Mode = enMode.enUpdate;
        }

        private int GetDriverID(int personID)
        {
            int driverID = ClsUtility.GetDirverIDBYPersonID(personID);
            if (driverID == -1)
            {
                ClsDrivers driver = new ClsDrivers(personID);
                driver.Save();
                driverID = driver.DriverID;
            }
            return driverID;
        }

        int WhichIssueReason(ClsEnums.EnIssueReason ENIssuReason)
        {
            switch (ENIssuReason)
            {
                case ClsEnums.EnIssueReason.FirstTime: return (int)ClsEnums.EnIssueReason.FirstTime;
                case ClsEnums.EnIssueReason.Renew: return (int)ClsEnums.EnIssueReason.Renew;
                case ClsEnums.EnIssueReason.ReplacemnetForDamaged: return (int)ClsEnums.EnIssueReason.ReplacemnetForDamaged;
                case ClsEnums.EnIssueReason.ReplacenmentForLost: return (int)ClsEnums.EnIssueReason.ReplacenmentForLost;
            }
            return -1;
        }

        public static ClsLicense Find(int licenseID)
        {
            int applicationID = 0, driverID = 0, licenseClass = 0, issueReason = 0, createdByUserID = 0;
            DateTime issueDate = DateTime.MinValue, expirationDate = DateTime.MinValue;
            string notes = null;
            double paidFees = 0;
            bool isActive = false;

            if (!ClsDataBase.GetLicenseInfo_ByLicenseID(
                    licenseID, ref applicationID, ref driverID, ref licenseClass,
                    ref issueDate, ref expirationDate, ref notes, ref paidFees,
                    ref isActive, ref issueReason, ref createdByUserID))
                return null;

            return new ClsLicense(
                licenseID, applicationID, driverID, licenseClass,
                issueDate, expirationDate, notes, paidFees, isActive,
                issueReason, createdByUserID
            );
        }
        public static ClsLicense FindByAppID(int applicationID)
        {
            int licenseID = 0, driverID = 0, licenseClass = 0, issueReason = 0, createdByUserID = 0;
            DateTime issueDate = DateTime.MinValue, expirationDate = DateTime.MinValue;
            string notes = null;
            double paidFees = 0;
            bool isActive = false;

            if (!ClsDataBase.GetLicenseInfo_ByApplicationID(
                    ref licenseID, ref applicationID, ref driverID, ref licenseClass,
                    ref issueDate, ref expirationDate, ref notes, ref paidFees,
                    ref isActive, ref issueReason, ref createdByUserID))
                return null;

            return new ClsLicense(
                licenseID, applicationID, driverID, licenseClass,
                issueDate, expirationDate, notes, paidFees, isActive,
                issueReason, createdByUserID
            );
        }

        private bool AddNewLicense()
        {
            int newLicenseID = -1;
            ClsDataBase.InsertLicenseInfo(
                ref newLicenseID, this.ApplicationID, this.DriverID, this.LicenseClass,
                this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
                this.IsActive, this.IssueReason, this.CreatedByUserID
            );
            this.LicenseID = newLicenseID;
            return this.LicenseID != -1;
        }

        private bool UpdateLicense()
        {
            return ClsDataBase.UpdateLicenseInfo(
                this.LicenseID, this.ApplicationID, this.DriverID, this.LicenseClass,
                this.IssueDate, this.ExpirationDate, this.Notes, this.PaidFees,
                this.IsActive, this.IssueReason, this.CreatedByUserID
            );
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.enAddNew:
                    if (AddNewLicense())
                    {
                        this.Mode = enMode.enUpdate;
                        return true;
                    }
                    return false;

                case enMode.enUpdate:
                    return UpdateLicense();
            }
            return false;
        }
        public static bool IS_ExpireLicense(int LicenseID)
        {
            ClsLicense lic = ClsLicense.Find(LicenseID);

            return lic.ExpirationDate < DateTime.Today;
        }
        // public static bool Delete(int licenseID)
        // {
        ////     return ClsDataBase.DeleteLicense(licenseID); still not Done
        // }
        public static bool IsDetainedLicense(int LicenseID)
        {
            return GetDetainID(LicenseID) != -1;
        }
        public static int DetainLicense(int LicenseID, double FineFees)
        {
            if (IsDetainedLicense(LicenseID))
            {
                return -1;
            }

            int CreatedByUserID = Current_User.CurrUser.UserID;
            bool ISRelease = false;


            DateTime DetainDate = DateTime.Today;


            return ClsDataBase.DetainLicense(LicenseID, DetainDate, FineFees, CreatedByUserID, ISRelease);

        }
        public static int GetDetainID(int LicenseID)
        {

            return ClsDataBase.GetDetainIDBYLicenseID(LicenseID);
        }
        public int GetDetainID()
        {
            return GetDetainID(this.LicenseID);
        }
        public static bool ReleaseLicense(int DetainID, int LicenseID, int ApplicationID)
        {
            if (!IsDetainedLicense(LicenseID))
            {
                return false;
            }

            int CreatedByUserID = Current_User.CurrUser.UserID;
            bool ISRelease = true;


            DateTime DetainDate = DateTime.Today;
            return ClsDataBase.ReleaseDetainedLicense(DetainID, ApplicationID, DetainDate, CreatedByUserID, ISRelease);

        }
        public  double GetFineFees()
        {
            return ClsDataBase.GetFineFeesBYLicenseID(this.LicenseID);
        }
        public static DataTable GetDetainedLicenses()
        {
            return ClsDataBase.GetAllDetainedLicenses();
        }
    }

}
