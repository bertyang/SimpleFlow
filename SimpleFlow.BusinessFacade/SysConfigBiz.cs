using System;
using System.Collections.Generic;
using System.Text;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessFacade
{
    public static class SysConfigBiz
    {
        public static List<SysConfig> GetAllConfig()
        {
            return ConfigDataAccess.GetAllConfig();
        }

        public static string GetConfig(string config_id)
        {
            return ConfigDataAccess.GetConfig(config_id);
        }

        public static void Insert(SysConfig entity)
        {
            ConfigDataAccess.Insert(entity);
        }

        public static void Update(SysConfig entity)
        {
            ConfigDataAccess.Update(entity);
        }

        public static void Delete(SysConfig entity)
        {
            ConfigDataAccess.Delete(entity);
        }

        
    }
}
