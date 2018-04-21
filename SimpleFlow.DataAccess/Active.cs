using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SimpleFlow.Entity;
using SimpleFlow.SystemFramework;
using SimpleFlow.DBFramework.SQLServer;


namespace SimpleFlow.DataAccess
{
    public class ActiveDataAccess
    {
        public static List<ActiveInfo>  GetAll(int formId)
        {
            ColumnFilterList cfl = new ColumnFilterList();

            cfl.Add(new ColumnFilter("form_Id", formId));

            return SqlHelper.QueryTable<ActiveInfo>(Config.ConnectionString, cfl);
        }

        public static ActiveInfo GetActive(string ActiveId)
        {
            return SqlHelper.Retrieve<ActiveInfo>(Config.ConnectionString, new ActiveInfo(ActiveId));
        }

    }
}
