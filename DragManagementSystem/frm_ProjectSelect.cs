﻿using System;
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
    }
}