using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessFacade
{
    public static class MenuBiz
    {
        public static string RootMenuID
        {
            get { return "00000000-0000-0000-0000-000000000000"; }
        }



        public static SysMenu GetMenu(string menu_id)
        {
            return MenuAccess.GetMenu(menu_id);
        }

      
        /// <summary>
        /// 获取所有的菜单
        /// </summary>
        /// <returns></returns>
        public static List<SysMenu> GetAllMenus()
        {
            return MenuAccess.GetAllMenus();
        }

        

        /// <summary>
        /// 新增SysMenu
        /// </summary>
        /// <param name="menu"></param>
        public static void InsertMenu(SysMenu menu)
        {
            MenuAccess.InsertMenu(menu);            
        }


        /// <summary>
        /// 修改SysMenu
        /// </summary>
        /// <param name="menu"></param>
        public static void UpdateMenu(SysMenu menu)
        {
            MenuAccess.UpdateMenu(menu);
        }

        /// <summary>
        /// 删除SysMenu
        /// </summary>
        /// <param name="menuID"></param>
        public static void DeleteMenu(string menuID)
        {
            MenuAccess.DeleteMenu(menuID);
        }

        /// <summary>
        /// 设定群组对应的用户
        /// </summary>
        /// <param name="menuID"></param>
        /// <param name="groupIDList"></param>
        public static void SetMenuGroups(string menuID, List<string> groupIDList)
        {
            MenuAccess.SetMenuGroups(menuID, groupIDList);
        }        

        public static SysMenu GetMenuById(string menuID)
        {
            return MenuAccess.GetMenuById(menuID);
        }
        

        /// <summary>
        /// 获取Parent下的所有SysMenu
        /// </summary>
        /// <returns></returns>
        public static List<SysMenu> GetChildMenuList(string parentID)
        {
            return MenuAccess.GetChildMenuList(parentID);
        }        

        public static List<SysGroup> GetMenuGroupList(string menuID)
        {
            return MenuAccess.GetMenuGroupList(menuID);
        }

        /// <summary>
        /// when file moveup or movedown, change it's order_index
        /// </summary>
        /// <param name="fileID">當前移動文件的menu_id</param>
        /// <param name="anotherFileID">被交換文件的menu_id</param>
        /// <param name="order">當前文件的display_order</param>
        /// <param name="anotherOrder">被交換文件的display_order</param>
        public static void UpdateOrderIndexOfMenu(string menuID, string anotherMenuID, int order, int anotherOrder)
        {
            MenuAccess.UpdateOrderIndexOfMenu(menuID,anotherMenuID,order,anotherOrder);
        }
    }
}
