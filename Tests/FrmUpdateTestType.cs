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
    public partial class FrmUpdateTestType : Form
    {
        ClsTestTypes clsTestType = null;

        public FrmUpdateTestType(int ID)
        {
            InitializeComponent();
            this.clsTestType = ClsTestTypes.Find(ID);
            LoadData();
            Txt_Fees.Focus();
        }

        public FrmUpdateTestType()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            LB_ShowID.Text = clsTestType.TestID.ToString();
            Txt_Title.Text = clsTestType.TestName;
            Txt_Fees.Text = clsTestType.TestFees.ToString();
            Txt_Description.Text = clsTestType.TestDescription;
        }

        void GetData()
        {
            clsTestType.TestID = int.Parse(LB_ShowID.Text);
            clsTestType.TestName = Txt_Title.Text;
            clsTestType.TestFees = double.Parse(Txt_Fees.Text);
            clsTestType.TestDescription = Txt_Description.Text;
        }

        private void Btn_Save_Click(object sender, EventArgs e)
        {
            GetData();
            if (clsTestType.Save())
            {
                MessageBox.Show("Succeed");
            }
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
