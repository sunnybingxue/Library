using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BookManageSystem.BLL;
using BookManageSystem.Model;

namespace BookManageSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if (tbUserName.Text != "" && tbUserPwd.Text != "")
            {
                CtbUserInformationBLL Cuser = new CtbUserInformationBLL();
                if (Cuser.Exists(tbUserName.Text, tbUserPwd.Text,cbUserSort.Text))
                {
                    MessageBox.Show("用户登录成功！");
                    CtbUserInformation cUser=new CtbUserInformation ();
                    cUser =Cuser.GetModel(tbUserName.Text);
                    Session.UserName = cUser.userName;
                    Session.UserPwd = cUser.userPwd;
                    Session.UserAllName = cUser.userAllName;
                    Session.UserPurview = cUser.userPurview;
                    Session.UserRole = cUser.userSort;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("不存在此用户或用户名密码错！");
                }
            }
        }
    }
}
