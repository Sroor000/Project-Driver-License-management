using Project_Driver_License_management;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_Presntation_Layer
{
    public class ClsApplicationsTypes
    {
        public int ApplicationID {  get; set; }
        public string ApplicationName { get; set; }
        public double ApplicationFees { get; set; }
       private  ClsApplicationsTypes(int ApplicationID,string ApplicationName,double ApplicationsFees)
        {

            this.ApplicationID=ApplicationID;
            this.ApplicationName=ApplicationName;
            this.ApplicationFees= ApplicationsFees;
        }
        public static ClsApplicationsTypes Find(int ApplicationID)
        {
            string Applicationname = "";
            double Applicationfees = 0;
            if (ClsDataBase.Get_ApplicationType_Info(ref ApplicationID,ref Applicationname,ref Applicationfees ))
            {
                return new ClsApplicationsTypes( ApplicationID,  Applicationname,  Applicationfees);
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetAllApplicationTypesInfo()
        {
            return ClsDataBase.Get_AllApplicationType_Info();
        }
       bool Update_Apptype()
        {
            return ClsDataBase.Update_ApptypeInfo(this.ApplicationID,this.ApplicationName,this.ApplicationFees);
        }
        public bool Save()
        {
            return Update_Apptype();
        }
    }
}
