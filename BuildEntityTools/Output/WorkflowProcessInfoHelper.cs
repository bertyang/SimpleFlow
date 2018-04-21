using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class WorkflowProcessInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<WorkflowProcessInfo>
    {
        public WorkflowProcessInfoHelper()
        {
        }

        /// <summary>
        ///  insert one WorkflowProcess to database 
        /// </summary>
        public override void Insert(string connection_string, WorkflowProcessInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [WorkFlow_Process] (");
            sb.Append("[WorkFlowID],");
            sb.Append("[WorkFlowName],");
            sb.Append("[WorkFlowXML] ");
            sb.Append(" ) values ( ");
            sb.Append("@Workflowid,");
            sb.Append("@Workflowname,");
            sb.Append("@Workflowxml ) ");

            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@Workflowid", entity.Workflowid);
            paramList.Add("@Workflowname", entity.Workflowname);
            paramList.Add("@Workflowxml", entity.Workflowxml);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one WorkflowProcess to database 
        /// </summary>
        public override void Insert(SqlConnection connection, WorkflowProcessInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [WorkFlow_Process] (");
            sb.Append("[WorkFlowID],");
            sb.Append("[WorkFlowName],");
            sb.Append("[WorkFlowXML] ");
            sb.Append(" ) values ( ");
            sb.Append("@Workflowid,");
            sb.Append("@Workflowname,");
            sb.Append("@Workflowxml ) ");

            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@Workflowid", entity.Workflowid);
            paramList.Add("@Workflowname", entity.Workflowname);
            paramList.Add("@Workflowxml", entity.Workflowxml);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one WorkflowProcess to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, WorkflowProcessInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [WorkFlow_Process] (");
            sb.Append("[WorkFlowID],");
            sb.Append("[WorkFlowName],");
            sb.Append("[WorkFlowXML] ");
            sb.Append(" ) values ( ");
            sb.Append("@Workflowid,");
            sb.Append("@Workflowname,");
            sb.Append("@Workflowxml ) ");

            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@Workflowid", entity.Workflowid);
            paramList.Add("@Workflowname", entity.Workflowname);
            paramList.Add("@Workflowxml", entity.Workflowxml);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :WorkFlowID/
        /// </summary>
        public override void Update(string connection_string, WorkflowProcessInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [WorkFlow_Process] set ");
            sb.Append("[WorkFlowName] = @Workflowname, ");
            sb.Append("[WorkFlowXML] = @Workflowxml ");
            sb.Append("where [WorkFlowID] = @Workflowid ");
            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@Workflowname", entity.Workflowname);
            paramList.Add("@Workflowxml", entity.Workflowxml);
            paramList.Add("@Workflowid", entity.Workflowid);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :WorkFlowID/
        /// </summary>
        public override void Update(SqlConnection connection, WorkflowProcessInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [WorkFlow_Process] set ");
            sb.Append("[WorkFlowName] = @Workflowname, ");
            sb.Append("[WorkFlowXML] = @Workflowxml ");
            sb.Append("where [WorkFlowID] = @Workflowid ");
            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@Workflowname", entity.Workflowname);
            paramList.Add("@Workflowxml", entity.Workflowxml);
            paramList.Add("@Workflowid", entity.Workflowid);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :WorkFlowID/
        /// </summary>
        public override void Update(SqlTransaction transaction, WorkflowProcessInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [WorkFlow_Process] set ");
            sb.Append("[WorkFlowName] = @Workflowname, ");
            sb.Append("[WorkFlowXML] = @Workflowxml ");
            sb.Append("where [WorkFlowID] = @Workflowid ");
            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@Workflowname", entity.Workflowname);
            paramList.Add("@Workflowxml", entity.Workflowxml);
            paramList.Add("@Workflowid", entity.Workflowid);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :WorkFlowID/
        /// </summary>
        public override void Delete(string connection_string, WorkflowProcessInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [WorkFlow_Process] ");
            sb.Append("where [WorkFlowID] = @Workflowid ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@Workflowid", entity.Workflowid);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :WorkFlowID/
        /// </summary>
        public override void Delete(SqlConnection connection, WorkflowProcessInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [WorkFlow_Process] ");
            sb.Append("where [WorkFlowID] = @Workflowid ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@Workflowid", entity.Workflowid);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :WorkFlowID/
        /// </summary>
        public override void Delete(SqlTransaction transaction, WorkflowProcessInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [WorkFlow_Process] ");
            sb.Append("where [WorkFlowID] = @Workflowid ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@Workflowid", entity.Workflowid);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to WorkflowProcess
        /// warning: this row must include all the columns of table(WorkFlow_Process)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(WorkFlow_Process)</param>
        /// <returns>an entity of WorkflowProcess</returns>
        public void FillEntityByRow(WorkflowProcessInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("WorkFlowID"))
            {
                entity.Workflowid = (string)row["WorkFlowID"];
            }
            else
            {
            }
            if (!row.IsNull("WorkFlowName"))
            {
                entity.Workflowname = (string)row["WorkFlowName"];
            }
            else
            {
            }
            if (!row.IsNull("WorkFlowXML"))
            {
                entity.Workflowxml = (string)row["WorkFlowXML"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to WorkflowProcess
        /// warning: this row must include all the columns of table(WorkFlow_Process)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(WorkFlow_Process)</param>
        /// <returns>an entity of WorkflowProcess</returns>
        public override WorkflowProcessInfo Row2Entity(System.Data.DataRow row)
        {
            WorkflowProcessInfo entity = new WorkflowProcessInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override WorkflowProcessInfo Retrieve(SqlTransaction transaction, WorkflowProcessInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [WorkFlow_Process] ");
            sb.Append("where [WorkFlowID] = @Workflowid ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@Workflowid", entity.Workflowid);

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
        public override WorkflowProcessInfo Retrieve(SqlConnection connection, WorkflowProcessInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [WorkFlow_Process] ");
            sb.Append("where [WorkFlowID] = @Workflowid ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@Workflowid", entity.Workflowid);

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
        public override WorkflowProcessInfo Retrieve(string connection_string, WorkflowProcessInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [WorkFlow_Process] ");
            sb.Append("where [WorkFlowID] = @Workflowid ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@Workflowid", entity.Workflowid);

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
