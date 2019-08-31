using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookManageSystem.Common;

namespace BookManageSystem
{
    public partial class frmManagePannel : Form
    {
        private bool btBookInfo=false;//是否具有图书管理权限
        private bool btReader = false;//是否具有读者维护权限
        private bool btLend = false;//是否具有借阅管理权限
        private bool btSysInfo = false;//是否具有系统信息查询权限
        private bool btUserPurview = false;//是否具有用户权限管理权限


        public frmManagePannel()
        {
            InitializeComponent();
          
        }
        #region 图书信息管理按钮 鼠标移入移出事件
        private void btBookInfoManage_MouseEnter(object sender, EventArgs e)
        {
            ///当鼠标移入菜单的时候显示功能介绍
            btBookInfoManage.BackColor = Color.GreenYellow;
            rtBtInformation.Text = "图书信息管理功能介绍";
            rtBtInformation.Text += "\n\n提供对图书卡片信息的添加修改与删除功能。";
        }
            

        private void btBookInfoManage_MouseLeave(object sender, EventArgs e)
        {
            btBookInfoManage.BackColor = this.BackColor;
            btBookInfoManage.UseVisualStyleBackColor = true;
            rtBtInformation.Clear();
        }
        #endregion

        #region 读者信息管理按钮 鼠标移入移出事件
        private void btReaderInfoManage_MouseEnter(object sender, EventArgs e)
        {
            btReaderInfoManage.BackColor = Color.GreenYellow;
            rtBtInformation.Text = "读者信息管理功能介绍";
            rtBtInformation.Text += "\n\n提供对读者信息的添加修改与删除功能。";
        }

        private void btReaderInfoManage_MouseLeave(object sender, EventArgs e)
        {
            btReaderInfoManage.BackColor =this.BackColor;
            btReaderInfoManage.UseVisualStyleBackColor = true;
            rtBtInformation.Clear();
        }
        #endregion

        #region 图书借阅管理按钮 鼠标移入移出事件
        private void btLendMange_MouseEnter(object sender, EventArgs e)
        {
            btLendMange.BackColor = Color.GreenYellow;
            rtBtInformation.Text = "图书借阅管理功能介绍";
            rtBtInformation.Text += "\n\n提供图书借阅功能。";
            rtBtInformation.Text += "\n提供图书归还功能。";
        }

        private void btLendMange_MouseLeave(object sender, EventArgs e)
        {
            btLendMange.BackColor = this.BackColor;
            btLendMange.UseVisualStyleBackColor = true;
            rtBtInformation.Clear();
        }
        #endregion

        #region 系统信息查询管理按钮 鼠标移入移出事件
        private void btSysInfoManage_MouseEnter(object sender, EventArgs e)
        {
            btSysInfoManage.BackColor = Color.GreenYellow;
            rtBtInformation.Text = "系统信息查询管理功能介绍";
            rtBtInformation.Text += "\n\n提供对图书卡片信息的查询功能。";
            rtBtInformation.Text += "\n提供对读者信息查询功能。";
            rtBtInformation.Text += "\n提供对图书借阅信息的查询功能。";
        }

        private void btSysInfoManage_MouseLeave(object sender, EventArgs e)
        {
            btSysInfoManage.BackColor = this.BackColor;
            btSysInfoManage.UseVisualStyleBackColor = true;
            rtBtInformation.Clear();
        }
        #endregion

        #region 用户权限管理按钮 鼠标移入移出事件
        private void btUserPurviewMange_MouseEnter(object sender, EventArgs e)
        {
            btUserPurviewMange.BackColor = Color.GreenYellow;
            rtBtInformation.Text = "用户权限管理功能介绍";
            rtBtInformation.Text += "\n\n提供用户管理功能。";
            rtBtInformation.Text += "\n提供用户权限的设置功能。";
        }

        private void btUserPurviewMange_MouseLeave(object sender, EventArgs e)
        {
            btUserPurviewMange.BackColor = this.BackColor;
            btUserPurviewMange.UseVisualStyleBackColor = true;
            rtBtInformation.Clear();
        }
        #endregion

        private void btBookInfoManage_Click(object sender, EventArgs e)
        {
            //打开卡片管理窗体
            if (btBookInfo)
            {
                frmBookInfoManage fbim = new frmBookInfoManage();
                fbim.MdiParent = this.MdiParent;
                fbim.Show();
            }
            else
            {
                MessageBox.Show("您不具有使用该功能的权限！","操作提示");
            }
        }

        private void btReaderInfoManage_Click(object sender, EventArgs e)
        {
            //打开读者信息维护窗体
            if (btReader)
            {
                frmReaderManage frm = new frmReaderManage();
                frm.MdiParent = this.MdiParent;
                frm.Show();
            }
            else
            {
                MessageBox.Show("您不具有使用该功能的权限！", "操作提示");
            }
        }

        private void frmManagePannel_Load(object sender, EventArgs e)
        {
            //权限读取与设置
            char[] openOrclose = Session.UserPurview.ToCharArray();
            btBookInfo = CCharToBool.CharToBool(openOrclose[3]);
            btReader = CCharToBool.CharToBool(openOrclose[9]);
            btLend = CCharToBool.CharToBool(openOrclose[15]);
            btSysInfo = CCharToBool.CharToBool(openOrclose[20]);
            btUserPurview = CCharToBool.CharToBool(openOrclose[25]);
        }

        private void btLendMange_Click(object sender, EventArgs e)
        {
            //打开借阅管理窗体
            if (btLend)
            {
                frmBorrowReturnMana frmBR = new frmBorrowReturnMana();
                frmBR.MdiParent = this.MdiParent;
                frmBR.Show();
            }
            else
            {
                MessageBox.Show("您不具有使用该功能的权限！", "操作提示");
            }
        }

        private void btSysInfoManage_Click(object sender, EventArgs e)
        {
            //打开系统信息查询窗体
            if (btSysInfo)
            {
                frmSystemInfoSearch frmSearch = new frmSystemInfoSearch();
                frmSearch.MdiParent = this.MdiParent;
                frmSearch.Show();
            }
            else
            {
                MessageBox.Show("您不具有使用该功能的权限！", "操作提示");
            }
        }

        private void btUserPurviewMange_Click(object sender, EventArgs e)
        {
            //打开用户权限管理
            if (btUserPurview)
            {
                frmUserPurviewManage frmUserPurview = new frmUserPurviewManage();
                frmUserPurview.MdiParent = this.MdiParent;
                frmUserPurview.Show();
            }
            else
            {
                MessageBox.Show("您不具有使用该功能的权限！", "操作提示");
            }
        }
    }
}
