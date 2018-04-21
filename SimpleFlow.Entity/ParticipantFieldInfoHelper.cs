using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class ParticipantFieldInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<ParticipantFieldInfo>
    {
        public ParticipantFieldInfoHelper()
        {
        }

        /// <summary>
        ///  insert one ParticipantField to database 
        /// </summary>
        public override void Insert(string connection_string, ParticipantFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [participant_field] (");
            sb.Append("[participant_id],");
            sb.Append("[field_name],");
            sb.Append("[table_name] ");
            sb.Append(" ) values ( ");
            sb.Append("@ParticipantId,");
            sb.Append("@FieldName,");
            sb.Append("@TableName ) ");

            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@ParticipantId", entity.ParticipantId);
            paramList.Add("@FieldName", entity.FieldName);
            paramList.Add("@TableName", entity.TableName);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one ParticipantField to database 
        /// </summary>
        public override void Insert(SqlConnection connection, ParticipantFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [participant_field] (");
            sb.Append("[participant_id],");
            sb.Append("[field_name],");
            sb.Append("[table_name] ");
            sb.Append(" ) values ( ");
            sb.Append("@ParticipantId,");
            sb.Append("@FieldName,");
            sb.Append("@TableName ) ");

            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@ParticipantId", entity.ParticipantId);
            paramList.Add("@FieldName", entity.FieldName);
            paramList.Add("@TableName", entity.TableName);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one ParticipantField to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, ParticipantFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [participant_field] (");
            sb.Append("[participant_id],");
            sb.Append("[field_name],");
            sb.Append("[table_name] ");
            sb.Append(" ) values ( ");
            sb.Append("@ParticipantId,");
            sb.Append("@FieldName,");
            sb.Append("@TableName ) ");

            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@ParticipantId", entity.ParticipantId);
            paramList.Add("@FieldName", entity.FieldName);
            paramList.Add("@TableName", entity.TableName);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :participant_id/
        /// </summary>
        public override void Update(string connection_string, ParticipantFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [participant_field] set ");
            sb.Append("[field_name] = @FieldName, ");
            sb.Append("[table_name] = @TableName ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@FieldName", entity.FieldName);
            paramList.Add("@TableName", entity.TableName);
            paramList.Add("@ParticipantId", entity.ParticipantId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :participant_id/
        /// </summary>
        public override void Update(SqlConnection connection, ParticipantFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [participant_field] set ");
            sb.Append("[field_name] = @FieldName, ");
            sb.Append("[table_name] = @TableName ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@FieldName", entity.FieldName);
            paramList.Add("@TableName", entity.TableName);
            paramList.Add("@ParticipantId", entity.ParticipantId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :participant_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, ParticipantFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [participant_field] set ");
            sb.Append("[field_name] = @FieldName, ");
            sb.Append("[table_name] = @TableName ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@FieldName", entity.FieldName);
            paramList.Add("@TableName", entity.TableName);
            paramList.Add("@ParticipantId", entity.ParticipantId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :participant_id/
        /// </summary>
        public override void Delete(string connection_string, ParticipantFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [participant_field] ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ParticipantId", entity.ParticipantId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :participant_id/
        /// </summary>
        public override void Delete(SqlConnection connection, ParticipantFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [participant_field] ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ParticipantId", entity.ParticipantId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :participant_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, ParticipantFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [participant_field] ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ParticipantId", entity.ParticipantId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to ParticipantField
        /// warning: this row must include all the columns of table(participant_field)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(participant_field)</param>
        /// <returns>an entity of ParticipantField</returns>
        public void FillEntityByRow(ParticipantFieldInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("participant_id"))
            {
                entity.ParticipantId = (string)row["participant_id"];
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
        /// convert one row to ParticipantField
        /// warning: this row must include all the columns of table(participant_field)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(participant_field)</param>
        /// <returns>an entity of ParticipantField</returns>
        public override ParticipantFieldInfo Row2Entity(System.Data.DataRow row)
        {
            ParticipantFieldInfo entity = new ParticipantFieldInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override ParticipantFieldInfo Retrieve(SqlTransaction transaction, ParticipantFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [participant_field] ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ParticipantId", entity.ParticipantId);

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
        public override ParticipantFieldInfo Retrieve(SqlConnection connection, ParticipantFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [participant_field] ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ParticipantId", entity.ParticipantId);

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
        public override ParticipantFieldInfo Retrieve(string connection_string, ParticipantFieldInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [participant_field] ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ParticipantId", entity.ParticipantId);

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
