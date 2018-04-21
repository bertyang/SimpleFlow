using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class SysDocPathHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<SysDocPath>
    {
        public SysDocPathHelper()
        {
        }

        /// <summary>
        ///  insert one SysDocPath to database 
        /// </summary>
        public override void Insert(string connection_string, SysDocPath entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_doc_path] (");
            sb.Append("[path_id],");
            sb.Append("[site_serial],");
            sb.Append("[doc_path] ");
            sb.Append(" ) values ( ");
            sb.Append("@PathId,");
            sb.Append("@SiteSerial,");
            sb.Append("@DocPath ) ");

            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@PathId", entity.PathId);
            paramList.Add("@SiteSerial", entity.SiteSerial);
            paramList.Add("@DocPath", entity.DocPath);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysDocPath to database 
        /// </summary>
        public override void Insert(SqlConnection connection, SysDocPath entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_doc_path] (");
            sb.Append("[path_id],");
            sb.Append("[site_serial],");
            sb.Append("[doc_path] ");
            sb.Append(" ) values ( ");
            sb.Append("@PathId,");
            sb.Append("@SiteSerial,");
            sb.Append("@DocPath ) ");

            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@PathId", entity.PathId);
            paramList.Add("@SiteSerial", entity.SiteSerial);
            paramList.Add("@DocPath", entity.DocPath);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysDocPath to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, SysDocPath entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_doc_path] (");
            sb.Append("[path_id],");
            sb.Append("[site_serial],");
            sb.Append("[doc_path] ");
            sb.Append(" ) values ( ");
            sb.Append("@PathId,");
            sb.Append("@SiteSerial,");
            sb.Append("@DocPath ) ");

            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@PathId", entity.PathId);
            paramList.Add("@SiteSerial", entity.SiteSerial);
            paramList.Add("@DocPath", entity.DocPath);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :path_id/
        /// </summary>
        public override void Update(string connection_string, SysDocPath entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_doc_path] set ");
            sb.Append("[site_serial] = @SiteSerial, ");
            sb.Append("[doc_path] = @DocPath ");
            sb.Append("where [path_id] = @PathId ");
            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@SiteSerial", entity.SiteSerial);
            paramList.Add("@DocPath", entity.DocPath);
            paramList.Add("@PathId", entity.PathId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :path_id/
        /// </summary>
        public override void Update(SqlConnection connection, SysDocPath entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_doc_path] set ");
            sb.Append("[site_serial] = @SiteSerial, ");
            sb.Append("[doc_path] = @DocPath ");
            sb.Append("where [path_id] = @PathId ");
            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@SiteSerial", entity.SiteSerial);
            paramList.Add("@DocPath", entity.DocPath);
            paramList.Add("@PathId", entity.PathId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :path_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, SysDocPath entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_doc_path] set ");
            sb.Append("[site_serial] = @SiteSerial, ");
            sb.Append("[doc_path] = @DocPath ");
            sb.Append("where [path_id] = @PathId ");
            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@SiteSerial", entity.SiteSerial);
            paramList.Add("@DocPath", entity.DocPath);
            paramList.Add("@PathId", entity.PathId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :path_id/
        /// </summary>
        public override void Delete(string connection_string, SysDocPath entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_doc_path] ");
            sb.Append("where [path_id] = @PathId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@PathId", entity.PathId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :path_id/
        /// </summary>
        public override void Delete(SqlConnection connection, SysDocPath entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_doc_path] ");
            sb.Append("where [path_id] = @PathId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@PathId", entity.PathId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :path_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, SysDocPath entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_doc_path] ");
            sb.Append("where [path_id] = @PathId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@PathId", entity.PathId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to SysDocPath
        /// warning: this row must include all the columns of table(sys_doc_path)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_doc_path)</param>
        /// <returns>an entity of SysDocPath</returns>
        public void FillEntityByRow(SysDocPath entity, System.Data.DataRow row)
        {
            if (!row.IsNull("path_id"))
            {
                entity.PathId = (int)row["path_id"];
            }
            else
            {
            }
            if (!row.IsNull("site_serial"))
            {
                entity.SiteSerial = (int)row["site_serial"];
            }
            else
            {
            }
            if (!row.IsNull("doc_path"))
            {
                entity.DocPath = (string)row["doc_path"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to SysDocPath
        /// warning: this row must include all the columns of table(sys_doc_path)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_doc_path)</param>
        /// <returns>an entity of SysDocPath</returns>
        public override SysDocPath Row2Entity(System.Data.DataRow row)
        {
            SysDocPath entity = new SysDocPath();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysDocPath Retrieve(SqlTransaction transaction, SysDocPath entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_doc_path] ");
            sb.Append("where [path_id] = @PathId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@PathId", entity.PathId);

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
        public override SysDocPath Retrieve(SqlConnection connection, SysDocPath entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_doc_path] ");
            sb.Append("where [path_id] = @PathId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@PathId", entity.PathId);

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
        public override SysDocPath Retrieve(string connection_string, SysDocPath entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_doc_path] ");
            sb.Append("where [path_id] = @PathId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@PathId", entity.PathId);

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
