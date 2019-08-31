using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BookManageSystem
{
    public partial class FormStatus : UserControl
    {
        public FormStatus()
        {
            InitializeComponent();
            LoadAllInfo();
        }

        /// <summary>
        /// 载入所有控件信息
        /// </summary>
        private void LoadAllInfo()
        {
            tsUserName.Text = Session.UserName;
            tsUserRole.Text = Session.UserRole;
            tsUserAllName.Text = Session.UserAllName;
            tsDateTimeNow.Text = DateTime.Now.ToString("yy-MM-dd hh:mm");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsDateTimeNow.Text = DateTime.Now.ToString("yy-MM-dd hh:mm");
        }
    }
}
