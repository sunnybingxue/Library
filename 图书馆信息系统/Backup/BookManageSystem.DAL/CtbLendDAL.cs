using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using BookManageSystem.Model;
using BookManageSystem.Common;//请先添加引用
namespace BookManageSystem.DAL
{
    /// <summary>
    /// 数据访问类CtbLend。
    /// </summary>
    public class CtbLendDAL
    {
        public CtbLendDAL()
        { }
        #region  成员方法


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int bookID, int readerID, int lendNum, DateTime lendDate, DateTime lendYDate, DateTime lendSDate, decimal lendMulct)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbLend");
            strSql.Append(" where bookID=" + bookID + " and readerID=" + readerID + " and lendNum=" + lendNum + " and lendDate='" + lendDate + "' and lendYDate='" + lendYDate + "' and lendSDate='" + lendSDate + "' and lendMulct=" + lendMulct + " ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(BookManageSystem.Model.CtbLend model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.bookID != null)
            {
                strSql1.Append("bookID,");
                strSql2.Append("" + model.bookID + ",");
            }
            if (model.readerID != null)
            {
                strSql1.Append("readerID,");
                strSql2.Append("" + model.readerID + ",");
            }
            if (model.lendNum != null)
            {
                strSql1.Append("lendNum,");
                strSql2.Append("" + model.lendNum + ",");
            }
            if (model.lendDate != null)
            {
                strSql1.Append("lendDate,");
                strSql2.Append("'" + model.lendDate + "',");
            }
            if (model.lendYDate != null)
            {
                strSql1.Append("lendYDate,");
                strSql2.Append("'" + model.lendYDate + "',");
            }
            if (model.lendSDate != null)
            {
                strSql1.Append("lendSDate,");
                strSql2.Append("'" + model.lendSDate + "',");
            }
            if (model.lendMulct != null)
            {
                strSql1.Append("lendMulct,");
                strSql2.Append("" + model.lendMulct + ",");
            }
            strSql.Append("insert into tbLend(");
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
        public void Update(BookManageSystem.Model.CtbLend model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tbLend set ");
            if (model.bookID != null)
            {
                strSql.Append("bookID=" + model.bookID + ",");
            }
            if (model.readerID != null)
            {
                strSql.Append("readerID=" + model.readerID + ",");
            }
            if (model.lendNum != null)
            {
                strSql.Append("lendNum=" + model.lendNum + ",");
            }
            if (model.lendDate != null)
            {
                strSql.Append("lendDate='" + model.lendDate + "',");
            }
            if (model.lendYDate != null)
            {
                strSql.Append("lendYDate='" + model.lendYDate + "',");
            }
            if (model.lendSDate != null)
            {
                strSql.Append("lendSDate='" + model.lendSDate + "',");
            }
            if (model.lendMulct != null)
            {
                strSql.Append("lendMulct=" + model.lendMulct + ",");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where bookID=" + model.bookID + " and readerID=" + model.readerID + " and lendDate='" + model.lendDate + "' and lendYDate='" + model.lendYDate + "'");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int bookID, int readerID, int lendNum, DateTime lendDate, DateTime lendYDate, string lendSDate, decimal lendMulct)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete tbLend ");
            strSql.Append(" where bookID=" + bookID + " and readerID=" + readerID + " and lendNum=" + lendNum + " and lendDate='" + lendDate + "' and lendYDate='" + lendYDate + "' and lendSDate='" + lendSDate + "' and lendMulct=" + lendMulct + " ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public BookManageSystem.Model.CtbLend GetModel(int bookID, int readerID, int lendNum, DateTime lendDate, DateTime lendYDate, string lendSDate, decimal lendMulct)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" bookID,readerID,lendNum,lendDate,lendYDate,lendSDate,lendMulct ");
            strSql.Append(" from tbLend ");
            strSql.Append(" where bookID=" + bookID + " and readerID=" + readerID + " and lendNum=" + lendNum + " and lendDate='" + lendDate + "' and lendYDate='" + lendYDate + "' and lendSDate='" + lendSDate + "' and lendMulct=" + lendMulct + " ");
            BookManageSystem.Model.CtbLend model = new BookManageSystem.Model.CtbLend();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["bookID"].ToString() != "")
                {
                    model.bookID = int.Parse(ds.Tables[0].Rows[0]["bookID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["readerID"].ToString() != "")
                {
                    model.readerID = int.Parse(ds.Tables[0].Rows[0]["readerID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["lendNum"].ToString() != "")
                {
                    model.lendNum = int.Parse(ds.Tables[0].Rows[0]["lendNum"].ToString());
                }
                if (ds.Tables[0].Rows[0]["lendDate"].ToString() != "")
                {
                    model.lendDate = DateTime.Parse(ds.Tables[0].Rows[0]["lendDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["lendYDate"].ToString() != "")
                {
                    model.lendYDate = DateTime.Parse(ds.Tables[0].Rows[0]["lendYDate"].ToString());
                }
                if (ds.Tables[0].Rows[0]["lendSDate"].ToString() != "")
                {
                    model.lendSDate =ds.Tables[0].Rows[0]["lendSDate"].ToString();
                }
                if (ds.Tables[0].Rows[0]["lendMulct"].ToString() != "")
                {
                    model.lendMulct = decimal.Parse(ds.Tables[0].Rows[0]["lendMulct"].ToString());
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
            strSql.Append("select bookID,readerID,lendNum,lendDate,lendYDate,lendSDate,lendMulct ");
            strSql.Append(" FROM tbLend ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

