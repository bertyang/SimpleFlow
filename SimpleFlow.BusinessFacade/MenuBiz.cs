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
        /// ��ȡ���еĲ˵�
        /// </summary>
        /// <returns></returns>
        public static List<SysMenu> GetAllMenus()
        {
            return MenuAccess.GetAllMenus();
        }

        

        /// <summary>
        /// ����SysMenu
        /// </summary>
        /// <param name="menu"></param>
        public static void InsertMenu(SysMenu menu)
        {
            MenuAccess.InsertMenu(menu);            
        }


        /// <summary>
        /// �޸�SysMenu
        /// </summary>
        /// <param name="menu"></param>
        public static void UpdateMenu(SysMenu menu)
        {
            MenuAccess.UpdateMenu(menu);
        }

        /// <summary>
        /// ɾ��SysMenu
        /// </summary>
        /// <param name="menuID"></param>
        public static void DeleteMenu(string menuID)
        {
            MenuAccess.DeleteMenu(menuID);
        }

        /// <summary>
        /// �趨Ⱥ���Ӧ���û�
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
        /// ��ȡParent�µ�����SysMenu
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
        /// <param name="fileID">��ǰ�Ƅ��ļ���menu_id</param>
        /// <param name="anotherFileID">�����Q�ļ���menu_id</param>
        /// <param name="order">��ǰ�ļ���display_order</param>
        /// <param name="anotherOrder">�����Q�ļ���display_order</param>
        public static void UpdateOrderIndexOfMenu(string menuID, string anotherMenuID, int order, int anotherOrder)
        {
            MenuAccess.UpdateOrderIndexOfMenu(menuID,anotherMenuID,order,anotherOrder);
        }
    }
}
