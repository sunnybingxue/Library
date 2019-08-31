using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookManageSystem.Common;
using BookManageSystem.BLL;
using BookManageSystem.Model;

namespace BookManageSystem
{
    public partial class frmBookSortManage : Form
    {
        public frmBookSortManage()
        {
            InitializeComponent();
            //权限读取,从权限字符串中取出该功能对应的字符,判断时候具有该功能的权限
            char[] openOrclose = Session.UserPurview.ToCharArray();
            tsbAddSort.Enabled = CCharToBool.CharToBool(openOrclose[1]);
            tsbDeleteSort.Enabled = CCharToBool.CharToBool(openOrclose[2]);
        }

        private void frmBookSortManage_Load(object sender, EventArgs e)
        {
            dgvDataBindingAllInfo();
        }

        /// <summary>
        /// 绑定所有种类信息到dgv
        /// </summary>
        private void dgvDataBindingAllInfo()
        {
            this.dgvAllSortInfo.Columns.Clear();
            CtbBookSortBLL cBs = new CtbBookSortBLL();
            List<CtbBookSort> LbookSort = cBs.GetModelList("bookSortID>0");
            this.dgvAllSortInfo.DataSource = LbookSort;
            this.dgvAllSortInfo.Columns["bookSortID"].HeaderText = "图书类别编号";
            this.dgvAllSortInfo.Columns["bookSortRemark"].HeaderText = "图书类别说明";
        }

        /// <summary>
        /// 添加图书种类
        /// </summary>
        private void tsbAddSort_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbSortID.Text != "" && tbSortCaption.Text != "")
                {
                    CtbBookSort newSort = new CtbBookSort();
                    newSort.bookSortID = int.Parse(tbSortID.Text);
                    newSort.bookSortRemark = tbSortCaption.Text;
                    CtbBookSortBLL newSortBll = new CtbBookSortBLL();
                    newSortBll.Add(newSort);
                    MessageBox.Show("添加成功！", "消息提示");
                    dgvDataBindingAllInfo();//刷新绑定信息
                }
                else
                {
                    MessageBox.Show("图书类别编号与图书类别说明不能为空！", "操作提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误信息");
            }
        }

        /// <summary>
        /// 删除图书类别
        /// </summary>
        private void tsbDeleteSort_Click(object sender, EventArgs e)
        {
            try
            {
                int currentIndex = this.dgvAllSortInfo.CurrentRow.Index;
                CtbBookSortBLL ctbDel = new CtbBookSortBLL();
                int bookSortID = int.Parse(this.dgvAllSortInfo["bookSortID", currentIndex].Value.ToString());
                if (MessageBox.Show("删除" + bookSortID.ToString() + "的图书编号会删除所有与此关联的图书信息,确定要删除吗？", "操作提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ctbDel.Delete(bookSortID);
                    MessageBox.Show("删除成功！", "操作提示");
                }
                dgvDataBindingAllInfo();//刷新绑定信息
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误信息");
            }
        }
    }
}
