using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessFacade
{
    public class CommonBiz
    {
        public static int CreateId(string type)
        {
            return CommonDataAccess.CreateId(type);
        }

        public static DataTable GetColumns(string tableName)
        {
            return CommonDataAccess.GetColumns(tableName);
        }

        public static string CreateFormId()
        {
            return CommonDataAccess.CreateFormId();
        }
    }
}
