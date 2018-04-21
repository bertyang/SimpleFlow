using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class MdOrgInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<MdOrgInfo>
    {
        public MdOrgInfoHelper()
        {
        }

        /// <summary>
        ///  insert one MdOrg to database 
        /// </summary>
        public override void Insert(string connection_string, MdOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [md_org] (");
            sb.Append("[model_id],");
            sb.Append("[user_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@ModelId,");
            sb.Append("@UserId ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@ModelId", entity.ModelId);
            paramList.Add("@UserId", entity.UserId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one MdOrg to database 
        /// </summary>
        public override void Insert(SqlConnection connection, MdOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [md_org] (");
            sb.Append("[model_id],");
            sb.Append("[user_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@ModelId,");
            sb.Append("@UserId ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@ModelId", entity.ModelId);
            paramList.Add("@UserId", entity.UserId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one MdOrg to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, MdOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [md_org] (");
            sb.Append("[model_id],");
            sb.Append("[user_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@ModelId,");
            sb.Append("@UserId ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@ModelId", entity.ModelId);
            paramList.Add("@UserId", entity.UserId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :model_id/
        /// </summary>
        public override void Update(string connection_string, MdOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [md_org] set ");
            sb.Append("[user_id] = @UserId ");
            sb.Append("where [model_id] = @ModelId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@UserId", entity.UserId);
            paramList.Add("@ModelId", entity.ModelId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :model_id/
        /// </summary>
        public override void Update(SqlConnection connection, MdOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [md_org] set ");
            sb.Append("[user_id] = @UserId ");
            sb.Append("where [model_id] = @ModelId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@UserId", entity.UserId);
            paramList.Add("@ModelId", entity.ModelId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :model_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, MdOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [md_org] set ");
            sb.Append("[user_id] = @UserId ");
            sb.Append("where [model_id] = @ModelId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@UserId", entity.UserId);
            paramList.Add("@ModelId", entity.ModelId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :model_id/
        /// </summary>
        public override void Delete(string connection_string, MdOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [md_org] ");
            sb.Append("where [model_id] = @ModelId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ModelId", entity.ModelId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :model_id/
        /// </summary>
        public override void Delete(SqlConnection connection, MdOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [md_org] ");
            sb.Append("where [model_id] = @ModelId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ModelId", entity.ModelId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :model_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, MdOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [md_org] ");
            sb.Append("where [model_id] = @ModelId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ModelId", entity.ModelId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to MdOrg
        /// warning: this row must include all the columns of table(md_org)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(md_org)</param>
        /// <returns>an entity of MdOrg</returns>
        public void FillEntityByRow(MdOrgInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("model_id"))
            {
                entity.ModelId = (string)row["model_id"];
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
        /// convert one row to MdOrg
        /// warning: this row must include all the columns of table(md_org)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(md_org)</param>
        /// <returns>an entity of MdOrg</returns>
        public override MdOrgInfo Row2Entity(System.Data.DataRow row)
        {
            MdOrgInfo entity = new MdOrgInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override MdOrgInfo Retrieve(SqlTransaction transaction, MdOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [md_org] ");
            sb.Append("where [model_id] = @ModelId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ModelId", entity.ModelId);

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
        public override MdOrgInfo Retrieve(SqlConnection connection, MdOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [md_org] ");
            sb.Append("where [model_id] = @ModelId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ModelId", entity.ModelId);

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
        public override MdOrgInfo Retrieve(string connection_string, MdOrgInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [md_org] ");
            sb.Append("where [model_id] = @ModelId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ModelId", entity.ModelId);

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
