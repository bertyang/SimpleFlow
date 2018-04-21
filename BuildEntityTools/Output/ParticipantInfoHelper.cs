using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class ParticipantInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<ParticipantInfo>
    {
        public ParticipantInfoHelper()
        {
        }

        /// <summary>
        ///  insert one Participant to database 
        /// </summary>
        public override void Insert(string connection_string, ParticipantInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [participant] (");
            sb.Append("[participant_id],");
            sb.Append("[participant_kind],");
            sb.Append("[relation_id],");
            sb.Append("[active_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@ParticipantId,");
            sb.Append("@ParticipantKind,");
            sb.Append("@RelationId,");
            sb.Append("@ActiveId ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@ParticipantId", entity.ParticipantId);
            paramList.Add("@ParticipantKind", entity.ParticipantKind);
            paramList.Add("@RelationId", entity.RelationId);
            paramList.Add("@ActiveId", entity.ActiveId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one Participant to database 
        /// </summary>
        public override void Insert(SqlConnection connection, ParticipantInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [participant] (");
            sb.Append("[participant_id],");
            sb.Append("[participant_kind],");
            sb.Append("[relation_id],");
            sb.Append("[active_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@ParticipantId,");
            sb.Append("@ParticipantKind,");
            sb.Append("@RelationId,");
            sb.Append("@ActiveId ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@ParticipantId", entity.ParticipantId);
            paramList.Add("@ParticipantKind", entity.ParticipantKind);
            paramList.Add("@RelationId", entity.RelationId);
            paramList.Add("@ActiveId", entity.ActiveId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one Participant to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, ParticipantInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [participant] (");
            sb.Append("[participant_id],");
            sb.Append("[participant_kind],");
            sb.Append("[relation_id],");
            sb.Append("[active_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@ParticipantId,");
            sb.Append("@ParticipantKind,");
            sb.Append("@RelationId,");
            sb.Append("@ActiveId ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@ParticipantId", entity.ParticipantId);
            paramList.Add("@ParticipantKind", entity.ParticipantKind);
            paramList.Add("@RelationId", entity.RelationId);
            paramList.Add("@ActiveId", entity.ActiveId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :participant_id/
        /// </summary>
        public override void Update(string connection_string, ParticipantInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [participant] set ");
            sb.Append("[participant_kind] = @ParticipantKind, ");
            sb.Append("[relation_id] = @RelationId, ");
            sb.Append("[active_id] = @ActiveId ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@ParticipantKind", entity.ParticipantKind);
            paramList.Add("@RelationId", entity.RelationId);
            paramList.Add("@ActiveId", entity.ActiveId);
            paramList.Add("@ParticipantId", entity.ParticipantId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :participant_id/
        /// </summary>
        public override void Update(SqlConnection connection, ParticipantInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [participant] set ");
            sb.Append("[participant_kind] = @ParticipantKind, ");
            sb.Append("[relation_id] = @RelationId, ");
            sb.Append("[active_id] = @ActiveId ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@ParticipantKind", entity.ParticipantKind);
            paramList.Add("@RelationId", entity.RelationId);
            paramList.Add("@ActiveId", entity.ActiveId);
            paramList.Add("@ParticipantId", entity.ParticipantId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :participant_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, ParticipantInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [participant] set ");
            sb.Append("[participant_kind] = @ParticipantKind, ");
            sb.Append("[relation_id] = @RelationId, ");
            sb.Append("[active_id] = @ActiveId ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@ParticipantKind", entity.ParticipantKind);
            paramList.Add("@RelationId", entity.RelationId);
            paramList.Add("@ActiveId", entity.ActiveId);
            paramList.Add("@ParticipantId", entity.ParticipantId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :participant_id/
        /// </summary>
        public override void Delete(string connection_string, ParticipantInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [participant] ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ParticipantId", entity.ParticipantId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :participant_id/
        /// </summary>
        public override void Delete(SqlConnection connection, ParticipantInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [participant] ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ParticipantId", entity.ParticipantId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :participant_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, ParticipantInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [participant] ");
            sb.Append("where [participant_id] = @ParticipantId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ParticipantId", entity.ParticipantId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to Participant
        /// warning: this row must include all the columns of table(participant)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(participant)</param>
        /// <returns>an entity of Participant</returns>
        public void FillEntityByRow(ParticipantInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("participant_id"))
            {
                entity.ParticipantId = (string)row["participant_id"];
            }
            else
            {
            }
            if (!row.IsNull("participant_kind"))
            {
                entity.ParticipantKind = (string)row["participant_kind"];
            }
            else
            {
            }
            if (!row.IsNull("relation_id"))
            {
                entity.RelationId = (string)row["relation_id"];
            }
            else
            {
            }
            if (!row.IsNull("active_id"))
            {
                entity.ActiveId = (string)row["active_id"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to Participant
        /// warning: this row must include all the columns of table(participant)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(participant)</param>
        /// <returns>an entity of Participant</returns>
        public override ParticipantInfo Row2Entity(System.Data.DataRow row)
        {
            ParticipantInfo entity = new ParticipantInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override ParticipantInfo Retrieve(SqlTransaction transaction, ParticipantInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [participant] ");
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
        public override ParticipantInfo Retrieve(SqlConnection connection, ParticipantInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [participant] ");
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
        public override ParticipantInfo Retrieve(string connection_string, ParticipantInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [participant] ");
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
