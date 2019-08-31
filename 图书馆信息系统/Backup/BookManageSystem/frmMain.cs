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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Session.UserName != "")
            {
                //权限读取与设置
                char[] openOrclose = Session.UserPurview.ToCharArray();

                图书卡片管理ToolStripMenuItem.Enabled = CCharToBool.CharToBool(openOrclose[3]);
                读者信息维护ToolStripMenuItem.Enabled= CCharToBool.CharToBool(openOrclose[9]);
                借阅图书ToolStripMenuItem.Enabled = CCharToBool.CharToBool(openOrclose[16]);
                归还图书ToolStripMenuItem.Enabled = CCharToBool.CharToBool(openOrclose[17]);
                图书信息查询ToolStripMenuItem.Enabled = CCharToBool.CharToBool(openOrclose[21]);
                读者信息查询ToolStripMenuItem.Enabled = CCharToBool.CharToBool(openOrclose[22]);
                图书借阅查询ToolStripMenuItem.Enabled = CCharToBool.CharToBool(openOrclose[23]);
                用户权限管理ToolStripMenuItem.Enabled = CCharToBool.CharToBool(openOrclose[27]);


                frmManagePannel frmMp = new frmManagePannel();
                frmMp.MdiParent = this;
                frmMp.Show();
            }
        }

        //显示当前打开的子窗体
        private void tsMenuItemWindow_DropDownOpening(object sender, EventArgs e)
        {
            this.tsMenuItemWindow.DropDownItems.Clear();

            int i = -1;

            foreach (Form fr in this.MdiChildren)
            {
                i++;
                this.tsMenuItemWindow.DropDownItems.Add(fr.Text);
                this.tsMenuItemWindow.DropDownItems[i].Click += new EventHandler(frmMain_Click);
                if (this.ActiveMdiChild.Text.Equals(fr.Text))
                {
                    (this.tsMenuItemWindow.DropDownItems[i] as ToolStripMenuItem).Checked = true;
                }
            }
        }

        void frmMain_Click(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            ToolStripItem ti = sender as ToolStripItem;
            if (ti != null)
            {
                foreach (Form fr in this.MdiChildren)
                {
                    if(fr.Text.Equals(ti.Text))
                        fr.Focus();

                }
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 注销用户ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Session.ReSetSession();
            Application.Restart();
        }

        private void 借阅图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowReturnMana frmBorrow = new frmBorrowReturnMana();
            frmBorrow.tabControl1.SelectedTab = frmBorrow.tabBorrow;
            frmBorrow.MdiParent = this;
            frmBorrow.Show();
        }

        private void 归还图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBorrowReturnMana frmReturn = new frmBorrowReturnMana();
            frmReturn.tabControl1.SelectedTab = frmReturn.tabReturn;
            frmReturn.MdiParent = this;
            frmReturn.Show();
        }

        private void 图书信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSystemInfoSearch frmSearch = new frmSystemInfoSearch();
            frmSearch.tabControl1.SelectedTab = frmSearch.tpBookInfo;
            frmSearch.MdiParent = this;
            frmSearch.Show();
        }

        private void 读者信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSystemInfoSearch frmSearch = new frmSystemInfoSearch();
            frmSearch.tabControl1.SelectedTab = frmSearch.tpReaderInfo;
            frmSearch.MdiParent = this;
            frmSearch.Show();
        }

        private void 图书借阅查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSystemInfoSearch frmSearch = new frmSystemInfoSearch();
            frmSearch.tabControl1.SelectedTab = frmSearch.tpLendInfo;
            frmSearch.MdiParent = this;
            frmSearch.Show();
        }

        private void 用户权限管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserPurviewManage frmUserPurview = new frmUserPurviewManage();
            frmUserPurview.MdiParent = this;
            frmUserPurview.Show();
        }

        private void 图书卡片管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBookInfoManage frmBookInfo = new frmBookInfoManage();
            frmBookInfo.MdiParent = this;
            frmBookInfo.Show();
        }

        private void 读者信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReaderManage frmReaderInfo = new frmReaderManage();
            frmReaderInfo.MdiParent = this;
            frmReaderInfo.Show();
        }


    }
}
