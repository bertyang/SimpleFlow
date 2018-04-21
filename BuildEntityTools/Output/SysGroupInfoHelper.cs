using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class SysGroupInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<SysGroupInfo>
    {
        public SysGroupInfoHelper()
        {
        }

        /// <summary>
        ///  insert one SysGroup to database 
        /// </summary>
        public override void Insert(string connection_string, SysGroupInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_group] (");
            sb.Append("[group_id],");
            sb.Append("[group_name],");
            sb.Append("[is_admin],");
            sb.Append("[description] ");
            sb.Append(" ) values ( ");
            sb.Append("@GroupId,");
            sb.Append("@GroupName,");
            sb.Append("@IsAdmin,");
            sb.Append("@Description ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@GroupId", entity.GroupId);
            paramList.Add("@GroupName", entity.GroupName);
            paramList.Add("@IsAdmin", entity.IsAdmin);
            paramList.Add("@Description", entity.Description);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysGroup to database 
        /// </summary>
        public override void Insert(SqlConnection connection, SysGroupInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_group] (");
            sb.Append("[group_id],");
            sb.Append("[group_name],");
            sb.Append("[is_admin],");
            sb.Append("[description] ");
            sb.Append(" ) values ( ");
            sb.Append("@GroupId,");
            sb.Append("@GroupName,");
            sb.Append("@IsAdmin,");
            sb.Append("@Description ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@GroupId", entity.GroupId);
            paramList.Add("@GroupName", entity.GroupName);
            paramList.Add("@IsAdmin", entity.IsAdmin);
            paramList.Add("@Description", entity.Description);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysGroup to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, SysGroupInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_group] (");
            sb.Append("[group_id],");
            sb.Append("[group_name],");
            sb.Append("[is_admin],");
            sb.Append("[description] ");
            sb.Append(" ) values ( ");
            sb.Append("@GroupId,");
            sb.Append("@GroupName,");
            sb.Append("@IsAdmin,");
            sb.Append("@Description ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@GroupId", entity.GroupId);
            paramList.Add("@GroupName", entity.GroupName);
            paramList.Add("@IsAdmin", entity.IsAdmin);
            paramList.Add("@Description", entity.Description);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :group_id/
        /// </summary>
        public override void Update(string connection_string, SysGroupInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_group] set ");
            sb.Append("[group_name] = @GroupName, ");
            sb.Append("[is_admin] = @IsAdmin, ");
            sb.Append("[description] = @Description ");
            sb.Append("where [group_id] = @GroupId ");
            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@GroupName", entity.GroupName);
            paramList.Add("@IsAdmin", entity.IsAdmin);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@GroupId", entity.GroupId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :group_id/
        /// </summary>
        public override void Update(SqlConnection connection, SysGroupInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_group] set ");
            sb.Append("[group_name] = @GroupName, ");
            sb.Append("[is_admin] = @IsAdmin, ");
            sb.Append("[description] = @Description ");
            sb.Append("where [group_id] = @GroupId ");
            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@GroupName", entity.GroupName);
            paramList.Add("@IsAdmin", entity.IsAdmin);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@GroupId", entity.GroupId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :group_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, SysGroupInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_group] set ");
            sb.Append("[group_name] = @GroupName, ");
            sb.Append("[is_admin] = @IsAdmin, ");
            sb.Append("[description] = @Description ");
            sb.Append("where [group_id] = @GroupId ");
            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@GroupName", entity.GroupName);
            paramList.Add("@IsAdmin", entity.IsAdmin);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@GroupId", entity.GroupId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :group_id/
        /// </summary>
        public override void Delete(string connection_string, SysGroupInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_group] ");
            sb.Append("where [group_id] = @GroupId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@GroupId", entity.GroupId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :group_id/
        /// </summary>
        public override void Delete(SqlConnection connection, SysGroupInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_group] ");
            sb.Append("where [group_id] = @GroupId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@GroupId", entity.GroupId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :group_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, SysGroupInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_group] ");
            sb.Append("where [group_id] = @GroupId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@GroupId", entity.GroupId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to SysGroup
        /// warning: this row must include all the columns of table(sys_group)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_group)</param>
        /// <returns>an entity of SysGroup</returns>
        public void FillEntityByRow(SysGroupInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("group_id"))
            {
                entity.GroupId = (string)row["group_id"];
            }
            else
            {
            }
            if (!row.IsNull("group_name"))
            {
                entity.GroupName = (string)row["group_name"];
            }
            else
            {
            }
            if (!row.IsNull("is_admin"))
            {
                entity.IsAdmin = (string)row["is_admin"];
            }
            else
            {
            }
            if (!row.IsNull("description"))
            {
                entity.Description = (string)row["description"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to SysGroup
        /// warning: this row must include all the columns of table(sys_group)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_group)</param>
        /// <returns>an entity of SysGroup</returns>
        public override SysGroupInfo Row2Entity(System.Data.DataRow row)
        {
            SysGroupInfo entity = new SysGroupInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysGroupInfo Retrieve(SqlTransaction transaction, SysGroupInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_group] ");
            sb.Append("where [group_id] = @GroupId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
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
        public override SysGroupInfo Retrieve(SqlConnection connection, SysGroupInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_group] ");
            sb.Append("where [group_id] = @GroupId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
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
        public override SysGroupInfo Retrieve(string connection_string, SysGroupInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_group] ");
            sb.Append("where [group_id] = @GroupId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
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
