using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// active
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("active", typeof(ActiveInfoHelper))]
    public class ActiveInfo : SimpleFlow.SystemFramework.IEntity
    {
        public ActiveInfo()
        {
        }
        public ActiveInfo(string _ActiveId)
        {
            m_ActiveId = _ActiveId;
        }

        private string m_ActiveId;

        /// <summary>
        /// active_id
        /// </summary>
        public string ActiveId
        {
            get
            {
                return m_ActiveId;
            }
            set
            {
                m_ActiveId = value;
            }
        }

        private string m_ActiveName;

        /// <summary>
        /// active_name
        /// </summary>
        public string ActiveName
        {
            get
            {
                return m_ActiveName;
            }
            set
            {
                m_ActiveName = value;
            }
        }

        private string m_ActiveType;

        /// <summary>
        /// active_type
        /// </summary>
        public string ActiveType
        {
            get
            {
                return m_ActiveType;
            }
            set
            {
                m_ActiveType = value;
            }
        }

        private int m_FormId;

        /// <summary>
        /// form_id
        /// </summary>
        public int FormId
        {
            get
            {
                return m_FormId;
            }
            set
            {
                m_FormId = value;
            }
        }
    }
}
