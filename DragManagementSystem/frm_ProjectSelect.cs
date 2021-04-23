using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DragManagementSystem
{
    public partial class frm_ProjectSelect : Form
    {
        public frm_ProjectSelect()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private string _UserNo;
        private string _UserName;
        public frm_ProjectSelect(string UserNo,string UserName) : this()
        {
            this._UserName = UserName;
            this._UserNo = UserNo;
        }

        private void frm_ProjectSelect_Load(object sender, EventArgs e)
        {
            this.lbl_UserName.Text = this._UserName+this._UserNo;
        }

        private void btn_Info_Click(object sender, EventArgs e)
        {
            frm_info _Info = new frm_info(this._UserNo,this._UserName);
            _Info.Show();
            this.Hide();
        }

        private void btn_Repertory_Click(object sender, EventArgs e)
        {
            frm_Repertory _Repertory = new frm_Repertory(_UserNo,_UserName);
            _Repertory.Show();
            this.Hide();
        }

        private void btn_Order_Click(object sender, EventArgs e)
        {
            frm_PlanningOrder _PlanningOrder = new frm_PlanningOrder();
            _PlanningOrder.Show();
        }
    }
}
