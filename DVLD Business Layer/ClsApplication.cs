using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Driver_License_management
{
    public class ClsApplication
    {
      
            public int ApplicationID { get; set; }
            public int ApplicantPersonID { get; set; }
            public DateTime ApplicationDate { get; set; }
            public int ApplicationTypeID { get; set; }
            public int ApplicationStatus { get; set; }
            public DateTime LastStatusDate { get; set; }
            public double PaidFees { get; set; }
            public int CreatedByUserID { get; set; }
       
             enum EnMode { ENAddNew, ENUpdate };
              EnMode mode= EnMode.ENAddNew;
        //public ClsApplication(int applicantPersonID) { 
        //this.ApplicantPersonID = applicantPersonID;
        //    ApplicationDate = DateTime.Now;
        //    ApplicationTypeID = -1;
        //    ApplicationStatus = 1;
        //    LastStatusDate = DateTime.Now;
        //     PaidFees = 0;
        //    CreatedByUserID = Current_User.CurrUser.UserID;
        //    mode= EnMode.ENAddNew;
        //}
        public ClsApplication(int applicantPersonID,ClsEnums.EnApplicationType AppType)
        {
            this.ApplicantPersonID = applicantPersonID;
            ApplicationDate = DateTime.Now;
            ApplicationTypeID = (int)AppType;
            ApplicationStatus = (int) ClsEnums.EnStateApplication.New;
            LastStatusDate = DateTime.Now;
            PaidFees = ClsUtility.GetFeesForApplicationType(AppType);
            CreatedByUserID = Current_User.CurrUser.UserID;
            mode = EnMode.ENAddNew;

        }


        protected ClsApplication(int applicationID, int applicantPersonID, DateTime applicationDate,
                                   int applicationTypeID, int applicationStatus, DateTime lastStatusDate,
                                   double paidFees, int createdByUserID)
            {
                ApplicationID = applicationID;
                ApplicantPersonID = applicantPersonID;
                ApplicationDate = applicationDate;
                ApplicationTypeID = applicationTypeID;
                ApplicationStatus = applicationStatus;
                LastStatusDate = lastStatusDate;
                PaidFees = paidFees;
                CreatedByUserID = createdByUserID;
                mode=EnMode.ENUpdate;
            }

            public static ClsApplication Find(int applicationID)
            {
                int personID = 0, typeID = 0, status = 0, createdBy = 0;
                DateTime appDate = DateTime.MinValue, lastDate = DateTime.MinValue;
                double fees = 0;

                if (ClsDataBase.Get_Application_Info(ref applicationID, ref personID, ref appDate,
                                                      ref typeID, ref status, ref lastDate,
                                                      ref fees, ref createdBy))
                {
                    return new ClsApplication(applicationID, personID, appDate, typeID, status, lastDate, fees, createdBy);
                }

                return null;
            }

            //public static DataTable GetAllApplications()
            //{
            //    return ClsDataBase.Get_AllApplication_Info();
            //}

            protected bool Update_Application()
            {
                return ClsDataBase.Update_Application_Info(ApplicationID, ApplicantPersonID,
                        ApplicationDate, ApplicationTypeID, ApplicationStatus,
                        LastStatusDate, PaidFees, CreatedByUserID);
            }
        protected int  AddnewApplication()
        {
            return ClsDataBase.Insert_Application_Info(
            
                this.ApplicantPersonID,
                this.ApplicationDate,
                this.ApplicationTypeID,
                this.ApplicationStatus,
                this.LastStatusDate,
                this.PaidFees,
                this.CreatedByUserID);
        }
        public bool Is_NewApplication(int LicenseClass)
        {
            return ClsDataBase.Is_NewApplication(this.ApplicantPersonID, LicenseClass);
        }
        public bool Save()
            {
            switch (mode)
            {
            case EnMode.ENUpdate:

                    return  Update_Application();
                case EnMode.ENAddNew:
                        this.ApplicationID=AddnewApplication();
                    return this.ApplicationID != -1;  
                    default: return false;
            }
              
            }
        public bool Delete()
        {
            return ClsDataBase.Delete_Application_Info(this.ApplicationID);
        }
        public static string GetType(int TypeAppID)
        {
            return TypeAppID == (int)ClsEnums.EnStateApplication.New ? "New" : TypeAppID == (int)ClsEnums.EnStateApplication.Caneled ? "Canceled" : "Complete";
        }
    }
}
