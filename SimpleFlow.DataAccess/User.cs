using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using SimpleFlow.Entity;
using SimpleFlow.SystemFramework;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.DataAccess
{
    public class UserDataAccess
    {
        /// <summary>
        /// 判断用户是否是管理员
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        public static bool IsAdminUser(string employeeID)
        {
            StringBuilder sb = new StringBuilder(100);
            sb.Append(" select count(*) from sys_group_user, sys_group ");
            sb.Append(" where sys_group_user.group_id = sys_group.group_id ");
            sb.Append(" and sys_group.is_admin = 'Y' ");
            sb.Append(" and sys_group_user.user_id = @emp_id ");

            ParameterBuilder pb = new ParameterBuilder(1);
            pb.Add("@emp_id", employeeID);

            int count = (int)SqlHelper.ExecuteScalar(Config.ConnectionString, CommandType.Text, sb.ToString(), pb.ToArray());
            return count > 0;
        }


    

        /// <summary>
        /// 根据群组ID和用户名查询对应的用户
        /// </summary>
        /// <param name="groupID"></param>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        public static List<SysUserInfo> Query(string groupID, string employeeAccount, string employeeName)
        {

            StringBuilder sb = new StringBuilder(200);
            sb.Append(" SELECT * FROM employees WHERE 1 = 1 ");
            ParameterBuilder pb = new ParameterBuilder(3);
            if (!Method.IsNullOrTrimedEmpty(groupID))
            {
                sb.Append(" AND emp_id IN (SELECT emp_id FROM group_users WHERE group_id = @group_id) ");
                pb.Add("@group_id", groupID);
            }

            if (!Method.IsNullOrTrimedEmpty(employeeAccount))
            {
                sb.Append(@" AND SUBSTRING(account, CHARINDEX('\', account) + 1, LEN(account)-CHARINDEX('\', account)) LIKE @account ");
                pb.Add("@account", "%" + employeeAccount + "%");
            }

            if (!Method.IsNullOrTrimedEmpty(employeeName))
            {
                sb.Append(" AND emp_name LIKE @emp_name ");
                pb.Add("@emp_name", employeeName);
            }

            sb.Append(" order by account asc ");

            // DataTable employeeTable = SqlHelper.ExecuteDataTable(BizConfig.ConnectionString, CommandType.Text, sb.ToString(), pb.ToArray());

            // return ConvertDataTableToList(employeeTable);

            return SqlHelper.GetListBySql<SysUserInfo>(Config.ConnectionString, sb.ToString(), pb.ToArray());
        }


        public static SqlDataReader GetAllDomainForLogin()
        {
            return SqlHelper.ExecuteReader(Config.ConnectionString, CommandType.StoredProcedure, "usp_GetAllDomain");
     
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
            string account = TrimLoginAccount(accountWithDomain);
            //List<SysUserInfo> list = SqlHelper.QueryTable<SysUserInfo>(BizConfig.ConnectionString,
            //    ColumnFilterList.New("account", accountWithDomain));
            //if (list.Count > 0)
            //{
            //    return list[0];
            //}
            string sql = " select * from sys_user where replace(replace(account, ' ', ''), '.', '') = @account ";
            ParameterBuilder param_list = new ParameterBuilder("@account", account);
            SysUserInfo user = SqlHelper.GetEntity<SysUserInfo>(Config.ConnectionString, sql, param_list.ToArray());
            return user;
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
            SqlHelper.Update(Config.ConnectionString, user);
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


        //public List<SysUserInfo> ConvertDataTableToList(DataTable employeeTable)
        //{
        //    List<SysUserInfo> employees = new List<SysUserInfo>();
        //    if (employeeTable != null && employeeTable.Rows.Count > 0)
        //    {
        //        foreach (DataRow row in employeeTable.Rows)
        //        {
        //            SysUserInfo employee = new SysUserInfo();
        //            employee.ID = ((string)row["emp_id"]).Trim();
        //            employee.Name = ((string)row["emp_name"]).Trim();
        //            employee.Account = ((string)row["account"]).Trim();
        //            employees.Add(employee);
        //        }
        //    }
        //    return employees;
        //}


        //public bool HasDownloadPrivilege(string emp_id, string menu_id)
        //{
        //    if (this.IsAdminUser(emp_id))
        //    {
        //        return true;
        //    }

        //    MenuBiz menu_biz = new MenuBiz();
        //    SysMenu src_menu = menu_biz.GetMenuById(menu_id);

        //    if (src_menu == null)
        //    {
        //        return false;
        //    }

        //    StringBuilder sb = new StringBuilder(100);
        //    if (src_menu.Parent_Id == MenuBiz.RootMenuID)
        //    {
        //        sb.Append(" select count(*) from menu_groups, group_users ");
        //        sb.Append(" where menu_groups.menu_id = @menu_id ");
        //        sb.Append(" and menu_groups.group_id = group_users.group_id ");
        //        sb.Append(" and group_users.emp_id = @emp_id ");
        //    }
        //    else
        //    {
        //        sb.Append("  select count(*) from menu_groups, group_users, menus ");
        //        sb.Append("  where (menu_groups.menu_id = menus.menu_id ");
        //        sb.Append("  or menu_groups.menu_id = menus.parent_id) ");
        //        sb.Append(" and menus.menu_id = @menu_id ");
        //        sb.Append(" and menu_groups.group_id = group_users.group_id ");
        //        sb.Append(" and group_users.emp_id = @emp_id ");
        //    }


        //    ParameterBuilder pb = new ParameterBuilder(2);
        //    pb.Add("@menu_id", menu_id);
        //    pb.Add("emp_id", emp_id);

        //    int count = (int)SqlHelper.ExecuteScalar(BizConfig.ConnectionString, CommandType.Text, sb.ToString(), pb.ToArray());

        //    return count > 0;

        //}



        /// <summary>
        /// 获取指定的用户
        /// </summary>
        /// <param name="user_id">用户ID</param>
        /// <returns>指定用户的对象</returns>
        public static SysUserInfo GetUser(string user_id)
        {
            return SqlHelper.Retrieve<SysUserInfo>(Config.ConnectionString, new SysUserInfo(user_id));
        }

        //public static SysUserInfo _GetUser(string user_id)
        //{
        //    return SqlHelper.Retrieve<SysUserInfo>(BizConfig.ConnectionString, new SysUserInfo(user_id));
        //}


        /// <summary>
        /// 获取所有用户，包括不在职的
        /// </summary>
        /// <returns>SysUserInfo的列表</returns>
        public static List<SysUserInfo> GetUserList()
        {
            return SqlHelper.GetAll<SysUserInfo>(Config.ConnectionString);
        }


        /// <summary>
        /// 获取在职人员列表
        /// </summary>
        /// <returns>SysUserInfo的列表</returns>
        public static List<SysUserInfo> GetActiveUserList()
        {
            return SqlHelper.QueryTable<SysUserInfo>(Config.ConnectionString,
                ColumnFilterList.New("active", "Y"));
        }
    }
}
