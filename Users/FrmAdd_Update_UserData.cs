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
    public partial class FrmAdd_Update_UserData : Form
    {
        public FrmAdd_Update_UserData()
        {
            InitializeComponent();
            uS_Add_Update_UserData1.SaveRequest += (sender, e) => MessageBox.Show("Succeed");
            uS_Add_Update_UserData1.CloseRequested += (sender, e) => this.Close();

        }
        public FrmAdd_Update_UserData(int UserID)
        {
            InitializeComponent();
            uS_Add_Update_UserData1.SaveRequest += (sender, e) => MessageBox.Show("Succeed");
            uS_Add_Update_UserData1.CloseRequested += (sender, e) => this.Close();
            uS_Add_Update_UserData1.LoadData(UserID);

        }
    }
}
