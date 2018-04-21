using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// sys_config
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("sys_config", typeof(SysConfigInfoHelper))]
    public class SysConfigInfo : SimpleFlow.SystemFramework.IEntity
    {
        public SysConfigInfo()
        {
        }
        public SysConfigInfo(string _ConfigId)
        {
            m_ConfigId = _ConfigId;
        }

        private string m_ConfigId;

        /// <summary>
        /// config_id
        /// </summary>
        public string ConfigId
        {
            get
            {
                return m_ConfigId;
            }
            set
            {
                m_ConfigId = value;
            }
        }

        private string m_ConfigValue;

        /// <summary>
        /// config_value
        /// </summary>
        public string ConfigValue
        {
            get
            {
                return m_ConfigValue;
            }
            set
            {
                m_ConfigValue = value;
            }
        }
    }
}
