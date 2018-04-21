using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SimpleFlow.Entity;
using SimpleFlow.SystemFramework;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.DataAccess
{
    public class HomePageDataAccess
    {
        /// <summary>
        /// 根据用户权限获取菜单
        /// </summary>
        /// <param name="empId">用户ID</param>
        /// <returns></returns>
        public static List<SysMenu> GetMenuListByUser(string empId)
        {
            return SqlHelper.GetAll<SysMenu>(Config.ConnectionString, empId);
        }

    }
}
