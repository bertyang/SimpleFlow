using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using SimpleFlow.Entity;
using SimpleFlow.SystemFramework;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.DataAccess
{
    public class MenuAccess
    {
        public static SysMenu GetMenu(string menu_id)
        {
            return SqlHelper.Retrieve<SysMenu>(Config.ConnectionString,
                new SysMenu(menu_id));
        }


        /// <summary>
        /// 获取所有的菜单
        /// </summary>
        /// <returns></returns>
        public static List<SysMenu> GetAllMenus()
        {
            return SqlHelper.GetAll<SysMenu>(Config.ConnectionString);
        }



        /// <summary>
        /// 新增SysMenu
        /// </summary>
        /// <param name="menu"></param>
        public static void InsertMenu(SysMenu menu)
        {
            SqlHelper.Insert(Config.ConnectionString, menu);
        }


        /// <summary>
        /// 修改SysMenu
        /// </summary>
        /// <param name="menu"></param>
        public static void UpdateMenu(SysMenu menu)
        {
            SqlHelper.Update(Config.ConnectionString, menu);
        }

        /// <summary>
        /// 删除SysMenu
        /// </summary>
        /// <param name="menuID"></param>
        public static void DeleteMenu(string menuID)
        {
            SqlHelper.Delete(Config.ConnectionString, new SysMenu(menuID));
        }

        /// <summary>
        /// 设定群组对应的用户
        /// </summary>
        /// <param name="menuID"></param>
        /// <param name="groupIDList"></param>
        public static void SetMenuGroups(string menuID, List<string> groupIDList)
        {
            SqlConnection conn = new SqlConnection(Config.ConnectionString);
            try
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    SqlHelper.DeleteTable<SysMenuGroup>(trans,
                        ColumnFilterList.New("menu_id", menuID));

                    //insert menu_groups
                    foreach (string groupID in groupIDList)
                    {
                        SysMenuGroup entity = new SysMenuGroup(menuID, groupID);
                        SqlHelper.Insert(trans, entity);
                    }

                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
            }
            finally
            {
                conn.Close();
            }
        }



        public static SysMenu GetMenuById(string menuID)
        {
            return SqlHelper.Retrieve<SysMenu>(Config.ConnectionString, new SysMenu(menuID));
        }


        /// <summary>
        /// 获取Parent下的所有SysMenu
        /// </summary>
        /// <returns></returns>
        public static List<SysMenu> GetChildMenuList(string parentID)
        {
            return SqlHelper.QueryTable<SysMenu>(Config.ConnectionString,
                ColumnFilterList.New("parent_id", parentID));
        }




        public static List<SysGroup> GetMenuGroupList(string menuID)
        {
            string sql = " select * from sys_group where group_id in (select group_id from sys_menu_group where menu_id = @menu_id ) ";
            ParameterBuilder param_list = new ParameterBuilder("menu_id", menuID);
            return SqlHelper.GetListBySql<SysGroup>(Config.ConnectionString, sql, param_list.ToArray());
        }



        ///// <summary>
        ///// get navigation information by sub_menu_id
        ///// </summary>
        ///// <param name="menuID">sub_menu_id</param>
        ///// <returns>dataset:sub_menu_name/menu_name/menu_description</returns>
        //public static DataSet GetNavigationBySubMenuID(string menuID)
        //{
        //    SqlConnection conn = new SqlConnection(BizConfig.ConnectionString);
        //    try
        //    {
        //        conn.Open();
        //        return SqlHelper.ExecuteDataset(conn, "usp_menu_select_navigation_by_sub_menu_id", menuID.Trim());
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}


        ///// <summary>
        ///// get max(order_index) & min(order_index) from menus by parent_id
        ///// </summary>
        ///// <param name="menuID">parent_id</param>
        ///// <returns>dataset</returns>
        //public static DataSet GetOrderIndexByParentMenuID(string parentID)
        //{
        //    SqlConnection conn = new SqlConnection(BizConfig.ConnectionString);
        //    try
        //    {
        //        conn.Open();
        //        return SqlHelper.ExecuteDataset(conn, "usp_menu_select_order_index", parentID.Trim());
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        /// <summary>
        /// when file moveup or movedown, change it's order_index
        /// </summary>
        /// <param name="fileID">當前移動文件的menu_id</param>
        /// <param name="anotherFileID">被交換文件的menu_id</param>
        /// <param name="order">當前文件的display_order</param>
        /// <param name="anotherOrder">被交換文件的display_order</param>
        public static void UpdateOrderIndexOfMenu(string menuID, string anotherMenuID, int order, int anotherOrder)
        {
            SqlConnection conn = new SqlConnection(Config.ConnectionString);
            try
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                SqlParameter[] parameters = new SqlParameter[4];
                parameters[0] = new SqlParameter("@menu_id", SqlDbType.NVarChar);
                parameters[0].Value = menuID;
                parameters[1] = new SqlParameter("@other_menu_id", SqlDbType.NVarChar);
                parameters[1].Value = anotherMenuID;
                parameters[2] = new SqlParameter("@display_order", SqlDbType.Int);
                parameters[2].Value = order;
                parameters[3] = new SqlParameter("@other_display_order", SqlDbType.Int);
                parameters[3].Value = anotherOrder;
                try
                {
                    SqlHelper.ExecuteNonQuery(trans, "usp_menu_update_order_index", parameters);
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
