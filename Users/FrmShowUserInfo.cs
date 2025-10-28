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
    public partial class FrmShowUserInfo : Form
    {
        public FrmShowUserInfo()
        {
            InitializeComponent();
        }
        public FrmShowUserInfo(int UserID)
        {
            InitializeComponent();
            uS_Card_User_info1.LoadData(UserID);
        }

    }
}
