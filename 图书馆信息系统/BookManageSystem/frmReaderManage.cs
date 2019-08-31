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
    public partial class frmReaderManage : Form
    {

        public  delegate void _delegateRefreshAllReader();//委托定义，用于同步刷新
        public frmReaderManage()
        {
            InitializeComponent();
            //权限检查语法
            char[] openOrclose = Session.UserPurview.ToCharArray();

            tsbAddNewReader.Enabled = CCharToBool.CharToBool(openOrclose[10]);
            tsbUpdateReader.Enabled = CCharToBool.CharToBool(openOrclose[11]);
            tsbDeleteReader.Enabled = CCharToBool.CharToBool(openOrclose[12]);
        }

        /// <summary>
        /// 绑定所有读者信息到datagridview
        /// </summary>
        private void RefreshAllReader()
        {
            this.dgvAllReader.Columns.Clear();
            List<CtbReaderInformation> allReader = new List<CtbReaderInformation>();
            CtbReaderInformationBLL allReaderBll = new CtbReaderInformationBLL();
            allReader = allReaderBll.GetModelList("readerID>0");
            this.dgvAllReader.DataSource = allReader;
            this.dgvAllReader.Columns["readerID"].HeaderText = "读者编号";
            this.dgvAllReader.Columns["readerName"].HeaderText = "读者姓名";
            this.dgvAllReader.Columns["readerSex"].HeaderText = "读者性别";
            this.dgvAllReader.Columns["readerOffice"].HeaderText = "读者职务";
            this.dgvAllReader.Columns["readerDept"].HeaderText = "工作单位";
            this.dgvAllReader.Columns["readerPhone"].HeaderText = "联系电话";
            this.dgvAllReader.Columns["readerHAddress"].HeaderText = "家庭住址";
            this.dgvAllReader.Columns["readerEmail"].HeaderText = "E-MAIL";
            this.dgvAllReader.Columns["readerResDate"].HeaderText = "登记日期";

        }

        //刷新所有读者信息
        private void tsbRefreshAllReader_Click(object sender, EventArgs e)
        {
            RefreshAllReader();
        }

        /// <summary>
        /// 添加读者
        /// </summary>
        private void tsbAddNewReader_Click(object sender, EventArgs e)
        {
            _delegateRefreshAllReader _dlg = new _delegateRefreshAllReader(RefreshAllReader);
            frmReaderAddOrUpdate frmAdd = new frmReaderAddOrUpdate(_dlg);
            frmAdd.MdiParent = this.MdiParent;
            frmAdd.Show();
        }

        //修改读者信息
        private void tsbUpdateReader_Click(object sender, EventArgs e)
        {
            CtbReaderInformation updateReader = new CtbReaderInformation();
            _delegateRefreshAllReader _dlg = new _delegateRefreshAllReader(RefreshAllReader);
            if (dgvAllReader.CurrentRow != null)
            {
                updateReader.readerID = int.Parse(dgvAllReader.CurrentRow.Cells["readerID"].Value.ToString());
                updateReader.readerName = dgvAllReader.CurrentRow.Cells["readerName"].Value.ToString();
                updateReader.readerSex = dgvAllReader.CurrentRow.Cells["readerSex"].Value.ToString();
                updateReader.readerOffice = dgvAllReader.CurrentRow.Cells["readerOffice"].Value.ToString();
                updateReader.readerDept = dgvAllReader.CurrentRow.Cells["readerDept"].Value.ToString();
                updateReader.readerPhone = dgvAllReader.CurrentRow.Cells["readerPhone"].Value.ToString();
                updateReader.readerHAddress = dgvAllReader.CurrentRow.Cells["readerHAddress"].Value.ToString();
                updateReader.readerEmail = dgvAllReader.CurrentRow.Cells["readerEmail"].Value.ToString();
                updateReader.readerResDate = DateTime.Parse(dgvAllReader.CurrentRow.Cells["readerResDate"].Value.ToString());

                //打开修改窗体
                frmReaderAddOrUpdate updateFrm = new frmReaderAddOrUpdate(updateReader, _dlg);
                updateFrm.MdiParent = this.MdiParent;
                updateFrm.Show();
            }
            else
            {
                MessageBox.Show("没有要修改的信息，请选中你要修改的信息再执行修改操作！","操作提示");
            }
        }

        //删除读者信息
        private void tsbDeleteReader_Click(object sender, EventArgs e)
        {
            CtbReaderInformationBLL readerInfo = new CtbReaderInformationBLL();
            if (dgvAllReader.CurrentRow != null)
            {
                int readerID = int.Parse(dgvAllReader.CurrentRow.Cells["readerID"].Value.ToString());
                if (MessageBox.Show("删除编号为" + readerID.ToString() + "的读者会删除所有与此读者关联的借阅与还书信息,确定要删除吗？", "操作提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    readerInfo.Delete(readerID);//执行删除
                    MessageBox.Show("删除成功！", "操作提示");
                }

                RefreshAllReader();//刷新显示
            }
            else
            {
                MessageBox.Show("请选中你要删除的信息再执行删除！", "操作提示");
            }
        }
    }
}
