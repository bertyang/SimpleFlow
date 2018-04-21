using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// sys_group
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("sys_group", typeof(SysGroupHelper))]
    public class SysGroup : SimpleFlow.SystemFramework.IEntity
    {
        public SysGroup()
        {
        }
        public SysGroup(string _GroupId)
        {
            m_GroupId = _GroupId;
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

        private string m_GroupName;

        /// <summary>
        /// group_name
        /// </summary>
        public string GroupName
        {
            get
            {
                return m_GroupName;
            }
            set
            {
                m_GroupName = value;
            }
        }

        private string m_IsAdmin;

        /// <summary>
        /// is_admin
        /// </summary>
        public string IsAdmin
        {
            get
            {
                return m_IsAdmin;
            }
            set
            {
                m_IsAdmin = value;
            }
        }

        private string m_Description;

        /// <summary>
        /// description
        /// </summary>
        public string Description
        {
            get
            {
                return m_Description;
            }
            set
            {
                m_Description = value;
            }
        }
    }
}
