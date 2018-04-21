using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// sys_group_user
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("sys_group_user", typeof(SysGroupUserHelper))]
    public class SysGroupUser : SimpleFlow.SystemFramework.IEntity
    {
        public SysGroupUser()
        {
        }
        public SysGroupUser(string _GroupId,string _UserId)
        {
            m_GroupId = _GroupId;
            m_UserId = _UserId;
        }

        private string m_GroupId;

        /// <summary>
        /// group_id
        /// </summary>
        public string GroupId
        {
            get
            {
                return m_GroupId;
            }
            set
            {
                m_GroupId = value;
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
