using System;
using System.Data;
using System.Collections.Generic;
using BookManageSystem.Model;
namespace BookManageSystem.BLL
{
    /// <summary>
    /// 业务逻辑类CtbLend 的摘要说明。
    /// </summary>
    public class CtbLendBLL
    {
        private readonly BookManageSystem.DAL.CtbLendDAL dal = new BookManageSystem.DAL.CtbLendDAL();
        public CtbLendBLL()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int bookID, int readerID, int lendNum, DateTime lendDate, DateTime lendYDate, DateTime lendSDate, decimal lendMulct)
        {
            return dal.Exists(bookID, readerID, lendNum, lendDate, lendYDate, lendSDate, lendMulct);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(BookManageSystem.Model.CtbLend model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(BookManageSystem.Model.CtbLend model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int bookID, int readerID, int lendNum, DateTime lendDate, DateTime lendYDate, string lendSDate, decimal lendMulct)
        {

            dal.Delete(bookID, readerID, lendNum, lendDate, lendYDate, lendSDate, lendMulct);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public BookManageSystem.Model.CtbLend GetModel(int bookID, int readerID, int lendNum, DateTime lendDate, DateTime lendYDate, string lendSDate, decimal lendMulct)
        {

            return dal.GetModel(bookID, readerID, lendNum, lendDate, lendYDate, lendSDate, lendMulct);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<BookManageSystem.Model.CtbLend> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            List<BookManageSystem.Model.CtbLend> modelList = new List<BookManageSystem.Model.CtbLend>();
            int rowsCount = ds.Tables[0].Rows.Count;
            if (rowsCount > 0)
            {
                BookManageSystem.Model.CtbLend model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new BookManageSystem.Model.CtbLend();
                    if (ds.Tables[0].Rows[n]["bookID"].ToString() != "")
                    {
                        model.bookID = int.Parse(ds.Tables[0].Rows[n]["bookID"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["readerID"].ToString() != "")
                    {
                        model.readerID = int.Parse(ds.Tables[0].Rows[n]["readerID"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["lendNum"].ToString() != "")
                    {
                        model.lendNum = int.Parse(ds.Tables[0].Rows[n]["lendNum"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["lendDate"].ToString() != "")
                    {
                        model.lendDate = DateTime.Parse(ds.Tables[0].Rows[n]["lendDate"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["lendYDate"].ToString() != "")
                    {
                        model.lendYDate = DateTime.Parse(ds.Tables[0].Rows[n]["lendYDate"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["lendSDate"].ToString() != "")
                    {
                        model.lendSDate = ds.Tables[0].Rows[n]["lendSDate"].ToString();
                    }
                    if (ds.Tables[0].Rows[n]["lendMulct"].ToString() != "")
                    {
                        model.lendMulct = decimal.Parse(ds.Tables[0].Rows[n]["lendMulct"].ToString());
                    }
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        #endregion  成员方法
    }
}

