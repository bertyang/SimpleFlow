using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class SysAttachmentInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<SysAttachmentInfo>
    {
        public SysAttachmentInfoHelper()
        {
        }

        /// <summary>
        ///  insert one SysAttachment to database 
        /// </summary>
        public override void Insert(string connection_string, SysAttachmentInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_attachment] (");
            sb.Append("[attachment_id],");
            sb.Append("[original_file_name],");
            sb.Append("[path_id],");
            sb.Append("[current_file_dir],");
            sb.Append("[current_file_name],");
            sb.Append("[file_size],");
            sb.Append("[upload_time],");
            sb.Append("[upload_user],");
            sb.Append("[content_type],");
            sb.Append("[file_extension] ");
            sb.Append(" ) values ( ");
            sb.Append("@AttachmentId,");
            sb.Append("@OriginalFileName,");
            sb.Append("@PathId,");
            sb.Append("@CurrentFileDir,");
            sb.Append("@CurrentFileName,");
            sb.Append("@FileSize,");
            sb.Append("@UploadTime,");
            sb.Append("@UploadUser,");
            sb.Append("@ContentType,");
            sb.Append("@FileExtension ) ");

            ParameterBuilder paramList = new ParameterBuilder(10);
            paramList.Add("@AttachmentId", entity.AttachmentId);
            paramList.Add("@OriginalFileName", entity.OriginalFileName);
            paramList.Add("@PathId", entity.PathId);
            paramList.Add("@CurrentFileDir", entity.CurrentFileDir);
            paramList.Add("@CurrentFileName", entity.CurrentFileName);
            paramList.Add("@FileSize", entity.FileSize);
            paramList.Add("@UploadTime", entity.UploadTime);
            paramList.Add("@UploadUser", entity.UploadUser);
            paramList.Add("@ContentType", entity.ContentType);
            paramList.Add("@FileExtension", entity.FileExtension);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysAttachment to database 
        /// </summary>
        public override void Insert(SqlConnection connection, SysAttachmentInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_attachment] (");
            sb.Append("[attachment_id],");
            sb.Append("[original_file_name],");
            sb.Append("[path_id],");
            sb.Append("[current_file_dir],");
            sb.Append("[current_file_name],");
            sb.Append("[file_size],");
            sb.Append("[upload_time],");
            sb.Append("[upload_user],");
            sb.Append("[content_type],");
            sb.Append("[file_extension] ");
            sb.Append(" ) values ( ");
            sb.Append("@AttachmentId,");
            sb.Append("@OriginalFileName,");
            sb.Append("@PathId,");
            sb.Append("@CurrentFileDir,");
            sb.Append("@CurrentFileName,");
            sb.Append("@FileSize,");
            sb.Append("@UploadTime,");
            sb.Append("@UploadUser,");
            sb.Append("@ContentType,");
            sb.Append("@FileExtension ) ");

            ParameterBuilder paramList = new ParameterBuilder(10);
            paramList.Add("@AttachmentId", entity.AttachmentId);
            paramList.Add("@OriginalFileName", entity.OriginalFileName);
            paramList.Add("@PathId", entity.PathId);
            paramList.Add("@CurrentFileDir", entity.CurrentFileDir);
            paramList.Add("@CurrentFileName", entity.CurrentFileName);
            paramList.Add("@FileSize", entity.FileSize);
            paramList.Add("@UploadTime", entity.UploadTime);
            paramList.Add("@UploadUser", entity.UploadUser);
            paramList.Add("@ContentType", entity.ContentType);
            paramList.Add("@FileExtension", entity.FileExtension);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysAttachment to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, SysAttachmentInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_attachment] (");
            sb.Append("[attachment_id],");
            sb.Append("[original_file_name],");
            sb.Append("[path_id],");
            sb.Append("[current_file_dir],");
            sb.Append("[current_file_name],");
            sb.Append("[file_size],");
            sb.Append("[upload_time],");
            sb.Append("[upload_user],");
            sb.Append("[content_type],");
            sb.Append("[file_extension] ");
            sb.Append(" ) values ( ");
            sb.Append("@AttachmentId,");
            sb.Append("@OriginalFileName,");
            sb.Append("@PathId,");
            sb.Append("@CurrentFileDir,");
            sb.Append("@CurrentFileName,");
            sb.Append("@FileSize,");
            sb.Append("@UploadTime,");
            sb.Append("@UploadUser,");
            sb.Append("@ContentType,");
            sb.Append("@FileExtension ) ");

            ParameterBuilder paramList = new ParameterBuilder(10);
            paramList.Add("@AttachmentId", entity.AttachmentId);
            paramList.Add("@OriginalFileName", entity.OriginalFileName);
            paramList.Add("@PathId", entity.PathId);
            paramList.Add("@CurrentFileDir", entity.CurrentFileDir);
            paramList.Add("@CurrentFileName", entity.CurrentFileName);
            paramList.Add("@FileSize", entity.FileSize);
            paramList.Add("@UploadTime", entity.UploadTime);
            paramList.Add("@UploadUser", entity.UploadUser);
            paramList.Add("@ContentType", entity.ContentType);
            paramList.Add("@FileExtension", entity.FileExtension);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :attachment_id/
        /// </summary>
        public override void Update(string connection_string, SysAttachmentInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_attachment] set ");
            sb.Append("[original_file_name] = @OriginalFileName, ");
            sb.Append("[path_id] = @PathId, ");
            sb.Append("[current_file_dir] = @CurrentFileDir, ");
            sb.Append("[current_file_name] = @CurrentFileName, ");
            sb.Append("[file_size] = @FileSize, ");
            sb.Append("[upload_time] = @UploadTime, ");
            sb.Append("[upload_user] = @UploadUser, ");
            sb.Append("[content_type] = @ContentType, ");
            sb.Append("[file_extension] = @FileExtension ");
            sb.Append("where [attachment_id] = @AttachmentId ");
            ParameterBuilder paramList = new ParameterBuilder(10);
            paramList.Add("@OriginalFileName", entity.OriginalFileName);
            paramList.Add("@PathId", entity.PathId);
            paramList.Add("@CurrentFileDir", entity.CurrentFileDir);
            paramList.Add("@CurrentFileName", entity.CurrentFileName);
            paramList.Add("@FileSize", entity.FileSize);
            paramList.Add("@UploadTime", entity.UploadTime);
            paramList.Add("@UploadUser", entity.UploadUser);
            paramList.Add("@ContentType", entity.ContentType);
            paramList.Add("@FileExtension", entity.FileExtension);
            paramList.Add("@AttachmentId", entity.AttachmentId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :attachment_id/
        /// </summary>
        public override void Update(SqlConnection connection, SysAttachmentInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_attachment] set ");
            sb.Append("[original_file_name] = @OriginalFileName, ");
            sb.Append("[path_id] = @PathId, ");
            sb.Append("[current_file_dir] = @CurrentFileDir, ");
            sb.Append("[current_file_name] = @CurrentFileName, ");
            sb.Append("[file_size] = @FileSize, ");
            sb.Append("[upload_time] = @UploadTime, ");
            sb.Append("[upload_user] = @UploadUser, ");
            sb.Append("[content_type] = @ContentType, ");
            sb.Append("[file_extension] = @FileExtension ");
            sb.Append("where [attachment_id] = @AttachmentId ");
            ParameterBuilder paramList = new ParameterBuilder(10);
            paramList.Add("@OriginalFileName", entity.OriginalFileName);
            paramList.Add("@PathId", entity.PathId);
            paramList.Add("@CurrentFileDir", entity.CurrentFileDir);
            paramList.Add("@CurrentFileName", entity.CurrentFileName);
            paramList.Add("@FileSize", entity.FileSize);
            paramList.Add("@UploadTime", entity.UploadTime);
            paramList.Add("@UploadUser", entity.UploadUser);
            paramList.Add("@ContentType", entity.ContentType);
            paramList.Add("@FileExtension", entity.FileExtension);
            paramList.Add("@AttachmentId", entity.AttachmentId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :attachment_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, SysAttachmentInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_attachment] set ");
            sb.Append("[original_file_name] = @OriginalFileName, ");
            sb.Append("[path_id] = @PathId, ");
            sb.Append("[current_file_dir] = @CurrentFileDir, ");
            sb.Append("[current_file_name] = @CurrentFileName, ");
            sb.Append("[file_size] = @FileSize, ");
            sb.Append("[upload_time] = @UploadTime, ");
            sb.Append("[upload_user] = @UploadUser, ");
            sb.Append("[content_type] = @ContentType, ");
            sb.Append("[file_extension] = @FileExtension ");
            sb.Append("where [attachment_id] = @AttachmentId ");
            ParameterBuilder paramList = new ParameterBuilder(10);
            paramList.Add("@OriginalFileName", entity.OriginalFileName);
            paramList.Add("@PathId", entity.PathId);
            paramList.Add("@CurrentFileDir", entity.CurrentFileDir);
            paramList.Add("@CurrentFileName", entity.CurrentFileName);
            paramList.Add("@FileSize", entity.FileSize);
            paramList.Add("@UploadTime", entity.UploadTime);
            paramList.Add("@UploadUser", entity.UploadUser);
            paramList.Add("@ContentType", entity.ContentType);
            paramList.Add("@FileExtension", entity.FileExtension);
            paramList.Add("@AttachmentId", entity.AttachmentId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :attachment_id/
        /// </summary>
        public override void Delete(string connection_string, SysAttachmentInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_attachment] ");
            sb.Append("where [attachment_id] = @AttachmentId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@AttachmentId", entity.AttachmentId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :attachment_id/
        /// </summary>
        public override void Delete(SqlConnection connection, SysAttachmentInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_attachment] ");
            sb.Append("where [attachment_id] = @AttachmentId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@AttachmentId", entity.AttachmentId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :attachment_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, SysAttachmentInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_attachment] ");
            sb.Append("where [attachment_id] = @AttachmentId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@AttachmentId", entity.AttachmentId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to SysAttachment
        /// warning: this row must include all the columns of table(sys_attachment)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_attachment)</param>
        /// <returns>an entity of SysAttachment</returns>
        public void FillEntityByRow(SysAttachmentInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("attachment_id"))
            {
                entity.AttachmentId = (string)row["attachment_id"];
            }
            else
            {
            }
            if (!row.IsNull("original_file_name"))
            {
                entity.OriginalFileName = (string)row["original_file_name"];
            }
            else
            {
            }
            if (!row.IsNull("path_id"))
            {
                entity.PathId = (int)row["path_id"];
            }
            else
            {
            }
            if (!row.IsNull("current_file_dir"))
            {
                entity.CurrentFileDir = (string)row["current_file_dir"];
            }
            else
            {
            }
            if (!row.IsNull("current_file_name"))
            {
                entity.CurrentFileName = (string)row["current_file_name"];
            }
            else
            {
            }
            if (!row.IsNull("file_size"))
            {
                entity.FileSize = (int)row["file_size"];
            }
            else
            {
            }
            if (!row.IsNull("upload_time"))
            {
                entity.UploadTime = (System.DateTime)row["upload_time"];
            }
            else
            {
            }
            if (!row.IsNull("upload_user"))
            {
                entity.UploadUser = (string)row["upload_user"];
            }
            else
            {
            }
            if (!row.IsNull("content_type"))
            {
                entity.ContentType = (string)row["content_type"];
            }
            else
            {
            }
            if (!row.IsNull("file_extension"))
            {
                entity.FileExtension = (string)row["file_extension"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to SysAttachment
        /// warning: this row must include all the columns of table(sys_attachment)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_attachment)</param>
        /// <returns>an entity of SysAttachment</returns>
        public override SysAttachmentInfo Row2Entity(System.Data.DataRow row)
        {
            SysAttachmentInfo entity = new SysAttachmentInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysAttachmentInfo Retrieve(SqlTransaction transaction, SysAttachmentInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_attachment] ");
            sb.Append("where [attachment_id] = @AttachmentId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
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
        public override SysAttachmentInfo Retrieve(SqlConnection connection, SysAttachmentInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_attachment] ");
            sb.Append("where [attachment_id] = @AttachmentId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
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
        public override SysAttachmentInfo Retrieve(string connection_string, SysAttachmentInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_attachment] ");
            sb.Append("where [attachment_id] = @AttachmentId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
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
