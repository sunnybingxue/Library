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
    public partial class frmSystemInfoSearch : Form
    {
        public frmSystemInfoSearch()
        {
            InitializeComponent();
        }


        //图书查询按钮事件
        private void btBookInfo_Click(object sender, EventArgs e)
        {
            List<CtbBookInformation> cBooks = new List<CtbBookInformation>();
            CtbBookInformationBLL cBookBll = new CtbBookInformationBLL();

            string sqlstr = "";

            if (cbBBookID.Checked)
            {
                if (tbBBookID.Text != "")
                {
                    sqlstr = sqlstr + "and bookID=" + tbBBookID.Text + " ";
                }
            }
            if (cbBSortID.Checked)
            {
                if (tbBSortID.Text != "")
                {
                    sqlstr = sqlstr + "and bookSortID=" + tbBSortID.Text + " ";
                }
            }
            if (cbBName.Checked)
            {
                if (tbBName.Text != "")
                {
                    sqlstr = sqlstr + "and bookName='" + tbBName.Text + "' ";
                }
            }
            if (cbBAuthor.Checked)
            {
                if (tbBAuthor.Text != "")
                {
                    sqlstr = sqlstr + "and bookAutor='" + tbBAuthor.Text + "' ";
                }
            }
            if (cbBPublish.Checked)
            {
                if (tbBPublish.Text != "")
                {
                    sqlstr = sqlstr + "and bookPublish='" + tbBPublish.Text + "' ";
                }
            }

            if (sqlstr != "")
            {
                sqlstr = sqlstr.Remove(0, 4);//去掉字符串中最前面的and
                cBooks = cBookBll.GetModelList(sqlstr);
                if (cBooks.Count > 0)
                {
                    this.dgvSearchResult.Columns.Clear();
                    this.dgvSearchResult.DataSource = cBooks;
                    this.dgvSearchResult.Columns["bookID"].HeaderText = "图书编号";
                    this.dgvSearchResult.Columns["bookSortID"].HeaderText = "图书类型编号";
                    this.dgvSearchResult.Columns["bookName"].HeaderText = "图书名称";
                    this.dgvSearchResult.Columns["bookAutor"].HeaderText = "图书作者";
                    this.dgvSearchResult.Columns["bookPublish"].HeaderText = "图书出版社";
                    this.dgvSearchResult.Columns["bookPubDate"].HeaderText = "出版日期";
                    this.dgvSearchResult.Columns["bookPrice"].HeaderText = "定价";
                    this.dgvSearchResult.Columns["bookSummary"].HeaderText = "内容摘要";
                    this.dgvSearchResult.Columns["bookRealNum"].HeaderText = "实际数量";
                    this.dgvSearchResult.Columns["bookLendNum"].HeaderText = "借出数量";
                    this.dgvSearchResult.Columns["bookResDate"].HeaderText = "卡片登记日期";
                }
                else
                {
                    MessageBox.Show("未查到相关信息！", "操作提示");
                }
            }
            else
            {
                sqlstr = "bookID>0";
                cBooks = cBookBll.GetModelList(sqlstr);
                if (cBooks.Count > 0)
                {
                    this.dgvSearchResult.Columns.Clear();
                    this.dgvSearchResult.DataSource = cBooks;
                    this.dgvSearchResult.Columns["bookID"].HeaderText = "图书编号";
                    this.dgvSearchResult.Columns["bookSortID"].HeaderText = "图书类型编号";
                    this.dgvSearchResult.Columns["bookName"].HeaderText = "图书名称";
                    this.dgvSearchResult.Columns["bookAutor"].HeaderText = "图书作者";
                    this.dgvSearchResult.Columns["bookPublish"].HeaderText = "图书出版社";
                    this.dgvSearchResult.Columns["bookPubDate"].HeaderText = "出版日期";
                    this.dgvSearchResult.Columns["bookPrice"].HeaderText = "定价";
                    this.dgvSearchResult.Columns["bookSummary"].HeaderText = "内容摘要";
                    this.dgvSearchResult.Columns["bookRealNum"].HeaderText = "实际数量";
                    this.dgvSearchResult.Columns["bookLendNum"].HeaderText = "借出数量";
                    this.dgvSearchResult.Columns["bookResDate"].HeaderText = "卡片登记日期";
                }
                else
                {
                    MessageBox.Show("未查到相关信息！", "操作提示");
                }
            }
        }


        //读者信息查询
        private void btReader_Click(object sender, EventArgs e)
        {
            List<CtbReaderInformation> cReaders = new List<CtbReaderInformation>();
            CtbReaderInformationBLL readerBll = new CtbReaderInformationBLL();

            string sqlStr = "";

            if (cbRID.Checked)
            {
                if (tbRID.Text != "")
                {
                    sqlStr = sqlStr + "and readerID=" + tbRID.Text+" ";
                }
            }
            if (cbRName.Checked)
            {
                if (tbRName.Text != "")
                {
                    sqlStr = sqlStr + "and readerName='" + tbRName.Text + "' ";
                }
            }
            if (cbRSex.Checked)
            {
                sqlStr = sqlStr + "and readerSex='" + comRSex.Text + "' ";
            }
            if (cbROffice.Checked)
            {
                if (tbROffice.Text != "")
                {
                    sqlStr = sqlStr + "and readerOffice=" + tbROffice.Text + "' ";
                }
            }
            if (cbRDept.Checked)
            {
                if (tbRDept.Text != "")
                {
                    sqlStr = sqlStr + "and readerDept='" + tbRDept.Text + "' ";
                }
            }
            if (cbRPhone.Checked)
            {
                if (tbRPhone.Text != "")
                {
                    sqlStr = sqlStr + "and readerPhone=" + tbRPhone.Text + "' ";
                }
            }
            if (cbREmail.Checked)
            {
                if (tbREmail.Text != "")
                {
                    sqlStr = sqlStr + "and readerEmail=" + tbREmail.Text + "' ";
                }
            }



            if (sqlStr != "")
            {
                sqlStr = sqlStr.Remove(0, 4);
                cReaders = readerBll.GetModelList(sqlStr);
                if (cReaders.Count > 0)
                {
                    this.dgvSearchResult.Columns.Clear();
                    this.dgvSearchResult.DataSource = cReaders;
                    this.dgvSearchResult.Columns["readerID"].HeaderText = "读者编号";
                    this.dgvSearchResult.Columns["readerName"].HeaderText = "读者姓名";
                    this.dgvSearchResult.Columns["readerSex"].HeaderText = "性别";
                    this.dgvSearchResult.Columns["readerOffice"].HeaderText = "读者职务";
                    this.dgvSearchResult.Columns["readerDept"].HeaderText = "工作单位";
                    this.dgvSearchResult.Columns["readerPhone"].HeaderText = "联系电话期";
                    this.dgvSearchResult.Columns["readerHAddress"].HeaderText = "家庭住址";
                    this.dgvSearchResult.Columns["readerEmail"].HeaderText = "Email";
                    this.dgvSearchResult.Columns["readerResDate"].HeaderText = "登记日期";
                }
                else
                {
                    MessageBox.Show("未查到相关信息！", "操作提示");
                }
            }
            else
            {
                sqlStr = "readerID>0";
                cReaders = readerBll.GetModelList(sqlStr);
                if (cReaders.Count > 0)
                {
                    this.dgvSearchResult.Columns.Clear();
                    this.dgvSearchResult.DataSource = cReaders;
                    this.dgvSearchResult.Columns["readerID"].HeaderText = "读者编号";
                    this.dgvSearchResult.Columns["readerName"].HeaderText = "读者姓名";
                    this.dgvSearchResult.Columns["readerSex"].HeaderText = "性别";
                    this.dgvSearchResult.Columns["readerOffice"].HeaderText = "读者职务";
                    this.dgvSearchResult.Columns["readerDept"].HeaderText = "工作单位";
                    this.dgvSearchResult.Columns["readerPhone"].HeaderText = "联系电话期";
                    this.dgvSearchResult.Columns["readerHAddress"].HeaderText = "家庭住址";
                    this.dgvSearchResult.Columns["readerEmail"].HeaderText = "Email";
                    this.dgvSearchResult.Columns["readerResDate"].HeaderText = "登记日期";
                }
                else
                {
                    MessageBox.Show("未查到相关信息！", "操作提示");
                }
            }
        }

        //借阅信息查询
        private void btLend_Click(object sender, EventArgs e)
        {
            List<CtbLend> cLends = new List<CtbLend>();
            CtbLendBLL lendBll = new CtbLendBLL();

            string StrSQL = "";

            if(cbLBookID.Checked)
            {
                if (tbLBookID.Text != "")
                {
                    StrSQL = StrSQL + "and bookID="+tbLBookID.Text+" ";
                }
            }
            if (cbLReaderID.Checked)
            {
                if (tbLReaderID.Text != "")
                {
                    StrSQL = StrSQL + "and readerID=" + tbLReaderID.Text + " ";
                }
            }
            if (cbLlendNum.Checked)
            {
                if (tbLlendNum.Text != "")
                {
                    StrSQL = StrSQL + "and lendNum" + numFlag.Text + tbLlendNum.Text+" ";
                }
            }
            if (cbLlenddate.Checked)
            {
             
                StrSQL = StrSQL + "and lendDate between '" +dtpStartTime.Value.ToString()  +"' and '"+ dtpEndTime.Value.ToString()+ "' ";
            }


            if (StrSQL != "")
            {
                StrSQL = StrSQL.Remove(0, 4);
                cLends = lendBll.GetModelList(StrSQL);
                if (cLends.Count > 0)
                {
                    this.dgvSearchResult.Columns.Clear();
                    this.dgvSearchResult.DataSource = cLends;
                    this.dgvSearchResult.Columns["bookID"].HeaderText = "图书编号";
                    this.dgvSearchResult.Columns["readerID"].HeaderText = "读者编号";
                    this.dgvSearchResult.Columns["lendNum"].HeaderText = "借阅数量";
                    this.dgvSearchResult.Columns["lendDate"].HeaderText = "借阅日期";
                    this.dgvSearchResult.Columns["lendYDate"].HeaderText = "应归还日期";
                    this.dgvSearchResult.Columns["lendSDate"].HeaderText = "实归还日期";
                    this.dgvSearchResult.Columns["lendMulct"].HeaderText = "罚款金额";
                }
                else
                {
                    MessageBox.Show("未查到相关信息！", "操作提示");
                }
            }
            else
            {
                StrSQL = "readerID>0";
                cLends = lendBll.GetModelList(StrSQL);
                if (cLends.Count > 0)
                {
                    this.dgvSearchResult.Columns.Clear();
                    this.dgvSearchResult.DataSource = cLends;
                    this.dgvSearchResult.Columns["bookID"].HeaderText = "图书编号";
                    this.dgvSearchResult.Columns["readerID"].HeaderText = "读者编号";
                    this.dgvSearchResult.Columns["lendNum"].HeaderText = "借阅数量";
                    this.dgvSearchResult.Columns["lendDate"].HeaderText = "借阅日期";
                    this.dgvSearchResult.Columns["lendYDate"].HeaderText = "应归还日期";
                    this.dgvSearchResult.Columns["lendSDate"].HeaderText = "实归还日期";
                    this.dgvSearchResult.Columns["lendMulct"].HeaderText = "罚款金额";
                }
                else
                {
                    MessageBox.Show("未查到相关信息！", "操作提示");
                }
            }
        }

        private void frmSystemInfoSearch_Load(object sender, EventArgs e)
        {
            //开始时间比结束时间小30天
            DateTime dt = dtpEndTime.Value;
            dt = dt.AddDays(-30);
            dtpStartTime.Value = dt;


            //权限读取与设置
            char[] openOrclose = Session.UserPurview.ToCharArray();
            if (!CCharToBool.CharToBool(openOrclose[21]))
            {
                this.tabControl1.TabPages.Remove(tpBookInfo);
            }
            if (!CCharToBool.CharToBool(openOrclose[22]))
            {
                this.tabControl1.TabPages.Remove(tpReaderInfo);
            }
            if (!CCharToBool.CharToBool(openOrclose[23]))
            {
                this.tabControl1.TabPages.Remove(tpLendInfo);
            }
        }
    }
}
