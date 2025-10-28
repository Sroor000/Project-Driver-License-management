using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Driver_License_management
{
    public class ClsTestTypes
    {
      
            public int TestID { get; set; }
            public string TestName { get; set; }
            public double TestFees { get; set; }
            public string TestDescription { get; set; }

            private ClsTestTypes(int testID, string testName, double testFees, string testDescription)
            {
                this.TestID = testID;
                this.TestName = testName;
                this.TestFees = testFees;
                this.TestDescription = testDescription;
            }

            public static ClsTestTypes Find(int testID)
            {
                string testName = "";
                double testFees = 0;
                string testDescription = "";

                if (ClsDataBase.Get_TestType_Info(ref testID, ref testName, ref testFees, ref testDescription))
                {
                    return new ClsTestTypes(testID, testName, testFees, testDescription);
                }
                else
                {
                    return null;
                }
            }

            public static DataTable GetAllTestTypesInfo()
            {
                return ClsDataBase.Get_AllTestType_Info();
            }

            private bool Update_TestType()
            {
                return ClsDataBase.Update_TestTypeInfo(this.TestID, this.TestName, this.TestFees, this.TestDescription);
            }

            public bool Save()
            {
                return Update_TestType();
            }
        }

    
}
