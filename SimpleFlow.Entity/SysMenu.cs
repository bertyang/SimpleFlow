using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// sys_menu
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("sys_menu", typeof(SysMenuHelper))]
    public class SysMenu : SimpleFlow.SystemFramework.IEntity, SimpleFlow.SystemFramework.IMenuItem
    {
        public SysMenu()
        {
        }
        public SysMenu(string _MenuId)
        {
            m_MenuId = _MenuId;
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

        private string m_MenuName;

        /// <summary>
        /// menu_name
        /// </summary>
        public string MenuName
        {
            get
            {
                return m_MenuName;
            }
            set
            {
                m_MenuName = value;
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

        private string m_ParentId;

        /// <summary>
        /// parent_id
        /// </summary>
        public string ParentId
        {
            get
            {
                return m_ParentId;
            }
            set
            {
                m_ParentId = value;
            }
        }

        private int m_TypeId;

        /// <summary>
        /// type_id
        /// </summary>
        public int TypeId
        {
            get
            {
                return m_TypeId;
            }
            set
            {
                m_TypeId = value;
            }
        }

        private string m_Url;

        /// <summary>
        /// url
        /// </summary>
        public string Url
        {
            get
            {
                return m_Url;
            }
            set
            {
                m_Url = value;
            }
        }

        private string m_IsValid;

        /// <summary>
        /// is_valid
        /// </summary>
        public string IsValid
        {
            get
            {
                return m_IsValid;
            }
            set
            {
                m_IsValid = value;
            }
        }

        private int m_DisplayOrder;

        /// <summary>
        /// display_order
        /// </summary>
        public int DisplayOrder
        {
            get
            {
                return m_DisplayOrder;
            }
            set
            {
                m_DisplayOrder = value;
            }
        }
    }
}
