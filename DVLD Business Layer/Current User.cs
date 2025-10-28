using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Driver_License_management
{
    
    public class Current_User
    {
       static public ClsUser CurrUser=new ClsUser();
       public Current_User(string UserName,string Password) 
        {
        CurrUser=ClsUser.Find(UserName, Password);
        }

    }
}
