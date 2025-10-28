using Guna.UI2.WinForms;
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
    public partial class Frmtest : Form
    {
        public Frmtest()
        {
            InitializeComponent();
        }
        public Frmtest(int UserID)
        {
            InitializeComponent();
            uS_Add_Update_UserData1.LoadData(UserID);
          
        

          
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
