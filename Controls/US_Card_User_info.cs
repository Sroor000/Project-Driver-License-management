using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Driver_License_management
{
    public partial class US_Card_User_info : UserControl
    {
        public US_Card_User_info()
        {
            InitializeComponent();
        }
         public void LoadData(int UserID)
        {
            ClsUser user = ClsUser.Find(UserID);
            if (user == null) return;
            uS_Card_People_Info1.LoadData(user.PersonID);
            LB_UserID.Text=user.UserID.ToString();
            LB_UserName.Text=user.UserName;
            LB_IsActive.Text= user.Active?"Yes":"NO";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
