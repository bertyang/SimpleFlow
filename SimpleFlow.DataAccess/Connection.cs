using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using SimpleFlow.SystemFramework;

namespace SimpleFlow.DataAccess
{
    public class ConnectionDataAccess
    {
        public static SqlConnection CreateConnection()
        {
            return new SqlConnection(Config.ConnectionString);
        }
    }
}
