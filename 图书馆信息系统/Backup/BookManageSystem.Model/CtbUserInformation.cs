using System;
namespace BookManageSystem.Model
{
    /// <summary>
    /// 实体类CtbUserInformation 。
    /// </summary>
    public class CtbUserInformation
    {
        public CtbUserInformation()
        { }
        #region Model
        private string _username;
        private string _userpwd;
        private string _userpurview;
        private string _userallname;
        private string _usersort;
        /// <summary>
        /// 用户登陆名
        /// </summary>
        public string userName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 用户口令
        /// </summary>
        public string userPwd
        {
            set { _userpwd = value; }
            get { return _userpwd; }
        }
        /// <summary>
        /// 用户权限
        /// </summary>
        public string userPurview
        {
            set { _userpurview = value; }
            get { return _userpurview; }
        }
        /// <summary>
        /// 用户全名
        /// </summary>
        public string userAllName
        {
            set { _userallname = value; }
            get { return _userallname; }
        }
        /// <summary>
        /// 用户身份
        /// </summary>
        public string userSort
        {
            set { _usersort = value; }
            get { return _usersort; }
        }
        #endregion Model

    }
}

