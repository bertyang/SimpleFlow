using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class WorkflowRuleInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<WorkflowRuleInfo>
    {
        public WorkflowRuleInfoHelper()
        {
        }

        /// <summary>
        ///  insert one WorkflowRule to database 
        /// </summary>
        public override void Insert(string connection_string, WorkflowRuleInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [WorkFlow_Rule] (");
            sb.Append("[RuleID],");
            sb.Append("[RuleName],");
            sb.Append("[BeginActivityID],");
            sb.Append("[EndActivityID],");
            sb.Append("[RuleType],");
            sb.Append("[Condition] ");
            sb.Append(" ) values ( ");
            sb.Append("@Ruleid,");
            sb.Append("@Rulename,");
            sb.Append("@Beginactivityid,");
            sb.Append("@Endactivityid,");
            sb.Append("@Ruletype,");
            sb.Append("@Condition ) ");

            ParameterBuilder paramList = new ParameterBuilder(6);
            paramList.Add("@Ruleid", entity.Ruleid);
            paramList.Add("@Rulename", entity.Rulename);
            paramList.Add("@Beginactivityid", entity.Beginactivityid);
            paramList.Add("@Endactivityid", entity.Endactivityid);
            paramList.Add("@Ruletype", entity.Ruletype);
            paramList.Add("@Condition", entity.Condition);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one WorkflowRule to database 
        /// </summary>
        public override void Insert(SqlConnection connection, WorkflowRuleInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [WorkFlow_Rule] (");
            sb.Append("[RuleID],");
            sb.Append("[RuleName],");
            sb.Append("[BeginActivityID],");
            sb.Append("[EndActivityID],");
            sb.Append("[RuleType],");
            sb.Append("[Condition] ");
            sb.Append(" ) values ( ");
            sb.Append("@Ruleid,");
            sb.Append("@Rulename,");
            sb.Append("@Beginactivityid,");
            sb.Append("@Endactivityid,");
            sb.Append("@Ruletype,");
            sb.Append("@Condition ) ");

            ParameterBuilder paramList = new ParameterBuilder(6);
            paramList.Add("@Ruleid", entity.Ruleid);
            paramList.Add("@Rulename", entity.Rulename);
            paramList.Add("@Beginactivityid", entity.Beginactivityid);
            paramList.Add("@Endactivityid", entity.Endactivityid);
            paramList.Add("@Ruletype", entity.Ruletype);
            paramList.Add("@Condition", entity.Condition);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one WorkflowRule to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, WorkflowRuleInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [WorkFlow_Rule] (");
            sb.Append("[RuleID],");
            sb.Append("[RuleName],");
            sb.Append("[BeginActivityID],");
            sb.Append("[EndActivityID],");
            sb.Append("[RuleType],");
            sb.Append("[Condition] ");
            sb.Append(" ) values ( ");
            sb.Append("@Ruleid,");
            sb.Append("@Rulename,");
            sb.Append("@Beginactivityid,");
            sb.Append("@Endactivityid,");
            sb.Append("@Ruletype,");
            sb.Append("@Condition ) ");

            ParameterBuilder paramList = new ParameterBuilder(6);
            paramList.Add("@Ruleid", entity.Ruleid);
            paramList.Add("@Rulename", entity.Rulename);
            paramList.Add("@Beginactivityid", entity.Beginactivityid);
            paramList.Add("@Endactivityid", entity.Endactivityid);
            paramList.Add("@Ruletype", entity.Ruletype);
            paramList.Add("@Condition", entity.Condition);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Update(string connection_string, WorkflowRuleInfo entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Update(SqlConnection connection, WorkflowRuleInfo entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Update(SqlTransaction transaction, WorkflowRuleInfo entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Delete(string connection_string, WorkflowRuleInfo entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Delete(SqlConnection connection, WorkflowRuleInfo entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Delete(SqlTransaction transaction, WorkflowRuleInfo entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// convert one row to WorkflowRule
        /// warning: this row must include all the columns of table(WorkFlow_Rule)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(WorkFlow_Rule)</param>
        /// <returns>an entity of WorkflowRule</returns>
        public void FillEntityByRow(WorkflowRuleInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("RuleID"))
            {
                entity.Ruleid = (string)row["RuleID"];
            }
            else
            {
            }
            if (!row.IsNull("RuleName"))
            {
                entity.Rulename = (string)row["RuleName"];
            }
            else
            {
            }
            if (!row.IsNull("BeginActivityID"))
            {
                entity.Beginactivityid = (string)row["BeginActivityID"];
            }
            else
            {
            }
            if (!row.IsNull("EndActivityID"))
            {
                entity.Endactivityid = (string)row["EndActivityID"];
            }
            else
            {
            }
            if (!row.IsNull("RuleType"))
            {
                entity.Ruletype = (string)row["RuleType"];
            }
            else
            {
            }
            if (!row.IsNull("Condition"))
            {
                entity.Condition = (string)row["Condition"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to WorkflowRule
        /// warning: this row must include all the columns of table(WorkFlow_Rule)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(WorkFlow_Rule)</param>
        /// <returns>an entity of WorkflowRule</returns>
        public override WorkflowRuleInfo Row2Entity(System.Data.DataRow row)
        {
            WorkflowRuleInfo entity = new WorkflowRuleInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override WorkflowRuleInfo Retrieve(SqlTransaction transaction, WorkflowRuleInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [WorkFlow_Rule] ");
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
        public override WorkflowRuleInfo Retrieve(SqlConnection connection, WorkflowRuleInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [WorkFlow_Rule] ");
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
        public override WorkflowRuleInfo Retrieve(string connection_string, WorkflowRuleInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [WorkFlow_Rule] ");
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
