using System;
using System.Collections.Generic;
using System.Text;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessFacade
{
    public static class SiteBiz
    {
        public static List<SysSiteList> GetAllSites()
        {
            return SiteDataAccess.GetAllSites();
        }
    }
}
