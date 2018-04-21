using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class ConditionInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<ConditionInfo>
    {
        public ConditionInfoHelper()
        {
        }

        /// <summary>
        ///  insert one Condition to database 
        /// </summary>
        public override void Insert(string connection_string, ConditionInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [condition] (");
            sb.Append("[condition_id],");
            sb.Append("[condition_name],");
            sb.Append("[condition_join],");
            sb.Append("[from_active_id],");
            sb.Append("[to_active_id],");
            sb.Append("[form_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@ConditionId,");
            sb.Append("@ConditionName,");
            sb.Append("@ConditionJoin,");
            sb.Append("@FromActiveId,");
            sb.Append("@ToActiveId,");
            sb.Append("@FormId ) ");

            ParameterBuilder paramList = new ParameterBuilder(6);
            paramList.Add("@ConditionId", entity.ConditionId);
            paramList.Add("@ConditionName", entity.ConditionName);
            paramList.Add("@ConditionJoin", entity.ConditionJoin);
            paramList.Add("@FromActiveId", entity.FromActiveId);
            paramList.Add("@ToActiveId", entity.ToActiveId);
            paramList.Add("@FormId", entity.FormId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one Condition to database 
        /// </summary>
        public override void Insert(SqlConnection connection, ConditionInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [condition] (");
            sb.Append("[condition_id],");
            sb.Append("[condition_name],");
            sb.Append("[condition_join],");
            sb.Append("[from_active_id],");
            sb.Append("[to_active_id],");
            sb.Append("[form_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@ConditionId,");
            sb.Append("@ConditionName,");
            sb.Append("@ConditionJoin,");
            sb.Append("@FromActiveId,");
            sb.Append("@ToActiveId,");
            sb.Append("@FormId ) ");

            ParameterBuilder paramList = new ParameterBuilder(6);
            paramList.Add("@ConditionId", entity.ConditionId);
            paramList.Add("@ConditionName", entity.ConditionName);
            paramList.Add("@ConditionJoin", entity.ConditionJoin);
            paramList.Add("@FromActiveId", entity.FromActiveId);
            paramList.Add("@ToActiveId", entity.ToActiveId);
            paramList.Add("@FormId", entity.FormId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one Condition to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, ConditionInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [condition] (");
            sb.Append("[condition_id],");
            sb.Append("[condition_name],");
            sb.Append("[condition_join],");
            sb.Append("[from_active_id],");
            sb.Append("[to_active_id],");
            sb.Append("[form_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@ConditionId,");
            sb.Append("@ConditionName,");
            sb.Append("@ConditionJoin,");
            sb.Append("@FromActiveId,");
            sb.Append("@ToActiveId,");
            sb.Append("@FormId ) ");

            ParameterBuilder paramList = new ParameterBuilder(6);
            paramList.Add("@ConditionId", entity.ConditionId);
            paramList.Add("@ConditionName", entity.ConditionName);
            paramList.Add("@ConditionJoin", entity.ConditionJoin);
            paramList.Add("@FromActiveId", entity.FromActiveId);
            paramList.Add("@ToActiveId", entity.ToActiveId);
            paramList.Add("@FormId", entity.FormId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :condition_id/
        /// </summary>
        public override void Update(string connection_string, ConditionInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [condition] set ");
            sb.Append("[condition_name] = @ConditionName, ");
            sb.Append("[condition_join] = @ConditionJoin, ");
            sb.Append("[from_active_id] = @FromActiveId, ");
            sb.Append("[to_active_id] = @ToActiveId, ");
            sb.Append("[form_id] = @FormId ");
            sb.Append("where [condition_id] = @ConditionId ");
            ParameterBuilder paramList = new ParameterBuilder(6);
            paramList.Add("@ConditionName", entity.ConditionName);
            paramList.Add("@ConditionJoin", entity.ConditionJoin);
            paramList.Add("@FromActiveId", entity.FromActiveId);
            paramList.Add("@ToActiveId", entity.ToActiveId);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@ConditionId", entity.ConditionId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :condition_id/
        /// </summary>
        public override void Update(SqlConnection connection, ConditionInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [condition] set ");
            sb.Append("[condition_name] = @ConditionName, ");
            sb.Append("[condition_join] = @ConditionJoin, ");
            sb.Append("[from_active_id] = @FromActiveId, ");
            sb.Append("[to_active_id] = @ToActiveId, ");
            sb.Append("[form_id] = @FormId ");
            sb.Append("where [condition_id] = @ConditionId ");
            ParameterBuilder paramList = new ParameterBuilder(6);
            paramList.Add("@ConditionName", entity.ConditionName);
            paramList.Add("@ConditionJoin", entity.ConditionJoin);
            paramList.Add("@FromActiveId", entity.FromActiveId);
            paramList.Add("@ToActiveId", entity.ToActiveId);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@ConditionId", entity.ConditionId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :condition_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, ConditionInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [condition] set ");
            sb.Append("[condition_name] = @ConditionName, ");
            sb.Append("[condition_join] = @ConditionJoin, ");
            sb.Append("[from_active_id] = @FromActiveId, ");
            sb.Append("[to_active_id] = @ToActiveId, ");
            sb.Append("[form_id] = @FormId ");
            sb.Append("where [condition_id] = @ConditionId ");
            ParameterBuilder paramList = new ParameterBuilder(6);
            paramList.Add("@ConditionName", entity.ConditionName);
            paramList.Add("@ConditionJoin", entity.ConditionJoin);
            paramList.Add("@FromActiveId", entity.FromActiveId);
            paramList.Add("@ToActiveId", entity.ToActiveId);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@ConditionId", entity.ConditionId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :condition_id/
        /// </summary>
        public override void Delete(string connection_string, ConditionInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [condition] ");
            sb.Append("where [condition_id] = @ConditionId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ConditionId", entity.ConditionId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :condition_id/
        /// </summary>
        public override void Delete(SqlConnection connection, ConditionInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [condition] ");
            sb.Append("where [condition_id] = @ConditionId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ConditionId", entity.ConditionId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :condition_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, ConditionInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [condition] ");
            sb.Append("where [condition_id] = @ConditionId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ConditionId", entity.ConditionId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to Condition
        /// warning: this row must include all the columns of table(condition)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(condition)</param>
        /// <returns>an entity of Condition</returns>
        public void FillEntityByRow(ConditionInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("condition_id"))
            {
                entity.ConditionId = (string)row["condition_id"];
            }
            else
            {
            }
            if (!row.IsNull("condition_name"))
            {
                entity.ConditionName = (string)row["condition_name"];
            }
            else
            {
            }
            if (!row.IsNull("condition_join"))
            {
                entity.ConditionJoin = (string)row["condition_join"];
            }
            else
            {
            }
            if (!row.IsNull("from_active_id"))
            {
                entity.FromActiveId = (string)row["from_active_id"];
            }
            else
            {
            }
            if (!row.IsNull("to_active_id"))
            {
                entity.ToActiveId = (string)row["to_active_id"];
            }
            else
            {
            }
            if (!row.IsNull("form_id"))
            {
                entity.FormId = (int)row["form_id"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to Condition
        /// warning: this row must include all the columns of table(condition)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(condition)</param>
        /// <returns>an entity of Condition</returns>
        public override ConditionInfo Row2Entity(System.Data.DataRow row)
        {
            ConditionInfo entity = new ConditionInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override ConditionInfo Retrieve(SqlTransaction transaction, ConditionInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [condition] ");
            sb.Append("where [condition_id] = @ConditionId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ConditionId", entity.ConditionId);

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
        public override ConditionInfo Retrieve(SqlConnection connection, ConditionInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [condition] ");
            sb.Append("where [condition_id] = @ConditionId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ConditionId", entity.ConditionId);

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
        public override ConditionInfo Retrieve(string connection_string, ConditionInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [condition] ");
            sb.Append("where [condition_id] = @ConditionId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ConditionId", entity.ConditionId);

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
