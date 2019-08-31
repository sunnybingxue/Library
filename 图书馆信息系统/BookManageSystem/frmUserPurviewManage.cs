using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using BookManageSystem.Model;
using BookManageSystem.BLL;
using BookManageSystem.Common;


namespace BookManageSystem
{
    //用户权限管理
    public partial class frmUserPurviewManage : Form
    {
        public frmUserPurviewManage()
        {
            InitializeComponent();
        }


        //刷新显示用户列表按钮事件
        private void btRefreshInfo_Click(object sender, EventArgs e)
        {
            BindAllUserList();
        }
        //绑定所有用户信息
        private void BindAllUserList()
        {
            List<CtbUserInformation> cUsers = new List<CtbUserInformation>();
            CtbUserInformationBLL userBll = new CtbUserInformationBLL();
            cUsers = userBll.GetModelList("userName is not NULL");

            dgvUserList.Columns.Clear();
            dgvUserList.DataSource = cUsers;
            dgvUserList.Columns["userName"].HeaderText = "用户名";
            dgvUserList.Columns["userPwd"].HeaderText = "用户密码";
            dgvUserList.Columns["userAllName"].HeaderText = "用户全名";
            dgvUserList.Columns["userSort"].HeaderText = "用户组别";
            dgvUserList.Columns["userPurview"].Visible = false;
        }

        //将groupbox1和groupbox3上的checkbox修改为false
        private void SetCheckBoxFalse()
        {
            //讲groupbox1上的checkbox置为未选中
            foreach (Control x in groupBox1.Controls)
            {
                CheckBox ca = (CheckBox)x;
                ca.Checked = false;
            }

            //讲groupbox3上的checkbox置为未选中
            foreach (Control y in groupBox3.Controls)
            {
                CheckBox cb = (CheckBox)y;
                cb.Checked = false;
            }
        }


        //单元格单击事件
        private void dgvUserList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetCheckBoxFalse();//将groupbox1和groupbox3上的checkbox修改为false
            int currentIndex = this.dgvUserList.CurrentRow.Index;//当前选中的行的索引
            string purviewStr = this.dgvUserList["userPurview", currentIndex].Value.ToString();

            //组别显示

            foreach (Control x in groupBox3.Controls)
            {
                CheckBox ca = (CheckBox)x;
                if (ca.Text == this.dgvUserList["userSort", currentIndex].Value.ToString())
                {
                    ca.Checked = true;
                }
            }


            //权限显示
            char[] openOrclose = purviewStr.ToCharArray();
            foreach (Control y in groupBox1.Controls)
            {
                CheckBox cb = (CheckBox)y;
                cb.Checked=CCharToBool.CharToBool(openOrclose[int.Parse(cb.Tag.ToString())]);
            }

        }

        private void btAddNewUser_Click(object sender, EventArgs e)
        {
            frmUserAddUpdate frmAdd = new frmUserAddUpdate();
            frmAdd.MdiParent = this.MdiParent;
            frmAdd.Show();
        }

        private void btUpdateUserInfo_Click(object sender, EventArgs e)
        {
            CtbUserInformation cUser = new CtbUserInformation();
            if (dgvUserList.CurrentRow != null)
            {
                cUser.userName = dgvUserList.CurrentRow.Cells["userName"].Value.ToString();
                cUser.userPwd = dgvUserList.CurrentRow.Cells["userPwd"].Value.ToString();
                cUser.userAllName = dgvUserList.CurrentRow.Cells["userAllName"].Value.ToString();
                cUser.userSort = dgvUserList.CurrentRow.Cells["userSort"].Value.ToString();
                cUser.userPurview = dgvUserList.CurrentRow.Cells["userPurview"].Value.ToString();

                frmUserAddUpdate frmUpdate = new frmUserAddUpdate(cUser);
                frmUpdate.MdiParent = this.MdiParent;
                frmUpdate.Show();
            }
            else
            {
                MessageBox.Show("请选中要修改的信息！", "操作提示");
            }
        }

        private void btDelUser_Click(object sender, EventArgs e)
        {
            if (dgvUserList.CurrentRow != null)
            {
                string userName = dgvUserList.CurrentRow.Cells["userName"].Value.ToString();
                if (MessageBox.Show("是否要删除 " + userName + " ？", "操作提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    CtbUserInformationBLL cBll = new CtbUserInformationBLL();
                    cBll.Delete(userName);
                    MessageBox.Show("删除成功！", "操作提示");
                }
            }
            else
            {
                MessageBox.Show("请选中要删除的信息！","操作提示");
            }

        }

    }
}
