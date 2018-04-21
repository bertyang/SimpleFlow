using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// WorkFlow_Process
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("WorkFlow_Process", typeof(WorkflowProcessInfoHelper))]
    public class WorkflowProcessInfo : SimpleFlow.DBFramework.SQLServer.IEntity
    {
        public WorkflowProcessInfo()
        {
        }
        public WorkflowProcessInfo(string _Workflowid)
        {
            m_Workflowid = _Workflowid;
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

        private string m_Workflowname;

        /// <summary>
        /// WorkFlowName
        /// </summary>
        public string Workflowname
        {
            get
            {
                return m_Workflowname;
            }
            set
            {
                m_Workflowname = value;
            }
        }

        private string m_Workflowxml;

        /// <summary>
        /// WorkFlowXML
        /// </summary>
        public string Workflowxml
        {
            get
            {
                return m_Workflowxml;
            }
            set
            {
                m_Workflowxml = value;
            }
        }
    }
}
