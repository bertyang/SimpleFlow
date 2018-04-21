using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SimpleFlow.Entity;
using SimpleFlow.SystemFramework;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.DataAccess
{
    public class FormDataAccess
    {
        public static List<FormInfo> GetAll()
        {
            return SqlHelper.GetAll<FormInfo>(Config.ConnectionString);
        }

        public static FormInfo GetForm(int form_Id)
        {
            return SqlHelper.Retrieve<FormInfo>(Config.ConnectionString, new FormInfo(form_Id));
        }
    }
}
