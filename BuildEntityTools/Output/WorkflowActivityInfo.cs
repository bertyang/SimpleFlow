using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// WorkFlow_Activity
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("WorkFlow_Activity", typeof(WorkflowActivityInfoHelper))]
    public class WorkflowActivityInfo : SimpleFlow.DBFramework.SQLServer.IEntity
    {
        public WorkflowActivityInfo()
        {
        }
        public WorkflowActivityInfo(string _Activityid)
        {
            m_Activityid = _Activityid;
        }

        private string m_Activityid;

        /// <summary>
        /// ActivityID
        /// </summary>
        public string Activityid
        {
            get
            {
                return m_Activityid;
            }
            set
            {
                m_Activityid = value;
            }
        }

        private string m_Activityname;

        /// <summary>
        /// ActivityName
        /// </summary>
        public string Activityname
        {
            get
            {
                return m_Activityname;
            }
            set
            {
                m_Activityname = value;
            }
        }

        private string m_Workflowid;

        /// <summary>
        /// WorkFlowID
        /// </summary>
        public string Workflowid
        {
            get
            {
                return m_Workflowid;
            }
            set
            {
                m_Workflowid = value;
            }
        }

        private string m_Activitytype;

        /// <summary>
        /// ActivityType
        /// </summary>
        public string Activitytype
        {
            get
            {
                return m_Activitytype;
            }
            set
            {
                m_Activitytype = value;
            }
        }
    }
}
