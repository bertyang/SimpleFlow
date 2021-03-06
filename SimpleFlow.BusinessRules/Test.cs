using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// Test
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("Test", typeof(TestHelper))]
    public class Test : SimpleFlow.DBFramework.SQLServer.IEntity
    {
        public Test()
        {
        }


        private int m_FormNo;

        /// <summary>
        /// form_no
        /// </summary>
        public int FormNo
        {
            get
            {
                return m_FormNo;
            }
            set
            {
                m_FormNo = value;
            }
        }

        private int m_Amount;

        /// <summary>
        /// amount
        /// </summary>
        public int Amount
        {
            get
            {
                return m_Amount;
            }
            set
            {
                m_Amount = value;
            }
        }

        private string m_Leader;

        /// <summary>
        /// leader
        /// </summary>
        public string Leader
        {
            get
            {
                return m_Leader;
            }
            set
            {
                m_Leader = value;
            }
        }

        private string m_Manager;

        /// <summary>
        /// manager
        /// </summary>
        public string Manager
        {
            get
            {
                return m_Manager;
            }
            set
            {
                m_Manager = value;
            }
        }
    }
}
