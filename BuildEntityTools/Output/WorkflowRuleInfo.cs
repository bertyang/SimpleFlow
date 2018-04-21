using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// WorkFlow_Rule
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("WorkFlow_Rule", typeof(WorkflowRuleInfoHelper))]
    public class WorkflowRuleInfo : SimpleFlow.DBFramework.SQLServer.IEntity
    {
        public WorkflowRuleInfo()
        {
        }
        public WorkflowRuleInfo()
        {
        }

        private string m_Ruleid;

        /// <summary>
        /// RuleID
        /// </summary>
        public string Ruleid
        {
            get
            {
                return m_Ruleid;
            }
            set
            {
                m_Ruleid = value;
            }
        }

        private string m_Rulename;

        /// <summary>
        /// RuleName
        /// </summary>
        public string Rulename
        {
            get
            {
                return m_Rulename;
            }
            set
            {
                m_Rulename = value;
            }
        }

        private string m_Beginactivityid;

        /// <summary>
        /// BeginActivityID
        /// </summary>
        public string Beginactivityid
        {
            get
            {
                return m_Beginactivityid;
            }
            set
            {
                m_Beginactivityid = value;
            }
        }

        private string m_Endactivityid;

        /// <summary>
        /// EndActivityID
        /// </summary>
        public string Endactivityid
        {
            get
            {
                return m_Endactivityid;
            }
            set
            {
                m_Endactivityid = value;
            }
        }

        private string m_Ruletype;

        /// <summary>
        /// RuleType
        /// </summary>
        public string Ruletype
        {
            get
            {
                return m_Ruletype;
            }
            set
            {
                m_Ruletype = value;
            }
        }

        private string m_Condition;

        /// <summary>
        /// Condition
        /// </summary>
        public string Condition
        {
            get
            {
                return m_Condition;
            }
            set
            {
                m_Condition = value;
            }
        }
    }
}
