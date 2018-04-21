using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// sys_menu_language
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("sys_menu_language", typeof(SysMenuLanguageInfoHelper))]
    public class SysMenuLanguageInfo : SimpleFlow.SystemFramework.IEntity
    {
        public SysMenuLanguageInfo()
        {
        }
        public SysMenuLanguageInfo(string _MenuId,string _LanguageId)
        {
            m_MenuId = _MenuId;
            m_LanguageId = _LanguageId;
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

        private string m_LanguageId;

        /// <summary>
        /// language_id
        /// </summary>
        public string LanguageId
        {
            get
            {
                return m_LanguageId;
            }
            set
            {
                m_LanguageId = value;
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
    }
}
