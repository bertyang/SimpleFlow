using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class SysConfigInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<SysConfigInfo>
    {
        public SysConfigInfoHelper()
        {
        }

        /// <summary>
        ///  insert one SysConfig to database 
        /// </summary>
        public override void Insert(string connection_string, SysConfigInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_config] (");
            sb.Append("[config_id],");
            sb.Append("[config_value] ");
            sb.Append(" ) values ( ");
            sb.Append("@ConfigId,");
            sb.Append("@ConfigValue ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@ConfigId", entity.ConfigId);
            paramList.Add("@ConfigValue", entity.ConfigValue);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysConfig to database 
        /// </summary>
        public override void Insert(SqlConnection connection, SysConfigInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_config] (");
            sb.Append("[config_id],");
            sb.Append("[config_value] ");
            sb.Append(" ) values ( ");
            sb.Append("@ConfigId,");
            sb.Append("@ConfigValue ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@ConfigId", entity.ConfigId);
            paramList.Add("@ConfigValue", entity.ConfigValue);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysConfig to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, SysConfigInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_config] (");
            sb.Append("[config_id],");
            sb.Append("[config_value] ");
            sb.Append(" ) values ( ");
            sb.Append("@ConfigId,");
            sb.Append("@ConfigValue ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@ConfigId", entity.ConfigId);
            paramList.Add("@ConfigValue", entity.ConfigValue);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :config_id/
        /// </summary>
        public override void Update(string connection_string, SysConfigInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_config] set ");
            sb.Append("[config_value] = @ConfigValue ");
            sb.Append("where [config_id] = @ConfigId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@ConfigValue", entity.ConfigValue);
            paramList.Add("@ConfigId", entity.ConfigId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :config_id/
        /// </summary>
        public override void Update(SqlConnection connection, SysConfigInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_config] set ");
            sb.Append("[config_value] = @ConfigValue ");
            sb.Append("where [config_id] = @ConfigId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@ConfigValue", entity.ConfigValue);
            paramList.Add("@ConfigId", entity.ConfigId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :config_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, SysConfigInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_config] set ");
            sb.Append("[config_value] = @ConfigValue ");
            sb.Append("where [config_id] = @ConfigId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@ConfigValue", entity.ConfigValue);
            paramList.Add("@ConfigId", entity.ConfigId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :config_id/
        /// </summary>
        public override void Delete(string connection_string, SysConfigInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_config] ");
            sb.Append("where [config_id] = @ConfigId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ConfigId", entity.ConfigId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :config_id/
        /// </summary>
        public override void Delete(SqlConnection connection, SysConfigInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_config] ");
            sb.Append("where [config_id] = @ConfigId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ConfigId", entity.ConfigId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :config_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, SysConfigInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_config] ");
            sb.Append("where [config_id] = @ConfigId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ConfigId", entity.ConfigId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to SysConfig
        /// warning: this row must include all the columns of table(sys_config)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_config)</param>
        /// <returns>an entity of SysConfig</returns>
        public void FillEntityByRow(SysConfigInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("config_id"))
            {
                entity.ConfigId = (string)row["config_id"];
            }
            else
            {
            }
            if (!row.IsNull("config_value"))
            {
                entity.ConfigValue = (string)row["config_value"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to SysConfig
        /// warning: this row must include all the columns of table(sys_config)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_config)</param>
        /// <returns>an entity of SysConfig</returns>
        public override SysConfigInfo Row2Entity(System.Data.DataRow row)
        {
            SysConfigInfo entity = new SysConfigInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysConfigInfo Retrieve(SqlTransaction transaction, SysConfigInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_config] ");
            sb.Append("where [config_id] = @ConfigId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ConfigId", entity.ConfigId);

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
        public override SysConfigInfo Retrieve(SqlConnection connection, SysConfigInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_config] ");
            sb.Append("where [config_id] = @ConfigId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ConfigId", entity.ConfigId);

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
        public override SysConfigInfo Retrieve(string connection_string, SysConfigInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_config] ");
            sb.Append("where [config_id] = @ConfigId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ConfigId", entity.ConfigId);

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
