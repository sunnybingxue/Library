using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using BookManageSystem.Common;
using BookManageSystem.Model;//请先添加引用
namespace BookManageSystem.DAL
{
    /// <summary>
    /// 数据访问类CtbReaderInformation。
    /// </summary>
    public class CtbReaderInformationDAL
    {
        public CtbReaderInformationDAL()
        { }
        #region  成员方法

        /// <summary>
        /// 得到最大ID
        /// </summary>
        /// <returns></returns>
        public int GetMaxId()
        {
            return DbHelperSQL.GetMaxID("readerID", "tbReaderInformation");
        }


        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int readerID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from tbReaderInformation");
            strSql.Append(" where readerID=" + readerID + " ");
            return DbHelperSQL.Exists(strSql.ToString());
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(BookManageSystem.Model.CtbReaderInformation model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.readerID != null)
            {
                strSql1.Append("readerID,");
                strSql2.Append("" + model.readerID + ",");
            }
            if (model.readerName != null)
            {
                strSql1.Append("readerName,");
                strSql2.Append("'" + model.readerName + "',");
            }
            if (model.readerSex != null)
            {
                strSql1.Append("readerSex,");
                strSql2.Append("'" + model.readerSex + "',");
            }
            if (model.readerOffice != null)
            {
                strSql1.Append("readerOffice,");
                strSql2.Append("'" + model.readerOffice + "',");
            }
            if (model.readerDept != null)
            {
                strSql1.Append("readerDept,");
                strSql2.Append("'" + model.readerDept + "',");
            }
            if (model.readerPhone != null)
            {
                strSql1.Append("readerPhone,");
                strSql2.Append("'" + model.readerPhone + "',");
            }
            if (model.readerHAddress != null)
            {
                strSql1.Append("readerHAddress,");
                strSql2.Append("'" + model.readerHAddress + "',");
            }
            if (model.readerEmail != null)
            {
                strSql1.Append("readerEmail,");
                strSql2.Append("'" + model.readerEmail + "',");
            }
            if (model.readerResDate != null)
            {
                strSql1.Append("readerResDate,");
                strSql2.Append("'" + model.readerResDate + "',");
            }
            strSql.Append("insert into tbReaderInformation(");
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
        public void Update(BookManageSystem.Model.CtbReaderInformation model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tbReaderInformation set ");
            if (model.readerName != null)
            {
                strSql.Append("readerName='" + model.readerName + "',");
            }
            if (model.readerSex != null)
            {
                strSql.Append("readerSex='" + model.readerSex + "',");
            }
            if (model.readerOffice != null)
            {
                strSql.Append("readerOffice='" + model.readerOffice + "',");
            }
            if (model.readerDept != null)
            {
                strSql.Append("readerDept='" + model.readerDept + "',");
            }
            if (model.readerPhone != null)
            {
                strSql.Append("readerPhone='" + model.readerPhone + "',");
            }
            if (model.readerHAddress != null)
            {
                strSql.Append("readerHAddress='" + model.readerHAddress + "',");
            }
            if (model.readerEmail != null)
            {
                strSql.Append("readerEmail='" + model.readerEmail + "',");
            }
            if (model.readerResDate != null)
            {
                strSql.Append("readerResDate='" + model.readerResDate + "',");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where readerID=" + model.readerID + " ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(int readerID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete tbReaderInformation ");
            strSql.Append(" where readerID=" + readerID + " ");
            DbHelperSQL.ExecuteSql(strSql.ToString());
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public BookManageSystem.Model.CtbReaderInformation GetModel(int readerID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" readerID,readerName,readerSex,readerOffice,readerDept,readerPhone,readerHAddress,readerEmail,readerResDate ");
            strSql.Append(" from tbReaderInformation ");
            strSql.Append(" where readerID=" + readerID + " ");
            BookManageSystem.Model.CtbReaderInformation model = new BookManageSystem.Model.CtbReaderInformation();
            DataSet ds = DbHelperSQL.Query(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["readerID"].ToString() != "")
                {
                    model.readerID = int.Parse(ds.Tables[0].Rows[0]["readerID"].ToString());
                }
                model.readerName = ds.Tables[0].Rows[0]["readerName"].ToString();
                model.readerSex = ds.Tables[0].Rows[0]["readerSex"].ToString();
                model.readerOffice = ds.Tables[0].Rows[0]["readerOffice"].ToString();
                model.readerDept = ds.Tables[0].Rows[0]["readerDept"].ToString();
                model.readerPhone = ds.Tables[0].Rows[0]["readerPhone"].ToString();
                model.readerHAddress = ds.Tables[0].Rows[0]["readerHAddress"].ToString();
                model.readerEmail = ds.Tables[0].Rows[0]["readerEmail"].ToString();
                if (ds.Tables[0].Rows[0]["readerResDate"].ToString() != "")
                {
                    model.readerResDate = DateTime.Parse(ds.Tables[0].Rows[0]["readerResDate"].ToString());
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
            strSql.Append("select readerID,readerName,readerSex,readerOffice,readerDept,readerPhone,readerHAddress,readerEmail,readerResDate ");
            strSql.Append(" FROM tbReaderInformation ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperSQL.Query(strSql.ToString());
        }

        #endregion  成员方法
    }
}

