using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFlow.DBFramework.SQLServer
{
    [AttributeUsage(AttributeTargets.Class)]
    public class EntityAttribute : System.Attribute
    {
        private string m_TableName;

        public string TableName
        {
            get { return m_TableName; }
        }

        private System.Type m_HelperType;

        public System.Type HelperType
        {
            get { return m_HelperType; }
        }


        public EntityAttribute(string table_name, System.Type helper_type)
        {
            m_TableName = table_name;
            m_HelperType = helper_type;
            // m_EntityHelper = m_HelperType.Assembly.CreateInstance(m_HelperType.FullName);
        }


        private object m_EntityHelper;

        public object EntityHelper
        {
            get 
            {
                if (m_EntityHelper == null)
                {
                    m_EntityHelper = m_HelperType.Assembly.CreateInstance(m_HelperType.FullName);
                }
                return m_EntityHelper; 
            }
        }

        


    }
}
