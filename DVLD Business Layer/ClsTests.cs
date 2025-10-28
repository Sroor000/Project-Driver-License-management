using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Project_Driver_License_management
{
    public class ClsTests : ClsTestAppointments
    {
        public int TestID { get; set; }
        public bool TestResult { get; set; } 
        public string Notes { get; set; }

        protected enum EnMode { AddNew, Update }
        protected EnMode mode = EnMode.AddNew;

        public ClsTests(int testAppointmentID)
        {
            ClsTestAppointments testAppointment = ClsTestAppointments.Find(testAppointmentID);
            if (testAppointment != null)
            {
                mode = EnMode.AddNew;
                this.TestAppointmentID = testAppointment.TestAppointmentID;
                this.LocalDrivingLicenseApplicationID = testAppointment.LocalDrivingLicenseApplicationID;
                this.AppointmentDate = testAppointment.AppointmentDate;
                this.PaidFees = testAppointment.PaidFees;
                this.TestTypeID = testAppointment.TestTypeID;
                this.CreatedByUserID = testAppointment.CreatedByUserID;
                this.IsLocked = testAppointment.IsLocked;
            }
            
        }
      

        private ClsTests(int testID, int testAppointmentID, bool testResult, string notes, int createdByUserID,int testTypeID,int localAppID,DateTime DateAppointment,double Fees,bool Islock)
            : base(testAppointmentID,testTypeID , localAppID, DateAppointment, Fees, createdByUserID, Islock)
        {
            TestID = testID;
            TestResult = testResult;
            Notes = notes;
    
          
            mode = EnMode.Update;
        }

        public static ClsTests Find(int testID)
        {
            int testAppointmentID = 0;
            bool testResult = false;
            string notes = "";
            int createdByUserID = 0;

            if (!ClsDataBase.Get_TestByTestAppointmentID(ref testID, ref testAppointmentID, ref testResult, ref notes, ref createdByUserID))
            {
                return null;
            }

                 ClsTestAppointments testAppointment= ClsTestAppointments.Find(testAppointmentID);
            if (testAppointment == null) return null;
            return new ClsTests(testID, testAppointmentID, testResult,notes,createdByUserID,testAppointment.TestTypeID,testAppointment.LocalDrivingLicenseApplicationID
                ,testAppointment.AppointmentDate,testAppointment.PaidFees,testAppointment.IsLocked);

        }
        public static DataTable AllVisiontestAppointments(int localApp)
        {
            return ClsDataBase.GenralQuery($"SELECT Tests.TestAppointmentID\r\nFROM Tests\r\nINNER JOIN TestAppointments \r\n    ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID\r\nWHERE TestAppointments.LocalDrivingLicenseApplicationID = {localApp} and TestTypeID=1");
        }
    static bool IsPassedVisionTest(int localApp)
        {
            DataTable dtappointment = AllVisiontestAppointments(localApp);
             foreach(DataRow dr in dtappointment.Rows)
            {
                if (ClsDataBase.GenralQuery($"select top 1 tests.testResult from tests where TestAppointmentID={int.Parse(dr[0].ToString())}and testResult=1").Rows.Count>0) 
                {
                return true;
                }
            
            }
            return false;
        }
        static bool IsPassedWrittenTest(int localApp)
        {
            DataTable dtappointment = AllWrittentestAppointments(localApp);
            foreach (DataRow dr in dtappointment.Rows)
            {
                if (ClsDataBase.GenralQuery($"select top 1 tests.testResult from tests where TestAppointmentID={int.Parse(dr[0].ToString())}and testResult=1").Rows.Count>0)
                {
                    return true;
                }

            }
            return false;
        }
        static bool IsPassedStreetTest(int localApp)
        {
            DataTable dtappointment = AllStreettestAppoinments(localApp);
            foreach (DataRow dr in dtappointment.Rows)
            {
                if (ClsDataBase.GenralQuery($"select top 1 tests.testResult from tests where TestAppointmentID={int.Parse(dr[0].ToString())}and testResult=1").Rows.Count>0)
                {
                    return true;
                }

            }
            return false;
        }
        public static bool IsPassVisionTest(int localapp) { return IsPassedVisionTest(localapp); }
        public static bool IsPassWrittenTest(int localapp){ return IsPassedWrittenTest(localapp); }
        public static bool IsPassStreetTest(int localapp){ return IsPassedStreetTest(localapp); }
        public static DataTable AllWrittentestAppointments(int localApp)
        {
            return ClsDataBase.GenralQuery($"SELECT Tests.TestAppointmentID\r\nFROM Tests\r\nINNER JOIN TestAppointments \r\n    ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID\r\nWHERE TestAppointments.LocalDrivingLicenseApplicationID = {localApp} and TestTypeID=2");

        }
        public static DataTable AllStreettestAppoinments(int localApp)
        {
            return ClsDataBase.GenralQuery($"SELECT Tests.TestAppointmentID\r\nFROM Tests\r\nINNER JOIN TestAppointments \r\n    ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID\r\nWHERE TestAppointments.LocalDrivingLicenseApplicationID = {localApp} and TestTypeID=3");

        }

        public static DataTable GetAllTests()
        {
            return ClsDataBase.Get_AllTests();
        }



        public bool Save()
        {
            
            int TestID = -1;
            switch (mode)
            {
                case EnMode.AddNew:
                    return Insert_test()&&base.Update();
                case EnMode.Update:
                  return update_test()&&base.Update();
            }

            return false;
        }

        public bool Delete()
        {
            return ClsDataBase.Delete_Test(TestID);
        }
        bool Insert_test()
        {
           int TestID = -1;
          if(ClsDataBase.Insert_Test(ref TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID))
            {
                this.TestID = TestID;
                EnMode mode = EnMode.Update;
                return true;
            }
            return false;
        }
        bool update_test()
        {
            return ClsDataBase.Update_Test(this.TestID, this.TestAppointmentID, this.TestResult, this.Notes, this.CreatedByUserID);
        }
    }

}
