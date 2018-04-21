using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessFacade
{

    public static class UserBiz
    {

        /// <summary>
        /// 判断用户是否是管理员
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        public static bool IsAdminUser(string employeeID)
        {
          return UserDataAccess.IsAdminUser(employeeID);    
        }      

        /// <summary>
        /// 根据群组ID和用户名查询对应的用户
        /// </summary>
        /// <param name="groupID"></param>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        public static List<SysUserInfo> Query(string groupID, string employeeAccount, string employeeName)
        {
            return UserDataAccess.Query(groupID,employeeAccount,employeeName);
        }


        public static List<string> GetAllDomainForLogin()
        {
            List<string> domains = new List<string>();

            using (SqlDataReader dataDomain = UserDataAccess.GetAllDomainForLogin())
            {
                while (dataDomain.Read())
                {
                    string domain = dataDomain.GetString(0).Trim();

                    domains.Add(domain);
                }
                dataDomain.Close();

            }
            return domains;
        }


        public static SysUserInfo GetUserByAccount(string domainName, string accountWithoutDomain)
        {
            string accountWithDomain;
            if (accountWithoutDomain.IndexOf('\\') > 0)
            {
                accountWithDomain = accountWithoutDomain;
            }
            else
            {
                accountWithDomain = domainName + "\\" + accountWithoutDomain;
            }

            return GetUserByAccount(accountWithDomain);
        }


        public static SysUserInfo GetUserByAccount(string accountWithDomain)
        {
           return UserDataAccess.GetUserByAccount(accountWithDomain);
        }


        /// <summary>
        /// 将登录用户名去掉圆点，空格，反斜线和域名
        /// </summary>
        /// <param name="source_account">登录名</param>
        /// <returns>去掉圆点，空格，反斜线和域名后的登录名称</returns>
        public static string TrimLoginAccount(string source_account)
        {
            if (string.IsNullOrEmpty(source_account))
            {
                return source_account;
            }
            StringBuilder sb = new StringBuilder(source_account.Length);
            foreach (char c in source_account)
            {
                if (c == '.')
                {
                    continue;
                }
                if (c == ' ')
                {
                    continue;
                }
                if (c == '\\')
                {
                    sb.Remove(0, sb.Length);
                    continue;
                }
                sb.Append(c);
            }
            return sb.ToString();
        }


        public static void UpdateUser(SysUserInfo user)
        {
            if (user.CreateTime < new DateTime(1800, 1, 1))
            {
                user.CreateTime = DateTime.Now;
            }
            if (user.LastLogonTime < new DateTime(1800, 1, 1))
            {
                user.CreateTime = DateTime.Now;
            }
            if (user.EntryDate < new DateTime(1800, 1, 1))
            {
                user.EntryDate = DateTime.Now;
            }

            UserDataAccess.UpdateUser(user);
        }


        /// <summary>
        /// 使用用户名和密码来获取用户. 
        /// </summary>
        /// <param name="account">登录用户名,判断前将自动去掉域名，反斜线，空格和小圆点</param>
        /// <param name="password">登录密码</param>
        /// <returns>如果登录成功，则返回该用户，否则返回null</returns>
        public static SysUserInfo Login(string account, string password)
        {

            //account = TrimLoginAccount(account);
            //List<SysUserInfo> list = SqlHelper.QueryTable<SysUserInfo>(BizConfig.ConnectionString,
            //    ColumnFilterList.New("account", account).Join("password", password));
            //if (list.Count > 0)
            //{
            //    return list[0];
            //}
            SysUserInfo user = GetUserByAccount(account);
            if ((user != null) && (user.Password == password) && (user.Active.ToUpper() == "Y"))
            {
                DoLogin(user);
                return user;
            }
            return null;
        }


        /// <summary>
        /// 修改登录次数和最后登录时间
        /// </summary>
        /// <param name="user"></param>
        public static void DoLogin(SysUserInfo user)
        {
            user.LogonTimes += 1;
            user.LastLogonTime = DateTime.Now;
            UpdateUser(user);
        }


        /// <summary>
        /// 获取指定的用户
        /// </summary>
        /// <param name="user_id">用户ID</param>
        /// <returns>指定用户的对象</returns>
        public static SysUserInfo GetUser(string user_id)
        {
            return UserDataAccess.GetUser(user_id);
        }

        /// <summary>
        /// 获取所有用户，包括不在职的
        /// </summary>
        /// <returns>SysUserInfo的列表</returns>
        public static List<SysUserInfo> GetUserList()
        {
            return UserDataAccess.GetUserList();
        }


        /// <summary>
        /// 获取在职人员列表
        /// </summary>
        /// <returns>SysUserInfo的列表</returns>
        public static List<SysUserInfo> GetActiveUserList()
        {
            return UserDataAccess.GetActiveUserList();
        }

    }
}
