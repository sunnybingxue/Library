using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using BookManageSystem.Common;
using BookManageSystem.Model;//请先添加引用
namespace BookManageSystem.DAL
{
    /// <summary>
    /// 数据访问类CtbUserInformation。
    /// </summary>
    public class CtbUserInformationDAL
    {
        public CtbUserInformationDAL()
        { }
        #region  成员方法


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns>存在返回true</returns>
        public bool Exists(string userName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbUserInformation]");
            strSql.Append(" where userName='" + userName + "' ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="userPwd">密码</param>
        /// <returns>存在返回true</returns>
        public bool Exists(string userName,string userPwd)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbUserInformation]");
            strSql.Append(" where userName='" + userName + "' and userPwd='" + userPwd + "'");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="userPwd">密码</param>
        /// <param name="userSort">用户身份</param>
        /// <returns></returns>
        public bool Exists(string userName, string userPwd,string userSort)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from [tbUserInformation]");
            strSql.Append(" where userName='" + userName + "' and userPwd='" + userPwd + "' and userSort='" + userSort + "'");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(BookManageSystem.Model.CtbUserInformation model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.userName != null)
            {
                strSql1.Append("userName,");
                strSql2.Append("'" + model.userName + "',");
            }
            if (model.userPwd != null)
            {
                strSql1.Append("userPwd,");
                strSql2.Append("'" + model.userPwd + "',");
            }
            if (model.userPurview != null)
            {
                strSql1.Append("userPurview,");
                strSql2.Append("'" + model.userPurview + "',");
            }
            if (model.userAllName != null)
            {
                strSql1.Append("userAllName,");
                strSql2.Append("'" + model.userAllName + "',");
            }
            if (model.userSort != null)
            {
                strSql1.Append("userSort,");
                strSql2.Append("'" + model.userSort + "',");
            }
            strSql.Append("insert into tbUserInformation(");
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
        public void Update(BookManageSystem.Model.CtbUserInformation model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tbUserInformation set ");
            if (model.userPwd != null)
            {
                strSql.Append("userPwd='" + model.userPwd + "',");
            }
            if (model.userPurview != null)
            {
                strSql.Append("userPurview='" + model.userPurview + "',");
            }
            if (model.userAllName != null)
            {
                strSql.Append("userAllName='" + model.userAllName + "',");
            }
            if (model.userSort != null)
            {
                strSql.Append("userSort='" + model.userSort + "',");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where userName='" + model.userName + "' ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string userName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete tbUserInformation ");
            strSql.Append(" where userName='" + userName + "' ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public BookManageSystem.Model.CtbUserInformation GetModel(string userName)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" userName,userPwd,userPurview,userAllName,userSort ");
            strSql.Append(" from tbUserInformation ");
            strSql.Append(" where userName='" + userName + "' ");
            BookManageSystem.Model.CtbUserInformation model = new BookManageSystem.Model.CtbUserInformation();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                model.userName = ds.Tables[0].Rows[0]["userName"].ToString();
                model.userPwd = ds.Tables[0].Rows[0]["userPwd"].ToString();
                model.userPurview = ds.Tables[0].Rows[0]["userPurview"].ToString();
                model.userAllName = ds.Tables[0].Rows[0]["userAllName"].ToString();
                model.userSort = ds.Tables[0].Rows[0]["userSort"].ToString();
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
            strSql.Append("select userName,userPwd,userPurview,userAllName,userSort ");
            strSql.Append(" FROM tbUserInformation ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        /*
        */

        #endregion  成员方法
    }
}

