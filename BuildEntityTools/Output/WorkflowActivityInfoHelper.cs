using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class WorkflowActivityInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<WorkflowActivityInfo>
    {
        public WorkflowActivityInfoHelper()
        {
        }

        /// <summary>
        ///  insert one WorkflowActivity to database 
        /// </summary>
        public override void Insert(string connection_string, WorkflowActivityInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [WorkFlow_Activity] (");
            sb.Append("[ActivityID],");
            sb.Append("[ActivityName],");
            sb.Append("[WorkFlowID],");
            sb.Append("[ActivityType] ");
            sb.Append(" ) values ( ");
            sb.Append("@Activityid,");
            sb.Append("@Activityname,");
            sb.Append("@Workflowid,");
            sb.Append("@Activitytype ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@Activityid", entity.Activityid);
            paramList.Add("@Activityname", entity.Activityname);
            paramList.Add("@Workflowid", entity.Workflowid);
            paramList.Add("@Activitytype", entity.Activitytype);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one WorkflowActivity to database 
        /// </summary>
        public override void Insert(SqlConnection connection, WorkflowActivityInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [WorkFlow_Activity] (");
            sb.Append("[ActivityID],");
            sb.Append("[ActivityName],");
            sb.Append("[WorkFlowID],");
            sb.Append("[ActivityType] ");
            sb.Append(" ) values ( ");
            sb.Append("@Activityid,");
            sb.Append("@Activityname,");
            sb.Append("@Workflowid,");
            sb.Append("@Activitytype ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@Activityid", entity.Activityid);
            paramList.Add("@Activityname", entity.Activityname);
            paramList.Add("@Workflowid", entity.Workflowid);
            paramList.Add("@Activitytype", entity.Activitytype);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one WorkflowActivity to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, WorkflowActivityInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [WorkFlow_Activity] (");
            sb.Append("[ActivityID],");
            sb.Append("[ActivityName],");
            sb.Append("[WorkFlowID],");
            sb.Append("[ActivityType] ");
            sb.Append(" ) values ( ");
            sb.Append("@Activityid,");
            sb.Append("@Activityname,");
            sb.Append("@Workflowid,");
            sb.Append("@Activitytype ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@Activityid", entity.Activityid);
            paramList.Add("@Activityname", entity.Activityname);
            paramList.Add("@Workflowid", entity.Workflowid);
            paramList.Add("@Activitytype", entity.Activitytype);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :ActivityID/
        /// </summary>
        public override void Update(string connection_string, WorkflowActivityInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [WorkFlow_Activity] set ");
            sb.Append("[ActivityName] = @Activityname, ");
            sb.Append("[WorkFlowID] = @Workflowid, ");
            sb.Append("[ActivityType] = @Activitytype ");
            sb.Append("where [ActivityID] = @Activityid ");
            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@Activityname", entity.Activityname);
            paramList.Add("@Workflowid", entity.Workflowid);
            paramList.Add("@Activitytype", entity.Activitytype);
            paramList.Add("@Activityid", entity.Activityid);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :ActivityID/
        /// </summary>
        public override void Update(SqlConnection connection, WorkflowActivityInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [WorkFlow_Activity] set ");
            sb.Append("[ActivityName] = @Activityname, ");
            sb.Append("[WorkFlowID] = @Workflowid, ");
            sb.Append("[ActivityType] = @Activitytype ");
            sb.Append("where [ActivityID] = @Activityid ");
            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@Activityname", entity.Activityname);
            paramList.Add("@Workflowid", entity.Workflowid);
            paramList.Add("@Activitytype", entity.Activitytype);
            paramList.Add("@Activityid", entity.Activityid);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :ActivityID/
        /// </summary>
        public override void Update(SqlTransaction transaction, WorkflowActivityInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [WorkFlow_Activity] set ");
            sb.Append("[ActivityName] = @Activityname, ");
            sb.Append("[WorkFlowID] = @Workflowid, ");
            sb.Append("[ActivityType] = @Activitytype ");
            sb.Append("where [ActivityID] = @Activityid ");
            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@Activityname", entity.Activityname);
            paramList.Add("@Workflowid", entity.Workflowid);
            paramList.Add("@Activitytype", entity.Activitytype);
            paramList.Add("@Activityid", entity.Activityid);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :ActivityID/
        /// </summary>
        public override void Delete(string connection_string, WorkflowActivityInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [WorkFlow_Activity] ");
            sb.Append("where [ActivityID] = @Activityid ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@Activityid", entity.Activityid);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :ActivityID/
        /// </summary>
        public override void Delete(SqlConnection connection, WorkflowActivityInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [WorkFlow_Activity] ");
            sb.Append("where [ActivityID] = @Activityid ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@Activityid", entity.Activityid);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :ActivityID/
        /// </summary>
        public override void Delete(SqlTransaction transaction, WorkflowActivityInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [WorkFlow_Activity] ");
            sb.Append("where [ActivityID] = @Activityid ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@Activityid", entity.Activityid);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to WorkflowActivity
        /// warning: this row must include all the columns of table(WorkFlow_Activity)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(WorkFlow_Activity)</param>
        /// <returns>an entity of WorkflowActivity</returns>
        public void FillEntityByRow(WorkflowActivityInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("ActivityID"))
            {
                entity.Activityid = (string)row["ActivityID"];
            }
            else
            {
            }
            if (!row.IsNull("ActivityName"))
            {
                entity.Activityname = (string)row["ActivityName"];
            }
            else
            {
            }
            if (!row.IsNull("WorkFlowID"))
            {
                entity.Workflowid = (string)row["WorkFlowID"];
            }
            else
            {
            }
            if (!row.IsNull("ActivityType"))
            {
                entity.Activitytype = (string)row["ActivityType"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to WorkflowActivity
        /// warning: this row must include all the columns of table(WorkFlow_Activity)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(WorkFlow_Activity)</param>
        /// <returns>an entity of WorkflowActivity</returns>
        public override WorkflowActivityInfo Row2Entity(System.Data.DataRow row)
        {
            WorkflowActivityInfo entity = new WorkflowActivityInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override WorkflowActivityInfo Retrieve(SqlTransaction transaction, WorkflowActivityInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [WorkFlow_Activity] ");
            sb.Append("where [ActivityID] = @Activityid ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@Activityid", entity.Activityid);

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
        public override WorkflowActivityInfo Retrieve(SqlConnection connection, WorkflowActivityInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [WorkFlow_Activity] ");
            sb.Append("where [ActivityID] = @Activityid ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@Activityid", entity.Activityid);

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
        public override WorkflowActivityInfo Retrieve(string connection_string, WorkflowActivityInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [WorkFlow_Activity] ");
            sb.Append("where [ActivityID] = @Activityid ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@Activityid", entity.Activityid);

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
