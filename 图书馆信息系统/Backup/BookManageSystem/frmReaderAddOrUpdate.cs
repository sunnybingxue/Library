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

namespace BookManageSystem
{
    public partial class frmReaderAddOrUpdate : Form
    {
        private frmReaderManage._delegateRefreshAllReader dlg;//用来同步刷新管理界面的信息
        /// <summary>
        /// 为了能使一个窗体进行两种操作
        /// 我们需要重载他的构造函数
        /// 不同构造函数构造出来的窗体完成各自不同的操作
        /// </summary>
        public frmReaderAddOrUpdate(frmReaderManage._delegateRefreshAllReader _dlg)
        {
            //默认构造函数为添加读者信息
            InitializeComponent();
            dlg = _dlg;
            this.Text = "添加读者信息";
            btEnter.Text = "添加";
        }

        public frmReaderAddOrUpdate(CtbReaderInformation cReader, frmReaderManage._delegateRefreshAllReader _dlg)
        {
            //此构造函数用于修改读者信息
            InitializeComponent();
            dlg = _dlg;
            this.Text = "修改读者信息";
            btEnter.Text = "保存";

            //将传递过来的读者信息赋值于各个控件以备修改
            tbReaderID.Text = cReader.readerID.ToString();
            tbReaderName.Text = cReader.readerName;
            cbReaderSex.Text = cReader.readerSex;
            tbReaderOffice.Text = cReader.readerOffice;
            tbReaderDept.Text = cReader.readerDept;
            tbReaderPhone.Text = cReader.readerPhone;
            tbReaderEMail.Text = cReader.readerEmail;
            dtkReaderResDate.Value = cReader.readerResDate;

            //读者编号不能修改
            tbReaderID.ReadOnly = true;
            
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            //取消按钮事件
            this.Close();
        }

        private void frmReaderAddOrUpdate_FormClosed(object sender, FormClosedEventArgs e)
        {
            //当窗体关闭后执行同步更新管理界面的读者信息
            dlg();
        }

        private void btEnter_Click(object sender, EventArgs e)
        {
            //在这里我们要进行判断我们进行的是添加还是修改
            //判断的方法我们这里只介绍针对我们现在这种情况的方法
            //方法就是判断按钮的TEXT是"添加"还是"保存"
            #region 添加事件代码部分

            if (btEnter.Text == "添加")
            {
                CtbReaderInformation cReader = new CtbReaderInformation();
                CtbReaderInformationBLL cReaderBll=new CtbReaderInformationBLL ();
                //这里我们允许某些字段为空,但是读者ID，和读者姓名不允许为空
                if (tbReaderID.Text != "" && tbReaderName.Text != "")
                {
                    cReader.readerID = int.Parse(tbReaderID.Text);
                    cReader.readerName = tbReaderName.Text;

                    //判断控件内容是否为空，为空不赋值，使用类属性的默认值
                    if (cbReaderSex.Text != "")
                    {
                        cReader.readerSex = cbReaderSex.Text;
                    }
                    if (tbReaderOffice.Text != "")
                    {
                        cReader.readerOffice = tbReaderOffice.Text;
                    }
                    if (tbReaderDept.Text != "")
                    {
                        cReader.readerDept = tbReaderDept.Text;
                    }
                    if (tbReaderPhone.Text != "")
                    {
                        cReader.readerPhone = tbReaderPhone.Text;
                    }
                    if (tbReaderAddress.Text != "")
                    {
                        cReader.readerHAddress = tbReaderAddress.Text;
                    }
                    if (tbReaderEMail.Text != "")
                    {
                        cReader.readerEmail = tbReaderEMail.Text;
                    }

                    cReader.readerResDate = dtkReaderResDate.Value;

                    try
                    {
                        //执行添加操作
                        cReaderBll.Add(cReader);
                        if (MessageBox.Show("添加成功！是否继续添加？", "操作提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            dlg();
                            ClearAllContent();
                        }
                        else
                        {
                            dlg();
                            this.Close();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "系统异常提示");
                    }
               
                    
                }
            }

            #endregion

            #region 修改事件代码
            if (btEnter.Text == "保存")
            {
                CtbReaderInformation cReader = new CtbReaderInformation();
                CtbReaderInformationBLL cReaderBll=new CtbReaderInformationBLL ();
                //这里我们允许某些字段为空,但是读者姓名不允许为空
                if (tbReaderName.Text != "")
                {
                    cReader.readerID = int.Parse(tbReaderID.Text);
                    cReader.readerName = tbReaderName.Text;

                    //判断控件内容是否为空，为空不赋值，使用类属性的默认值
                    if (cbReaderSex.Text != "")
                    {
                        cReader.readerSex = cbReaderSex.Text;
                    }
                    if (tbReaderOffice.Text != "")
                    {
                        cReader.readerOffice = tbReaderOffice.Text;
                    }
                    if (tbReaderDept.Text != "")
                    {
                        cReader.readerDept = tbReaderDept.Text;
                    }
                    if (tbReaderPhone.Text != "")
                    {
                        cReader.readerPhone = tbReaderPhone.Text;
                    }
                    if (tbReaderAddress.Text != "")
                    {
                        cReader.readerHAddress = tbReaderAddress.Text;
                    }
                    if (tbReaderEMail.Text != "")
                    {
                        cReader.readerEmail = tbReaderEMail.Text;
                    }

                    cReader.readerResDate = dtkReaderResDate.Value;

                    //执行修改操作
                    try
                    {
                        cReaderBll.Update(cReader);
                        MessageBox.Show("修改成功","操作提示");
                        dlg();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "系统异常提示");
                    }
                }
            }

            #endregion
        }

        /// <summary>
        ///  清空所有控件中的内容，以备再次输入
        /// </summary>
        private void ClearAllContent()
        {
            //时间以及CB控件无需清空
            tbReaderID.Clear();
            tbReaderName.Clear();
            tbReaderOffice.Clear();
            tbReaderDept.Clear();
            tbReaderPhone.Clear();
            tbReaderEMail.Clear();
            tbReaderAddress.Clear();
            dtkReaderResDate.Value = DateTime.Now;//将当前时间赋予时间控件
        }
    }
}
