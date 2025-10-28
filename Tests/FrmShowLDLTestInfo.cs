using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;


namespace Project_Driver_License_management
{
    public partial class FrmShowLDLTestInfo : Form
    {
       int D_L_APPID {  get; set; }
        int testTypeID {  get; set; }
        public FrmShowLDLTestInfo(int localappID,string Label,Image im,int TestTypeID)
        {
            InitializeComponent();
        D_L_APPID = localappID;
            testTypeID = TestTypeID;
            uS_ShowLDLAInfo1.Btn_Adddel += Add_TestAppointment;
            uS_ShowLDLAInfo1.LoadData(localappID,TestTypeID);
            LB_TextHeader.Text = Label;
            PB_Image.Image = im;
        }
      
        private void PB_Image_Click(object sender, EventArgs e)
        {

        }
        void Add_TestAppointment(object Sender, EventArgs e)
        {

            if (ClsTestAppointments.IsLockedTestAppointment(D_L_APPID,testTypeID))
            {
                MessageBox.Show("There Already Appointment not Taken Yet");
                return;
            }
            FrmEditTest Edittest = new FrmEditTest(D_L_APPID,testTypeID,uS_ShowLDLAInfo1.RowCounts());
            Edittest.ShowDialog();
            uS_ShowLDLAInfo1.LoadData(D_L_APPID, testTypeID);
        }
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditTest Edittest = new FrmEditTest(uS_ShowLDLAInfo1.TestAppointmentID,uS_ShowLDLAInfo1.RowCounts());
            Edittest.ShowDialog();
            uS_ShowLDLAInfo1.LoadData(D_L_APPID, testTypeID);

        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTakeTest TakeTest = new FrmTakeTest(uS_ShowLDLAInfo1.TestAppointmentID, uS_ShowLDLAInfo1.RowCounts());
            TakeTest.ShowDialog();
            uS_ShowLDLAInfo1.LoadData(D_L_APPID, testTypeID);
        }
        void DisableContextMenustripItem()
        {
            foreach (ToolStripItem item in contextMenuStrip1.Items)
            {
                item.Enabled= false;
            }
        }
        void EnableContextMenustripItem() {
            foreach (ToolStripItem item in contextMenuStrip1.Items)
            {
                item.Enabled = true;
            }
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

            EnableContextMenustripItem();
            if (ClsTestAppointments.Find(uS_ShowLDLAInfo1.TestAppointmentID).IsLocked)
            {
                DisableContextMenustripItem();
            }
            
        }
    }
}
