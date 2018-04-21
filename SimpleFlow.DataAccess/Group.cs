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
    public class GroupDataAccess
    {
        /// <summary>
        /// 新增群组
        /// </summary>
        /// <param name="group"></param>
        public static void InsertGroup(SysGroup group)
        {
            SqlHelper.Insert(Config.ConnectionString, group);
        }


        /// <summary>
        /// 修改群组
        /// </summary>
        /// <param name="group"></param>
        public static void UpdateGroup(SysGroup group)
        {
            SqlHelper.Update(Config.ConnectionString, group);
        }

        /// <summary>
        /// 判断群组ID是否存在
        /// </summary>
        /// <param name="groupID"></param>
        /// <returns></returns>
        public static bool ExistsGroupID(string groupID)
        {
            string sql = " select count(*) from groups where group_id = @group_id ";
            ParameterBuilder pb = new ParameterBuilder(1);
            pb.Add("@group_id", groupID);

            return (int)SqlHelper.ExecuteScalar(Config.ConnectionString, CommandType.Text, sql, pb.ToArray()) > 0;
        }


        /// <summary>
        /// 判断群组名称是否存在
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns></returns>
        public static bool ExistsGroupName(string groupName)
        {
            string sql = " select count(*) from groups where group_name = @group_name ";
            ParameterBuilder pb = new ParameterBuilder(1);
            pb.Add("@group_name", groupName);

            return (int)SqlHelper.ExecuteScalar(Config.ConnectionString, CommandType.Text, sql, pb.ToArray()) > 0;
        }



        /// <summary>
        /// 判断群组名称是否存在
        /// </summary>
        /// <param name="groupID"></param>
        /// <returns></returns>
        public static bool ExistsGroupName(string groupName, string groupID)
        {
            string sql = " select top 1 group_id from groups where group_name = @group_name and group_id <> @group_id ";
            ParameterBuilder pb = new ParameterBuilder(2);
            pb.Add("@group_name", groupName);
            pb.Add("@group_id", groupID);

            return SqlHelper.ExecuteDataTable(Config.ConnectionString, CommandType.Text, sql, pb.ToArray()).Rows.Count > 0;
        }

      
        /// <summary>
        /// 删除群组
        /// </summary>
        /// <param name="groupId"></param>
        public static void DeleteGroup(string groupID)
        {
            SqlConnection conn = new SqlConnection(Config.ConnectionString);
            try
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {

                    SysGroup group = new SysGroup(groupID);

                    SqlHelper.Delete(trans, group);

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



        /// <summary>
        /// 获取所有的群组
        /// </summary>
        /// <returns></returns>
        public static List<SysGroup> GetAllGroups()
        {
            return SqlHelper.GetAll<SysGroup>(Config.ConnectionString);
        }




        /// <summary>
        /// 获取指定群组中的用户
        /// </summary>
        /// <param name="groupID"></param>
        /// <returns></returns>
        public static List<SysUserInfo> GetGroupUsers(string groupID)
        {
            string sql = "select * from sys_user where user_id in (select user_id from sys_group_user where group_id = @group_id ) ";
            ParameterBuilder param_list = new ParameterBuilder("@group_id", groupID);
            return SqlHelper.GetListBySql<SysUserInfo>(Config.ConnectionString, sql, param_list.ToArray());
        }

        /// <summary>
        /// 设定群组对应的用户
        /// </summary>
        /// <param name="groupID"></param>
        /// <param name="empIDList"></param>
        public static void SetGroupUsers(string groupID, List<string> empIDList)
        {
            SqlConnection conn = new SqlConnection(Config.ConnectionString);
            try
            {
                conn.Open();
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    SqlHelper.DeleteTable<SysGroupUser>(trans, ColumnFilterList.New("group_id", groupID));

                    //insert group_users
                    foreach (string empID in empIDList)
                    {
                        SysGroupUser entity = new SysGroupUser(groupID, empID);
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



        /// <summary>
        /// 根据ID获取群组
        /// </summary>
        /// <param name="groupID"></param>
        /// <returns></returns>
        public static SysGroup GetGroupById(string groupID)
        {
            return SqlHelper.Retrieve<SysGroup>(Config.ConnectionString, new SysGroup(groupID));
        }
    }
}
