using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class SysMenuGroupHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<SysMenuGroup>
    {
        public SysMenuGroupHelper()
        {
        }

        /// <summary>
        ///  insert one SysMenuGroup to database 
        /// </summary>
        public override void Insert(string connection_string, SysMenuGroup entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_menu_group] (");
            sb.Append("[menu_id],");
            sb.Append("[group_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@MenuId,");
            sb.Append("@GroupId ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@GroupId", entity.GroupId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysMenuGroup to database 
        /// </summary>
        public override void Insert(SqlConnection connection, SysMenuGroup entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_menu_group] (");
            sb.Append("[menu_id],");
            sb.Append("[group_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@MenuId,");
            sb.Append("@GroupId ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@GroupId", entity.GroupId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysMenuGroup to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, SysMenuGroup entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_menu_group] (");
            sb.Append("[menu_id],");
            sb.Append("[group_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@MenuId,");
            sb.Append("@GroupId ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@GroupId", entity.GroupId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :menu_id/group_id/
        /// </summary>
        public override void Update(string connection_string, SysMenuGroup entity)
        {
            // all column is primary key, need do nothing 
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :menu_id/group_id/
        /// </summary>
        public override void Update(SqlConnection connection, SysMenuGroup entity)
        {
            // all column is primary key, need do nothing 
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :menu_id/group_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, SysMenuGroup entity)
        {
            // all column is primary key, need do nothing 
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :menu_id/group_id/
        /// </summary>
        public override void Delete(string connection_string, SysMenuGroup entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_menu_group] ");
            sb.Append("where [menu_id] = @MenuId ");
            sb.Append("and [group_id] = @GroupId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@GroupId", entity.GroupId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :menu_id/group_id/
        /// </summary>
        public override void Delete(SqlConnection connection, SysMenuGroup entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_menu_group] ");
            sb.Append("where [menu_id] = @MenuId ");
            sb.Append("and [group_id] = @GroupId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@GroupId", entity.GroupId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :menu_id/group_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, SysMenuGroup entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_menu_group] ");
            sb.Append("where [menu_id] = @MenuId ");
            sb.Append("and [group_id] = @GroupId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@GroupId", entity.GroupId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to SysMenuGroup
        /// warning: this row must include all the columns of table(sys_menu_group)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_menu_group)</param>
        /// <returns>an entity of SysMenuGroup</returns>
        public void FillEntityByRow(SysMenuGroup entity, System.Data.DataRow row)
        {
            if (!row.IsNull("menu_id"))
            {
                entity.MenuId = (string)row["menu_id"];
            }
            else
            {
            }
            if (!row.IsNull("group_id"))
            {
                entity.GroupId = (string)row["group_id"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to SysMenuGroup
        /// warning: this row must include all the columns of table(sys_menu_group)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_menu_group)</param>
        /// <returns>an entity of SysMenuGroup</returns>
        public override SysMenuGroup Row2Entity(System.Data.DataRow row)
        {
            SysMenuGroup entity = new SysMenuGroup();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysMenuGroup Retrieve(SqlTransaction transaction, SysMenuGroup entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_menu_group] ");
            sb.Append("where [menu_id] = @MenuId ");
            sb.Append("and [group_id] = @GroupId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@GroupId", entity.GroupId);

            DataTable data = SqlHelper.ExecuteDataTableBySql(transaction, sb.ToString(), paramList.ToArray());
            if (data.Rows.Count > 0)
            {
                FillEntityByRow(entity, data.Rows[0]);
                return entity;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysMenuGroup Retrieve(SqlConnection connection, SysMenuGroup entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_menu_group] ");
            sb.Append("where [menu_id] = @MenuId ");
            sb.Append("and [group_id] = @GroupId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@GroupId", entity.GroupId);

            DataTable data = SqlHelper.ExecuteDataTableBySql(connection, sb.ToString(), paramList.ToArray());
            if (data.Rows.Count > 0)
            {
                FillEntityByRow(entity, data.Rows[0]);
                return entity;
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysMenuGroup Retrieve(string connection_string, SysMenuGroup entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_menu_group] ");
            sb.Append("where [menu_id] = @MenuId ");
            sb.Append("and [group_id] = @GroupId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@GroupId", entity.GroupId);

            DataTable data = SqlHelper.ExecuteDataTableBySql(connection_string, sb.ToString(), paramList.ToArray());
            if (data.Rows.Count > 0)
            {
                FillEntityByRow(entity, data.Rows[0]);
                return entity;
            }
            return null;
        }
    }
}
