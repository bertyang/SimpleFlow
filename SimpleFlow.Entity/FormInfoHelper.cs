using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class FormInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<FormInfo>
    {
        public FormInfoHelper()
        {
        }

        /// <summary>
        ///  insert one Form to database 
        /// </summary>
        public override void Insert(string connection_string, FormInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [form] (");
            sb.Append("[form_id],");
            sb.Append("[form_name],");
            sb.Append("[flower_form_kind],");
            sb.Append("[apply_url],");
            sb.Append("[view_url],");
            sb.Append("[modify_url],");
            sb.Append("[chek_in_url],");
            sb.Append("[ver_back_url],");
            sb.Append("[main_table],");
            sb.Append("[form_no_column],");
            sb.Append("[part_no_column],");
            sb.Append("[flow_xml] ");
            sb.Append(" ) values ( ");
            sb.Append("@FormId,");
            sb.Append("@FormName,");
            sb.Append("@FlowerFormKind,");
            sb.Append("@ApplyUrl,");
            sb.Append("@ViewUrl,");
            sb.Append("@ModifyUrl,");
            sb.Append("@ChekInUrl,");
            sb.Append("@VerBackUrl,");
            sb.Append("@MainTable,");
            sb.Append("@FormNoColumn,");
            sb.Append("@PartNoColumn,");
            sb.Append("@FlowXml ) ");

            ParameterBuilder paramList = new ParameterBuilder(12);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@FormName", entity.FormName);
            paramList.Add("@FlowerFormKind", entity.FlowerFormKind);
            paramList.Add("@ApplyUrl", entity.ApplyUrl);
            paramList.Add("@ViewUrl", entity.ViewUrl);
            paramList.Add("@ModifyUrl", entity.ModifyUrl);
            paramList.Add("@ChekInUrl", entity.ChekInUrl);
            paramList.Add("@VerBackUrl", entity.VerBackUrl);
            paramList.Add("@MainTable", entity.MainTable);
            paramList.Add("@FormNoColumn", entity.FormNoColumn);
            paramList.Add("@PartNoColumn", entity.PartNoColumn);
            paramList.Add("@FlowXml", entity.FlowXml);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one Form to database 
        /// </summary>
        public override void Insert(SqlConnection connection, FormInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [form] (");
            sb.Append("[form_id],");
            sb.Append("[form_name],");
            sb.Append("[flower_form_kind],");
            sb.Append("[apply_url],");
            sb.Append("[view_url],");
            sb.Append("[modify_url],");
            sb.Append("[chek_in_url],");
            sb.Append("[ver_back_url],");
            sb.Append("[main_table],");
            sb.Append("[form_no_column],");
            sb.Append("[part_no_column],");
            sb.Append("[flow_xml] ");
            sb.Append(" ) values ( ");
            sb.Append("@FormId,");
            sb.Append("@FormName,");
            sb.Append("@FlowerFormKind,");
            sb.Append("@ApplyUrl,");
            sb.Append("@ViewUrl,");
            sb.Append("@ModifyUrl,");
            sb.Append("@ChekInUrl,");
            sb.Append("@VerBackUrl,");
            sb.Append("@MainTable,");
            sb.Append("@FormNoColumn,");
            sb.Append("@PartNoColumn,");
            sb.Append("@FlowXml ) ");

            ParameterBuilder paramList = new ParameterBuilder(12);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@FormName", entity.FormName);
            paramList.Add("@FlowerFormKind", entity.FlowerFormKind);
            paramList.Add("@ApplyUrl", entity.ApplyUrl);
            paramList.Add("@ViewUrl", entity.ViewUrl);
            paramList.Add("@ModifyUrl", entity.ModifyUrl);
            paramList.Add("@ChekInUrl", entity.ChekInUrl);
            paramList.Add("@VerBackUrl", entity.VerBackUrl);
            paramList.Add("@MainTable", entity.MainTable);
            paramList.Add("@FormNoColumn", entity.FormNoColumn);
            paramList.Add("@PartNoColumn", entity.PartNoColumn);
            paramList.Add("@FlowXml", entity.FlowXml);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one Form to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, FormInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [form] (");
            sb.Append("[form_id],");
            sb.Append("[form_name],");
            sb.Append("[flower_form_kind],");
            sb.Append("[apply_url],");
            sb.Append("[view_url],");
            sb.Append("[modify_url],");
            sb.Append("[chek_in_url],");
            sb.Append("[ver_back_url],");
            sb.Append("[main_table],");
            sb.Append("[form_no_column],");
            sb.Append("[part_no_column],");
            sb.Append("[flow_xml] ");
            sb.Append(" ) values ( ");
            sb.Append("@FormId,");
            sb.Append("@FormName,");
            sb.Append("@FlowerFormKind,");
            sb.Append("@ApplyUrl,");
            sb.Append("@ViewUrl,");
            sb.Append("@ModifyUrl,");
            sb.Append("@ChekInUrl,");
            sb.Append("@VerBackUrl,");
            sb.Append("@MainTable,");
            sb.Append("@FormNoColumn,");
            sb.Append("@PartNoColumn,");
            sb.Append("@FlowXml ) ");

            ParameterBuilder paramList = new ParameterBuilder(12);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@FormName", entity.FormName);
            paramList.Add("@FlowerFormKind", entity.FlowerFormKind);
            paramList.Add("@ApplyUrl", entity.ApplyUrl);
            paramList.Add("@ViewUrl", entity.ViewUrl);
            paramList.Add("@ModifyUrl", entity.ModifyUrl);
            paramList.Add("@ChekInUrl", entity.ChekInUrl);
            paramList.Add("@VerBackUrl", entity.VerBackUrl);
            paramList.Add("@MainTable", entity.MainTable);
            paramList.Add("@FormNoColumn", entity.FormNoColumn);
            paramList.Add("@PartNoColumn", entity.PartNoColumn);
            paramList.Add("@FlowXml", entity.FlowXml);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :form_id/
        /// </summary>
        public override void Update(string connection_string, FormInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [form] set ");
            sb.Append("[form_name] = @FormName, ");
            sb.Append("[flower_form_kind] = @FlowerFormKind, ");
            sb.Append("[apply_url] = @ApplyUrl, ");
            sb.Append("[view_url] = @ViewUrl, ");
            sb.Append("[modify_url] = @ModifyUrl, ");
            sb.Append("[chek_in_url] = @ChekInUrl, ");
            sb.Append("[ver_back_url] = @VerBackUrl, ");
            sb.Append("[main_table] = @MainTable, ");
            sb.Append("[form_no_column] = @FormNoColumn, ");
            sb.Append("[part_no_column] = @PartNoColumn, ");
            sb.Append("[flow_xml] = @FlowXml ");
            sb.Append("where [form_id] = @FormId ");
            ParameterBuilder paramList = new ParameterBuilder(12);
            paramList.Add("@FormName", entity.FormName);
            paramList.Add("@FlowerFormKind", entity.FlowerFormKind);
            paramList.Add("@ApplyUrl", entity.ApplyUrl);
            paramList.Add("@ViewUrl", entity.ViewUrl);
            paramList.Add("@ModifyUrl", entity.ModifyUrl);
            paramList.Add("@ChekInUrl", entity.ChekInUrl);
            paramList.Add("@VerBackUrl", entity.VerBackUrl);
            paramList.Add("@MainTable", entity.MainTable);
            paramList.Add("@FormNoColumn", entity.FormNoColumn);
            paramList.Add("@PartNoColumn", entity.PartNoColumn);
            paramList.Add("@FlowXml", entity.FlowXml);
            paramList.Add("@FormId", entity.FormId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :form_id/
        /// </summary>
        public override void Update(SqlConnection connection, FormInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [form] set ");
            sb.Append("[form_name] = @FormName, ");
            sb.Append("[flower_form_kind] = @FlowerFormKind, ");
            sb.Append("[apply_url] = @ApplyUrl, ");
            sb.Append("[view_url] = @ViewUrl, ");
            sb.Append("[modify_url] = @ModifyUrl, ");
            sb.Append("[chek_in_url] = @ChekInUrl, ");
            sb.Append("[ver_back_url] = @VerBackUrl, ");
            sb.Append("[main_table] = @MainTable, ");
            sb.Append("[form_no_column] = @FormNoColumn, ");
            sb.Append("[part_no_column] = @PartNoColumn, ");
            sb.Append("[flow_xml] = @FlowXml ");
            sb.Append("where [form_id] = @FormId ");
            ParameterBuilder paramList = new ParameterBuilder(12);
            paramList.Add("@FormName", entity.FormName);
            paramList.Add("@FlowerFormKind", entity.FlowerFormKind);
            paramList.Add("@ApplyUrl", entity.ApplyUrl);
            paramList.Add("@ViewUrl", entity.ViewUrl);
            paramList.Add("@ModifyUrl", entity.ModifyUrl);
            paramList.Add("@ChekInUrl", entity.ChekInUrl);
            paramList.Add("@VerBackUrl", entity.VerBackUrl);
            paramList.Add("@MainTable", entity.MainTable);
            paramList.Add("@FormNoColumn", entity.FormNoColumn);
            paramList.Add("@PartNoColumn", entity.PartNoColumn);
            paramList.Add("@FlowXml", entity.FlowXml);
            paramList.Add("@FormId", entity.FormId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :form_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, FormInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [form] set ");
            sb.Append("[form_name] = @FormName, ");
            sb.Append("[flower_form_kind] = @FlowerFormKind, ");
            sb.Append("[apply_url] = @ApplyUrl, ");
            sb.Append("[view_url] = @ViewUrl, ");
            sb.Append("[modify_url] = @ModifyUrl, ");
            sb.Append("[chek_in_url] = @ChekInUrl, ");
            sb.Append("[ver_back_url] = @VerBackUrl, ");
            sb.Append("[main_table] = @MainTable, ");
            sb.Append("[form_no_column] = @FormNoColumn, ");
            sb.Append("[part_no_column] = @PartNoColumn, ");
            sb.Append("[flow_xml] = @FlowXml ");
            sb.Append("where [form_id] = @FormId ");
            ParameterBuilder paramList = new ParameterBuilder(12);
            paramList.Add("@FormName", entity.FormName);
            paramList.Add("@FlowerFormKind", entity.FlowerFormKind);
            paramList.Add("@ApplyUrl", entity.ApplyUrl);
            paramList.Add("@ViewUrl", entity.ViewUrl);
            paramList.Add("@ModifyUrl", entity.ModifyUrl);
            paramList.Add("@ChekInUrl", entity.ChekInUrl);
            paramList.Add("@VerBackUrl", entity.VerBackUrl);
            paramList.Add("@MainTable", entity.MainTable);
            paramList.Add("@FormNoColumn", entity.FormNoColumn);
            paramList.Add("@PartNoColumn", entity.PartNoColumn);
            paramList.Add("@FlowXml", entity.FlowXml);
            paramList.Add("@FormId", entity.FormId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :form_id/
        /// </summary>
        public override void Delete(string connection_string, FormInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [form] ");
            sb.Append("where [form_id] = @FormId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@FormId", entity.FormId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :form_id/
        /// </summary>
        public override void Delete(SqlConnection connection, FormInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [form] ");
            sb.Append("where [form_id] = @FormId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@FormId", entity.FormId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :form_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, FormInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [form] ");
            sb.Append("where [form_id] = @FormId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@FormId", entity.FormId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to Form
        /// warning: this row must include all the columns of table(form)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(form)</param>
        /// <returns>an entity of Form</returns>
        public void FillEntityByRow(FormInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("form_id"))
            {
                entity.FormId = (int)row["form_id"];
            }
            else
            {
            }
            if (!row.IsNull("form_name"))
            {
                entity.FormName = (string)row["form_name"];
            }
            else
            {
            }
            if (!row.IsNull("flower_form_kind"))
            {
                entity.FlowerFormKind = (string)row["flower_form_kind"];
            }
            else
            {
            }
            if (!row.IsNull("apply_url"))
            {
                entity.ApplyUrl = (string)row["apply_url"];
            }
            else
            {
            }
            if (!row.IsNull("view_url"))
            {
                entity.ViewUrl = (string)row["view_url"];
            }
            else
            {
            }
            if (!row.IsNull("modify_url"))
            {
                entity.ModifyUrl = (string)row["modify_url"];
            }
            else
            {
            }
            if (!row.IsNull("chek_in_url"))
            {
                entity.ChekInUrl = (string)row["chek_in_url"];
            }
            else
            {
            }
            if (!row.IsNull("ver_back_url"))
            {
                entity.VerBackUrl = (string)row["ver_back_url"];
            }
            else
            {
            }
            if (!row.IsNull("main_table"))
            {
                entity.MainTable = (string)row["main_table"];
            }
            else
            {
            }
            if (!row.IsNull("form_no_column"))
            {
                entity.FormNoColumn = (string)row["form_no_column"];
            }
            else
            {
            }
            if (!row.IsNull("part_no_column"))
            {
                entity.PartNoColumn = (string)row["part_no_column"];
            }
            else
            {
            }
            if (!row.IsNull("flow_xml"))
            {
                entity.FlowXml = (string)row["flow_xml"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to Form
        /// warning: this row must include all the columns of table(form)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(form)</param>
        /// <returns>an entity of Form</returns>
        public override FormInfo Row2Entity(System.Data.DataRow row)
        {
            FormInfo entity = new FormInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override FormInfo Retrieve(SqlTransaction transaction, FormInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [form] ");
            sb.Append("where [form_id] = @FormId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@FormId", entity.FormId);

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
        public override FormInfo Retrieve(SqlConnection connection, FormInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [form] ");
            sb.Append("where [form_id] = @FormId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@FormId", entity.FormId);

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
        public override FormInfo Retrieve(string connection_string, FormInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [form] ");
            sb.Append("where [form_id] = @FormId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@FormId", entity.FormId);

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
