using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// md_field
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("md_field", typeof(MdFieldInfoHelper))]
    public class MdFieldInfo : SimpleFlow.SystemFramework.IEntity
    {
        public MdFieldInfo()
        {
        }
        public MdFieldInfo(string _ModelId)
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

        private string m_FieldName;

        /// <summary>
        /// field_name
        /// </summary>
        public string FieldName
        {
            get
            {
                return m_FieldName;
            }
            set
            {
                m_FieldName = value;
            }
        }

        private string m_TableName;

        /// <summary>
        /// table_name
        /// </summary>
        public string TableName
        {
            get
            {
                return m_TableName;
            }
            set
            {
                m_TableName = value;
            }
        }
    }
}
