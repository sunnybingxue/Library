using System;
using System.Data;
using System.Collections.Generic;
using BookManageSystem.Model;
namespace BookManageSystem.BLL
{
    /// <summary>
    /// 业务逻辑类CtbUserInformation 的摘要说明。
    /// </summary>
    public class CtbUserInformationBLL
    {
        private readonly BookManageSystem.DAL.CtbUserInformationDAL dal = new BookManageSystem.DAL.CtbUserInformationDAL();
        public CtbUserInformationBLL()
        { }
        #region  成员方法
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <returns></returns>
        public bool Exists(string userName)
        {
            return dal.Exists(userName);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="userPwd">密码</param>
        /// <returns></returns>
        public bool Exists(string userName,string userPwd)
        {
            return dal.Exists(userName,userPwd);
        }

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        /// <param name="userName">用户名</param>
        /// <param name="userPwd">密码</param>
        /// <param name="userRole">用户角色(用户身份)</param>
        /// <returns></returns>
        public bool Exists(string userName, string userPwd,string userRole)
        {
            return dal.Exists(userName, userPwd,userRole);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public void Add(BookManageSystem.Model.CtbUserInformation model)
        {
            dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public void Update(BookManageSystem.Model.CtbUserInformation model)
        {
            dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public void Delete(string userName)
        {

            dal.Delete(userName);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public BookManageSystem.Model.CtbUserInformation GetModel(string userName)
        {

            return dal.GetModel(userName);
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
        public List<BookManageSystem.Model.CtbUserInformation> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            List<BookManageSystem.Model.CtbUserInformation> modelList = new List<BookManageSystem.Model.CtbUserInformation>();
            int rowsCount = ds.Tables[0].Rows.Count;
            if (rowsCount > 0)
            {
                BookManageSystem.Model.CtbUserInformation model;
                for (int n = 0; n < rowsCount; n++)
                {
                    model = new BookManageSystem.Model.CtbUserInformation();
                    model.userName = ds.Tables[0].Rows[n]["userName"].ToString();
                    model.userPwd = ds.Tables[0].Rows[n]["userPwd"].ToString();
                    model.userPurview = ds.Tables[0].Rows[n]["userPurview"].ToString();
                    model.userAllName = ds.Tables[0].Rows[n]["userAllName"].ToString();
                    model.userSort = ds.Tables[0].Rows[n]["userSort"].ToString();
                    modelList.Add(model);
                }
            }
            return modelList;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetAllList()
        {
            return GetList("");
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        //public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        //{
        //return dal.GetList(PageSize,PageIndex,strWhere);
        //}

        #endregion  成员方法
    }
}

