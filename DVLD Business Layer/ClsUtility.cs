using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace Project_Driver_License_management
{
    public class ClsUtility
    {

       public static   DataTable Get_LicenseClassesNameandFees()
        {
            return ClsDataBase.Get_ClassLicense_NameandFees();
        }
        public static string Get_ClassLicense_NameBYClassLicenseID(int ClassID)
        {
            return ClsDataBase.Get_ClassLicense_NameBYClassLicenseID(ClassID);
        }
       public static string Get_ClassLicense_NameBYD_APPID(int D_L_AppID)
        {
            return ClsDataBase.Get_ClassLicense_NameBYD_APPID(D_L_AppID);
        }
        public static int Get_ClassLicense_IDBYD_APPID(int D_L_AppID)
        {
            return ClsDataBase.Get_ClassLicense_IDBYD_APPID(D_L_AppID);
        }
        public static int INT(string s) { 
        return int.Parse(s);

        }
        public static double DOUBLE(string s)
        {
            return double.Parse(s);

        }
        public static int  GetDirverIDBYPersonID(int personID)
        {
          return   ClsDataBase.GetDirverIDBYPersonID( personID);
        }
        public static int GetPersonIDBYDriverID(int DriverID)
        {
            return ClsDataBase.GetPersonIDBYDriverID(DriverID);
        }
        public static string GetNameIssueReason(ClsEnums.EnIssueReason EnIssueReason) 
        {
            switch (EnIssueReason) 
            
            {
                case ClsEnums.EnIssueReason.FirstTime:
                    return "FirstTime";
                case ClsEnums.EnIssueReason.Renew:
                    return "Renew";
                case ClsEnums.EnIssueReason.ReplacemnetForDamaged:
                    return "ReplacemnetForDamaged";
                case ClsEnums.EnIssueReason.ReplacenmentForLost:
                    return "ReplacenmentForLost";





            }

            return null;
        
        }
      public static   void ValidateChar(TextBox textBox, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBox.Text)) return;

            char lastChar = textBox.Text[textBox.TextLength - 1];

            bool isValid = char.IsLetter(lastChar);

            if (!isValid)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                textBox.SelectionStart = textBox.Text.Length;
            }
        }
      public static  void ValidateNumber(TextBox textBox, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text)) return;
            char lastChar = textBox.Text[textBox.TextLength - 1];

            bool isValid = char.IsDigit(lastChar);

            if (!isValid)
            {
                textBox.Text = textBox.Text.Remove(textBox.Text.Length - 1, 1);
                textBox.SelectionStart = textBox.Text.Length;
            }

        }
      public static  double GetFeesForApplicationType(ClsEnums.EnApplicationType applicationType)
        {
            return ClsDataBase.GetFeesForApplicationType((int)applicationType);
        }
        public static bool IsDetainedLicense(int LicenseID)
        {
            return ClsDataBase.IsDetainedLicense(LicenseID);
        }
        public static double GetFeesLicense(int licenseClassID)
        {
           return  ClsDataBase.GetFeesLicense(licenseClassID);
        }
        public static string ComputeHash(string data)
        {
            using (SHA256 sHA256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(data);
                byte[] hashbyte = sHA256.ComputeHash(bytes);
                return BitConverter.ToString(hashbyte).Replace("-", "");
            }

        }

        public static string Get_Name_Country(int countryID)
        {
           return ClsDataBase.Get_Name_Country((int)countryID);
        }
    }
}
