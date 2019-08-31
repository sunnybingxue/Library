using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//-------添加命名空间--------
using BookManageSystem.Model;
using BookManageSystem.BLL;
using BookManageSystem.Common;

namespace BookManageSystem
{
    //添加修改用户窗体
    public partial class frmUserAddUpdate : Form
    {
        private string userName = "";//用户名
        private string userPwd = "";//密码
        private string userPurview = "00000000000000000000000000000000000000000000000000";//权限
        private string userAllName = "";//全称
        private string userSort = "";//组别

        private char[] charPurview ;//保存权限字符串

        private CtbUserInformation cUser;

        //默认构造函数
        public frmUserAddUpdate()
        {
            InitializeComponent();

            //---------------添加用户-----------
            this.Text = "添加用户";
            btEnter.Text = "添加";
            //----------------------------------

            charPurview = userPurview.ToCharArray();//将权限字符串转为权限字符
        }
        //重载构造函数
        public frmUserAddUpdate(CtbUserInformation _cUser)
        {
            InitializeComponent();

            //----------修改用户信息------------
            this.Text = "修改用户信息";
            btEnter.Text = "保存";

            cUser = _cUser;//接收传过来的用户信息

            //----以下提取用户信息进行控件赋值-----
            charPurview = cUser.userPurview.ToCharArray();

            //----组别赋值---
            foreach (Control x in groupBox3.Controls)
            {
                RadioButton ra = (RadioButton)x;
                if (ra.Text == cUser.userSort)
                {
                    ra.Checked = true;
                }
            }

            //----权限控件赋值----
            foreach (Control y in groupBox2.Controls)
            {
                CheckBox ca = (CheckBox)y;
                ca.Checked = CCharToBool.CharToBool(charPurview[int.Parse(ca.Tag.ToString())]);
            }

            //----基本信息赋值----
            tbUserName.Text = cUser.userName;
            tbUserPwd.Text = cUser.userPwd;
            tbUserAllName.Text = cUser.userAllName;


            tbUserName.ReadOnly = true;
        }

        //按钮事件
        private void btEnter_Click(object sender, EventArgs e)
        {
            CtbUserInformationBLL userBll = new CtbUserInformationBLL();

            #region 操作代码
                if (tbUserName.Text != "" && tbUserPwd.Text != "" && tbPwdAgain.Text != "" && tbUserAllName.Text != "")
                {
                    if (btEnter.Text == "添加")
                    {
                        if (userBll.Exists(tbUserName.Text))
                        {
                            MessageBox.Show("已经存在的用户名！", "操作提示");
                            return;
                        }
                    }
                    if (!tbPwdAgain.Text.Equals(tbUserPwd.Text))
                    {
                        MessageBox.Show("两次密码输入不一致！", "操作提示");
                        return;
                    }

                    userName = tbUserName.Text;//取用户名
                    userPwd = tbUserPwd.Text;//取密码
                    userAllName = tbUserAllName.Text;//取全称

                    //--------取组别--------------
                    foreach (Control x in groupBox3.Controls)
                    {
                        RadioButton ra = (RadioButton)x;
                        if (ra.Checked)
                        {
                            userSort = ra.Text;
                        }
                    }
                    //----------------------------



                    #region //------取权限----------------
                    foreach (Control y in groupBox2.Controls)
                    {
                        CheckBox ca = (CheckBox)y;
                        int index = int.Parse(ca.Tag.ToString());//获取字符串中位置

                        charPurview[index] = CBoolToChar.BoolToChar(ca.Checked);//设置权限
                    }

                    userPurview = new string(charPurview);//取得权限


                    #endregion ----------分割线--------------


                    cUser = new CtbUserInformation();
                    cUser.userName = userName;
                    cUser.userPwd = userPwd;
                    cUser.userPurview = userPurview;
                    cUser.userAllName = userAllName;
                    cUser.userSort = userSort;

                    if (btEnter.Text == "添加")
                    {
                        userBll.Add(cUser);

                        MessageBox.Show("添加成功！", "操作成功");
                    }
                    if (btEnter.Text == "保存")
                    {
                        userBll.Update(cUser);

                        MessageBox.Show("修改成功！", "操作成功");
                    }

                }
                else
                {
                    MessageBox.Show("请讲基本信息填写完整！", "操作提示");
                }
            #endregion

 
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

 
    }
}
