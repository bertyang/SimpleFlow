using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// sys_user
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("sys_user", typeof(SysUserInfoHelper))]
    public class SysUserInfo : SimpleFlow.SystemFramework.IEntity
    {
        public SysUserInfo()
        {
        }
        public SysUserInfo(string _UserId)
        {
            m_UserId = _UserId;
        }

        private string m_UserId;

        /// <summary>
        /// user_id
        /// </summary>
        public string UserId
        {
            get
            {
                return m_UserId;
            }
            set
            {
                m_UserId = value;
            }
        }

        private string m_DomainName;

        /// <summary>
        /// domain_name
        /// </summary>
        public string DomainName
        {
            get
            {
                return m_DomainName;
            }
            set
            {
                m_DomainName = value;
            }
        }

        private string m_Account;

        /// <summary>
        /// account
        /// </summary>
        public string Account
        {
            get
            {
                return m_Account;
            }
            set
            {
                m_Account = value;
            }
        }

        private string m_UserName;

        /// <summary>
        /// user_name
        /// </summary>
        public string UserName
        {
            get
            {
                return m_UserName;
            }
            set
            {
                m_UserName = value;
            }
        }

        private string m_LoginName;

        /// <summary>
        /// login_name
        /// </summary>
        public string LoginName
        {
            get
            {
                return m_LoginName;
            }
            set
            {
                m_LoginName = value;
            }
        }

        private string m_Password;

        /// <summary>
        /// password
        /// </summary>
        public string Password
        {
            get
            {
                return m_Password;
            }
            set
            {
                m_Password = value;
            }
        }

        private string m_Active;

        /// <summary>
        /// active
        /// </summary>
        public string Active
        {
            get
            {
                return m_Active;
            }
            set
            {
                m_Active = value;
            }
        }

        private string m_Email;

        /// <summary>
        /// email
        /// </summary>
        public string Email
        {
            get
            {
                return m_Email;
            }
            set
            {
                m_Email = value;
            }
        }

        private string m_DeptCode;

        /// <summary>
        /// dept_code
        /// </summary>
        public string DeptCode
        {
            get
            {
                return m_DeptCode;
            }
            set
            {
                m_DeptCode = value;
            }
        }

        private string m_ExtNo;

        /// <summary>
        /// ext_no
        /// </summary>
        public string ExtNo
        {
            get
            {
                return m_ExtNo;
            }
            set
            {
                m_ExtNo = value;
            }
        }

        private string m_DefaultUrl;

        /// <summary>
        /// default_url
        /// </summary>
        public string DefaultUrl
        {
            get
            {
                return m_DefaultUrl;
            }
            set
            {
                m_DefaultUrl = value;
            }
        }

        private string m_Description;

        /// <summary>
        /// description
        /// </summary>
        public string Description
        {
            get
            {
                return m_Description;
            }
            set
            {
                m_Description = value;
            }
        }

        private int m_SiteSerial;

        /// <summary>
        /// site_serial
        /// </summary>
        public int SiteSerial
        {
            get
            {
                return m_SiteSerial;
            }
            set
            {
                m_SiteSerial = value;
            }
        }

        private int m_LanguageId;

        /// <summary>
        /// language_id
        /// </summary>
        public int LanguageId
        {
            get
            {
                return m_LanguageId;
            }
            set
            {
                m_LanguageId = value;
            }
        }

        private int m_LogonTimes;

        /// <summary>
        /// logon_times
        /// </summary>
        public int LogonTimes
        {
            get
            {
                return m_LogonTimes;
            }
            set
            {
                m_LogonTimes = value;
            }
        }

        private System.DateTime m_LastLogonTime;

        /// <summary>
        /// last_logon_time
        /// </summary>
        public System.DateTime LastLogonTime
        {
            get
            {
                return m_LastLogonTime;
            }
            set
            {
                m_LastLogonTime = value;
            }
        }

        private System.DateTime m_CreateTime;

        /// <summary>
        /// create_time
        /// </summary>
        public System.DateTime CreateTime
        {
            get
            {
                return m_CreateTime;
            }
            set
            {
                m_CreateTime = value;
            }
        }

        private string m_CreateUser;

        /// <summary>
        /// create_user
        /// </summary>
        public string CreateUser
        {
            get
            {
                return m_CreateUser;
            }
            set
            {
                m_CreateUser = value;
            }
        }

        private System.DateTime m_EntryDate;

        /// <summary>
        /// entry_date
        /// </summary>
        public System.DateTime EntryDate
        {
            get
            {
                return m_EntryDate;
            }
            set
            {
                m_EntryDate = value;
            }
        }

        private string m_FlowerId;

        /// <summary>
        /// flower_id
        /// </summary>
        public string FlowerId
        {
            get
            {
                return m_FlowerId;
            }
            set
            {
                m_FlowerId = value;
            }
        }
    }
}
