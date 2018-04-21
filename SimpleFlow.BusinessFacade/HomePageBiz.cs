using System;
using System.Collections.Generic;
using System.Text;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessFacade
{
    public static class HomePageBiz
    {
        /// <summary>
        /// 根据用户权限获取菜单
        /// </summary>
        /// <param name="empId">用户ID</param>
        /// <returns></returns>
        public static List<SysMenu> GetMenuListByUser(string empId)
        {
            return HomePageDataAccess.GetMenuListByUser(empId);
        }


        private static void BuildChildLevel(List<SysMenu> menuList, MenuNode node)
        {
            for (int i = 0; i < menuList.Count; i++)
            {
                if (menuList[i].ParentId == node.SysMenu.MenuId)
                {
                    node.Nodes.Add(new MenuNode(menuList[i]));
                }
            }
            node.Nodes.Sort(new MenuNodeComparer());
        }


        public static List<MenuNode> BuildMenuTree(List<SysMenu> menuList)
        {
            List<MenuNode> nodeList = new List<MenuNode>();
            for (int i = 0; i < menuList.Count; i++)
            {
                if (menuList[i].ParentId == MenuBiz.RootMenuID)
                {
                    MenuNode node = new MenuNode(menuList[i]);
                    nodeList.Add(node);
                    BuildChildLevel(menuList, node);
                }
            }

            nodeList.Sort(new MenuNodeComparer());

            return nodeList;
        }


        private class MenuNodeComparer : IComparer<MenuNode>
        {
            #region IComparer<MenuNode> Members

            public int Compare(MenuNode x, MenuNode y)
            {
                return x.SysMenu.DisplayOrder - y.SysMenu.DisplayOrder;
            }

            #endregion
        }

    }
}
