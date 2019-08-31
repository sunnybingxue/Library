using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookManageSystem.Common;
using BookManageSystem.Model;
using BookManageSystem.BLL;

namespace BookManageSystem
{
    public partial class frmBookInfoManage : Form
    {
        public delegate void _delegateRefreshAllInfo();//定义委托
        public frmBookInfoManage()
        {
            InitializeComponent();
            //权限检查语法
            char[] openOrclose = Session.UserPurview.ToCharArray();
            tsbBookSortManage.Enabled = CCharToBool.CharToBool(openOrclose[3]);
            tsbAddInfo.Enabled = CCharToBool.CharToBool(openOrclose[4]);
            tsbUpdateInfo.Enabled = CCharToBool.CharToBool(openOrclose[5]);
            tsbDeleteInfo.Enabled = CCharToBool.CharToBool(openOrclose[6]);
        }

        /// <summary>
        ///类别管理
        /// </summary>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmBookSortManage fsm = new frmBookSortManage();
            fsm.MdiParent = this.MdiParent;
            fsm.Show();
        }

        /// <summary>
        /// 添加图书卡片信息
        /// </summary>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            _delegateRefreshAllInfo dlg = new _delegateRefreshAllInfo(RefreshAllInfo);
            frmBookInfoAddOrUpdate fia = new frmBookInfoAddOrUpdate(dlg);
            fia.MdiParent = this.MdiParent;
            fia.Show();
        }
        /// <summary>
        /// 绑定所有书目信息到datagridview
        /// </summary>
        private void RefreshAllInfo()
        {
            this.dgvAllBookInfo.Columns.Clear();
            List<CtbBookInformation> allBookInfo = new List<CtbBookInformation>();
            CtbBookInformationBLL allBInfoBll = new CtbBookInformationBLL();
            allBookInfo = allBInfoBll.GetModelList("bookID>0");
            this.dgvAllBookInfo.DataSource = allBookInfo;
            this.dgvAllBookInfo.Columns["bookID"].HeaderText = "图书编号";
            this.dgvAllBookInfo.Columns["bookSortID"].HeaderText = "图书类型编号";
            this.dgvAllBookInfo.Columns["bookName"].HeaderText = "图书名称";
            this.dgvAllBookInfo.Columns["bookAutor"].HeaderText = "图书作者";
            this.dgvAllBookInfo.Columns["bookPublish"].HeaderText = "图书出版社";
            this.dgvAllBookInfo.Columns["bookPubDate"].HeaderText = "出版日期";
            this.dgvAllBookInfo.Columns["bookPrice"].HeaderText = "定价";
            this.dgvAllBookInfo.Columns["bookSummary"].HeaderText = "内容摘要";
            this.dgvAllBookInfo.Columns["bookRealNum"].HeaderText = "实际数量";
            this.dgvAllBookInfo.Columns["bookLendNum"].HeaderText = "借出数量";
            this.dgvAllBookInfo.Columns["bookResDate"].HeaderText = "卡片登记日期";
            
        }

        //刷新显示所有图书信息
        private void tsbRefreshAllInfo_Click(object sender, EventArgs e)
        {
            RefreshAllInfo();//刷新显示
        }

        /// <summary>
        /// 删除卡片信息
        /// </summary>
        private void tsbDeleteInfo_Click(object sender, EventArgs e)
        {
            CtbBookInformationBLL bookInfo = new CtbBookInformationBLL();
            if (dgvAllBookInfo.CurrentRow != null)
            {
                int bookID = int.Parse(dgvAllBookInfo.CurrentRow.Cells["bookID"].Value.ToString());
                if (MessageBox.Show("删除编号为" + bookID.ToString() + "的图书会删除所有与此图书关联的借阅与还书信息,确定要删除吗？", "操作提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    bookInfo.Delete(bookID);//执行删除
                    MessageBox.Show("删除成功！","操作提示");
                }

                RefreshAllInfo();//刷新显示
            }
            else
            {
                MessageBox.Show("请选中你要删除的信息再执行删除！","操作提示");
            }

        }

        //修改卡片信息
        private void tsbUpdateInfo_Click(object sender, EventArgs e)
        {
            CtbBookInformation updateBook = new CtbBookInformation();
            _delegateRefreshAllInfo dlg=new _delegateRefreshAllInfo (RefreshAllInfo);
            if (dgvAllBookInfo.CurrentRow != null)
            {
                updateBook.bookID = int.Parse(dgvAllBookInfo.CurrentRow.Cells["bookID"].Value.ToString());
                updateBook.bookSortID = int.Parse(dgvAllBookInfo.CurrentRow.Cells["bookSortID"].Value.ToString());
                updateBook.bookName = dgvAllBookInfo.CurrentRow.Cells["bookName"].Value.ToString();
                updateBook.bookAutor = dgvAllBookInfo.CurrentRow.Cells["bookAutor"].Value.ToString();
                updateBook.bookPublish = dgvAllBookInfo.CurrentRow.Cells["bookPublish"].Value.ToString();
                updateBook.bookPubDate = DateTime.Parse(dgvAllBookInfo.CurrentRow.Cells["bookPubDate"].Value.ToString());
                updateBook.bookPrice = Decimal.Parse(dgvAllBookInfo.CurrentRow.Cells["bookPrice"].Value.ToString());
                updateBook.bookSummary = dgvAllBookInfo.CurrentRow.Cells["bookSummary"].Value.ToString();
                updateBook.bookRealNum = int.Parse(dgvAllBookInfo.CurrentRow.Cells["bookRealNum"].Value.ToString());
                updateBook.bookLendNum = int.Parse(dgvAllBookInfo.CurrentRow.Cells["bookLendNum"].Value.ToString());
                updateBook.bookResDate = DateTime.Parse(dgvAllBookInfo.CurrentRow.Cells["bookResDate"].Value.ToString());

                frmBookInfoAddOrUpdate frmUpdate = new frmBookInfoAddOrUpdate(updateBook, dlg);//打开修改窗体
                frmUpdate.Show();
            }
            else
            {
                MessageBox.Show("请选中你要修改的信息再执行修改！", "操作提示");
            }
        }

    }
}
