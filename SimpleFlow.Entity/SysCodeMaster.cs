using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// sys_code_master
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("sys_code_master", typeof(SysCodeMasterHelper))]
    public class SysCodeMaster : SimpleFlow.SystemFramework.IEntity
    {
        public SysCodeMaster()
        {
        }
        public SysCodeMaster(string _MainKey)
        {
            m_MainKey = _MainKey;
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
