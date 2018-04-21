using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using SimpleFlow.Entity;
using SimpleFlow.SystemFramework;
using SimpleFlow.DBFramework.SQLServer;


namespace SimpleFlow.DataAccess
{
    public class ConditionSubDataAccess
    {
        public static List<ConditionSubInfo> GetConditionSubList(string conditionId)
        {
            ColumnFilterList cfl = new ColumnFilterList();

            cfl.Add(new ColumnFilter("Condition_Id", conditionId));

            return SqlHelper.QueryTable<ConditionSubInfo>(Config.ConnectionString, cfl);

        }

        public static void UpdateConditionSub(ConditionSubInfo cs)
        {

            SqlHelper.Update(Config.ConnectionString, cs);
        }

        public static void AddConditionSub(ConditionSubInfo cs)
        {
            SqlHelper.Insert(Config.ConnectionString, cs);
        }

        public static void DelConditionSub(string ConditionSubId)
        {
            SqlHelper.Delete(Config.ConnectionString, new ConditionSubInfo(ConditionSubId));
        }

        public static ConditionSubInfo GetConditionSub(string ConditionSubId)
        {
            return SqlHelper.Retrieve<ConditionSubInfo>(Config.ConnectionString, new ConditionSubInfo(ConditionSubId));
        }

        public static object GetValue(string sql)
        {
              return SqlHelper.ExecuteScalar(Config.ConnectionString, CommandType.Text, sql);
        }
    }
}
