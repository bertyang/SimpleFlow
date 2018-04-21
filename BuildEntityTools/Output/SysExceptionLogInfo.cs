using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// sys_exception_log
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("sys_exception_log", typeof(SysExceptionLogInfoHelper))]
    public class SysExceptionLogInfo : SimpleFlow.DBFramework.SQLServer.IEntity
    {
        public SysExceptionLogInfo()
        {
        }
        public SysExceptionLogInfo(string _LogId)
        {
            m_LogId = _LogId;
        }

        private string m_LogId;

        /// <summary>
        /// log_id
        /// </summary>
        public string LogId
        {
            get
            {
                return m_LogId;
            }
            set
            {
                m_LogId = value;
            }
        }

        private string m_LogType;

        /// <summary>
        /// log_type
        /// </summary>
        public string LogType
        {
            get
            {
                return m_LogType;
            }
            set
            {
                m_LogType = value;
            }
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

        private System.DateTime m_LogTime;

        /// <summary>
        /// log_time
        /// </summary>
        public System.DateTime LogTime
        {
            get
            {
                return m_LogTime;
            }
            set
            {
                m_LogTime = value;
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

        private string m_ErrorUrl;

        /// <summary>
        /// error_url
        /// </summary>
        public string ErrorUrl
        {
            get
            {
                return m_ErrorUrl;
            }
            set
            {
                m_ErrorUrl = value;
            }
        }

        private string m_HttpContext;

        /// <summary>
        /// http_context
        /// </summary>
        public string HttpContext
        {
            get
            {
                return m_HttpContext;
            }
            set
            {
                m_HttpContext = value;
            }
        }

        private string m_ExMessage;

        /// <summary>
        /// ex_message
        /// </summary>
        public string ExMessage
        {
            get
            {
                return m_ExMessage;
            }
            set
            {
                m_ExMessage = value;
            }
        }

        private string m_ExData;

        /// <summary>
        /// ex_data
        /// </summary>
        public string ExData
        {
            get
            {
                return m_ExData;
            }
            set
            {
                m_ExData = value;
            }
        }

        private string m_ExSource;

        /// <summary>
        /// ex_source
        /// </summary>
        public string ExSource
        {
            get
            {
                return m_ExSource;
            }
            set
            {
                m_ExSource = value;
            }
        }

        private string m_ExStackTrace;

        /// <summary>
        /// ex_stack_trace
        /// </summary>
        public string ExStackTrace
        {
            get
            {
                return m_ExStackTrace;
            }
            set
            {
                m_ExStackTrace = value;
            }
        }

        private string m_ExTargetSite;

        /// <summary>
        /// ex_target_site
        /// </summary>
        public string ExTargetSite
        {
            get
            {
                return m_ExTargetSite;
            }
            set
            {
                m_ExTargetSite = value;
            }
        }

        private string m_InnerMessage;

        /// <summary>
        /// inner_message
        /// </summary>
        public string InnerMessage
        {
            get
            {
                return m_InnerMessage;
            }
            set
            {
                m_InnerMessage = value;
            }
        }

        private string m_InnerData;

        /// <summary>
        /// inner_data
        /// </summary>
        public string InnerData
        {
            get
            {
                return m_InnerData;
            }
            set
            {
                m_InnerData = value;
            }
        }

        private string m_InnerSource;

        /// <summary>
        /// inner_source
        /// </summary>
        public string InnerSource
        {
            get
            {
                return m_InnerSource;
            }
            set
            {
                m_InnerSource = value;
            }
        }

        private string m_InnerStackTrace;

        /// <summary>
        /// inner_stack_trace
        /// </summary>
        public string InnerStackTrace
        {
            get
            {
                return m_InnerStackTrace;
            }
            set
            {
                m_InnerStackTrace = value;
            }
        }

        private string m_InnerTargetSite;

        /// <summary>
        /// inner_target_site
        /// </summary>
        public string InnerTargetSite
        {
            get
            {
                return m_InnerTargetSite;
            }
            set
            {
                m_InnerTargetSite = value;
            }
        }
    }
}
