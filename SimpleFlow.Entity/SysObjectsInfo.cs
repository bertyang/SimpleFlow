using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// sys_objects
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("sys_objects", typeof(SysObjectsInfoHelper))]
    public class SysObjectsInfo : SimpleFlow.SystemFramework.IEntity
    {
        public SysObjectsInfo()
        {
        }
        public SysObjectsInfo(string _ObjectType)
        {
            m_ObjectType = _ObjectType;
        }

        private string m_ObjectType;

        /// <summary>
        /// object_type
        /// </summary>
        public string ObjectType
        {
            get
            {
                return m_ObjectType;
            }
            set
            {
                m_ObjectType = value;
            }
        }

        private int m_MaxId;

        /// <summary>
        /// max_id
        /// </summary>
        public int MaxId
        {
            get
            {
                return m_MaxId;
            }
            set
            {
                m_MaxId = value;
            }
        }
    }
}
