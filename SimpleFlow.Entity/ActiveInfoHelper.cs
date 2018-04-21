using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class ActiveInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<ActiveInfo>
    {
        public ActiveInfoHelper()
        {
        }

        /// <summary>
        ///  insert one Active to database 
        /// </summary>
        public override void Insert(string connection_string, ActiveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [active] (");
            sb.Append("[active_id],");
            sb.Append("[active_name],");
            sb.Append("[active_type],");
            sb.Append("[form_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@ActiveId,");
            sb.Append("@ActiveName,");
            sb.Append("@ActiveType,");
            sb.Append("@FormId ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@ActiveId", entity.ActiveId);
            paramList.Add("@ActiveName", entity.ActiveName);
            paramList.Add("@ActiveType", entity.ActiveType);
            paramList.Add("@FormId", entity.FormId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one Active to database 
        /// </summary>
        public override void Insert(SqlConnection connection, ActiveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [active] (");
            sb.Append("[active_id],");
            sb.Append("[active_name],");
            sb.Append("[active_type],");
            sb.Append("[form_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@ActiveId,");
            sb.Append("@ActiveName,");
            sb.Append("@ActiveType,");
            sb.Append("@FormId ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@ActiveId", entity.ActiveId);
            paramList.Add("@ActiveName", entity.ActiveName);
            paramList.Add("@ActiveType", entity.ActiveType);
            paramList.Add("@FormId", entity.FormId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one Active to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, ActiveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [active] (");
            sb.Append("[active_id],");
            sb.Append("[active_name],");
            sb.Append("[active_type],");
            sb.Append("[form_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@ActiveId,");
            sb.Append("@ActiveName,");
            sb.Append("@ActiveType,");
            sb.Append("@FormId ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@ActiveId", entity.ActiveId);
            paramList.Add("@ActiveName", entity.ActiveName);
            paramList.Add("@ActiveType", entity.ActiveType);
            paramList.Add("@FormId", entity.FormId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :active_id/
        /// </summary>
        public override void Update(string connection_string, ActiveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [active] set ");
            sb.Append("[active_name] = @ActiveName, ");
            sb.Append("[active_type] = @ActiveType, ");
            sb.Append("[form_id] = @FormId ");
            sb.Append("where [active_id] = @ActiveId ");
            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@ActiveName", entity.ActiveName);
            paramList.Add("@ActiveType", entity.ActiveType);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@ActiveId", entity.ActiveId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :active_id/
        /// </summary>
        public override void Update(SqlConnection connection, ActiveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [active] set ");
            sb.Append("[active_name] = @ActiveName, ");
            sb.Append("[active_type] = @ActiveType, ");
            sb.Append("[form_id] = @FormId ");
            sb.Append("where [active_id] = @ActiveId ");
            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@ActiveName", entity.ActiveName);
            paramList.Add("@ActiveType", entity.ActiveType);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@ActiveId", entity.ActiveId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :active_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, ActiveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [active] set ");
            sb.Append("[active_name] = @ActiveName, ");
            sb.Append("[active_type] = @ActiveType, ");
            sb.Append("[form_id] = @FormId ");
            sb.Append("where [active_id] = @ActiveId ");
            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@ActiveName", entity.ActiveName);
            paramList.Add("@ActiveType", entity.ActiveType);
            paramList.Add("@FormId", entity.FormId);
            paramList.Add("@ActiveId", entity.ActiveId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :active_id/
        /// </summary>
        public override void Delete(string connection_string, ActiveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [active] ");
            sb.Append("where [active_id] = @ActiveId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ActiveId", entity.ActiveId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :active_id/
        /// </summary>
        public override void Delete(SqlConnection connection, ActiveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [active] ");
            sb.Append("where [active_id] = @ActiveId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ActiveId", entity.ActiveId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :active_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, ActiveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [active] ");
            sb.Append("where [active_id] = @ActiveId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ActiveId", entity.ActiveId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to Active
        /// warning: this row must include all the columns of table(active)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(active)</param>
        /// <returns>an entity of Active</returns>
        public void FillEntityByRow(ActiveInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("active_id"))
            {
                entity.ActiveId = (string)row["active_id"];
            }
            else
            {
            }
            if (!row.IsNull("active_name"))
            {
                entity.ActiveName = (string)row["active_name"];
            }
            else
            {
            }
            if (!row.IsNull("active_type"))
            {
                entity.ActiveType = (string)row["active_type"];
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
        }

        /// <summary>
        /// convert one row to Active
        /// warning: this row must include all the columns of table(active)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(active)</param>
        /// <returns>an entity of Active</returns>
        public override ActiveInfo Row2Entity(System.Data.DataRow row)
        {
            ActiveInfo entity = new ActiveInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override ActiveInfo Retrieve(SqlTransaction transaction, ActiveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [active] ");
            sb.Append("where [active_id] = @ActiveId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ActiveId", entity.ActiveId);

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
        public override ActiveInfo Retrieve(SqlConnection connection, ActiveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [active] ");
            sb.Append("where [active_id] = @ActiveId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ActiveId", entity.ActiveId);

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
        public override ActiveInfo Retrieve(string connection_string, ActiveInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [active] ");
            sb.Append("where [active_id] = @ActiveId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ActiveId", entity.ActiveId);

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
