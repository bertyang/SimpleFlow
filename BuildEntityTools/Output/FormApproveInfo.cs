using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// form_approve
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("form_approve", typeof(FormApproveInfoHelper))]
    public class FormApproveInfo : SimpleFlow.SystemFramework.IEntity
    {
        public FormApproveInfo()
        {
        }
        public FormApproveInfo(string _FormApproveId)
        {
            m_FormApproveId = _FormApproveId;
        }

        private string m_FormApproveId;

        /// <summary>
        /// form_approve_id
        /// </summary>
        public string FormApproveId
        {
            get
            {
                return m_FormApproveId;
            }
            set
            {
                m_FormApproveId = value;
            }
        }

        private int m_FormNo;

        /// <summary>
        /// form_no
        /// </summary>
        public int FormNo
        {
            get
            {
                return m_FormNo;
            }
            set
            {
                m_FormNo = value;
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

        private int m_AppSerial;

        /// <summary>
        /// app_serial
        /// </summary>
        public int AppSerial
        {
            get
            {
                return m_AppSerial;
            }
            set
            {
                m_AppSerial = value;
            }
        }

        private string m_AppAssigner;

        /// <summary>
        /// app_assigner
        /// </summary>
        public string AppAssigner
        {
            get
            {
                return m_AppAssigner;
            }
            set
            {
                m_AppAssigner = value;
            }
        }

        private string m_AppEmpId;

        /// <summary>
        /// app_emp_id
        /// </summary>
        public string AppEmpId
        {
            get
            {
                return m_AppEmpId;
            }
            set
            {
                m_AppEmpId = value;
            }
        }

        private string m_AppRole;

        /// <summary>
        /// app_role
        /// </summary>
        public string AppRole
        {
            get
            {
                return m_AppRole;
            }
            set
            {
                m_AppRole = value;
            }
        }

        private string m_AppActor;

        /// <summary>
        /// app_actor
        /// </summary>
        public string AppActor
        {
            get
            {
                return m_AppActor;
            }
            set
            {
                m_AppActor = value;
            }
        }

        private string m_AppName;

        /// <summary>
        /// app_name
        /// </summary>
        public string AppName
        {
            get
            {
                return m_AppName;
            }
            set
            {
                m_AppName = value;
            }
        }

        private string m_AppStatus;

        /// <summary>
        /// app_status
        /// </summary>
        public string AppStatus
        {
            get
            {
                return m_AppStatus;
            }
            set
            {
                m_AppStatus = value;
            }
        }

        private string m_AppType;

        /// <summary>
        /// app_type
        /// </summary>
        public string AppType
        {
            get
            {
                return m_AppType;
            }
            set
            {
                m_AppType = value;
            }
        }

        private System.DateTime m_BeginDate;

        /// <summary>
        /// begin_date
        /// </summary>
        public System.DateTime BeginDate
        {
            get
            {
                return m_BeginDate;
            }
            set
            {
                m_BeginDate = value;
            }
        }

        private System.DateTime m_EndDate;

        /// <summary>
        /// end_date
        /// </summary>
        public System.DateTime EndDate
        {
            get
            {
                return m_EndDate;
            }
            set
            {
                m_EndDate = value;
            }
        }

        private string m_AppValue;

        /// <summary>
        /// app_value
        /// </summary>
        public string AppValue
        {
            get
            {
                return m_AppValue;
            }
            set
            {
                m_AppValue = value;
            }
        }

        private string m_AppContent;

        /// <summary>
        /// app_content
        /// </summary>
        public string AppContent
        {
            get
            {
                return m_AppContent;
            }
            set
            {
                m_AppContent = value;
            }
        }

        private string m_AssignReason;

        /// <summary>
        /// assign_reason
        /// </summary>
        public string AssignReason
        {
            get
            {
                return m_AssignReason;
            }
            set
            {
                m_AssignReason = value;
            }
        }
    }
}
