using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// form
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("form", typeof(FormInfoHelper))]
    public class FormInfo : SimpleFlow.SystemFramework.IEntity
    {
        public FormInfo()
        {
        }
        public FormInfo(int _FormId)
        {
            m_FormId = _FormId;
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

        private string m_FormName;

        /// <summary>
        /// form_name
        /// </summary>
        public string FormName
        {
            get
            {
                return m_FormName;
            }
            set
            {
                m_FormName = value;
            }
        }

        private string m_FlowerFormKind;

        /// <summary>
        /// flower_form_kind
        /// </summary>
        public string FlowerFormKind
        {
            get
            {
                return m_FlowerFormKind;
            }
            set
            {
                m_FlowerFormKind = value;
            }
        }

        private string m_ApplyUrl;

        /// <summary>
        /// apply_url
        /// </summary>
        public string ApplyUrl
        {
            get
            {
                return m_ApplyUrl;
            }
            set
            {
                m_ApplyUrl = value;
            }
        }

        private string m_ViewUrl;

        /// <summary>
        /// view_url
        /// </summary>
        public string ViewUrl
        {
            get
            {
                return m_ViewUrl;
            }
            set
            {
                m_ViewUrl = value;
            }
        }

        private string m_ModifyUrl;

        /// <summary>
        /// modify_url
        /// </summary>
        public string ModifyUrl
        {
            get
            {
                return m_ModifyUrl;
            }
            set
            {
                m_ModifyUrl = value;
            }
        }

        private string m_ChekInUrl;

        /// <summary>
        /// chek_in_url
        /// </summary>
        public string ChekInUrl
        {
            get
            {
                return m_ChekInUrl;
            }
            set
            {
                m_ChekInUrl = value;
            }
        }

        private string m_VerBackUrl;

        /// <summary>
        /// ver_back_url
        /// </summary>
        public string VerBackUrl
        {
            get
            {
                return m_VerBackUrl;
            }
            set
            {
                m_VerBackUrl = value;
            }
        }

        private string m_MainTable;

        /// <summary>
        /// main_table
        /// </summary>
        public string MainTable
        {
            get
            {
                return m_MainTable;
            }
            set
            {
                m_MainTable = value;
            }
        }

        private string m_FormNoColumn;

        /// <summary>
        /// form_no_column
        /// </summary>
        public string FormNoColumn
        {
            get
            {
                return m_FormNoColumn;
            }
            set
            {
                m_FormNoColumn = value;
            }
        }

        private string m_PartNoColumn;

        /// <summary>
        /// part_no_column
        /// </summary>
        public string PartNoColumn
        {
            get
            {
                return m_PartNoColumn;
            }
            set
            {
                m_PartNoColumn = value;
            }
        }

        private string m_FlowXml;

        /// <summary>
        /// flow_xml
        /// </summary>
        public string FlowXml
        {
            get
            {
                return m_FlowXml;
            }
            set
            {
                m_FlowXml = value;
            }
        }
    }
}
