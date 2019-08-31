using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using BookManageSystem.Common;
using BookManageSystem.Model;//请先添加引用
namespace BookManageSystem.DAL
{
    /// <summary>
    /// 数据访问类CtbBookSort。
    /// </summary>
    public class CtbBookSortDAL
    {
        public CtbBookSortDAL()
        { }
        #region  成员方法

        /// <summary>
        /// 得到最大ID
        /// </summary>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("bookSortID", "tbBookSort");
        }


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int bookSortID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbBookSort");
            strSql.Append(" where bookSortID=" + bookSortID + " ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(BookManageSystem.Model.CtbBookSort model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.bookSortID != null)
            {
                strSql1.Append("bookSortID,");
                strSql2.Append("" + model.bookSortID + ",");
            }
            if (model.bookSortRemark != null)
            {
                strSql1.Append("bookSortRemark,");
                strSql2.Append("'" + model.bookSortRemark + "',");
            }
            strSql.Append("insert into tbBookSort(");
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
        public void Update(BookManageSystem.Model.CtbBookSort model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tbBookSort set ");
            if (model.bookSortRemark != null)
            {
                strSql.Append("bookSortRemark='" + model.bookSortRemark + "',");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where bookSortID=" + model.bookSortID + " ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int bookSortID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete tbBookSort ");
            strSql.Append(" where bookSortID=" + bookSortID + " ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public BookManageSystem.Model.CtbBookSort GetModel(int bookSortID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" bookSortID,bookSortRemark ");
            strSql.Append(" from tbBookSort ");
            strSql.Append(" where bookSortID=" + bookSortID + " ");
            BookManageSystem.Model.CtbBookSort model = new BookManageSystem.Model.CtbBookSort();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["bookSortID"].ToString() != "")
                {
                    model.bookSortID = int.Parse(ds.Tables[0].Rows[0]["bookSortID"].ToString());
                }
                model.bookSortRemark = ds.Tables[0].Rows[0]["bookSortRemark"].ToString();
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
            strSql.Append("select bookSortID,bookSortRemark ");
            strSql.Append(" FROM tbBookSort ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }
        #endregion  成员方法
    }
}

