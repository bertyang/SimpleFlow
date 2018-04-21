using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// sys_menu_group
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("sys_menu_group", typeof(SysMenuGroupHelper))]
    public class SysMenuGroup : SimpleFlow.SystemFramework.IEntity
    {
        public SysMenuGroup()
        {
        }
        public SysMenuGroup(string _MenuId,string _GroupId)
        {
            m_MenuId = _MenuId;
            m_GroupId = _GroupId;
        }

        private string m_MenuId;

        /// <summary>
        /// menu_id
        /// </summary>
        public string MenuId
        {
            get
            {
                return m_MenuId;
            }
            set
            {
                m_MenuId = value;
            }
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
    }
}
