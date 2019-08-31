using System;
using System.Data;
using System.Collections.Generic;
using BookManageSystem.Model;
namespace BookManageSystem.BLL
{
    /// <summary>
    /// 业务逻辑类CtbReaderInformation 的摘要说明。
    /// </summary>
    public class CtbReaderInformationBLL
    {
        private readonly BookManageSystem.DAL.CtbReaderInformationDAL dal = new BookManageSystem.DAL.CtbReaderInformationDAL();
        public CtbReaderInformationBLL()
        { }
        #region  成员方法

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return dal.GetMaxId();
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int readerID)
        {
            return dal.Exists(readerID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(BookManageSystem.Model.CtbReaderInformation model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(BookManageSystem.Model.CtbReaderInformation model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int readerID)
        {

            dal.Delete(readerID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public BookManageSystem.Model.CtbReaderInformation GetModel(int readerID)
        {

            return dal.GetModel(readerID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            return dal.GetList(strWhere);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<BookManageSystem.Model.CtbReaderInformation> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            List<BookManageSystem.Model.CtbReaderInformation> modelList = new List<BookManageSystem.Model.CtbReaderInformation>();
            int rowsCount = ds.Tables[0].Rows.Count;
            if (rowsCount > 0)
            {
                BookManageSystem.Model.CtbReaderInformation model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new BookManageSystem.Model.CtbReaderInformation();
                    if (ds.Tables[0].Rows[n]["readerID"].ToString() != "")
                    {
                        model.readerID = int.Parse(ds.Tables[0].Rows[n]["readerID"].ToString());
                    }
                    model.readerName = ds.Tables[0].Rows[n]["readerName"].ToString();
                    model.readerSex = ds.Tables[0].Rows[n]["readerSex"].ToString();
                    model.readerOffice = ds.Tables[0].Rows[n]["readerOffice"].ToString();
                    model.readerDept = ds.Tables[0].Rows[n]["readerDept"].ToString();
                    model.readerPhone = ds.Tables[0].Rows[n]["readerPhone"].ToString();
                    model.readerHAddress = ds.Tables[0].Rows[n]["readerHAddress"].ToString();
                    model.readerEmail = ds.Tables[0].Rows[n]["readerEmail"].ToString();
                    if (ds.Tables[0].Rows[n]["readerResDate"].ToString() != "")
                    {
                        model.readerResDate = DateTime.Parse(ds.Tables[0].Rows[n]["readerResDate"].ToString());
                    }
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        #endregion  成员方法
    }
}

