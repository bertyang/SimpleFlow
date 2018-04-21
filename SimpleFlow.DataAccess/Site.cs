using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SimpleFlow.Entity;
using SimpleFlow.SystemFramework;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.DataAccess
{
    public class SiteDataAccess
    {
        public static List<SysSiteList> GetAllSites()
        {
            return SqlHelper.GetAll<SysSiteList>(Config.ConnectionString);
        }
    }
}
