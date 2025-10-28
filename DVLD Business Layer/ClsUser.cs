using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project_Driver_License_management
{
    public class ClsUser
    {
        public int UserID { get; set; }
        public string UserName {  get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public int PersonID {  get; set; }
       public string FullName {  get; set; }
        public enum enmode { enAddnew = 0, enUpdate = 1 };
        public enmode Mode = enmode.enAddnew;
        private ClsUser(int userID, string username,string  password,int  personID,string  fullname,bool active)
        {
            this.UserName=username;
            this.UserID = userID;
            this.PersonID = personID;
            this.FullName= fullname;
            this.Active = active;
            this.Password = password;
            this.Mode = enmode.enUpdate;
        }
       public ClsUser()
        {
            this.UserName = string.Empty;
            this.UserID = -1;
            this.PersonID = -1;
            this.FullName = string.Empty;
            this.Active = false;
            this.Mode = enmode.enAddnew;
        }
        public  static ClsUser Find(int UserID)
        {
            int  personID=-1;
            string username = "", password = "",fullname="";
            bool active=false;

            if (ClsDataBase.Get_UserData_ByID(ref UserID, ref username, ref password, ref personID, ref fullname, ref active))
                    {
                return new ClsUser(UserID, username, password, personID, fullname, active);
                    }
            else
            {
                return null;
            }
        } 
    
          public static ClsUser Find(string UserName,string Password)
        {
            int userID = -1, personID = -1;
            string username = UserName, password =Password, fullname = "";
            bool active = false;

            if (ClsDataBase.Get_UserData_UserandPassword(ref userID, ref username, ref password, ref personID, ref fullname, ref active))
            {
                return new ClsUser(userID, username, password, personID, fullname, active);
            }
            else
            {
                return null;
            }
        }
        private bool AddNewUser()
        {

            return ClsDataBase.Insert_UserData(this.PersonID, this.UserName,ClsUtility.ComputeHash( this.Password), this.Active);
        }
        public static int Get_UserIDBy_PersonID(int PersonID)
        {
            return ClsDataBase.GetUserIDBy_PersonID(PersonID);
        }
        private bool Update_People_Data()
        {
            return ClsDataBase.Update_UserData(this.UserID,this.PersonID, this.UserName,ClsUtility.ComputeHash( this.Password), this.Active);

        }
        public bool Save()
        {
            switch (Mode)
            {
                case enmode.enAddnew:
                    if (AddNewUser())
                    {
                        Mode = enmode.enUpdate;
                        return true;
                    }
                    else { return false; }

                case enmode.enUpdate:
                    if (Update_People_Data())
                    {
                        return true;
                    }
                    else return false;


            }
            return false;
        }
        public static DataTable GetAllUserData() {
            return ClsDataBase.Get_AllUserData();
        }
        public static bool DeleteUserData(int UserID)
        {
            return ClsDataBase.DeleteUserData(UserID);
        }
        public static bool IsExist_User(int UserID) {
        return ClsDataBase.ISExist_User(UserID);
        }
        public static string GetUserName(int UserID) 
        {
        return ClsDataBase.GenralQuery($"Select UserName from Users where UserID={UserID}").Rows[0]["UserName"].ToString();
        }
    }
}
