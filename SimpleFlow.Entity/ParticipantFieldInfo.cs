using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// participant_field
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("participant_field", typeof(ParticipantFieldInfoHelper))]
    public class ParticipantFieldInfo : SimpleFlow.SystemFramework.IEntity
    {
        public ParticipantFieldInfo()
        {
        }
        public ParticipantFieldInfo(string _ParticipantId)
        {
            m_ParticipantId = _ParticipantId;
        }

        private string m_ParticipantId;

        /// <summary>
        /// participant_id
        /// </summary>
        public string ParticipantId
        {
            get
            {
                return m_ParticipantId;
            }
            set
            {
                m_ParticipantId = value;
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
