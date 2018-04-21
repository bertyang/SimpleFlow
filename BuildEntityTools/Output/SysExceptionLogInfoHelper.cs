using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class SysExceptionLogInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<SysExceptionLogInfo>
    {
        public SysExceptionLogInfoHelper()
        {
        }

        /// <summary>
        ///  insert one SysExceptionLog to database 
        /// </summary>
        public override void Insert(string connection_string, SysExceptionLogInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_exception_log] (");
            sb.Append("[log_id],");
            sb.Append("[log_type],");
            sb.Append("[user_id],");
            sb.Append("[log_time],");
            sb.Append("[description],");
            sb.Append("[error_url],");
            sb.Append("[http_context],");
            sb.Append("[ex_message],");
            sb.Append("[ex_data],");
            sb.Append("[ex_source],");
            sb.Append("[ex_stack_trace],");
            sb.Append("[ex_target_site],");
            sb.Append("[inner_message],");
            sb.Append("[inner_data],");
            sb.Append("[inner_source],");
            sb.Append("[inner_stack_trace],");
            sb.Append("[inner_target_site] ");
            sb.Append(" ) values ( ");
            sb.Append("@LogId,");
            sb.Append("@LogType,");
            sb.Append("@UserId,");
            sb.Append("@LogTime,");
            sb.Append("@Description,");
            sb.Append("@ErrorUrl,");
            sb.Append("@HttpContext,");
            sb.Append("@ExMessage,");
            sb.Append("@ExData,");
            sb.Append("@ExSource,");
            sb.Append("@ExStackTrace,");
            sb.Append("@ExTargetSite,");
            sb.Append("@InnerMessage,");
            sb.Append("@InnerData,");
            sb.Append("@InnerSource,");
            sb.Append("@InnerStackTrace,");
            sb.Append("@InnerTargetSite ) ");

            ParameterBuilder paramList = new ParameterBuilder(17);
            paramList.Add("@LogId", entity.LogId);
            paramList.Add("@LogType", entity.LogType);
            paramList.Add("@UserId", entity.UserId);
            paramList.Add("@LogTime", entity.LogTime);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@ErrorUrl", entity.ErrorUrl);
            paramList.Add("@HttpContext", entity.HttpContext);
            paramList.Add("@ExMessage", entity.ExMessage);
            paramList.Add("@ExData", entity.ExData);
            paramList.Add("@ExSource", entity.ExSource);
            paramList.Add("@ExStackTrace", entity.ExStackTrace);
            paramList.Add("@ExTargetSite", entity.ExTargetSite);
            paramList.Add("@InnerMessage", entity.InnerMessage);
            paramList.Add("@InnerData", entity.InnerData);
            paramList.Add("@InnerSource", entity.InnerSource);
            paramList.Add("@InnerStackTrace", entity.InnerStackTrace);
            paramList.Add("@InnerTargetSite", entity.InnerTargetSite);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysExceptionLog to database 
        /// </summary>
        public override void Insert(SqlConnection connection, SysExceptionLogInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_exception_log] (");
            sb.Append("[log_id],");
            sb.Append("[log_type],");
            sb.Append("[user_id],");
            sb.Append("[log_time],");
            sb.Append("[description],");
            sb.Append("[error_url],");
            sb.Append("[http_context],");
            sb.Append("[ex_message],");
            sb.Append("[ex_data],");
            sb.Append("[ex_source],");
            sb.Append("[ex_stack_trace],");
            sb.Append("[ex_target_site],");
            sb.Append("[inner_message],");
            sb.Append("[inner_data],");
            sb.Append("[inner_source],");
            sb.Append("[inner_stack_trace],");
            sb.Append("[inner_target_site] ");
            sb.Append(" ) values ( ");
            sb.Append("@LogId,");
            sb.Append("@LogType,");
            sb.Append("@UserId,");
            sb.Append("@LogTime,");
            sb.Append("@Description,");
            sb.Append("@ErrorUrl,");
            sb.Append("@HttpContext,");
            sb.Append("@ExMessage,");
            sb.Append("@ExData,");
            sb.Append("@ExSource,");
            sb.Append("@ExStackTrace,");
            sb.Append("@ExTargetSite,");
            sb.Append("@InnerMessage,");
            sb.Append("@InnerData,");
            sb.Append("@InnerSource,");
            sb.Append("@InnerStackTrace,");
            sb.Append("@InnerTargetSite ) ");

            ParameterBuilder paramList = new ParameterBuilder(17);
            paramList.Add("@LogId", entity.LogId);
            paramList.Add("@LogType", entity.LogType);
            paramList.Add("@UserId", entity.UserId);
            paramList.Add("@LogTime", entity.LogTime);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@ErrorUrl", entity.ErrorUrl);
            paramList.Add("@HttpContext", entity.HttpContext);
            paramList.Add("@ExMessage", entity.ExMessage);
            paramList.Add("@ExData", entity.ExData);
            paramList.Add("@ExSource", entity.ExSource);
            paramList.Add("@ExStackTrace", entity.ExStackTrace);
            paramList.Add("@ExTargetSite", entity.ExTargetSite);
            paramList.Add("@InnerMessage", entity.InnerMessage);
            paramList.Add("@InnerData", entity.InnerData);
            paramList.Add("@InnerSource", entity.InnerSource);
            paramList.Add("@InnerStackTrace", entity.InnerStackTrace);
            paramList.Add("@InnerTargetSite", entity.InnerTargetSite);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysExceptionLog to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, SysExceptionLogInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_exception_log] (");
            sb.Append("[log_id],");
            sb.Append("[log_type],");
            sb.Append("[user_id],");
            sb.Append("[log_time],");
            sb.Append("[description],");
            sb.Append("[error_url],");
            sb.Append("[http_context],");
            sb.Append("[ex_message],");
            sb.Append("[ex_data],");
            sb.Append("[ex_source],");
            sb.Append("[ex_stack_trace],");
            sb.Append("[ex_target_site],");
            sb.Append("[inner_message],");
            sb.Append("[inner_data],");
            sb.Append("[inner_source],");
            sb.Append("[inner_stack_trace],");
            sb.Append("[inner_target_site] ");
            sb.Append(" ) values ( ");
            sb.Append("@LogId,");
            sb.Append("@LogType,");
            sb.Append("@UserId,");
            sb.Append("@LogTime,");
            sb.Append("@Description,");
            sb.Append("@ErrorUrl,");
            sb.Append("@HttpContext,");
            sb.Append("@ExMessage,");
            sb.Append("@ExData,");
            sb.Append("@ExSource,");
            sb.Append("@ExStackTrace,");
            sb.Append("@ExTargetSite,");
            sb.Append("@InnerMessage,");
            sb.Append("@InnerData,");
            sb.Append("@InnerSource,");
            sb.Append("@InnerStackTrace,");
            sb.Append("@InnerTargetSite ) ");

            ParameterBuilder paramList = new ParameterBuilder(17);
            paramList.Add("@LogId", entity.LogId);
            paramList.Add("@LogType", entity.LogType);
            paramList.Add("@UserId", entity.UserId);
            paramList.Add("@LogTime", entity.LogTime);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@ErrorUrl", entity.ErrorUrl);
            paramList.Add("@HttpContext", entity.HttpContext);
            paramList.Add("@ExMessage", entity.ExMessage);
            paramList.Add("@ExData", entity.ExData);
            paramList.Add("@ExSource", entity.ExSource);
            paramList.Add("@ExStackTrace", entity.ExStackTrace);
            paramList.Add("@ExTargetSite", entity.ExTargetSite);
            paramList.Add("@InnerMessage", entity.InnerMessage);
            paramList.Add("@InnerData", entity.InnerData);
            paramList.Add("@InnerSource", entity.InnerSource);
            paramList.Add("@InnerStackTrace", entity.InnerStackTrace);
            paramList.Add("@InnerTargetSite", entity.InnerTargetSite);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :log_id/
        /// </summary>
        public override void Update(string connection_string, SysExceptionLogInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_exception_log] set ");
            sb.Append("[log_type] = @LogType, ");
            sb.Append("[user_id] = @UserId, ");
            sb.Append("[log_time] = @LogTime, ");
            sb.Append("[description] = @Description, ");
            sb.Append("[error_url] = @ErrorUrl, ");
            sb.Append("[http_context] = @HttpContext, ");
            sb.Append("[ex_message] = @ExMessage, ");
            sb.Append("[ex_data] = @ExData, ");
            sb.Append("[ex_source] = @ExSource, ");
            sb.Append("[ex_stack_trace] = @ExStackTrace, ");
            sb.Append("[ex_target_site] = @ExTargetSite, ");
            sb.Append("[inner_message] = @InnerMessage, ");
            sb.Append("[inner_data] = @InnerData, ");
            sb.Append("[inner_source] = @InnerSource, ");
            sb.Append("[inner_stack_trace] = @InnerStackTrace, ");
            sb.Append("[inner_target_site] = @InnerTargetSite ");
            sb.Append("where [log_id] = @LogId ");
            ParameterBuilder paramList = new ParameterBuilder(17);
            paramList.Add("@LogType", entity.LogType);
            paramList.Add("@UserId", entity.UserId);
            paramList.Add("@LogTime", entity.LogTime);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@ErrorUrl", entity.ErrorUrl);
            paramList.Add("@HttpContext", entity.HttpContext);
            paramList.Add("@ExMessage", entity.ExMessage);
            paramList.Add("@ExData", entity.ExData);
            paramList.Add("@ExSource", entity.ExSource);
            paramList.Add("@ExStackTrace", entity.ExStackTrace);
            paramList.Add("@ExTargetSite", entity.ExTargetSite);
            paramList.Add("@InnerMessage", entity.InnerMessage);
            paramList.Add("@InnerData", entity.InnerData);
            paramList.Add("@InnerSource", entity.InnerSource);
            paramList.Add("@InnerStackTrace", entity.InnerStackTrace);
            paramList.Add("@InnerTargetSite", entity.InnerTargetSite);
            paramList.Add("@LogId", entity.LogId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :log_id/
        /// </summary>
        public override void Update(SqlConnection connection, SysExceptionLogInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_exception_log] set ");
            sb.Append("[log_type] = @LogType, ");
            sb.Append("[user_id] = @UserId, ");
            sb.Append("[log_time] = @LogTime, ");
            sb.Append("[description] = @Description, ");
            sb.Append("[error_url] = @ErrorUrl, ");
            sb.Append("[http_context] = @HttpContext, ");
            sb.Append("[ex_message] = @ExMessage, ");
            sb.Append("[ex_data] = @ExData, ");
            sb.Append("[ex_source] = @ExSource, ");
            sb.Append("[ex_stack_trace] = @ExStackTrace, ");
            sb.Append("[ex_target_site] = @ExTargetSite, ");
            sb.Append("[inner_message] = @InnerMessage, ");
            sb.Append("[inner_data] = @InnerData, ");
            sb.Append("[inner_source] = @InnerSource, ");
            sb.Append("[inner_stack_trace] = @InnerStackTrace, ");
            sb.Append("[inner_target_site] = @InnerTargetSite ");
            sb.Append("where [log_id] = @LogId ");
            ParameterBuilder paramList = new ParameterBuilder(17);
            paramList.Add("@LogType", entity.LogType);
            paramList.Add("@UserId", entity.UserId);
            paramList.Add("@LogTime", entity.LogTime);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@ErrorUrl", entity.ErrorUrl);
            paramList.Add("@HttpContext", entity.HttpContext);
            paramList.Add("@ExMessage", entity.ExMessage);
            paramList.Add("@ExData", entity.ExData);
            paramList.Add("@ExSource", entity.ExSource);
            paramList.Add("@ExStackTrace", entity.ExStackTrace);
            paramList.Add("@ExTargetSite", entity.ExTargetSite);
            paramList.Add("@InnerMessage", entity.InnerMessage);
            paramList.Add("@InnerData", entity.InnerData);
            paramList.Add("@InnerSource", entity.InnerSource);
            paramList.Add("@InnerStackTrace", entity.InnerStackTrace);
            paramList.Add("@InnerTargetSite", entity.InnerTargetSite);
            paramList.Add("@LogId", entity.LogId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :log_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, SysExceptionLogInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_exception_log] set ");
            sb.Append("[log_type] = @LogType, ");
            sb.Append("[user_id] = @UserId, ");
            sb.Append("[log_time] = @LogTime, ");
            sb.Append("[description] = @Description, ");
            sb.Append("[error_url] = @ErrorUrl, ");
            sb.Append("[http_context] = @HttpContext, ");
            sb.Append("[ex_message] = @ExMessage, ");
            sb.Append("[ex_data] = @ExData, ");
            sb.Append("[ex_source] = @ExSource, ");
            sb.Append("[ex_stack_trace] = @ExStackTrace, ");
            sb.Append("[ex_target_site] = @ExTargetSite, ");
            sb.Append("[inner_message] = @InnerMessage, ");
            sb.Append("[inner_data] = @InnerData, ");
            sb.Append("[inner_source] = @InnerSource, ");
            sb.Append("[inner_stack_trace] = @InnerStackTrace, ");
            sb.Append("[inner_target_site] = @InnerTargetSite ");
            sb.Append("where [log_id] = @LogId ");
            ParameterBuilder paramList = new ParameterBuilder(17);
            paramList.Add("@LogType", entity.LogType);
            paramList.Add("@UserId", entity.UserId);
            paramList.Add("@LogTime", entity.LogTime);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@ErrorUrl", entity.ErrorUrl);
            paramList.Add("@HttpContext", entity.HttpContext);
            paramList.Add("@ExMessage", entity.ExMessage);
            paramList.Add("@ExData", entity.ExData);
            paramList.Add("@ExSource", entity.ExSource);
            paramList.Add("@ExStackTrace", entity.ExStackTrace);
            paramList.Add("@ExTargetSite", entity.ExTargetSite);
            paramList.Add("@InnerMessage", entity.InnerMessage);
            paramList.Add("@InnerData", entity.InnerData);
            paramList.Add("@InnerSource", entity.InnerSource);
            paramList.Add("@InnerStackTrace", entity.InnerStackTrace);
            paramList.Add("@InnerTargetSite", entity.InnerTargetSite);
            paramList.Add("@LogId", entity.LogId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :log_id/
        /// </summary>
        public override void Delete(string connection_string, SysExceptionLogInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_exception_log] ");
            sb.Append("where [log_id] = @LogId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@LogId", entity.LogId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :log_id/
        /// </summary>
        public override void Delete(SqlConnection connection, SysExceptionLogInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_exception_log] ");
            sb.Append("where [log_id] = @LogId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@LogId", entity.LogId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :log_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, SysExceptionLogInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_exception_log] ");
            sb.Append("where [log_id] = @LogId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@LogId", entity.LogId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to SysExceptionLog
        /// warning: this row must include all the columns of table(sys_exception_log)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_exception_log)</param>
        /// <returns>an entity of SysExceptionLog</returns>
        public void FillEntityByRow(SysExceptionLogInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("log_id"))
            {
                entity.LogId = (string)row["log_id"];
            }
            else
            {
            }
            if (!row.IsNull("log_type"))
            {
                entity.LogType = (string)row["log_type"];
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
            if (!row.IsNull("log_time"))
            {
                entity.LogTime = (System.DateTime)row["log_time"];
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
            if (!row.IsNull("error_url"))
            {
                entity.ErrorUrl = (string)row["error_url"];
            }
            else
            {
            }
            if (!row.IsNull("http_context"))
            {
                entity.HttpContext = (string)row["http_context"];
            }
            else
            {
            }
            if (!row.IsNull("ex_message"))
            {
                entity.ExMessage = (string)row["ex_message"];
            }
            else
            {
            }
            if (!row.IsNull("ex_data"))
            {
                entity.ExData = (string)row["ex_data"];
            }
            else
            {
            }
            if (!row.IsNull("ex_source"))
            {
                entity.ExSource = (string)row["ex_source"];
            }
            else
            {
            }
            if (!row.IsNull("ex_stack_trace"))
            {
                entity.ExStackTrace = (string)row["ex_stack_trace"];
            }
            else
            {
            }
            if (!row.IsNull("ex_target_site"))
            {
                entity.ExTargetSite = (string)row["ex_target_site"];
            }
            else
            {
            }
            if (!row.IsNull("inner_message"))
            {
                entity.InnerMessage = (string)row["inner_message"];
            }
            else
            {
            }
            if (!row.IsNull("inner_data"))
            {
                entity.InnerData = (string)row["inner_data"];
            }
            else
            {
            }
            if (!row.IsNull("inner_source"))
            {
                entity.InnerSource = (string)row["inner_source"];
            }
            else
            {
            }
            if (!row.IsNull("inner_stack_trace"))
            {
                entity.InnerStackTrace = (string)row["inner_stack_trace"];
            }
            else
            {
            }
            if (!row.IsNull("inner_target_site"))
            {
                entity.InnerTargetSite = (string)row["inner_target_site"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to SysExceptionLog
        /// warning: this row must include all the columns of table(sys_exception_log)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_exception_log)</param>
        /// <returns>an entity of SysExceptionLog</returns>
        public override SysExceptionLogInfo Row2Entity(System.Data.DataRow row)
        {
            SysExceptionLogInfo entity = new SysExceptionLogInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysExceptionLogInfo Retrieve(SqlTransaction transaction, SysExceptionLogInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_exception_log] ");
            sb.Append("where [log_id] = @LogId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@LogId", entity.LogId);

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
        public override SysExceptionLogInfo Retrieve(SqlConnection connection, SysExceptionLogInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_exception_log] ");
            sb.Append("where [log_id] = @LogId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@LogId", entity.LogId);

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
        public override SysExceptionLogInfo Retrieve(string connection_string, SysExceptionLogInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_exception_log] ");
            sb.Append("where [log_id] = @LogId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@LogId", entity.LogId);

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
