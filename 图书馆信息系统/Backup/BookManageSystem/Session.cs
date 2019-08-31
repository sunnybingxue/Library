using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookManageSystem
{
   /// <summary>
   /// Session作为一个静态类，用于保存用户登陆后的信息
   /// </summary>
    public static class Session
    {
        /// <summary>
        /// 用户登录名
        /// </summary>
        public static string UserName="";

        /// <summary>
        /// 用户口令
        /// </summary>
        public static string UserPwd = "";

        /// <summary>
        /// 用户权限
        /// </summary>
        public static string UserPurview = "";

        /// <summary>
        /// 用户全称
        /// </summary>
        public static string UserAllName = "";

        /// <summary>
        /// 用户身份
        /// </summary>
        public static string UserRole = "";


        /// <summary>
        /// 重置Session信息
        /// </summary>
        public static void ReSetSession()
        {
            UserName = "";
            UserPwd = "";
            UserPurview = "";
            UserAllName = "";
            UserRole = "";
        }
    }
}
