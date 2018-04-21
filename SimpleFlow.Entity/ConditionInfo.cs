using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// condition
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("condition", typeof(ConditionInfoHelper))]
    public class ConditionInfo : SimpleFlow.SystemFramework.IEntity
    {
        public ConditionInfo()
        {
        }
        public ConditionInfo(string _ConditionId)
        {
            m_ConditionId = _ConditionId;
        }

        private string m_ConditionId;

        /// <summary>
        /// condition_id
        /// </summary>
        public string ConditionId
        {
            get
            {
                return m_ConditionId;
            }
            set
            {
                m_ConditionId = value;
            }
        }

        private string m_ConditionName;

        /// <summary>
        /// condition_name
        /// </summary>
        public string ConditionName
        {
            get
            {
                return m_ConditionName;
            }
            set
            {
                m_ConditionName = value;
            }
        }

        private string m_ConditionJoin;

        /// <summary>
        /// condition_join
        /// </summary>
        public string ConditionJoin
        {
            get
            {
                return m_ConditionJoin;
            }
            set
            {
                m_ConditionJoin = value;
            }
        }

        private string m_FromActiveId;

        /// <summary>
        /// from_active_id
        /// </summary>
        public string FromActiveId
        {
            get
            {
                return m_FromActiveId;
            }
            set
            {
                m_FromActiveId = value;
            }
        }

        private string m_ToActiveId;

        /// <summary>
        /// to_active_id
        /// </summary>
        public string ToActiveId
        {
            get
            {
                return m_ToActiveId;
            }
            set
            {
                m_ToActiveId = value;
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
