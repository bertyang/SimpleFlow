using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class SysBatchUploadHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<SysBatchUpload>
    {
        public SysBatchUploadHelper()
        {
        }

        /// <summary>
        ///  insert one SysBatchUpload to database 
        /// </summary>
        public override void Insert(string connection_string, SysBatchUpload entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_batch_upload] (");
            sb.Append("[batch_id],");
            sb.Append("[attachment_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@BatchId,");
            sb.Append("@AttachmentId ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@BatchId", entity.BatchId);
            paramList.Add("@AttachmentId", entity.AttachmentId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysBatchUpload to database 
        /// </summary>
        public override void Insert(SqlConnection connection, SysBatchUpload entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_batch_upload] (");
            sb.Append("[batch_id],");
            sb.Append("[attachment_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@BatchId,");
            sb.Append("@AttachmentId ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@BatchId", entity.BatchId);
            paramList.Add("@AttachmentId", entity.AttachmentId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysBatchUpload to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, SysBatchUpload entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_batch_upload] (");
            sb.Append("[batch_id],");
            sb.Append("[attachment_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@BatchId,");
            sb.Append("@AttachmentId ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@BatchId", entity.BatchId);
            paramList.Add("@AttachmentId", entity.AttachmentId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :batch_id/attachment_id/
        /// </summary>
        public override void Update(string connection_string, SysBatchUpload entity)
        {
            // all column is primary key, need do nothing 
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :batch_id/attachment_id/
        /// </summary>
        public override void Update(SqlConnection connection, SysBatchUpload entity)
        {
            // all column is primary key, need do nothing 
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :batch_id/attachment_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, SysBatchUpload entity)
        {
            // all column is primary key, need do nothing 
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :batch_id/attachment_id/
        /// </summary>
        public override void Delete(string connection_string, SysBatchUpload entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_batch_upload] ");
            sb.Append("where [batch_id] = @BatchId ");
            sb.Append("and [attachment_id] = @AttachmentId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@BatchId", entity.BatchId);
            paramList.Add("@AttachmentId", entity.AttachmentId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :batch_id/attachment_id/
        /// </summary>
        public override void Delete(SqlConnection connection, SysBatchUpload entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_batch_upload] ");
            sb.Append("where [batch_id] = @BatchId ");
            sb.Append("and [attachment_id] = @AttachmentId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@BatchId", entity.BatchId);
            paramList.Add("@AttachmentId", entity.AttachmentId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :batch_id/attachment_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, SysBatchUpload entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_batch_upload] ");
            sb.Append("where [batch_id] = @BatchId ");
            sb.Append("and [attachment_id] = @AttachmentId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@BatchId", entity.BatchId);
            paramList.Add("@AttachmentId", entity.AttachmentId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to SysBatchUpload
        /// warning: this row must include all the columns of table(sys_batch_upload)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_batch_upload)</param>
        /// <returns>an entity of SysBatchUpload</returns>
        public void FillEntityByRow(SysBatchUpload entity, System.Data.DataRow row)
        {
            if (!row.IsNull("batch_id"))
            {
                entity.BatchId = (string)row["batch_id"];
            }
            else
            {
            }
            if (!row.IsNull("attachment_id"))
            {
                entity.AttachmentId = (string)row["attachment_id"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to SysBatchUpload
        /// warning: this row must include all the columns of table(sys_batch_upload)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_batch_upload)</param>
        /// <returns>an entity of SysBatchUpload</returns>
        public override SysBatchUpload Row2Entity(System.Data.DataRow row)
        {
            SysBatchUpload entity = new SysBatchUpload();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysBatchUpload Retrieve(SqlTransaction transaction, SysBatchUpload entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_batch_upload] ");
            sb.Append("where [batch_id] = @BatchId ");
            sb.Append("and [attachment_id] = @AttachmentId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@BatchId", entity.BatchId);
            paramList.Add("@AttachmentId", entity.AttachmentId);

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
        public override SysBatchUpload Retrieve(SqlConnection connection, SysBatchUpload entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_batch_upload] ");
            sb.Append("where [batch_id] = @BatchId ");
            sb.Append("and [attachment_id] = @AttachmentId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@BatchId", entity.BatchId);
            paramList.Add("@AttachmentId", entity.AttachmentId);

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
        public override SysBatchUpload Retrieve(string connection_string, SysBatchUpload entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_batch_upload] ");
            sb.Append("where [batch_id] = @BatchId ");
            sb.Append("and [attachment_id] = @AttachmentId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@BatchId", entity.BatchId);
            paramList.Add("@AttachmentId", entity.AttachmentId);

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
