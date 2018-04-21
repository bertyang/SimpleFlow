using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// Test_bak
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("Test_bak", typeof(TestBakInfoHelper))]
    public class TestBakInfo : SimpleFlow.DBFramework.SQLServer.IEntity
    {
        public TestBakInfo()
        {
        }
        public TestBakInfo()
        {
        }

        private string m_A;

        /// <summary>
        /// a
        /// </summary>
        public string A
        {
            get
            {
                return m_A;
            }
            set
            {
                m_A = value;
            }
        }

        private int m_B;

        /// <summary>
        /// b
        /// </summary>
        public int B
        {
            get
            {
                return m_B;
            }
            set
            {
                m_B = value;
            }
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
    }
}
