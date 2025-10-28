using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_Driver_License_management
{
    public class ClsLocalLicenseApplication : ClsApplication
    {
        public int LocalDrivingLicenseApplicationID { get; set; }
      
        public int LicenseClassID { get; set; }
        public int PassedTest { get; set; }
        private enum EnMode { AddNew, Update }
        private EnMode mode = EnMode.AddNew;

        public ClsLocalLicenseApplication(int PersonID,ClsEnums.EnApplicationType appType,ClsEnums.EnLicenseClass licenclass) : base(PersonID,appType)
        {
            LocalDrivingLicenseApplicationID = -1;
            ApplicationID = -1;
            LicenseClassID = (int)licenclass;
            mode = EnMode.AddNew;
            if(appType!=ClsEnums.EnApplicationType.NewLocalDrivingLicenseService) PassedTest = 3;
        }

        private ClsLocalLicenseApplication(
      int localID,
      int applicationID,
      int applicantPersonID,
      DateTime applicationDate,
      int applicationTypeID,
      int applicationStatus,
      DateTime lastStatusDate,
      double paidFees,
      int createdByUserID,
      int licenseClassID,
      int passedtest
  ) : base(applicationID, applicantPersonID, applicationDate, applicationTypeID, applicationStatus, lastStatusDate, paidFees, createdByUserID)
        {
            LocalDrivingLicenseApplicationID = localID;
            LicenseClassID = licenseClassID;
            mode = EnMode.Update;
            this.PassedTest = passedtest;
        }

        public static ClsLocalLicenseApplication Find(int localAppID)
        {
            int ApplicationID = -1;
            int licenseClassID = -1;
            int PASSEDTEST = 0;
         
            if (!ClsDataBase.Get_LocalDrivingLicenseApp_Info(ref localAppID, ref ApplicationID, ref licenseClassID))
                return null;

           
            ClsApplication baseApplication = ClsApplication.Find(ApplicationID);
            if (baseApplication == null)
                return null;

            PASSEDTEST = GetPassedTest(localAppID);
            return new ClsLocalLicenseApplication(
                localAppID,
                ApplicationID,
                baseApplication.ApplicantPersonID,             
                baseApplication.ApplicationDate,
                baseApplication.ApplicationTypeID,
                baseApplication.ApplicationStatus,
                baseApplication.LastStatusDate,
                baseApplication.PaidFees,
                baseApplication.CreatedByUserID,
                licenseClassID,
                PASSEDTEST
            );
        }


        public static DataTable GetAllLocalLicenseApplicationsView()
        {
            return ClsDataBase.Get_LocalLicenseApplicationInfoView();
        }
        private bool Update_LocalApp()
        {

            return base.Update_Application();
        }

        private bool Insert_LocalApp()
        {
            this.ApplicationID = base.AddnewApplication();
            if (this.ApplicationID == -1) return false;
            this.LocalDrivingLicenseApplicationID =

                ClsDataBase.Insert_LocalDrivingLicenseApp_Info(

                this.ApplicationID,
                this.LicenseClassID);
            if (this.LocalDrivingLicenseApplicationID == -1) return false;
            return true;
        }
        static int GetPassedTest( int localAppID)
        {
            return ClsDataBase.Get_PassedTestbyLocalApplicationID(localAppID);
        } 
        public new bool Save()
        {
            switch (mode)
            {
                case EnMode.AddNew:
                    return
                    Insert_LocalApp();

                case EnMode.Update: return Update_LocalApp();
                default: return false;
            }
        }
        public new bool Delete()
        {

            ClsApplication app = ClsApplication.Find(this.ApplicationID);
            if (ClsDataBase.Delete_LocalDrivingLicenseApp_Info(this.LocalDrivingLicenseApplicationID) && base.Delete())
                return true;

            return false;

        }
        public bool IS_NewApplication()
        {
            return base.Is_NewApplication(this.LicenseClassID);
        }
        public static string NameApplicant(int D_L_LocalApp)
        {
            return ClsPeople.Get_PersonFullName(ClsLocalLicenseApplication.Find(D_L_LocalApp).ApplicantPersonID);
        }
    } 

}

