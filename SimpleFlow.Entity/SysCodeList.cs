using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// sys_code_list
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("sys_code_list", typeof(SysCodeListHelper))]
    public class SysCodeList : SimpleFlow.SystemFramework.IEntity
    {
        public SysCodeList()
        {
        }
        public SysCodeList(string _MainKey,string _SubKey)
        {
            m_MainKey = _MainKey;
            m_SubKey = _SubKey;
        }

        private string m_MainKey;

        /// <summary>
        /// main_key
        /// </summary>
        public string MainKey
        {
            get
            {
                return m_MainKey;
            }
            set
            {
                m_MainKey = value;
            }
        }

        private string m_SubKey;

        /// <summary>
        /// sub_key
        /// </summary>
        public string SubKey
        {
            get
            {
                return m_SubKey;
            }
            set
            {
                m_SubKey = value;
            }
        }

        private string m_Content;

        /// <summary>
        /// content
        /// </summary>
        public string Content
        {
            get
            {
                return m_Content;
            }
            set
            {
                m_Content = value;
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
    }
}
