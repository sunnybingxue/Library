using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BookManageSystem.BLL;
using BookManageSystem.Common;
using BookManageSystem.Model;

namespace BookManageSystem
{
    /// <summary>
    /// 添加或者修改信息窗体
    /// </summary>
    public partial class frmBookInfoAddOrUpdate : Form
    {
        /// <summary>
        /// 为了能使一个窗体进行两种操作
        /// 我们需要重载他的构造函数
        /// 不同构造函数构造出来的窗体完成各自不同的操作
        /// </summary>
        private frmBookInfoManage._delegateRefreshAllInfo dlg;//用来同步刷新管理界面的信息
        public frmBookInfoAddOrUpdate(frmBookInfoManage._delegateRefreshAllInfo _dlg)
        {
            InitializeComponent();
            //默认构造函数创建添加卡片信息的窗体
            this.Text = "添加新卡片信息";
            btEnter.Text = "添加";
            dlg = _dlg;
            
        }
        public frmBookInfoAddOrUpdate(CtbBookInformation bookInfoModel, frmBookInfoManage._delegateRefreshAllInfo _dlg)
        {
            InitializeComponent();
            //此构造函数用于创建修改图书卡片信息的窗体
            dlg = _dlg;
         
            //然后修改窗体标题显示的信息以及按钮显示的信息
            this.Text = "修改卡片信息";
            btEnter.Text = "保存";

            //将传过来的待修改的信息进行窗体赋值
            tbBookID.Text = bookInfoModel.bookID.ToString();
            cbBookSortID.Text = bookInfoModel.bookSortID.ToString();
            tbBookName.Text = bookInfoModel.bookName;
            tbBookAutor.Text = bookInfoModel.bookAutor;
            tbBookPublish.Text = bookInfoModel.bookPublish;
            dtpPublishDate.Value = bookInfoModel.bookPubDate;
            tbBookPrice.Text = bookInfoModel.bookPrice.ToString();
            tbBookRealNum.Text = bookInfoModel.bookRealNum.ToString();
            tbLendNum.Text = bookInfoModel.bookLendNum.ToString();
            rtbBookSummary.Text = bookInfoModel.bookSummary;
            dtpBookResDate.Value = bookInfoModel.bookResDate;

            //图书编号在修改过程不能更改
            tbBookID.ReadOnly = true;

        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            //在这里我们要进行判断我们进行的是添加还是修改
            //判断的方法我们这里只介绍针对我们现在这种情况的方法
            //方法就是判断按钮的TEXT是"添加"还是"保存"
            #region 添加事件代码
            if (btEnter.Text == "添加")
            {
                //任何时候不要忘记做程序异常检查
                //这是个良好的习惯,便于检查程序运行过程出现的容易忽略的错误
                try
                {
                    //这里做添加事件的代码
                    //先判断输入的数据是否为空
                    //我们进行进行整体判断
                    if (tbBookID.Text != "")
                        if (cbBookSortID.Text != "")
                            if (tbBookName.Text != "")
                                if (tbBookAutor.Text != "")
                                    if (tbBookPublish.Text != "")
                                        if (tbBookPrice.Text != "")
                                            if (tbBookRealNum.Text != "")
                                                if (tbLendNum.Text != "")
                                                    if (rtbBookSummary.Text != "")
                                                    {
                                                        //添加图书卡片信息的代码
                                                        CtbBookInformation newBook = new CtbBookInformation();
                                                        CtbBookInformationBLL newBookBll = new CtbBookInformationBLL();
                                                        newBook.bookID = int.Parse(tbBookID.Text);
                                                        newBook.bookSortID = int.Parse(cbBookSortID.Text);
                                                        newBook.bookName = tbBookName.Text;
                                                        newBook.bookAutor = tbBookAutor.Text;
                                                        newBook.bookPublish = tbBookPublish.Text;
                                                        newBook.bookPubDate = dtpPublishDate.Value;
                                                        newBook.bookPrice = decimal.Parse(tbBookPrice.Text);
                                                        newBook.bookRealNum = int.Parse(tbBookRealNum.Text);
                                                        newBook.bookLendNum = int.Parse(tbLendNum.Text);
                                                        newBook.bookSummary = rtbBookSummary.Text;
                                                        newBook.bookResDate = dtpBookResDate.Value;
                                                        newBookBll.Add(newBook);
                                                        if (MessageBox.Show("添加成功！是否继续添加？", "操作提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                                                        {
                                                            ClearControlValue();//清除控件中的现有值
                                                        }
                                                        else
                                                        {
                                                            dlg();//同步更新
                                                            this.Close();
                                                        }
                                                    }
                                                    else
                                                        MessageBox.Show("图书摘要不能为空！", "操作提示");
                                                else
                                                    MessageBox.Show("借出数量不能为空！", "操作提示");
                                            else
                                                MessageBox.Show("实际数量不能为空！", "操作提示");
                                        else
                                            MessageBox.Show("定价不能为空！", "操作提示");
                                    else
                                        MessageBox.Show("出版社不能为空！", "操作提示");
                                else
                                    MessageBox.Show("作者不能为空！", "操作提示");
                            else
                                MessageBox.Show("图书名称不能为空！", "操作提示");
                        else
                            MessageBox.Show("图书类别不能为空！", "操作提示");
                    else
                        MessageBox.Show("图书编号不能为空！", "操作提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "程序异常提示");
                }

            }
            #endregion
            #region 修改事件代码
            else if (btEnter.Text == "保存")
            {
                //这里做修改事件的代码
                try
                {
                    //这里我们也应该判断修改后的数据有没有空值
                        if (cbBookSortID.Text != "")
                            if (tbBookName.Text != "")
                                if (tbBookAutor.Text != "")
                                    if (tbBookPublish.Text != "")
                                        if (tbBookPrice.Text != "")
                                            if (tbBookRealNum.Text != "")
                                                if (tbLendNum.Text != "")
                                                    if (rtbBookSummary.Text != "")
                                                    {
                                                        //修改图书卡片信息的代码
                                                        CtbBookInformation newBook = new CtbBookInformation();
                                                        CtbBookInformationBLL newBookBll = new CtbBookInformationBLL();
                                                        newBook.bookID = int.Parse(tbBookID.Text);
                                                        newBook.bookSortID = int.Parse(cbBookSortID.Text);
                                                        newBook.bookName = tbBookName.Text;
                                                        newBook.bookAutor = tbBookAutor.Text;
                                                        newBook.bookPublish = tbBookPublish.Text;
                                                        newBook.bookPubDate = dtpPublishDate.Value;
                                                        newBook.bookPrice = decimal.Parse(tbBookPrice.Text);
                                                        newBook.bookRealNum = int.Parse(tbBookRealNum.Text);
                                                        newBook.bookLendNum = int.Parse(tbLendNum.Text);
                                                        newBook.bookSummary = rtbBookSummary.Text;
                                                        newBook.bookResDate = dtpBookResDate.Value;
                                                        newBookBll.Update(newBook);
                                                        MessageBox.Show("修改成功！", "操作提示");
                                                        dlg();//同步更新
                                                        this.Close(); 
                                                    }
                                                    else
                                                        MessageBox.Show("图书摘要不能为空！", "操作提示");
                                                else
                                                    MessageBox.Show("借出数量不能为空！", "操作提示");
                                            else
                                                MessageBox.Show("实际数量不能为空！", "操作提示");
                                        else
                                            MessageBox.Show("定价不能为空！", "操作提示");
                                    else
                                        MessageBox.Show("出版社不能为空！", "操作提示");
                                else
                                    MessageBox.Show("作者不能为空！", "操作提示");
                            else
                                MessageBox.Show("图书名称不能为空！", "操作提示");
                        else
                            MessageBox.Show("图书类别不能为空！", "操作提示");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "程序异常提示");
                }
            }
            #endregion
        }

        /// <summary>
        /// 清除控件现有值以备再次输入
        /// </summary>
        private void ClearControlValue()
        {
            tbBookID.Clear();
            //cbBookSortID  选择型控件可不予清空
            tbBookName.Clear();
            tbBookAutor.Clear();
            tbBookPublish.Clear();
            //dtpPublishDate 时间型控件可不予清空
            tbBookPrice.Clear();
            tbBookRealNum.Clear();
            tbLendNum.Clear();
            rtbBookSummary.Clear();
            //dtpBookResDate 时间型控件可不予清空
        }
        //绑定图书类别信息到Combox
        private void ComboxDataBinding()
        {
            CtbBookSortBLL cBs = new CtbBookSortBLL();
            List<CtbBookSort> LbookSort = cBs.GetModelList("bookSortID>0");
            foreach (CtbBookSort ctbSort in LbookSort)
            {
                cbBookSortID.Items.Add(ctbSort.bookSortID);
            }

        }

        private void frmBookInfoAddOrUpdate_Load(object sender, EventArgs e)
        {
            ComboxDataBinding();
        }

        /// <summary>
        /// 当选中图书类别编号时在标签中显示类别说明
        /// </summary>
        private void cbBookSortID_TextChanged(object sender, EventArgs e)
        {
            string selectedSortID = cbBookSortID.Text;
            CtbBookSortBLL cBs = new CtbBookSortBLL();
            List<CtbBookSort> LbookSort = cBs.GetModelList("bookSortID>0");
            foreach (CtbBookSort ctbSort in LbookSort)
            {
                if (ctbSort.bookSortID.ToString() == selectedSortID)
                {
                    lBookSortMark.Text = ctbSort.bookSortRemark;
                    break;
                }
            }
        }

        private void frmBookInfoAddOrUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            dlg();
        }
    }
}
