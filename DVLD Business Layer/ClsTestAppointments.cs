using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Project_Driver_License_management
{
    public class ClsTestAppointments
    {
        public int TestAppointmentID { get; set; }
        public int TestTypeID { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public double PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }

        protected enum EnMode { AddNew, Update }
        protected EnMode mode = EnMode.AddNew;

       public  ClsTestAppointments() { }
        public ClsTestAppointments(int D_L_AppID,int testType)
        {
            this.TestAppointmentID = -1;
             ClsLocalLicenseApplication localApp=ClsLocalLicenseApplication.Find(D_L_AppID);
            this.LocalDrivingLicenseApplicationID = localApp.LocalDrivingLicenseApplicationID;
            this.CreatedByUserID=localApp.CreatedByUserID;
            this.TestTypeID = testType;
            this.PaidFees = localApp.PaidFees;
            mode = EnMode.AddNew;
        }

        protected ClsTestAppointments(int id, int typeID, int localAppID, DateTime date, double fees, int userID, bool isLocked)
        {
            TestAppointmentID = id;
            TestTypeID = typeID;
            LocalDrivingLicenseApplicationID = localAppID;
            AppointmentDate = date;
            PaidFees = fees;
            CreatedByUserID = userID;
            IsLocked = isLocked;
            mode = EnMode.Update;
        }
        public static ClsTestAppointments Find(int testAppointmentID)
        {
            int testTypeID = 0;
            int localDrivingLicenseApplicationID = 0;
            DateTime appointmentDate = DateTime.MinValue;
            double paidFees = 0;
            int createdByUserID = 0;
            bool isLocked = false;

            if (ClsDataBase.Get_TestAppointment_Info(
                ref testAppointmentID,
                ref testTypeID,
                ref localDrivingLicenseApplicationID,
                ref appointmentDate,
                ref paidFees,
                ref createdByUserID,
                ref isLocked))
            {
                return new ClsTestAppointments(testAppointmentID,
                                               testTypeID,
                                               localDrivingLicenseApplicationID,
                                               appointmentDate,
                                               paidFees,
                                               createdByUserID,
                                               isLocked);
            }

            return null;
        }
        public static DataTable GetAppiointMents_forVision(int LocalApp)
        {
            return ClsDataBase.Get_TestAppointmentsInfoBYLocalAppID(LocalApp, 1);
        }
        public  DataTable GetAppiointMents_forVision()
        {
            return ClsDataBase.Get_TestAppointmentsInfoBYLocalAppID(this.LocalDrivingLicenseApplicationID, 1);
        }
        public static DataTable GetAppiointMents_forWritten(int LocalApp)
        {
            return ClsDataBase.Get_TestAppointmentsInfoBYLocalAppID(LocalApp, 2);
        }
        public DataTable GetAppiointMents_forWritten()
        {
            return ClsDataBase.Get_TestAppointmentsInfoBYLocalAppID(this.LocalDrivingLicenseApplicationID, 2);
        }
        public static DataTable GetAppiointMents_forStreet(int LocalApp)
        {
            return ClsDataBase.Get_TestAppointmentsInfoBYLocalAppID(LocalApp, 3);
        }
        public DataTable GetAppiointMents_forStreet()
        {
            return ClsDataBase.Get_TestAppointmentsInfoBYLocalAppID(this.LocalDrivingLicenseApplicationID, 3);
        }
        public bool Save()
        {
            switch (mode)
            {
                case EnMode.AddNew:
                    return Insert();
                case EnMode.Update:return Update();
            }
            return false;
        }
        public bool Insert()
        {
           
            int newTestAppointmentID = 0;

            bool isInserted = ClsDataBase.Insert_TestAppointment(
                ref newTestAppointmentID,
                this.TestTypeID,
                this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate,
                this.PaidFees,
                this.CreatedByUserID,
                this.IsLocked
            );

            if (isInserted)
            {
                this.TestAppointmentID = newTestAppointmentID;
                mode=EnMode.Update;
            }

            return isInserted;
        }

        public bool Update()
        {
            return ClsDataBase.Update_TestAppointment(
                this.TestAppointmentID,
                this.TestTypeID,
                this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate,
                this.PaidFees,
                this.CreatedByUserID,
                this.IsLocked
            );
        }
        public static bool IsLockedTestAppointment(int D_L_AppID,int testTypeID)
        {
            return ClsDataBase.IsLockedTestAppointment(D_L_AppID, testTypeID);
        }
    }

}
