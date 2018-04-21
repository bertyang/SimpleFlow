using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// condition_sub
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("condition_sub", typeof(ConditionSubInfoHelper))]
    public class ConditionSubInfo : SimpleFlow.SystemFramework.IEntity
    {
        public ConditionSubInfo()
        {
        }
        public ConditionSubInfo(string _ConditionSubId)
        {
            m_ConditionSubId = _ConditionSubId;
        }

        private string m_ConditionSubId;

        /// <summary>
        /// condition_sub_id
        /// </summary>
        public string ConditionSubId
        {
            get
            {
                return m_ConditionSubId;
            }
            set
            {
                m_ConditionSubId = value;
            }
        }

        private string m_ConditionSubField;

        /// <summary>
        /// condition_sub_field
        /// </summary>
        public string ConditionSubField
        {
            get
            {
                return m_ConditionSubField;
            }
            set
            {
                m_ConditionSubField = value;
            }
        }

        private string m_ConditionSubOperator;

        /// <summary>
        /// condition_sub_operator
        /// </summary>
        public string ConditionSubOperator
        {
            get
            {
                return m_ConditionSubOperator;
            }
            set
            {
                m_ConditionSubOperator = value;
            }
        }

        private string m_ConditionSubValue;

        /// <summary>
        /// condition_sub_value
        /// </summary>
        public string ConditionSubValue
        {
            get
            {
                return m_ConditionSubValue;
            }
            set
            {
                m_ConditionSubValue = value;
            }
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
    }
}
