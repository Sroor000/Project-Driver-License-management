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
    public partial class FrmManageDrivers : Form
    {
        public FrmManageDrivers()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            uS_ShowTableData1.HideButtonAdd();
            uS_ShowTableData1.LoadData(ClsDrivers.GetAllDriversInfo_View());
        }
    }
}
