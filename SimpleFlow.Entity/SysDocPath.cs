using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// sys_doc_path
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("sys_doc_path", typeof(SysDocPathHelper))]
    public class SysDocPath : SimpleFlow.SystemFramework.IEntity
    {
        public SysDocPath()
        {
        }
        public SysDocPath(int _PathId)
        {
            m_PathId = _PathId;
        }

        private int m_PathId;

        /// <summary>
        /// path_id
        /// </summary>
        public int PathId
        {
            get
            {
                return m_PathId;
            }
            set
            {
                m_PathId = value;
            }
        }

        private int m_SiteSerial;

        /// <summary>
        /// site_serial
        /// </summary>
        public int SiteSerial
        {
            get
            {
                return m_SiteSerial;
            }
            set
            {
                m_SiteSerial = value;
            }
        }

        private string m_DocPath;

        /// <summary>
        /// doc_path
        /// </summary>
        public string DocPath
        {
            get
            {
                return m_DocPath;
            }
            set
            {
                m_DocPath = value;
            }
        }
    }
}
