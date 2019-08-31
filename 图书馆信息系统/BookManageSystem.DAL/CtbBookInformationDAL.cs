using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using System.Collections.Generic;
using BookManageSystem.Common;
using BookManageSystem.Model;//请先添加引用
namespace BookManageSystem.DAL
{
    /// <summary>
    /// 数据访问类CtbBookInformationDAL。
    /// </summary>
    public class CtbBookInformationDAL
    {
        public CtbBookInformationDAL()
        { }
        #region  成员方法

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("bookID", "tbBookInformation");
        }


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int bookID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbBookInformation");
            strSql.Append(" where bookID=" + bookID + " ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(BookManageSystem.Model.CtbBookInformation model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.bookID != null)
            {
                strSql1.Append("bookID,");
                strSql2.Append("" + model.bookID + ",");
            }
            if (model.bookSortID != null)
            {
                strSql1.Append("bookSortID,");
                strSql2.Append("" + model.bookSortID + ",");
            }
            if (model.bookName != null)
            {
                strSql1.Append("bookName,");
                strSql2.Append("'" + model.bookName + "',");
            }
            if (model.bookAutor != null)
            {
                strSql1.Append("bookAutor,");
                strSql2.Append("'" + model.bookAutor + "',");
            }
            if (model.bookPublish != null)
            {
                strSql1.Append("bookPublish,");
                strSql2.Append("'" + model.bookPublish + "',");
            }
            if (model.bookPubDate != null)
            {
                strSql1.Append("bookPubDate,");
                strSql2.Append("'" + model.bookPubDate + "',");
            }
            if (model.bookPrice != null)
            {
                strSql1.Append("bookPrice,");
                strSql2.Append("" + model.bookPrice + ",");
            }
            if (model.bookSummary != null)
            {
                strSql1.Append("bookSummary,");
                strSql2.Append("'" + model.bookSummary + "',");
            }
            if (model.bookRealNum != null)
            {
                strSql1.Append("bookRealNum,");
                strSql2.Append("" + model.bookRealNum + ",");
            }
            if (model.bookLendNum != null)
            {
                strSql1.Append("bookLendNum,");
                strSql2.Append("" + model.bookLendNum + ",");
            }
            if (model.bookResDate != null)
            {
                strSql1.Append("bookResDate,");
                strSql2.Append("'" + model.bookResDate + "',");
            }
            strSql.Append("insert into tbBookInformation(");
            strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
            strSql.Append(")");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(BookManageSystem.Model.CtbBookInformation model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tbBookInformation set ");
            if (model.bookSortID != null)
            {
                strSql.Append("bookSortID=" + model.bookSortID + ",");
            }
            if (model.bookName != null)
            {
                strSql.Append("bookName='" + model.bookName + "',");
            }
            if (model.bookAutor != null)
            {
                strSql.Append("bookAutor='" + model.bookAutor + "',");
            }
            if (model.bookPublish != null)
            {
                strSql.Append("bookPublish='" + model.bookPublish + "',");
            }
            if (model.bookPubDate != null)
            {
                strSql.Append("bookPubDate='" + model.bookPubDate + "',");
            }
            if (model.bookPrice != null)
            {
                strSql.Append("bookPrice=" + model.bookPrice + ",");
            }
            if (model.bookSummary != null)
            {
                strSql.Append("bookSummary='" + model.bookSummary + "',");
            }
            if (model.bookRealNum != null)
            {
                strSql.Append("bookRealNum=" + model.bookRealNum + ",");
            }
            if (model.bookLendNum != null)
            {
                strSql.Append("bookLendNum=" + model.bookLendNum + ",");
            }
            if (model.bookResDate != null)
            {
                strSql.Append("bookResDate='" + model.bookResDate + "',");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where bookID=" + model.bookID + " ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int bookID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete tbBookInformation ");
            strSql.Append(" where bookID=" + bookID + " ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public BookManageSystem.Model.CtbBookInformation GetModel(int bookID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" bookID,bookSortID,bookName,bookAutor,bookPublish,bookPubDate,bookPrice,bookSummary,bookRealNum,bookLendNum,bookResDate ");
            strSql.Append(" from tbBookInformation ");
            strSql.Append(" where bookID=" + bookID + " ");
            BookManageSystem.Model.CtbBookInformation model = new BookManageSystem.Model.CtbBookInformation();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["bookID"].ToString() != "")
                {
                    model.bookID = int.Parse(ds.Tables[0].Rows[0]["bookID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["bookSortID"].ToString() != "")
                {
                    model.bookSortID = int.Parse(ds.Tables[0].Rows[0]["bookSortID"].ToString());
                }
                model.bookName = ds.Tables[0].Rows[0]["bookName"].ToString();
                model.bookAutor = ds.Tables[0].Rows[0]["bookAutor"].ToString();
                model.bookPublish = ds.Tables[0].Rows[0]["bookPublish"].ToString();
                if (ds.Tables[0].Rows[0]["bookPubDate"].ToString() != "")
                {
                    model.bookPubDate = DateTime.Parse(ds.Tables[0].Rows[0]["bookPubDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["bookPrice"].ToString() != "")
                {
                    model.bookPrice = decimal.Parse(ds.Tables[0].Rows[0]["bookPrice"].ToString());
                }
                model.bookSummary = ds.Tables[0].Rows[0]["bookSummary"].ToString();
                if (ds.Tables[0].Rows[0]["bookRealNum"].ToString() != "")
                {
                    model.bookRealNum = int.Parse(ds.Tables[0].Rows[0]["bookRealNum"].ToString());
                }
                if (ds.Tables[0].Rows[0]["bookLendNum"].ToString() != "")
                {
                    model.bookLendNum = int.Parse(ds.Tables[0].Rows[0]["bookLendNum"].ToString());
                }
                if (ds.Tables[0].Rows[0]["bookResDate"].ToString() != "")
                {
                    model.bookResDate = DateTime.Parse(ds.Tables[0].Rows[0]["bookResDate"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select bookID,bookSortID,bookName,bookAutor,bookPublish,bookPubDate,bookPrice,bookSummary,bookRealNum,bookLendNum,bookResDate ");
            strSql.Append(" FROM tbBookInformation ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  成员方法
    }
}

