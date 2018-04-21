using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class ParticipantOrgInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<ParticipantOrgInfo>
    {
        public ParticipantOrgInfoHelper()
        {
        }

        /// <summary>
        ///  insert one ParticipantOrg to database 
        /// </summary>
        public override void Insert(string connection_string, ParticipantOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [participant_org] (");
            sb.Append("[participant_id],");
            sb.Append("[user_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@ParticipantId,");
            sb.Append("@UserId ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@ParticipantId", entity.ParticipantId);
            paramList.Add("@UserId", entity.UserId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one ParticipantOrg to database 
        /// </summary>
        public override void Insert(SqlConnection connection, ParticipantOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [participant_org] (");
            sb.Append("[participant_id],");
            sb.Append("[user_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@ParticipantId,");
            sb.Append("@UserId ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@ParticipantId", entity.ParticipantId);
            paramList.Add("@UserId", entity.UserId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one ParticipantOrg to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, ParticipantOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [participant_org] (");
            sb.Append("[participant_id],");
            sb.Append("[user_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@ParticipantId,");
            sb.Append("@UserId ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@ParticipantId", entity.ParticipantId);
            paramList.Add("@UserId", entity.UserId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :participant_id/
        /// </summary>
        public override void Update(string connection_string, ParticipantOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [participant_org] set ");
            sb.Append("[user_id] = @UserId ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@UserId", entity.UserId);
            paramList.Add("@ParticipantId", entity.ParticipantId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :participant_id/
        /// </summary>
        public override void Update(SqlConnection connection, ParticipantOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [participant_org] set ");
            sb.Append("[user_id] = @UserId ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@UserId", entity.UserId);
            paramList.Add("@ParticipantId", entity.ParticipantId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :participant_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, ParticipantOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [participant_org] set ");
            sb.Append("[user_id] = @UserId ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@UserId", entity.UserId);
            paramList.Add("@ParticipantId", entity.ParticipantId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :participant_id/
        /// </summary>
        public override void Delete(string connection_string, ParticipantOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [participant_org] ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ParticipantId", entity.ParticipantId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :participant_id/
        /// </summary>
        public override void Delete(SqlConnection connection, ParticipantOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [participant_org] ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ParticipantId", entity.ParticipantId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :participant_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, ParticipantOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [participant_org] ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ParticipantId", entity.ParticipantId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to ParticipantOrg
        /// warning: this row must include all the columns of table(participant_org)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(participant_org)</param>
        /// <returns>an entity of ParticipantOrg</returns>
        public void FillEntityByRow(ParticipantOrgInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("participant_id"))
            {
                entity.ParticipantId = (string)row["participant_id"];
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
        }

        /// <summary>
        /// convert one row to ParticipantOrg
        /// warning: this row must include all the columns of table(participant_org)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(participant_org)</param>
        /// <returns>an entity of ParticipantOrg</returns>
        public override ParticipantOrgInfo Row2Entity(System.Data.DataRow row)
        {
            ParticipantOrgInfo entity = new ParticipantOrgInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override ParticipantOrgInfo Retrieve(SqlTransaction transaction, ParticipantOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [participant_org] ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ParticipantId", entity.ParticipantId);

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
        public override ParticipantOrgInfo Retrieve(SqlConnection connection, ParticipantOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [participant_org] ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ParticipantId", entity.ParticipantId);

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
        public override ParticipantOrgInfo Retrieve(string connection_string, ParticipantOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [participant_org] ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ParticipantId", entity.ParticipantId);

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
