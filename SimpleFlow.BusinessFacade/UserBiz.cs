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
        /// �ж��û��Ƿ��ǹ���Ա
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>
        public static bool IsAdminUser(string employeeID)
        {
          return UserDataAccess.IsAdminUser(employeeID);    
        }      

        /// <summary>
        /// ����Ⱥ��ID���û�����ѯ��Ӧ���û�
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
        /// ����¼�û���ȥ��Բ�㣬�ո񣬷�б�ߺ�����
        /// </summary>
        /// <param name="source_account">��¼��</param>
        /// <returns>ȥ��Բ�㣬�ո񣬷�б�ߺ�������ĵ�¼����</returns>
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
        /// ʹ���û�������������ȡ�û�. 
        /// </summary>
        /// <param name="account">��¼�û���,�ж�ǰ���Զ�ȥ����������б�ߣ��ո��СԲ��</param>
        /// <param name="password">��¼����</param>
        /// <returns>�����¼�ɹ����򷵻ظ��û������򷵻�null</returns>
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
        /// �޸ĵ�¼����������¼ʱ��
        /// </summary>
        /// <param name="user"></param>
        public static void DoLogin(SysUserInfo user)
        {
            user.LogonTimes += 1;
            user.LastLogonTime = DateTime.Now;
            UpdateUser(user);
        }


        /// <summary>
        /// ��ȡָ�����û�
        /// </summary>
        /// <param name="user_id">�û�ID</param>
        /// <returns>ָ���û��Ķ���</returns>
        public static SysUserInfo GetUser(string user_id)
        {
            return UserDataAccess.GetUser(user_id);
        }

        /// <summary>
        /// ��ȡ�����û�����������ְ��
        /// </summary>
        /// <returns>SysUserInfo���б�</returns>
        public static List<SysUserInfo> GetUserList()
        {
            return UserDataAccess.GetUserList();
        }


        /// <summary>
        /// ��ȡ��ְ��Ա�б�
        /// </summary>
        /// <returns>SysUserInfo���б�</returns>
        public static List<SysUserInfo> GetActiveUserList()
        {
            return UserDataAccess.GetActiveUserList();
        }

    }
}
