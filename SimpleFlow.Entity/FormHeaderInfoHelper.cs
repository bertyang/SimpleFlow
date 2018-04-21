using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class FormHeaderInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<FormHeaderInfo>
    {
        public FormHeaderInfoHelper()
        {
        }

        /// <summary>
        ///  insert one FormHeader to database 
        /// </summary>
        public override void Insert(string connection_string, FormHeaderInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [form_header] (");
            sb.Append("[form_header_id],");
            sb.Append("[form_no],");
            sb.Append("[form_id],");
            sb.Append("[form_status],");
            sb.Append("[begin_date],");
            sb.Append("[end_date],");
            sb.Append("[applyer],");
            sb.Append("[filler] ");
            sb.Append(" ) values ( ");
            sb.Append("@FormHeaderId,");
            sb.Append("@FormNo,");
            sb.Append("@FormId,");
            sb.Append("@FormStatus,");
            sb.Append("@BeginDate,");
            sb.Append("@EndDate,");
            sb.Append("@Applyer,");
            sb.Append("@Filler ) ");

            ParameterBuilder paramList = new ParameterBuilder(8);
            paramList.Add("@FormHeaderId", entity.FormHeaderId);
            paramList.Add("@FormNo", entity.FormNo);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@FormStatus", entity.FormStatus);
            paramList.Add("@BeginDate", entity.BeginDate);
            paramList.Add("@EndDate", entity.EndDate);
            paramList.Add("@Applyer", entity.Applyer);
            paramList.Add("@Filler", entity.Filler);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one FormHeader to database 
        /// </summary>
        public override void Insert(SqlConnection connection, FormHeaderInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [form_header] (");
            sb.Append("[form_header_id],");
            sb.Append("[form_no],");
            sb.Append("[form_id],");
            sb.Append("[form_status],");
            sb.Append("[begin_date],");
            sb.Append("[end_date],");
            sb.Append("[applyer],");
            sb.Append("[filler] ");
            sb.Append(" ) values ( ");
            sb.Append("@FormHeaderId,");
            sb.Append("@FormNo,");
            sb.Append("@FormId,");
            sb.Append("@FormStatus,");
            sb.Append("@BeginDate,");
            sb.Append("@EndDate,");
            sb.Append("@Applyer,");
            sb.Append("@Filler ) ");

            ParameterBuilder paramList = new ParameterBuilder(8);
            paramList.Add("@FormHeaderId", entity.FormHeaderId);
            paramList.Add("@FormNo", entity.FormNo);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@FormStatus", entity.FormStatus);
            paramList.Add("@BeginDate", entity.BeginDate);
            paramList.Add("@EndDate", entity.EndDate);
            paramList.Add("@Applyer", entity.Applyer);
            paramList.Add("@Filler", entity.Filler);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one FormHeader to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, FormHeaderInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [form_header] (");
            sb.Append("[form_header_id],");
            sb.Append("[form_no],");
            sb.Append("[form_id],");
            sb.Append("[form_status],");
            sb.Append("[begin_date],");
            sb.Append("[end_date],");
            sb.Append("[applyer],");
            sb.Append("[filler] ");
            sb.Append(" ) values ( ");
            sb.Append("@FormHeaderId,");
            sb.Append("@FormNo,");
            sb.Append("@FormId,");
            sb.Append("@FormStatus,");
            sb.Append("@BeginDate,");
            sb.Append("@EndDate,");
            sb.Append("@Applyer,");
            sb.Append("@Filler ) ");

            ParameterBuilder paramList = new ParameterBuilder(8);
            paramList.Add("@FormHeaderId", entity.FormHeaderId);
            paramList.Add("@FormNo", entity.FormNo);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@FormStatus", entity.FormStatus);
            paramList.Add("@BeginDate", entity.BeginDate);
            paramList.Add("@EndDate", entity.EndDate);
            paramList.Add("@Applyer", entity.Applyer);
            paramList.Add("@Filler", entity.Filler);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :form_header_id/
        /// </summary>
        public override void Update(string connection_string, FormHeaderInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [form_header] set ");
            sb.Append("[form_no] = @FormNo, ");
            sb.Append("[form_id] = @FormId, ");
            sb.Append("[form_status] = @FormStatus, ");
            sb.Append("[begin_date] = @BeginDate, ");
            sb.Append("[end_date] = @EndDate, ");
            sb.Append("[applyer] = @Applyer, ");
            sb.Append("[filler] = @Filler ");
            sb.Append("where [form_header_id] = @FormHeaderId ");
            ParameterBuilder paramList = new ParameterBuilder(8);
            paramList.Add("@FormNo", entity.FormNo);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@FormStatus", entity.FormStatus);
            paramList.Add("@BeginDate", entity.BeginDate);
            paramList.Add("@EndDate", entity.EndDate);
            paramList.Add("@Applyer", entity.Applyer);
            paramList.Add("@Filler", entity.Filler);
            paramList.Add("@FormHeaderId", entity.FormHeaderId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :form_header_id/
        /// </summary>
        public override void Update(SqlConnection connection, FormHeaderInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [form_header] set ");
            sb.Append("[form_no] = @FormNo, ");
            sb.Append("[form_id] = @FormId, ");
            sb.Append("[form_status] = @FormStatus, ");
            sb.Append("[begin_date] = @BeginDate, ");
            sb.Append("[end_date] = @EndDate, ");
            sb.Append("[applyer] = @Applyer, ");
            sb.Append("[filler] = @Filler ");
            sb.Append("where [form_header_id] = @FormHeaderId ");
            ParameterBuilder paramList = new ParameterBuilder(8);
            paramList.Add("@FormNo", entity.FormNo);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@FormStatus", entity.FormStatus);
            paramList.Add("@BeginDate", entity.BeginDate);
            paramList.Add("@EndDate", entity.EndDate);
            paramList.Add("@Applyer", entity.Applyer);
            paramList.Add("@Filler", entity.Filler);
            paramList.Add("@FormHeaderId", entity.FormHeaderId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :form_header_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, FormHeaderInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [form_header] set ");
            sb.Append("[form_no] = @FormNo, ");
            sb.Append("[form_id] = @FormId, ");
            sb.Append("[form_status] = @FormStatus, ");
            sb.Append("[begin_date] = @BeginDate, ");
            sb.Append("[end_date] = @EndDate, ");
            sb.Append("[applyer] = @Applyer, ");
            sb.Append("[filler] = @Filler ");
            sb.Append("where [form_header_id] = @FormHeaderId ");
            ParameterBuilder paramList = new ParameterBuilder(8);
            paramList.Add("@FormNo", entity.FormNo);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@FormStatus", entity.FormStatus);
            paramList.Add("@BeginDate", entity.BeginDate);
            paramList.Add("@EndDate", entity.EndDate);
            paramList.Add("@Applyer", entity.Applyer);
            paramList.Add("@Filler", entity.Filler);
            paramList.Add("@FormHeaderId", entity.FormHeaderId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :form_header_id/
        /// </summary>
        public override void Delete(string connection_string, FormHeaderInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [form_header] ");
            sb.Append("where [form_header_id] = @FormHeaderId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@FormHeaderId", entity.FormHeaderId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :form_header_id/
        /// </summary>
        public override void Delete(SqlConnection connection, FormHeaderInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [form_header] ");
            sb.Append("where [form_header_id] = @FormHeaderId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@FormHeaderId", entity.FormHeaderId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :form_header_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, FormHeaderInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [form_header] ");
            sb.Append("where [form_header_id] = @FormHeaderId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@FormHeaderId", entity.FormHeaderId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to FormHeader
        /// warning: this row must include all the columns of table(form_header)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(form_header)</param>
        /// <returns>an entity of FormHeader</returns>
        public void FillEntityByRow(FormHeaderInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("form_header_id"))
            {
                entity.FormHeaderId = (string)row["form_header_id"];
            }
            else
            {
            }
            if (!row.IsNull("form_no"))
            {
                entity.FormNo = (int)row["form_no"];
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
            if (!row.IsNull("form_status"))
            {
                entity.FormStatus = (string)row["form_status"];
            }
            else
            {
            }
            if (!row.IsNull("begin_date"))
            {
                entity.BeginDate = (System.DateTime)row["begin_date"];
            }
            else
            {
            }
            if (!row.IsNull("end_date"))
            {
                entity.EndDate = (System.DateTime)row["end_date"];
            }
            else
            {
            }
            if (!row.IsNull("applyer"))
            {
                entity.Applyer = (string)row["applyer"];
            }
            else
            {
            }
            if (!row.IsNull("filler"))
            {
                entity.Filler = (string)row["filler"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to FormHeader
        /// warning: this row must include all the columns of table(form_header)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(form_header)</param>
        /// <returns>an entity of FormHeader</returns>
        public override FormHeaderInfo Row2Entity(System.Data.DataRow row)
        {
            FormHeaderInfo entity = new FormHeaderInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override FormHeaderInfo Retrieve(SqlTransaction transaction, FormHeaderInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [form_header] ");
            sb.Append("where [form_header_id] = @FormHeaderId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@FormHeaderId", entity.FormHeaderId);

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
        public override FormHeaderInfo Retrieve(SqlConnection connection, FormHeaderInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [form_header] ");
            sb.Append("where [form_header_id] = @FormHeaderId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@FormHeaderId", entity.FormHeaderId);

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
        public override FormHeaderInfo Retrieve(string connection_string, FormHeaderInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [form_header] ");
            sb.Append("where [form_header_id] = @FormHeaderId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@FormHeaderId", entity.FormHeaderId);

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
