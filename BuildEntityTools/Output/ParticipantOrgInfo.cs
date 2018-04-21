using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// participant_org
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("participant_org", typeof(ParticipantOrgInfoHelper))]
    public class ParticipantOrgInfo : SimpleFlow.SystemFramework.IEntity
    {
        public ParticipantOrgInfo()
        {
        }
        public ParticipantOrgInfo(string _ParticipantId)
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

        private string m_UserId;

        /// <summary>
        /// user_id
        /// </summary>
        public string UserId
        {
            get
            {
                return m_UserId;
            }
            set
            {
                m_UserId = value;
            }
        }
    }
}
