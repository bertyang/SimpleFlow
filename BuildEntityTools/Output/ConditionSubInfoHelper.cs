using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class ConditionSubInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<ConditionSubInfo>
    {
        public ConditionSubInfoHelper()
        {
        }

        /// <summary>
        ///  insert one ConditionSub to database 
        /// </summary>
        public override void Insert(string connection_string, ConditionSubInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [condition_sub] (");
            sb.Append("[condition_sub_id],");
            sb.Append("[condition_sub_field],");
            sb.Append("[condition_sub_operator],");
            sb.Append("[condition_sub_value],");
            sb.Append("[condition_id],");
            sb.Append("[create_time] ");
            sb.Append(" ) values ( ");
            sb.Append("@ConditionSubId,");
            sb.Append("@ConditionSubField,");
            sb.Append("@ConditionSubOperator,");
            sb.Append("@ConditionSubValue,");
            sb.Append("@ConditionId,");
            sb.Append("@CreateTime ) ");

            ParameterBuilder paramList = new ParameterBuilder(6);
            paramList.Add("@ConditionSubId", entity.ConditionSubId);
            paramList.Add("@ConditionSubField", entity.ConditionSubField);
            paramList.Add("@ConditionSubOperator", entity.ConditionSubOperator);
            paramList.Add("@ConditionSubValue", entity.ConditionSubValue);
            paramList.Add("@ConditionId", entity.ConditionId);
            paramList.Add("@CreateTime", entity.CreateTime);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one ConditionSub to database 
        /// </summary>
        public override void Insert(SqlConnection connection, ConditionSubInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [condition_sub] (");
            sb.Append("[condition_sub_id],");
            sb.Append("[condition_sub_field],");
            sb.Append("[condition_sub_operator],");
            sb.Append("[condition_sub_value],");
            sb.Append("[condition_id],");
            sb.Append("[create_time] ");
            sb.Append(" ) values ( ");
            sb.Append("@ConditionSubId,");
            sb.Append("@ConditionSubField,");
            sb.Append("@ConditionSubOperator,");
            sb.Append("@ConditionSubValue,");
            sb.Append("@ConditionId,");
            sb.Append("@CreateTime ) ");

            ParameterBuilder paramList = new ParameterBuilder(6);
            paramList.Add("@ConditionSubId", entity.ConditionSubId);
            paramList.Add("@ConditionSubField", entity.ConditionSubField);
            paramList.Add("@ConditionSubOperator", entity.ConditionSubOperator);
            paramList.Add("@ConditionSubValue", entity.ConditionSubValue);
            paramList.Add("@ConditionId", entity.ConditionId);
            paramList.Add("@CreateTime", entity.CreateTime);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one ConditionSub to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, ConditionSubInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [condition_sub] (");
            sb.Append("[condition_sub_id],");
            sb.Append("[condition_sub_field],");
            sb.Append("[condition_sub_operator],");
            sb.Append("[condition_sub_value],");
            sb.Append("[condition_id],");
            sb.Append("[create_time] ");
            sb.Append(" ) values ( ");
            sb.Append("@ConditionSubId,");
            sb.Append("@ConditionSubField,");
            sb.Append("@ConditionSubOperator,");
            sb.Append("@ConditionSubValue,");
            sb.Append("@ConditionId,");
            sb.Append("@CreateTime ) ");

            ParameterBuilder paramList = new ParameterBuilder(6);
            paramList.Add("@ConditionSubId", entity.ConditionSubId);
            paramList.Add("@ConditionSubField", entity.ConditionSubField);
            paramList.Add("@ConditionSubOperator", entity.ConditionSubOperator);
            paramList.Add("@ConditionSubValue", entity.ConditionSubValue);
            paramList.Add("@ConditionId", entity.ConditionId);
            paramList.Add("@CreateTime", entity.CreateTime);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :condition_sub_id/
        /// </summary>
        public override void Update(string connection_string, ConditionSubInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [condition_sub] set ");
            sb.Append("[condition_sub_field] = @ConditionSubField, ");
            sb.Append("[condition_sub_operator] = @ConditionSubOperator, ");
            sb.Append("[condition_sub_value] = @ConditionSubValue, ");
            sb.Append("[condition_id] = @ConditionId, ");
            sb.Append("[create_time] = @CreateTime ");
            sb.Append("where [condition_sub_id] = @ConditionSubId ");
            ParameterBuilder paramList = new ParameterBuilder(6);
            paramList.Add("@ConditionSubField", entity.ConditionSubField);
            paramList.Add("@ConditionSubOperator", entity.ConditionSubOperator);
            paramList.Add("@ConditionSubValue", entity.ConditionSubValue);
            paramList.Add("@ConditionId", entity.ConditionId);
            paramList.Add("@CreateTime", entity.CreateTime);
            paramList.Add("@ConditionSubId", entity.ConditionSubId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :condition_sub_id/
        /// </summary>
        public override void Update(SqlConnection connection, ConditionSubInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [condition_sub] set ");
            sb.Append("[condition_sub_field] = @ConditionSubField, ");
            sb.Append("[condition_sub_operator] = @ConditionSubOperator, ");
            sb.Append("[condition_sub_value] = @ConditionSubValue, ");
            sb.Append("[condition_id] = @ConditionId, ");
            sb.Append("[create_time] = @CreateTime ");
            sb.Append("where [condition_sub_id] = @ConditionSubId ");
            ParameterBuilder paramList = new ParameterBuilder(6);
            paramList.Add("@ConditionSubField", entity.ConditionSubField);
            paramList.Add("@ConditionSubOperator", entity.ConditionSubOperator);
            paramList.Add("@ConditionSubValue", entity.ConditionSubValue);
            paramList.Add("@ConditionId", entity.ConditionId);
            paramList.Add("@CreateTime", entity.CreateTime);
            paramList.Add("@ConditionSubId", entity.ConditionSubId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :condition_sub_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, ConditionSubInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [condition_sub] set ");
            sb.Append("[condition_sub_field] = @ConditionSubField, ");
            sb.Append("[condition_sub_operator] = @ConditionSubOperator, ");
            sb.Append("[condition_sub_value] = @ConditionSubValue, ");
            sb.Append("[condition_id] = @ConditionId, ");
            sb.Append("[create_time] = @CreateTime ");
            sb.Append("where [condition_sub_id] = @ConditionSubId ");
            ParameterBuilder paramList = new ParameterBuilder(6);
            paramList.Add("@ConditionSubField", entity.ConditionSubField);
            paramList.Add("@ConditionSubOperator", entity.ConditionSubOperator);
            paramList.Add("@ConditionSubValue", entity.ConditionSubValue);
            paramList.Add("@ConditionId", entity.ConditionId);
            paramList.Add("@CreateTime", entity.CreateTime);
            paramList.Add("@ConditionSubId", entity.ConditionSubId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :condition_sub_id/
        /// </summary>
        public override void Delete(string connection_string, ConditionSubInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [condition_sub] ");
            sb.Append("where [condition_sub_id] = @ConditionSubId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ConditionSubId", entity.ConditionSubId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :condition_sub_id/
        /// </summary>
        public override void Delete(SqlConnection connection, ConditionSubInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [condition_sub] ");
            sb.Append("where [condition_sub_id] = @ConditionSubId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ConditionSubId", entity.ConditionSubId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :condition_sub_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, ConditionSubInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [condition_sub] ");
            sb.Append("where [condition_sub_id] = @ConditionSubId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ConditionSubId", entity.ConditionSubId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to ConditionSub
        /// warning: this row must include all the columns of table(condition_sub)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(condition_sub)</param>
        /// <returns>an entity of ConditionSub</returns>
        public void FillEntityByRow(ConditionSubInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("condition_sub_id"))
            {
                entity.ConditionSubId = (string)row["condition_sub_id"];
            }
            else
            {
            }
            if (!row.IsNull("condition_sub_field"))
            {
                entity.ConditionSubField = (string)row["condition_sub_field"];
            }
            else
            {
            }
            if (!row.IsNull("condition_sub_operator"))
            {
                entity.ConditionSubOperator = (string)row["condition_sub_operator"];
            }
            else
            {
            }
            if (!row.IsNull("condition_sub_value"))
            {
                entity.ConditionSubValue = (string)row["condition_sub_value"];
            }
            else
            {
            }
            if (!row.IsNull("condition_id"))
            {
                entity.ConditionId = (string)row["condition_id"];
            }
            else
            {
            }
            if (!row.IsNull("create_time"))
            {
                entity.CreateTime = (System.DateTime)row["create_time"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to ConditionSub
        /// warning: this row must include all the columns of table(condition_sub)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(condition_sub)</param>
        /// <returns>an entity of ConditionSub</returns>
        public override ConditionSubInfo Row2Entity(System.Data.DataRow row)
        {
            ConditionSubInfo entity = new ConditionSubInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override ConditionSubInfo Retrieve(SqlTransaction transaction, ConditionSubInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [condition_sub] ");
            sb.Append("where [condition_sub_id] = @ConditionSubId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ConditionSubId", entity.ConditionSubId);

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
        public override ConditionSubInfo Retrieve(SqlConnection connection, ConditionSubInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [condition_sub] ");
            sb.Append("where [condition_sub_id] = @ConditionSubId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ConditionSubId", entity.ConditionSubId);

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
        public override ConditionSubInfo Retrieve(string connection_string, ConditionSubInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [condition_sub] ");
            sb.Append("where [condition_sub_id] = @ConditionSubId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ConditionSubId", entity.ConditionSubId);

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
