using System;
using System.Collections;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace SimpleFlow.DBFramework.SQLServer
{
	/// <summary>
	/// 收集SQL参数的构造器
	/// </summary>
	public class ParameterBuilder : List<SqlParameter>
	{

        public ParameterBuilder()
            : base()
        {
        }

        public ParameterBuilder(int capacity)
            : base(capacity)
        {
        }

        public ParameterBuilder(IEnumerable<SqlParameter> collection)
            : base(collection)
        {
        }

        public ParameterBuilder(string firstParamName, object firstParamValue)
            : base(1)
        {
            this.Add(firstParamName, firstParamValue);
        }


        public ParameterBuilder(string firstParamName, SqlDbType firstParamType, object firstParamValue)
            : base(1)
        {
            this.Add(firstParamName, firstParamType, firstParamValue);
        }
		
		public void Add(string paramName, object paramValue)
		{
            this.Add(new SqlParameter(paramName, paramValue));
		}


		public void Add(string paramName, SqlDbType dbType, object paramValue)
		{
			SqlParameter prm = new SqlParameter(paramName, dbType);
			prm.Value = paramValue;
            this.Add(prm);
		}
				
	}
}
