using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// form_header
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("form_header", typeof(FormHeaderInfoHelper))]
    public class FormHeaderInfo : SimpleFlow.SystemFramework.IEntity
    {
        public FormHeaderInfo()
        {
        }
        public FormHeaderInfo(string _FormHeaderId)
        {
            m_FormHeaderId = _FormHeaderId;
        }

        private string m_FormHeaderId;

        /// <summary>
        /// form_header_id
        /// </summary>
        public string FormHeaderId
        {
            get
            {
                return m_FormHeaderId;
            }
            set
            {
                m_FormHeaderId = value;
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

        private string m_FormStatus;

        /// <summary>
        /// form_status
        /// </summary>
        public string FormStatus
        {
            get
            {
                return m_FormStatus;
            }
            set
            {
                m_FormStatus = value;
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

        private string m_Applyer;

        /// <summary>
        /// applyer
        /// </summary>
        public string Applyer
        {
            get
            {
                return m_Applyer;
            }
            set
            {
                m_Applyer = value;
            }
        }

        private string m_Filler;

        /// <summary>
        /// filler
        /// </summary>
        public string Filler
        {
            get
            {
                return m_Filler;
            }
            set
            {
                m_Filler = value;
            }
        }
    }
}
