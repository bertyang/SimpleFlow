using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// form_code_List
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("form_code_List", typeof(FormCodeListInfoHelper))]
    public class FormCodeListInfo : SimpleFlow.DBFramework.SQLServer.IEntity
    {
        public FormCodeListInfo()
        {
        }
        public FormCodeListInfo()
        {
        }

        private string m_FormKind;

        /// <summary>
        /// form_kind
        /// </summary>
        public string FormKind
        {
            get
            {
                return m_FormKind;
            }
            set
            {
                m_FormKind = value;
            }
        }

        private string m_CodeKind;

        /// <summary>
        /// code_kind
        /// </summary>
        public string CodeKind
        {
            get
            {
                return m_CodeKind;
            }
            set
            {
                m_CodeKind = value;
            }
        }

        private string m_CodeDetailDes;

        /// <summary>
        /// code_detail_des
        /// </summary>
        public string CodeDetailDes
        {
            get
            {
                return m_CodeDetailDes;
            }
            set
            {
                m_CodeDetailDes = value;
            }
        }

        private string m_CodeDetailValue;

        /// <summary>
        /// code_detail_value
        /// </summary>
        public string CodeDetailValue
        {
            get
            {
                return m_CodeDetailValue;
            }
            set
            {
                m_CodeDetailValue = value;
            }
        }
    }
}
