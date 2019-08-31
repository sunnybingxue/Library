using System;
using System.Data;
using System.Collections.Generic;
using BookManageSystem.Model;
using BookManageSystem.DAL;
namespace BookManageSystem.BLL
{
    /// <summary>
    /// 业务逻辑类CtbBookInformationBLL 的摘要说明。
    /// </summary>
    public class CtbBookInformationBLL
    {
        private readonly CtbBookInformationDAL dal = new CtbBookInformationDAL();
        public CtbBookInformationBLL()
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
        public bool Exists(int bookID)
        {
            return dal.Exists(bookID);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(BookManageSystem.Model.CtbBookInformation model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(BookManageSystem.Model.CtbBookInformation model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int bookID)
        {

            dal.Delete(bookID);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public BookManageSystem.Model.CtbBookInformation GetModel(int bookID)
        {

            return dal.GetModel(bookID);
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<CtbBookInformation> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            List<CtbBookInformation> modelList = new List<CtbBookInformation>();
            int rowsCount = ds.Tables[0].Rows.Count;
            if (rowsCount > 0)
            {
                CtbBookInformation model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new CtbBookInformation();
                    if (ds.Tables[0].Rows[n]["bookID"].ToString() != "")
                    {
                        model.bookID = int.Parse(ds.Tables[0].Rows[n]["bookID"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["bookSortID"].ToString() != "")
                    {
                        model.bookSortID = int.Parse(ds.Tables[0].Rows[n]["bookSortID"].ToString());
                    }
                    model.bookName = ds.Tables[0].Rows[n]["bookName"].ToString();
                    model.bookAutor = ds.Tables[0].Rows[n]["bookAutor"].ToString();
                    model.bookPublish = ds.Tables[0].Rows[n]["bookPublish"].ToString();
                    if (ds.Tables[0].Rows[n]["bookPubDate"].ToString() != "")
                    {
                        model.bookPubDate = DateTime.Parse(ds.Tables[0].Rows[n]["bookPubDate"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["bookPrice"].ToString() != "")
                    {
                        model.bookPrice = decimal.Parse(ds.Tables[0].Rows[n]["bookPrice"].ToString());
                    }
                    model.bookSummary = ds.Tables[0].Rows[n]["bookSummary"].ToString();
                    if (ds.Tables[0].Rows[n]["bookRealNum"].ToString() != "")
                    {
                        model.bookRealNum = int.Parse(ds.Tables[0].Rows[n]["bookRealNum"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["bookLendNum"].ToString() != "")
                    {
                        model.bookLendNum = int.Parse(ds.Tables[0].Rows[n]["bookLendNum"].ToString());
                    }
                    if (ds.Tables[0].Rows[n]["bookResDate"].ToString() != "")
                    {
                        model.bookResDate = DateTime.Parse(ds.Tables[0].Rows[n]["bookResDate"].ToString());
                    }
                    modelList.Add(model);
                }
            }
            return modelList;
        }
        #endregion  成员方法
    }
}

