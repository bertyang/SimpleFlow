using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// participant
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("participant", typeof(ParticipantInfoHelper))]
    public class ParticipantInfo : SimpleFlow.SystemFramework.IEntity
    {
        public ParticipantInfo()
        {
        }
        public ParticipantInfo(string _ParticipantId)
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

        private string m_ParticipantKind;

        /// <summary>
        /// participant_kind
        /// </summary>
        public string ParticipantKind
        {
            get
            {
                return m_ParticipantKind;
            }
            set
            {
                m_ParticipantKind = value;
            }
        }

        private string m_RelationId;

        /// <summary>
        /// relation_id
        /// </summary>
        public string RelationId
        {
            get
            {
                return m_RelationId;
            }
            set
            {
                m_RelationId = value;
            }
        }

        private string m_ActiveId;

        /// <summary>
        /// active_id
        /// </summary>
        public string ActiveId
        {
            get
            {
                return m_ActiveId;
            }
            set
            {
                m_ActiveId = value;
            }
        }
    }
}
