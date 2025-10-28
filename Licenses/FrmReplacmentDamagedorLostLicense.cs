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
    public partial class FrmReplacmentDamagedorLostLicense : Form
    {
        public FrmReplacmentDamagedorLostLicense()
        {
            InitializeComponent();
            uS_ReplecmentDamgedorLostLicense1.delClose += (object s, EventArgs e) => this.Close();
        }
    }
}
