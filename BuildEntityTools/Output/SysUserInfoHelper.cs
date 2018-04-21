using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class SysUserInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<SysUserInfo>
    {
        public SysUserInfoHelper()
        {
        }

        /// <summary>
        ///  insert one SysUser to database 
        /// </summary>
        public override void Insert(string connection_string, SysUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_user] (");
            sb.Append("[user_id],");
            sb.Append("[domain_name],");
            sb.Append("[account],");
            sb.Append("[user_name],");
            sb.Append("[login_name],");
            sb.Append("[password],");
            sb.Append("[active],");
            sb.Append("[email],");
            sb.Append("[dept_code],");
            sb.Append("[ext_no],");
            sb.Append("[default_url],");
            sb.Append("[description],");
            sb.Append("[site_serial],");
            sb.Append("[language_id],");
            sb.Append("[logon_times],");
            sb.Append("[last_logon_time],");
            sb.Append("[create_time],");
            sb.Append("[create_user],");
            sb.Append("[entry_date],");
            sb.Append("[flower_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@UserId,");
            sb.Append("@DomainName,");
            sb.Append("@Account,");
            sb.Append("@UserName,");
            sb.Append("@LoginName,");
            sb.Append("@Password,");
            sb.Append("@Active,");
            sb.Append("@Email,");
            sb.Append("@DeptCode,");
            sb.Append("@ExtNo,");
            sb.Append("@DefaultUrl,");
            sb.Append("@Description,");
            sb.Append("@SiteSerial,");
            sb.Append("@LanguageId,");
            sb.Append("@LogonTimes,");
            sb.Append("@LastLogonTime,");
            sb.Append("@CreateTime,");
            sb.Append("@CreateUser,");
            sb.Append("@EntryDate,");
            sb.Append("@FlowerId ) ");

            ParameterBuilder paramList = new ParameterBuilder(20);
            paramList.Add("@UserId", entity.UserId);
            paramList.Add("@DomainName", entity.DomainName);
            paramList.Add("@Account", entity.Account);
            paramList.Add("@UserName", entity.UserName);
            paramList.Add("@LoginName", entity.LoginName);
            paramList.Add("@Password", entity.Password);
            paramList.Add("@Active", entity.Active);
            paramList.Add("@Email", entity.Email);
            paramList.Add("@DeptCode", entity.DeptCode);
            paramList.Add("@ExtNo", entity.ExtNo);
            paramList.Add("@DefaultUrl", entity.DefaultUrl);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@SiteSerial", entity.SiteSerial);
            paramList.Add("@LanguageId", entity.LanguageId);
            paramList.Add("@LogonTimes", entity.LogonTimes);
            paramList.Add("@LastLogonTime", entity.LastLogonTime);
            paramList.Add("@CreateTime", entity.CreateTime);
            paramList.Add("@CreateUser", entity.CreateUser);
            paramList.Add("@EntryDate", entity.EntryDate);
            paramList.Add("@FlowerId", entity.FlowerId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysUser to database 
        /// </summary>
        public override void Insert(SqlConnection connection, SysUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_user] (");
            sb.Append("[user_id],");
            sb.Append("[domain_name],");
            sb.Append("[account],");
            sb.Append("[user_name],");
            sb.Append("[login_name],");
            sb.Append("[password],");
            sb.Append("[active],");
            sb.Append("[email],");
            sb.Append("[dept_code],");
            sb.Append("[ext_no],");
            sb.Append("[default_url],");
            sb.Append("[description],");
            sb.Append("[site_serial],");
            sb.Append("[language_id],");
            sb.Append("[logon_times],");
            sb.Append("[last_logon_time],");
            sb.Append("[create_time],");
            sb.Append("[create_user],");
            sb.Append("[entry_date],");
            sb.Append("[flower_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@UserId,");
            sb.Append("@DomainName,");
            sb.Append("@Account,");
            sb.Append("@UserName,");
            sb.Append("@LoginName,");
            sb.Append("@Password,");
            sb.Append("@Active,");
            sb.Append("@Email,");
            sb.Append("@DeptCode,");
            sb.Append("@ExtNo,");
            sb.Append("@DefaultUrl,");
            sb.Append("@Description,");
            sb.Append("@SiteSerial,");
            sb.Append("@LanguageId,");
            sb.Append("@LogonTimes,");
            sb.Append("@LastLogonTime,");
            sb.Append("@CreateTime,");
            sb.Append("@CreateUser,");
            sb.Append("@EntryDate,");
            sb.Append("@FlowerId ) ");

            ParameterBuilder paramList = new ParameterBuilder(20);
            paramList.Add("@UserId", entity.UserId);
            paramList.Add("@DomainName", entity.DomainName);
            paramList.Add("@Account", entity.Account);
            paramList.Add("@UserName", entity.UserName);
            paramList.Add("@LoginName", entity.LoginName);
            paramList.Add("@Password", entity.Password);
            paramList.Add("@Active", entity.Active);
            paramList.Add("@Email", entity.Email);
            paramList.Add("@DeptCode", entity.DeptCode);
            paramList.Add("@ExtNo", entity.ExtNo);
            paramList.Add("@DefaultUrl", entity.DefaultUrl);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@SiteSerial", entity.SiteSerial);
            paramList.Add("@LanguageId", entity.LanguageId);
            paramList.Add("@LogonTimes", entity.LogonTimes);
            paramList.Add("@LastLogonTime", entity.LastLogonTime);
            paramList.Add("@CreateTime", entity.CreateTime);
            paramList.Add("@CreateUser", entity.CreateUser);
            paramList.Add("@EntryDate", entity.EntryDate);
            paramList.Add("@FlowerId", entity.FlowerId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysUser to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, SysUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_user] (");
            sb.Append("[user_id],");
            sb.Append("[domain_name],");
            sb.Append("[account],");
            sb.Append("[user_name],");
            sb.Append("[login_name],");
            sb.Append("[password],");
            sb.Append("[active],");
            sb.Append("[email],");
            sb.Append("[dept_code],");
            sb.Append("[ext_no],");
            sb.Append("[default_url],");
            sb.Append("[description],");
            sb.Append("[site_serial],");
            sb.Append("[language_id],");
            sb.Append("[logon_times],");
            sb.Append("[last_logon_time],");
            sb.Append("[create_time],");
            sb.Append("[create_user],");
            sb.Append("[entry_date],");
            sb.Append("[flower_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@UserId,");
            sb.Append("@DomainName,");
            sb.Append("@Account,");
            sb.Append("@UserName,");
            sb.Append("@LoginName,");
            sb.Append("@Password,");
            sb.Append("@Active,");
            sb.Append("@Email,");
            sb.Append("@DeptCode,");
            sb.Append("@ExtNo,");
            sb.Append("@DefaultUrl,");
            sb.Append("@Description,");
            sb.Append("@SiteSerial,");
            sb.Append("@LanguageId,");
            sb.Append("@LogonTimes,");
            sb.Append("@LastLogonTime,");
            sb.Append("@CreateTime,");
            sb.Append("@CreateUser,");
            sb.Append("@EntryDate,");
            sb.Append("@FlowerId ) ");

            ParameterBuilder paramList = new ParameterBuilder(20);
            paramList.Add("@UserId", entity.UserId);
            paramList.Add("@DomainName", entity.DomainName);
            paramList.Add("@Account", entity.Account);
            paramList.Add("@UserName", entity.UserName);
            paramList.Add("@LoginName", entity.LoginName);
            paramList.Add("@Password", entity.Password);
            paramList.Add("@Active", entity.Active);
            paramList.Add("@Email", entity.Email);
            paramList.Add("@DeptCode", entity.DeptCode);
            paramList.Add("@ExtNo", entity.ExtNo);
            paramList.Add("@DefaultUrl", entity.DefaultUrl);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@SiteSerial", entity.SiteSerial);
            paramList.Add("@LanguageId", entity.LanguageId);
            paramList.Add("@LogonTimes", entity.LogonTimes);
            paramList.Add("@LastLogonTime", entity.LastLogonTime);
            paramList.Add("@CreateTime", entity.CreateTime);
            paramList.Add("@CreateUser", entity.CreateUser);
            paramList.Add("@EntryDate", entity.EntryDate);
            paramList.Add("@FlowerId", entity.FlowerId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :user_id/
        /// </summary>
        public override void Update(string connection_string, SysUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_user] set ");
            sb.Append("[domain_name] = @DomainName, ");
            sb.Append("[account] = @Account, ");
            sb.Append("[user_name] = @UserName, ");
            sb.Append("[login_name] = @LoginName, ");
            sb.Append("[password] = @Password, ");
            sb.Append("[active] = @Active, ");
            sb.Append("[email] = @Email, ");
            sb.Append("[dept_code] = @DeptCode, ");
            sb.Append("[ext_no] = @ExtNo, ");
            sb.Append("[default_url] = @DefaultUrl, ");
            sb.Append("[description] = @Description, ");
            sb.Append("[site_serial] = @SiteSerial, ");
            sb.Append("[language_id] = @LanguageId, ");
            sb.Append("[logon_times] = @LogonTimes, ");
            sb.Append("[last_logon_time] = @LastLogonTime, ");
            sb.Append("[create_time] = @CreateTime, ");
            sb.Append("[create_user] = @CreateUser, ");
            sb.Append("[entry_date] = @EntryDate, ");
            sb.Append("[flower_id] = @FlowerId ");
            sb.Append("where [user_id] = @UserId ");
            ParameterBuilder paramList = new ParameterBuilder(20);
            paramList.Add("@DomainName", entity.DomainName);
            paramList.Add("@Account", entity.Account);
            paramList.Add("@UserName", entity.UserName);
            paramList.Add("@LoginName", entity.LoginName);
            paramList.Add("@Password", entity.Password);
            paramList.Add("@Active", entity.Active);
            paramList.Add("@Email", entity.Email);
            paramList.Add("@DeptCode", entity.DeptCode);
            paramList.Add("@ExtNo", entity.ExtNo);
            paramList.Add("@DefaultUrl", entity.DefaultUrl);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@SiteSerial", entity.SiteSerial);
            paramList.Add("@LanguageId", entity.LanguageId);
            paramList.Add("@LogonTimes", entity.LogonTimes);
            paramList.Add("@LastLogonTime", entity.LastLogonTime);
            paramList.Add("@CreateTime", entity.CreateTime);
            paramList.Add("@CreateUser", entity.CreateUser);
            paramList.Add("@EntryDate", entity.EntryDate);
            paramList.Add("@FlowerId", entity.FlowerId);
            paramList.Add("@UserId", entity.UserId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :user_id/
        /// </summary>
        public override void Update(SqlConnection connection, SysUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_user] set ");
            sb.Append("[domain_name] = @DomainName, ");
            sb.Append("[account] = @Account, ");
            sb.Append("[user_name] = @UserName, ");
            sb.Append("[login_name] = @LoginName, ");
            sb.Append("[password] = @Password, ");
            sb.Append("[active] = @Active, ");
            sb.Append("[email] = @Email, ");
            sb.Append("[dept_code] = @DeptCode, ");
            sb.Append("[ext_no] = @ExtNo, ");
            sb.Append("[default_url] = @DefaultUrl, ");
            sb.Append("[description] = @Description, ");
            sb.Append("[site_serial] = @SiteSerial, ");
            sb.Append("[language_id] = @LanguageId, ");
            sb.Append("[logon_times] = @LogonTimes, ");
            sb.Append("[last_logon_time] = @LastLogonTime, ");
            sb.Append("[create_time] = @CreateTime, ");
            sb.Append("[create_user] = @CreateUser, ");
            sb.Append("[entry_date] = @EntryDate, ");
            sb.Append("[flower_id] = @FlowerId ");
            sb.Append("where [user_id] = @UserId ");
            ParameterBuilder paramList = new ParameterBuilder(20);
            paramList.Add("@DomainName", entity.DomainName);
            paramList.Add("@Account", entity.Account);
            paramList.Add("@UserName", entity.UserName);
            paramList.Add("@LoginName", entity.LoginName);
            paramList.Add("@Password", entity.Password);
            paramList.Add("@Active", entity.Active);
            paramList.Add("@Email", entity.Email);
            paramList.Add("@DeptCode", entity.DeptCode);
            paramList.Add("@ExtNo", entity.ExtNo);
            paramList.Add("@DefaultUrl", entity.DefaultUrl);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@SiteSerial", entity.SiteSerial);
            paramList.Add("@LanguageId", entity.LanguageId);
            paramList.Add("@LogonTimes", entity.LogonTimes);
            paramList.Add("@LastLogonTime", entity.LastLogonTime);
            paramList.Add("@CreateTime", entity.CreateTime);
            paramList.Add("@CreateUser", entity.CreateUser);
            paramList.Add("@EntryDate", entity.EntryDate);
            paramList.Add("@FlowerId", entity.FlowerId);
            paramList.Add("@UserId", entity.UserId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :user_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, SysUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_user] set ");
            sb.Append("[domain_name] = @DomainName, ");
            sb.Append("[account] = @Account, ");
            sb.Append("[user_name] = @UserName, ");
            sb.Append("[login_name] = @LoginName, ");
            sb.Append("[password] = @Password, ");
            sb.Append("[active] = @Active, ");
            sb.Append("[email] = @Email, ");
            sb.Append("[dept_code] = @DeptCode, ");
            sb.Append("[ext_no] = @ExtNo, ");
            sb.Append("[default_url] = @DefaultUrl, ");
            sb.Append("[description] = @Description, ");
            sb.Append("[site_serial] = @SiteSerial, ");
            sb.Append("[language_id] = @LanguageId, ");
            sb.Append("[logon_times] = @LogonTimes, ");
            sb.Append("[last_logon_time] = @LastLogonTime, ");
            sb.Append("[create_time] = @CreateTime, ");
            sb.Append("[create_user] = @CreateUser, ");
            sb.Append("[entry_date] = @EntryDate, ");
            sb.Append("[flower_id] = @FlowerId ");
            sb.Append("where [user_id] = @UserId ");
            ParameterBuilder paramList = new ParameterBuilder(20);
            paramList.Add("@DomainName", entity.DomainName);
            paramList.Add("@Account", entity.Account);
            paramList.Add("@UserName", entity.UserName);
            paramList.Add("@LoginName", entity.LoginName);
            paramList.Add("@Password", entity.Password);
            paramList.Add("@Active", entity.Active);
            paramList.Add("@Email", entity.Email);
            paramList.Add("@DeptCode", entity.DeptCode);
            paramList.Add("@ExtNo", entity.ExtNo);
            paramList.Add("@DefaultUrl", entity.DefaultUrl);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@SiteSerial", entity.SiteSerial);
            paramList.Add("@LanguageId", entity.LanguageId);
            paramList.Add("@LogonTimes", entity.LogonTimes);
            paramList.Add("@LastLogonTime", entity.LastLogonTime);
            paramList.Add("@CreateTime", entity.CreateTime);
            paramList.Add("@CreateUser", entity.CreateUser);
            paramList.Add("@EntryDate", entity.EntryDate);
            paramList.Add("@FlowerId", entity.FlowerId);
            paramList.Add("@UserId", entity.UserId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :user_id/
        /// </summary>
        public override void Delete(string connection_string, SysUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_user] ");
            sb.Append("where [user_id] = @UserId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@UserId", entity.UserId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :user_id/
        /// </summary>
        public override void Delete(SqlConnection connection, SysUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_user] ");
            sb.Append("where [user_id] = @UserId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@UserId", entity.UserId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :user_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, SysUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_user] ");
            sb.Append("where [user_id] = @UserId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@UserId", entity.UserId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to SysUser
        /// warning: this row must include all the columns of table(sys_user)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_user)</param>
        /// <returns>an entity of SysUser</returns>
        public void FillEntityByRow(SysUserInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("user_id"))
            {
                entity.UserId = (string)row["user_id"];
            }
            else
            {
            }
            if (!row.IsNull("domain_name"))
            {
                entity.DomainName = (string)row["domain_name"];
            }
            else
            {
            }
            if (!row.IsNull("account"))
            {
                entity.Account = (string)row["account"];
            }
            else
            {
            }
            if (!row.IsNull("user_name"))
            {
                entity.UserName = (string)row["user_name"];
            }
            else
            {
            }
            if (!row.IsNull("login_name"))
            {
                entity.LoginName = (string)row["login_name"];
            }
            else
            {
            }
            if (!row.IsNull("password"))
            {
                entity.Password = (string)row["password"];
            }
            else
            {
            }
            if (!row.IsNull("active"))
            {
                entity.Active = (string)row["active"];
            }
            else
            {
            }
            if (!row.IsNull("email"))
            {
                entity.Email = (string)row["email"];
            }
            else
            {
            }
            if (!row.IsNull("dept_code"))
            {
                entity.DeptCode = (string)row["dept_code"];
            }
            else
            {
            }
            if (!row.IsNull("ext_no"))
            {
                entity.ExtNo = (string)row["ext_no"];
            }
            else
            {
            }
            if (!row.IsNull("default_url"))
            {
                entity.DefaultUrl = (string)row["default_url"];
            }
            else
            {
            }
            if (!row.IsNull("description"))
            {
                entity.Description = (string)row["description"];
            }
            else
            {
            }
            if (!row.IsNull("site_serial"))
            {
                entity.SiteSerial = (int)row["site_serial"];
            }
            else
            {
            }
            if (!row.IsNull("language_id"))
            {
                entity.LanguageId = (int)row["language_id"];
            }
            else
            {
            }
            if (!row.IsNull("logon_times"))
            {
                entity.LogonTimes = (int)row["logon_times"];
            }
            else
            {
            }
            if (!row.IsNull("last_logon_time"))
            {
                entity.LastLogonTime = (System.DateTime)row["last_logon_time"];
            }
            else
            {
            }
            if (!row.IsNull("create_time"))
            {
                entity.CreateTime = (System.DateTime)row["create_time"];
            }
            else
            {
            }
            if (!row.IsNull("create_user"))
            {
                entity.CreateUser = (string)row["create_user"];
            }
            else
            {
            }
            if (!row.IsNull("entry_date"))
            {
                entity.EntryDate = (System.DateTime)row["entry_date"];
            }
            else
            {
            }
            if (!row.IsNull("flower_id"))
            {
                entity.FlowerId = (string)row["flower_id"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to SysUser
        /// warning: this row must include all the columns of table(sys_user)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_user)</param>
        /// <returns>an entity of SysUser</returns>
        public override SysUserInfo Row2Entity(System.Data.DataRow row)
        {
            SysUserInfo entity = new SysUserInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysUserInfo Retrieve(SqlTransaction transaction, SysUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_user] ");
            sb.Append("where [user_id] = @UserId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@UserId", entity.UserId);

            DataTable data = SqlHelper.ExecuteDataTableBySql(transaction, sb.ToString(), paramList.ToArray());
            if (data.Rows.Count > 0)
            {
                FillEntityByRow(entity, data.Rows[0]);
                return entity;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysUserInfo Retrieve(SqlConnection connection, SysUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_user] ");
            sb.Append("where [user_id] = @UserId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@UserId", entity.UserId);

            DataTable data = SqlHelper.ExecuteDataTableBySql(connection, sb.ToString(), paramList.ToArray());
            if (data.Rows.Count > 0)
            {
                FillEntityByRow(entity, data.Rows[0]);
                return entity;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysUserInfo Retrieve(string connection_string, SysUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_user] ");
            sb.Append("where [user_id] = @UserId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@UserId", entity.UserId);

            DataTable data = SqlHelper.ExecuteDataTableBySql(connection_string, sb.ToString(), paramList.ToArray());
            if (data.Rows.Count > 0)
            {
                FillEntityByRow(entity, data.Rows[0]);
                return entity;
            }
            return null;
        }
    }
}
