using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class SysGroupUserInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<SysGroupUserInfo>
    {
        public SysGroupUserInfoHelper()
        {
        }

        /// <summary>
        ///  insert one SysGroupUser to database 
        /// </summary>
        public override void Insert(string connection_string, SysGroupUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_group_user] (");
            sb.Append("[group_id],");
            sb.Append("[user_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@GroupId,");
            sb.Append("@UserId ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@GroupId", entity.GroupId);
            paramList.Add("@UserId", entity.UserId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysGroupUser to database 
        /// </summary>
        public override void Insert(SqlConnection connection, SysGroupUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_group_user] (");
            sb.Append("[group_id],");
            sb.Append("[user_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@GroupId,");
            sb.Append("@UserId ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@GroupId", entity.GroupId);
            paramList.Add("@UserId", entity.UserId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysGroupUser to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, SysGroupUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_group_user] (");
            sb.Append("[group_id],");
            sb.Append("[user_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@GroupId,");
            sb.Append("@UserId ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@GroupId", entity.GroupId);
            paramList.Add("@UserId", entity.UserId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :group_id/user_id/
        /// </summary>
        public override void Update(string connection_string, SysGroupUserInfo entity)
        {
            // all column is primary key, need do nothing 
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :group_id/user_id/
        /// </summary>
        public override void Update(SqlConnection connection, SysGroupUserInfo entity)
        {
            // all column is primary key, need do nothing 
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :group_id/user_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, SysGroupUserInfo entity)
        {
            // all column is primary key, need do nothing 
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :group_id/user_id/
        /// </summary>
        public override void Delete(string connection_string, SysGroupUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_group_user] ");
            sb.Append("where [group_id] = @GroupId ");
            sb.Append("and [user_id] = @UserId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@GroupId", entity.GroupId);
            paramList.Add("@UserId", entity.UserId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :group_id/user_id/
        /// </summary>
        public override void Delete(SqlConnection connection, SysGroupUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_group_user] ");
            sb.Append("where [group_id] = @GroupId ");
            sb.Append("and [user_id] = @UserId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@GroupId", entity.GroupId);
            paramList.Add("@UserId", entity.UserId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :group_id/user_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, SysGroupUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_group_user] ");
            sb.Append("where [group_id] = @GroupId ");
            sb.Append("and [user_id] = @UserId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@GroupId", entity.GroupId);
            paramList.Add("@UserId", entity.UserId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to SysGroupUser
        /// warning: this row must include all the columns of table(sys_group_user)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_group_user)</param>
        /// <returns>an entity of SysGroupUser</returns>
        public void FillEntityByRow(SysGroupUserInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("group_id"))
            {
                entity.GroupId = (string)row["group_id"];
            }
            else
            {
            }
            if (!row.IsNull("user_id"))
            {
                entity.UserId = (string)row["user_id"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to SysGroupUser
        /// warning: this row must include all the columns of table(sys_group_user)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_group_user)</param>
        /// <returns>an entity of SysGroupUser</returns>
        public override SysGroupUserInfo Row2Entity(System.Data.DataRow row)
        {
            SysGroupUserInfo entity = new SysGroupUserInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysGroupUserInfo Retrieve(SqlTransaction transaction, SysGroupUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_group_user] ");
            sb.Append("where [group_id] = @GroupId ");
            sb.Append("and [user_id] = @UserId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@GroupId", entity.GroupId);
            paramList.Add("@UserId", entity.UserId);

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
        public override SysGroupUserInfo Retrieve(SqlConnection connection, SysGroupUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_group_user] ");
            sb.Append("where [group_id] = @GroupId ");
            sb.Append("and [user_id] = @UserId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@GroupId", entity.GroupId);
            paramList.Add("@UserId", entity.UserId);

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
        public override SysGroupUserInfo Retrieve(string connection_string, SysGroupUserInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_group_user] ");
            sb.Append("where [group_id] = @GroupId ");
            sb.Append("and [user_id] = @UserId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@GroupId", entity.GroupId);
            paramList.Add("@UserId", entity.UserId);

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
