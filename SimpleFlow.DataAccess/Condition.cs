using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SimpleFlow.Entity;
using SimpleFlow.SystemFramework;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.DataAccess
{
    public class ConditionDataAccess
    {
        public static List<ConditionInfo> GetAll(int formId)
        {
            ColumnFilterList cfl = new ColumnFilterList();

            cfl.Add(new ColumnFilter("form_Id", formId));

            return SqlHelper.QueryTable<ConditionInfo>(Config.ConnectionString, cfl);
        }

        public static ConditionInfo GetCondition(string conditionId)
        {
            return SqlHelper.Retrieve<ConditionInfo>(Config.ConnectionString, new ConditionInfo(conditionId));
        }

        public static void Update(ConditionInfo condition)
        {
            SqlHelper.Update(Config.ConnectionString, condition);
        }

    }
}
