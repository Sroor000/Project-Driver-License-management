using Guna.UI2.WinForms;
using System.Drawing;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Collections;
using System.Security.Policy;

namespace Project_Driver_License_management
{
    public partial class US_ShowTableData : UserControl
    {
        public US_ShowTableData()
        {
            InitializeComponent();
        
            DelID?.Invoke(GetSelectedRowAsHashtable());
            MoveButtonToRightEdge(this, Btn_Add);
            this.Resize += Resize_Control;
   
        }
    

        public delegate void EventAction(object sender, EventArgs e);
       public EventHandler Btn_AddAction=null;
        public delegate void EventID(Hashtable HT);
        public EventID DelID = null;
     

        public US_ShowTableData(DataTable dt)
        {
            InitializeComponent();
           
           this.DGV.DataSource = dt;
       
            DelID?.Invoke(GetSelectedRowAsHashtable());
            MoveButtonToRightEdge(this, Btn_Add);
        }
         public void SetSizeTable(int width,int hight)
        {
            DGV.Size=new Size(width,hight);
        }
       public void LoadData(DataTable dt) {
           
     
   
          this.DGV.DataSource = dt;
            LoadFilter();

            DelID?.Invoke(GetSelectedRowAsHashtable());

        }
        public void ReLoadData(DataTable dt)
        {



            this.DGV.DataSource = dt;
            LoadFilter();

     

        }

        public  void HideColumn(string col)
        {
            DGV.Columns[col].Visible = false;
            CMB_Filter.Items.Remove(col);  
        }
        void LoadFilter()
        {
            foreach (DataGridViewColumn col in DGV.Columns)
            {
                if (col.Visible) CMB_Filter.Items.Add(col.HeaderText);
            }
        }
        private void CMB_Filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_Search.Visible = true;
        }
        void FilterTable(string Colname, string Searchtext)
        {

            SafeSuspendBinding(DGV);
            bool ShoudShow = true;
            foreach (DataGridViewRow row in DGV.Rows)
            {
                ShoudShow = row.Cells[Colname].Value.ToString().ToLower().Contains(Searchtext.ToLower());
                row.Visible = ShoudShow;
            }
        }
        void Resete_Table()
        {
            foreach (DataGridViewRow row in DGV.Rows)
            {

                row.Visible = true;
            }
        }

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
            if (Txt_Search.Text.Length > 0)
            {
                bool isnumber = CMB_Filter.SelectedItem.ToString() == "ID";
                if (isnumber && !(Txt_Search.Text[Txt_Search.TextLength - 1] >= '0' && Txt_Search.Text[Txt_Search.TextLength - 1] <= '9'))
                {
                    Txt_Search.Text = Txt_Search.Text.Remove(Txt_Search.Text.Length - 1, 1);
                    Txt_Search.SelectionStart = Txt_Search.Text.Length;
                }
                FilterTable(CMB_Filter.SelectedItem.ToString(), Txt_Search.Text);
            }
            else Resete_Table();
        }
        private void SafeSuspendBinding(DataGridView dgv)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[dgv.DataSource];
            cm.SuspendBinding();
        }
       

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Btn_AddAction?.Invoke(sender, e);
        }
        private Hashtable GetSelectedRowAsHashtable()
        {
            Hashtable result = new Hashtable();

            if (DGV.SelectedRows.Count > 0)
            {
                DataGridViewRow row = DGV.SelectedRows[0];

                foreach (DataGridViewCell cell in row.Cells)
                {
                    string headerText = DGV.Columns[cell.ColumnIndex].HeaderText;

                    
                    if (headerText.IndexOf("ID", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        result[headerText] = cell.Value;
                    }
                }
            }

            return result;
        }
       

        private void DGV_People_Data_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DelID?.Invoke(GetSelectedRowAsHashtable());
        }
        public void HideButtonAdd()
        {
            Btn_Add.Visible = false;
        }
        public void HideButtonFilter() { 
        CMB_Filter.Visible = false;
           label1.Visible = false;
        }
        public void FocusRow(string columnName,string Value)
        {
          //  DGV_People_Data.Rows[].Selected = true;
          foreach(DataGridViewRow row in DGV.Rows)
            {
                if (row.Cells[columnName].Value.ToString() == Value)
                {
                    row.Selected = true;
                    return;
                }
            }
        }

        void MoveButtonToRightEdge(UserControl form, Control button, int margin = 10)
        {
            int newX = form.ClientSize.Width - button.Width - margin;
            int newY = button.Location.Y; 

           
            if (newX < 0) newX = 0;

            button.Location = new Point(newX, newY);
        }
        void Resize_Control(object sender, EventArgs e) {
            MoveButtonToRightEdge(this, Btn_Add);
        }
       public int RowsCount()
        {
            return DGV.Rows.Count;
        }
        public void SetImageButtonAdd(Image img)=>  Btn_Add.Image = img;
        
        public void SetImageButtonAdd(string TextPath)=>Btn_Add.Image = Image.FromFile(TextPath);

        
    }
}
