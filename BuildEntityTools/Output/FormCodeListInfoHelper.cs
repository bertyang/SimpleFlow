using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class FormCodeListInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<FormCodeListInfo>
    {
        public FormCodeListInfoHelper()
        {
        }

        /// <summary>
        ///  insert one FormCodeList to database 
        /// </summary>
        public override void Insert(string connection_string, FormCodeListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [form_code_List] (");
            sb.Append("[form_kind],");
            sb.Append("[code_kind],");
            sb.Append("[code_detail_des],");
            sb.Append("[code_detail_value] ");
            sb.Append(" ) values ( ");
            sb.Append("@FormKind,");
            sb.Append("@CodeKind,");
            sb.Append("@CodeDetailDes,");
            sb.Append("@CodeDetailValue ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@FormKind", entity.FormKind);
            paramList.Add("@CodeKind", entity.CodeKind);
            paramList.Add("@CodeDetailDes", entity.CodeDetailDes);
            paramList.Add("@CodeDetailValue", entity.CodeDetailValue);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one FormCodeList to database 
        /// </summary>
        public override void Insert(SqlConnection connection, FormCodeListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [form_code_List] (");
            sb.Append("[form_kind],");
            sb.Append("[code_kind],");
            sb.Append("[code_detail_des],");
            sb.Append("[code_detail_value] ");
            sb.Append(" ) values ( ");
            sb.Append("@FormKind,");
            sb.Append("@CodeKind,");
            sb.Append("@CodeDetailDes,");
            sb.Append("@CodeDetailValue ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@FormKind", entity.FormKind);
            paramList.Add("@CodeKind", entity.CodeKind);
            paramList.Add("@CodeDetailDes", entity.CodeDetailDes);
            paramList.Add("@CodeDetailValue", entity.CodeDetailValue);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one FormCodeList to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, FormCodeListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [form_code_List] (");
            sb.Append("[form_kind],");
            sb.Append("[code_kind],");
            sb.Append("[code_detail_des],");
            sb.Append("[code_detail_value] ");
            sb.Append(" ) values ( ");
            sb.Append("@FormKind,");
            sb.Append("@CodeKind,");
            sb.Append("@CodeDetailDes,");
            sb.Append("@CodeDetailValue ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@FormKind", entity.FormKind);
            paramList.Add("@CodeKind", entity.CodeKind);
            paramList.Add("@CodeDetailDes", entity.CodeDetailDes);
            paramList.Add("@CodeDetailValue", entity.CodeDetailValue);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Update(string connection_string, FormCodeListInfo entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Update(SqlConnection connection, FormCodeListInfo entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Update(SqlTransaction transaction, FormCodeListInfo entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Delete(string connection_string, FormCodeListInfo entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Delete(SqlConnection connection, FormCodeListInfo entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Delete(SqlTransaction transaction, FormCodeListInfo entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// convert one row to FormCodeList
        /// warning: this row must include all the columns of table(form_code_List)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(form_code_List)</param>
        /// <returns>an entity of FormCodeList</returns>
        public void FillEntityByRow(FormCodeListInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("form_kind"))
            {
                entity.FormKind = (string)row["form_kind"];
            }
            else
            {
            }
            if (!row.IsNull("code_kind"))
            {
                entity.CodeKind = (string)row["code_kind"];
            }
            else
            {
            }
            if (!row.IsNull("code_detail_des"))
            {
                entity.CodeDetailDes = (string)row["code_detail_des"];
            }
            else
            {
            }
            if (!row.IsNull("code_detail_value"))
            {
                entity.CodeDetailValue = (string)row["code_detail_value"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to FormCodeList
        /// warning: this row must include all the columns of table(form_code_List)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(form_code_List)</param>
        /// <returns>an entity of FormCodeList</returns>
        public override FormCodeListInfo Row2Entity(System.Data.DataRow row)
        {
            FormCodeListInfo entity = new FormCodeListInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override FormCodeListInfo Retrieve(SqlTransaction transaction, FormCodeListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [form_code_List] ");
            ParameterBuilder paramList = new ParameterBuilder(0);

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
        public override FormCodeListInfo Retrieve(SqlConnection connection, FormCodeListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [form_code_List] ");
            ParameterBuilder paramList = new ParameterBuilder(0);

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
        public override FormCodeListInfo Retrieve(string connection_string, FormCodeListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [form_code_List] ");
            ParameterBuilder paramList = new ParameterBuilder(0);

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
