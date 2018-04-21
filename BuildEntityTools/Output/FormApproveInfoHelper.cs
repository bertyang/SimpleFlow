using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class FormApproveInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<FormApproveInfo>
    {
        public FormApproveInfoHelper()
        {
        }

        /// <summary>
        ///  insert one FormApprove to database 
        /// </summary>
        public override void Insert(string connection_string, FormApproveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [form_approve] (");
            sb.Append("[form_approve_id],");
            sb.Append("[form_no],");
            sb.Append("[form_id],");
            sb.Append("[app_serial],");
            sb.Append("[app_assigner],");
            sb.Append("[app_emp_id],");
            sb.Append("[app_role],");
            sb.Append("[app_actor],");
            sb.Append("[app_name],");
            sb.Append("[app_status],");
            sb.Append("[app_type],");
            sb.Append("[begin_date],");
            sb.Append("[end_date],");
            sb.Append("[app_value],");
            sb.Append("[app_content],");
            sb.Append("[assign_reason] ");
            sb.Append(" ) values ( ");
            sb.Append("@FormApproveId,");
            sb.Append("@FormNo,");
            sb.Append("@FormId,");
            sb.Append("@AppSerial,");
            sb.Append("@AppAssigner,");
            sb.Append("@AppEmpId,");
            sb.Append("@AppRole,");
            sb.Append("@AppActor,");
            sb.Append("@AppName,");
            sb.Append("@AppStatus,");
            sb.Append("@AppType,");
            sb.Append("@BeginDate,");
            sb.Append("@EndDate,");
            sb.Append("@AppValue,");
            sb.Append("@AppContent,");
            sb.Append("@AssignReason ) ");

            ParameterBuilder paramList = new ParameterBuilder(16);
            paramList.Add("@FormApproveId", entity.FormApproveId);
            paramList.Add("@FormNo", entity.FormNo);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@AppSerial", entity.AppSerial);
            paramList.Add("@AppAssigner", entity.AppAssigner);
            paramList.Add("@AppEmpId", entity.AppEmpId);
            paramList.Add("@AppRole", entity.AppRole);
            paramList.Add("@AppActor", entity.AppActor);
            paramList.Add("@AppName", entity.AppName);
            paramList.Add("@AppStatus", entity.AppStatus);
            paramList.Add("@AppType", entity.AppType);
            paramList.Add("@BeginDate", entity.BeginDate);
            paramList.Add("@EndDate", entity.EndDate);
            paramList.Add("@AppValue", entity.AppValue);
            paramList.Add("@AppContent", entity.AppContent);
            paramList.Add("@AssignReason", entity.AssignReason);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one FormApprove to database 
        /// </summary>
        public override void Insert(SqlConnection connection, FormApproveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [form_approve] (");
            sb.Append("[form_approve_id],");
            sb.Append("[form_no],");
            sb.Append("[form_id],");
            sb.Append("[app_serial],");
            sb.Append("[app_assigner],");
            sb.Append("[app_emp_id],");
            sb.Append("[app_role],");
            sb.Append("[app_actor],");
            sb.Append("[app_name],");
            sb.Append("[app_status],");
            sb.Append("[app_type],");
            sb.Append("[begin_date],");
            sb.Append("[end_date],");
            sb.Append("[app_value],");
            sb.Append("[app_content],");
            sb.Append("[assign_reason] ");
            sb.Append(" ) values ( ");
            sb.Append("@FormApproveId,");
            sb.Append("@FormNo,");
            sb.Append("@FormId,");
            sb.Append("@AppSerial,");
            sb.Append("@AppAssigner,");
            sb.Append("@AppEmpId,");
            sb.Append("@AppRole,");
            sb.Append("@AppActor,");
            sb.Append("@AppName,");
            sb.Append("@AppStatus,");
            sb.Append("@AppType,");
            sb.Append("@BeginDate,");
            sb.Append("@EndDate,");
            sb.Append("@AppValue,");
            sb.Append("@AppContent,");
            sb.Append("@AssignReason ) ");

            ParameterBuilder paramList = new ParameterBuilder(16);
            paramList.Add("@FormApproveId", entity.FormApproveId);
            paramList.Add("@FormNo", entity.FormNo);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@AppSerial", entity.AppSerial);
            paramList.Add("@AppAssigner", entity.AppAssigner);
            paramList.Add("@AppEmpId", entity.AppEmpId);
            paramList.Add("@AppRole", entity.AppRole);
            paramList.Add("@AppActor", entity.AppActor);
            paramList.Add("@AppName", entity.AppName);
            paramList.Add("@AppStatus", entity.AppStatus);
            paramList.Add("@AppType", entity.AppType);
            paramList.Add("@BeginDate", entity.BeginDate);
            paramList.Add("@EndDate", entity.EndDate);
            paramList.Add("@AppValue", entity.AppValue);
            paramList.Add("@AppContent", entity.AppContent);
            paramList.Add("@AssignReason", entity.AssignReason);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one FormApprove to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, FormApproveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [form_approve] (");
            sb.Append("[form_approve_id],");
            sb.Append("[form_no],");
            sb.Append("[form_id],");
            sb.Append("[app_serial],");
            sb.Append("[app_assigner],");
            sb.Append("[app_emp_id],");
            sb.Append("[app_role],");
            sb.Append("[app_actor],");
            sb.Append("[app_name],");
            sb.Append("[app_status],");
            sb.Append("[app_type],");
            sb.Append("[begin_date],");
            sb.Append("[end_date],");
            sb.Append("[app_value],");
            sb.Append("[app_content],");
            sb.Append("[assign_reason] ");
            sb.Append(" ) values ( ");
            sb.Append("@FormApproveId,");
            sb.Append("@FormNo,");
            sb.Append("@FormId,");
            sb.Append("@AppSerial,");
            sb.Append("@AppAssigner,");
            sb.Append("@AppEmpId,");
            sb.Append("@AppRole,");
            sb.Append("@AppActor,");
            sb.Append("@AppName,");
            sb.Append("@AppStatus,");
            sb.Append("@AppType,");
            sb.Append("@BeginDate,");
            sb.Append("@EndDate,");
            sb.Append("@AppValue,");
            sb.Append("@AppContent,");
            sb.Append("@AssignReason ) ");

            ParameterBuilder paramList = new ParameterBuilder(16);
            paramList.Add("@FormApproveId", entity.FormApproveId);
            paramList.Add("@FormNo", entity.FormNo);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@AppSerial", entity.AppSerial);
            paramList.Add("@AppAssigner", entity.AppAssigner);
            paramList.Add("@AppEmpId", entity.AppEmpId);
            paramList.Add("@AppRole", entity.AppRole);
            paramList.Add("@AppActor", entity.AppActor);
            paramList.Add("@AppName", entity.AppName);
            paramList.Add("@AppStatus", entity.AppStatus);
            paramList.Add("@AppType", entity.AppType);
            paramList.Add("@BeginDate", entity.BeginDate);
            paramList.Add("@EndDate", entity.EndDate);
            paramList.Add("@AppValue", entity.AppValue);
            paramList.Add("@AppContent", entity.AppContent);
            paramList.Add("@AssignReason", entity.AssignReason);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :form_approve_id/
        /// </summary>
        public override void Update(string connection_string, FormApproveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [form_approve] set ");
            sb.Append("[form_no] = @FormNo, ");
            sb.Append("[form_id] = @FormId, ");
            sb.Append("[app_serial] = @AppSerial, ");
            sb.Append("[app_assigner] = @AppAssigner, ");
            sb.Append("[app_emp_id] = @AppEmpId, ");
            sb.Append("[app_role] = @AppRole, ");
            sb.Append("[app_actor] = @AppActor, ");
            sb.Append("[app_name] = @AppName, ");
            sb.Append("[app_status] = @AppStatus, ");
            sb.Append("[app_type] = @AppType, ");
            sb.Append("[begin_date] = @BeginDate, ");
            sb.Append("[end_date] = @EndDate, ");
            sb.Append("[app_value] = @AppValue, ");
            sb.Append("[app_content] = @AppContent, ");
            sb.Append("[assign_reason] = @AssignReason ");
            sb.Append("where [form_approve_id] = @FormApproveId ");
            ParameterBuilder paramList = new ParameterBuilder(16);
            paramList.Add("@FormNo", entity.FormNo);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@AppSerial", entity.AppSerial);
            paramList.Add("@AppAssigner", entity.AppAssigner);
            paramList.Add("@AppEmpId", entity.AppEmpId);
            paramList.Add("@AppRole", entity.AppRole);
            paramList.Add("@AppActor", entity.AppActor);
            paramList.Add("@AppName", entity.AppName);
            paramList.Add("@AppStatus", entity.AppStatus);
            paramList.Add("@AppType", entity.AppType);
            paramList.Add("@BeginDate", entity.BeginDate);
            paramList.Add("@EndDate", entity.EndDate);
            paramList.Add("@AppValue", entity.AppValue);
            paramList.Add("@AppContent", entity.AppContent);
            paramList.Add("@AssignReason", entity.AssignReason);
            paramList.Add("@FormApproveId", entity.FormApproveId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :form_approve_id/
        /// </summary>
        public override void Update(SqlConnection connection, FormApproveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [form_approve] set ");
            sb.Append("[form_no] = @FormNo, ");
            sb.Append("[form_id] = @FormId, ");
            sb.Append("[app_serial] = @AppSerial, ");
            sb.Append("[app_assigner] = @AppAssigner, ");
            sb.Append("[app_emp_id] = @AppEmpId, ");
            sb.Append("[app_role] = @AppRole, ");
            sb.Append("[app_actor] = @AppActor, ");
            sb.Append("[app_name] = @AppName, ");
            sb.Append("[app_status] = @AppStatus, ");
            sb.Append("[app_type] = @AppType, ");
            sb.Append("[begin_date] = @BeginDate, ");
            sb.Append("[end_date] = @EndDate, ");
            sb.Append("[app_value] = @AppValue, ");
            sb.Append("[app_content] = @AppContent, ");
            sb.Append("[assign_reason] = @AssignReason ");
            sb.Append("where [form_approve_id] = @FormApproveId ");
            ParameterBuilder paramList = new ParameterBuilder(16);
            paramList.Add("@FormNo", entity.FormNo);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@AppSerial", entity.AppSerial);
            paramList.Add("@AppAssigner", entity.AppAssigner);
            paramList.Add("@AppEmpId", entity.AppEmpId);
            paramList.Add("@AppRole", entity.AppRole);
            paramList.Add("@AppActor", entity.AppActor);
            paramList.Add("@AppName", entity.AppName);
            paramList.Add("@AppStatus", entity.AppStatus);
            paramList.Add("@AppType", entity.AppType);
            paramList.Add("@BeginDate", entity.BeginDate);
            paramList.Add("@EndDate", entity.EndDate);
            paramList.Add("@AppValue", entity.AppValue);
            paramList.Add("@AppContent", entity.AppContent);
            paramList.Add("@AssignReason", entity.AssignReason);
            paramList.Add("@FormApproveId", entity.FormApproveId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :form_approve_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, FormApproveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [form_approve] set ");
            sb.Append("[form_no] = @FormNo, ");
            sb.Append("[form_id] = @FormId, ");
            sb.Append("[app_serial] = @AppSerial, ");
            sb.Append("[app_assigner] = @AppAssigner, ");
            sb.Append("[app_emp_id] = @AppEmpId, ");
            sb.Append("[app_role] = @AppRole, ");
            sb.Append("[app_actor] = @AppActor, ");
            sb.Append("[app_name] = @AppName, ");
            sb.Append("[app_status] = @AppStatus, ");
            sb.Append("[app_type] = @AppType, ");
            sb.Append("[begin_date] = @BeginDate, ");
            sb.Append("[end_date] = @EndDate, ");
            sb.Append("[app_value] = @AppValue, ");
            sb.Append("[app_content] = @AppContent, ");
            sb.Append("[assign_reason] = @AssignReason ");
            sb.Append("where [form_approve_id] = @FormApproveId ");
            ParameterBuilder paramList = new ParameterBuilder(16);
            paramList.Add("@FormNo", entity.FormNo);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@AppSerial", entity.AppSerial);
            paramList.Add("@AppAssigner", entity.AppAssigner);
            paramList.Add("@AppEmpId", entity.AppEmpId);
            paramList.Add("@AppRole", entity.AppRole);
            paramList.Add("@AppActor", entity.AppActor);
            paramList.Add("@AppName", entity.AppName);
            paramList.Add("@AppStatus", entity.AppStatus);
            paramList.Add("@AppType", entity.AppType);
            paramList.Add("@BeginDate", entity.BeginDate);
            paramList.Add("@EndDate", entity.EndDate);
            paramList.Add("@AppValue", entity.AppValue);
            paramList.Add("@AppContent", entity.AppContent);
            paramList.Add("@AssignReason", entity.AssignReason);
            paramList.Add("@FormApproveId", entity.FormApproveId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :form_approve_id/
        /// </summary>
        public override void Delete(string connection_string, FormApproveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [form_approve] ");
            sb.Append("where [form_approve_id] = @FormApproveId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@FormApproveId", entity.FormApproveId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :form_approve_id/
        /// </summary>
        public override void Delete(SqlConnection connection, FormApproveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [form_approve] ");
            sb.Append("where [form_approve_id] = @FormApproveId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@FormApproveId", entity.FormApproveId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :form_approve_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, FormApproveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [form_approve] ");
            sb.Append("where [form_approve_id] = @FormApproveId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@FormApproveId", entity.FormApproveId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to FormApprove
        /// warning: this row must include all the columns of table(form_approve)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(form_approve)</param>
        /// <returns>an entity of FormApprove</returns>
        public void FillEntityByRow(FormApproveInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("form_approve_id"))
            {
                entity.FormApproveId = (string)row["form_approve_id"];
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
            if (!row.IsNull("app_serial"))
            {
                entity.AppSerial = (int)row["app_serial"];
            }
            else
            {
            }
            if (!row.IsNull("app_assigner"))
            {
                entity.AppAssigner = (string)row["app_assigner"];
            }
            else
            {
            }
            if (!row.IsNull("app_emp_id"))
            {
                entity.AppEmpId = (string)row["app_emp_id"];
            }
            else
            {
            }
            if (!row.IsNull("app_role"))
            {
                entity.AppRole = (string)row["app_role"];
            }
            else
            {
            }
            if (!row.IsNull("app_actor"))
            {
                entity.AppActor = (string)row["app_actor"];
            }
            else
            {
            }
            if (!row.IsNull("app_name"))
            {
                entity.AppName = (string)row["app_name"];
            }
            else
            {
            }
            if (!row.IsNull("app_status"))
            {
                entity.AppStatus = (string)row["app_status"];
            }
            else
            {
            }
            if (!row.IsNull("app_type"))
            {
                entity.AppType = (string)row["app_type"];
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
            if (!row.IsNull("app_value"))
            {
                entity.AppValue = (string)row["app_value"];
            }
            else
            {
            }
            if (!row.IsNull("app_content"))
            {
                entity.AppContent = (string)row["app_content"];
            }
            else
            {
            }
            if (!row.IsNull("assign_reason"))
            {
                entity.AssignReason = (string)row["assign_reason"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to FormApprove
        /// warning: this row must include all the columns of table(form_approve)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(form_approve)</param>
        /// <returns>an entity of FormApprove</returns>
        public override FormApproveInfo Row2Entity(System.Data.DataRow row)
        {
            FormApproveInfo entity = new FormApproveInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override FormApproveInfo Retrieve(SqlTransaction transaction, FormApproveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [form_approve] ");
            sb.Append("where [form_approve_id] = @FormApproveId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@FormApproveId", entity.FormApproveId);

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
        public override FormApproveInfo Retrieve(SqlConnection connection, FormApproveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [form_approve] ");
            sb.Append("where [form_approve_id] = @FormApproveId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@FormApproveId", entity.FormApproveId);

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
        public override FormApproveInfo Retrieve(string connection_string, FormApproveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [form_approve] ");
            sb.Append("where [form_approve_id] = @FormApproveId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@FormApproveId", entity.FormApproveId);

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
