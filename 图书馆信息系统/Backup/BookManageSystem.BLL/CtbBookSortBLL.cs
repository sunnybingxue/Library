using System;
using System.Data;
using System.Collections.Generic;
using BookManageSystem.Model;
namespace BookManageSystem.BLL
{
    /// <summary>
    /// 业务逻辑类CtbBookSort 的摘要说明。
    /// </summary>
    public class CtbBookSortBLL
    {
        private readonly BookManageSystem.DAL.CtbBookSortDAL dal = new BookManageSystem.DAL.CtbBookSortDAL();
        public CtbBookSortBLL()
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
        public bool Exists(int bookSortID)
        {
            return dal.Exists(bookSortID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(BookManageSystem.Model.CtbBookSort model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(BookManageSystem.Model.CtbBookSort model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int bookSortID)
        {

            dal.Delete(bookSortID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public BookManageSystem.Model.CtbBookSort GetModel(int bookSortID)
        {

            return dal.GetModel(bookSortID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<BookManageSystem.Model.CtbBookSort> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            List<BookManageSystem.Model.CtbBookSort> modelList = new List<BookManageSystem.Model.CtbBookSort>();
            int rowsCount = ds.Tables[0].Rows.Count;
            if (rowsCount > 0)
            {
                BookManageSystem.Model.CtbBookSort model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new BookManageSystem.Model.CtbBookSort();
                    if (ds.Tables[0].Rows[n]["bookSortID"].ToString() != "")
                    {
                        model.bookSortID = int.Parse(ds.Tables[0].Rows[n]["bookSortID"].ToString());
                    }
                    model.bookSortRemark = ds.Tables[0].Rows[n]["bookSortRemark"].ToString();
                    modelList.Add(model);
                }
            }
            return modelList;
        }
        #endregion  成员方法
    }
}

