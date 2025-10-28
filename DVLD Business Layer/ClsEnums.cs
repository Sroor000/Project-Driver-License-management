using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Driver_License_management
{
    public class ClsEnums
    {
       public  enum EnIssueReason
        {
            FirstTime=1,
            Renew=2,
            ReplacemnetForDamaged=3,
            ReplacenmentForLost=4,
        }
        public enum EnStateApplication
        {
            New=1,
            Caneled=2,
            Compeleted=3
        }
        public enum EnApplicationType
        {
            NewLocalDrivingLicenseService = 1,
            RenewDrivingLicenseService = 2,
            ReplacementForLostDrivingLicense = 3,
            ReplacementForDamagedDrivingLicense = 4,
            ReleaseDetainedDrivingLicense = 5,
            NewInternationalLicense = 6
        }
        public enum EnLicenseClass
        {

     SmallMotorcycle         = 1 ,
     HeavyMotorcycleLicense  =2 ,
     Ordinarydrivinglicense  =3 ,
     Commercial              =4 ,
     Agricultural            =5 ,
     Smallandmediumbus       =6 ,
     Truckandheavyvehicle    =7 ,
        }

    }
}
