using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// md_org
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("md_org", typeof(MdOrgInfoHelper))]
    public class MdOrgInfo : SimpleFlow.SystemFramework.IEntity
    {
        public MdOrgInfo()
        {
        }
        public MdOrgInfo(string _ModelId)
        {
            m_ModelId = _ModelId;
        }

        private string m_ModelId;

        /// <summary>
        /// model_id
        /// </summary>
        public string ModelId
        {
            get
            {
                return m_ModelId;
            }
            set
            {
                m_ModelId = value;
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
    }
}
