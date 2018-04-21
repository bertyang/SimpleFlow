using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFlow.DBFramework.SQLServer
{
    public class ColumnFilter
    {
        private string m_name;
        private object m_value;

        public string Name
        {
            get { return m_name; }
        }
        public object Value
        {
            get { return m_value; }
        }

        public ColumnFilter(string name, object value)
        {
            m_name = name;
            m_value = value;
        }
    }

    public class ColumnFilterList : List<ColumnFilter>
    {
        public ColumnFilterList Join(string name, object value)
        {
            this.Add(new ColumnFilter(name, value));
            return this;
        }

        public static ColumnFilterList New(string name, object value)
        {
            return new ColumnFilterList().Join(name, value);
        }

        
    }
}
