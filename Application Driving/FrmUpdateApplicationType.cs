using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_Presntation_Layer
{
    public partial class FrmUpdateApplicationType : Form
    {ClsApplicationsTypes clsAppType = null;
        public FrmUpdateApplicationType(int ID)
        {
            InitializeComponent();
            this.clsAppType = ClsApplicationsTypes.Find(ID);
            LoadData();
        }
        public FrmUpdateApplicationType()
        {
            InitializeComponent();
           
        }
        void LoadData() {
            LB_ShowID.Text = clsAppType.ApplicationID.ToString();
            Txt_Title.Text = clsAppType.ApplicationName;
            textBox2.Text = clsAppType.ApplicationFees.ToString();
        }
        void GetData()
        {


          clsAppType.ApplicationID=int.Parse ( LB_ShowID.Text);
           clsAppType.ApplicationName=  Txt_Title.Text;
           clsAppType.ApplicationFees=double.Parse( textBox2.Text);

        }
        private void Btn_Save_Click(object sender, EventArgs e)
        {
            GetData();
            if (clsAppType.Save()) { MessageBox.Show("Succeed"); }
            else
            {
                MessageBox.Show("Failed");
            }
            
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
