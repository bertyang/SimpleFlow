using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class MdFieldInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<MdFieldInfo>
    {
        public MdFieldInfoHelper()
        {
        }

        /// <summary>
        ///  insert one MdField to database 
        /// </summary>
        public override void Insert(string connection_string, MdFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [md_field] (");
            sb.Append("[model_id],");
            sb.Append("[field_name],");
            sb.Append("[table_name] ");
            sb.Append(" ) values ( ");
            sb.Append("@ModelId,");
            sb.Append("@FieldName,");
            sb.Append("@TableName ) ");

            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@ModelId", entity.ModelId);
            paramList.Add("@FieldName", entity.FieldName);
            paramList.Add("@TableName", entity.TableName);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one MdField to database 
        /// </summary>
        public override void Insert(SqlConnection connection, MdFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [md_field] (");
            sb.Append("[model_id],");
            sb.Append("[field_name],");
            sb.Append("[table_name] ");
            sb.Append(" ) values ( ");
            sb.Append("@ModelId,");
            sb.Append("@FieldName,");
            sb.Append("@TableName ) ");

            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@ModelId", entity.ModelId);
            paramList.Add("@FieldName", entity.FieldName);
            paramList.Add("@TableName", entity.TableName);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one MdField to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, MdFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [md_field] (");
            sb.Append("[model_id],");
            sb.Append("[field_name],");
            sb.Append("[table_name] ");
            sb.Append(" ) values ( ");
            sb.Append("@ModelId,");
            sb.Append("@FieldName,");
            sb.Append("@TableName ) ");

            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@ModelId", entity.ModelId);
            paramList.Add("@FieldName", entity.FieldName);
            paramList.Add("@TableName", entity.TableName);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :model_id/
        /// </summary>
        public override void Update(string connection_string, MdFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [md_field] set ");
            sb.Append("[field_name] = @FieldName, ");
            sb.Append("[table_name] = @TableName ");
            sb.Append("where [model_id] = @ModelId ");
            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@FieldName", entity.FieldName);
            paramList.Add("@TableName", entity.TableName);
            paramList.Add("@ModelId", entity.ModelId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :model_id/
        /// </summary>
        public override void Update(SqlConnection connection, MdFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [md_field] set ");
            sb.Append("[field_name] = @FieldName, ");
            sb.Append("[table_name] = @TableName ");
            sb.Append("where [model_id] = @ModelId ");
            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@FieldName", entity.FieldName);
            paramList.Add("@TableName", entity.TableName);
            paramList.Add("@ModelId", entity.ModelId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :model_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, MdFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [md_field] set ");
            sb.Append("[field_name] = @FieldName, ");
            sb.Append("[table_name] = @TableName ");
            sb.Append("where [model_id] = @ModelId ");
            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@FieldName", entity.FieldName);
            paramList.Add("@TableName", entity.TableName);
            paramList.Add("@ModelId", entity.ModelId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :model_id/
        /// </summary>
        public override void Delete(string connection_string, MdFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [md_field] ");
            sb.Append("where [model_id] = @ModelId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ModelId", entity.ModelId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :model_id/
        /// </summary>
        public override void Delete(SqlConnection connection, MdFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [md_field] ");
            sb.Append("where [model_id] = @ModelId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ModelId", entity.ModelId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :model_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, MdFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [md_field] ");
            sb.Append("where [model_id] = @ModelId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ModelId", entity.ModelId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to MdField
        /// warning: this row must include all the columns of table(md_field)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(md_field)</param>
        /// <returns>an entity of MdField</returns>
        public void FillEntityByRow(MdFieldInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("model_id"))
            {
                entity.ModelId = (string)row["model_id"];
            }
            else
            {
            }
            if (!row.IsNull("field_name"))
            {
                entity.FieldName = (string)row["field_name"];
            }
            else
            {
            }
            if (!row.IsNull("table_name"))
            {
                entity.TableName = (string)row["table_name"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to MdField
        /// warning: this row must include all the columns of table(md_field)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(md_field)</param>
        /// <returns>an entity of MdField</returns>
        public override MdFieldInfo Row2Entity(System.Data.DataRow row)
        {
            MdFieldInfo entity = new MdFieldInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override MdFieldInfo Retrieve(SqlTransaction transaction, MdFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [md_field] ");
            sb.Append("where [model_id] = @ModelId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ModelId", entity.ModelId);

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
        public override MdFieldInfo Retrieve(SqlConnection connection, MdFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [md_field] ");
            sb.Append("where [model_id] = @ModelId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ModelId", entity.ModelId);

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
        public override MdFieldInfo Retrieve(string connection_string, MdFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [md_field] ");
            sb.Append("where [model_id] = @ModelId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ModelId", entity.ModelId);

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
