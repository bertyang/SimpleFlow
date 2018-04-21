using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SimpleFlow.DBFramework.SQLServer;
using SimpleFlow.Entity;
using SimpleFlow.SystemFramework;

namespace SimpleFlow.DataAccess
{
    public class ConfigDataAccess
    {       
        public static List<SysConfig> GetAllConfig()
        {
            return SqlHelper.GetAll<SysConfig>(Config.ConnectionString);
        }

        public static string GetConfig(string config_id)
        {
            SysConfig entity = new SysConfig(config_id);
            return SqlHelper.Retrieve<SysConfig>(Config.ConnectionString, entity).ConfigValue;
        }

        public static void Insert(SysConfig entity)
        {
            SqlHelper.Insert(Config.ConnectionString, entity);
        }

        public static void Update(SysConfig entity)
        {
            SqlHelper.Update(Config.ConnectionString, entity);
        }

        public static void Delete(SysConfig entity)
        {
            SqlHelper.Delete(Config.ConnectionString, entity);
        }

    }
}
