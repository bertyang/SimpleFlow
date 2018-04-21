using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// sys_dept
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("sys_dept", typeof(SysDeptInfoHelper))]
    public class SysDeptInfo : SimpleFlow.SystemFramework.IEntity
    {
        public SysDeptInfo()
        {
        }
        public SysDeptInfo(string _DeptId)
        {
            m_DeptId = _DeptId;
        }

        private string m_DeptId;

        /// <summary>
        /// dept_id
        /// </summary>
        public string DeptId
        {
            get
            {
                return m_DeptId;
            }
            set
            {
                m_DeptId = value;
            }
        }

        private string m_DeptCode;

        /// <summary>
        /// dept_code
        /// </summary>
        public string DeptCode
        {
            get
            {
                return m_DeptCode;
            }
            set
            {
                m_DeptCode = value;
            }
        }

        private string m_DeptName;

        /// <summary>
        /// dept_name
        /// </summary>
        public string DeptName
        {
            get
            {
                return m_DeptName;
            }
            set
            {
                m_DeptName = value;
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
    }
}
