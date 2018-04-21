using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class SysObjectsInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<SysObjectsInfo>
    {
        public SysObjectsInfoHelper()
        {
        }

        /// <summary>
        ///  insert one SysObjects to database 
        /// </summary>
        public override void Insert(string connection_string, SysObjectsInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_objects] (");
            sb.Append("[object_type],");
            sb.Append("[max_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@ObjectType,");
            sb.Append("@MaxId ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@ObjectType", entity.ObjectType);
            paramList.Add("@MaxId", entity.MaxId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysObjects to database 
        /// </summary>
        public override void Insert(SqlConnection connection, SysObjectsInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_objects] (");
            sb.Append("[object_type],");
            sb.Append("[max_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@ObjectType,");
            sb.Append("@MaxId ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@ObjectType", entity.ObjectType);
            paramList.Add("@MaxId", entity.MaxId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysObjects to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, SysObjectsInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_objects] (");
            sb.Append("[object_type],");
            sb.Append("[max_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@ObjectType,");
            sb.Append("@MaxId ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@ObjectType", entity.ObjectType);
            paramList.Add("@MaxId", entity.MaxId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :object_type/
        /// </summary>
        public override void Update(string connection_string, SysObjectsInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_objects] set ");
            sb.Append("[max_id] = @MaxId ");
            sb.Append("where [object_type] = @ObjectType ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MaxId", entity.MaxId);
            paramList.Add("@ObjectType", entity.ObjectType);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :object_type/
        /// </summary>
        public override void Update(SqlConnection connection, SysObjectsInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_objects] set ");
            sb.Append("[max_id] = @MaxId ");
            sb.Append("where [object_type] = @ObjectType ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MaxId", entity.MaxId);
            paramList.Add("@ObjectType", entity.ObjectType);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :object_type/
        /// </summary>
        public override void Update(SqlTransaction transaction, SysObjectsInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_objects] set ");
            sb.Append("[max_id] = @MaxId ");
            sb.Append("where [object_type] = @ObjectType ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MaxId", entity.MaxId);
            paramList.Add("@ObjectType", entity.ObjectType);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :object_type/
        /// </summary>
        public override void Delete(string connection_string, SysObjectsInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_objects] ");
            sb.Append("where [object_type] = @ObjectType ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ObjectType", entity.ObjectType);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :object_type/
        /// </summary>
        public override void Delete(SqlConnection connection, SysObjectsInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_objects] ");
            sb.Append("where [object_type] = @ObjectType ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ObjectType", entity.ObjectType);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :object_type/
        /// </summary>
        public override void Delete(SqlTransaction transaction, SysObjectsInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_objects] ");
            sb.Append("where [object_type] = @ObjectType ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ObjectType", entity.ObjectType);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to SysObjects
        /// warning: this row must include all the columns of table(sys_objects)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_objects)</param>
        /// <returns>an entity of SysObjects</returns>
        public void FillEntityByRow(SysObjectsInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("object_type"))
            {
                entity.ObjectType = (string)row["object_type"];
            }
            else
            {
            }
            if (!row.IsNull("max_id"))
            {
                entity.MaxId = (int)row["max_id"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to SysObjects
        /// warning: this row must include all the columns of table(sys_objects)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_objects)</param>
        /// <returns>an entity of SysObjects</returns>
        public override SysObjectsInfo Row2Entity(System.Data.DataRow row)
        {
            SysObjectsInfo entity = new SysObjectsInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysObjectsInfo Retrieve(SqlTransaction transaction, SysObjectsInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_objects] ");
            sb.Append("where [object_type] = @ObjectType ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ObjectType", entity.ObjectType);

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
        public override SysObjectsInfo Retrieve(SqlConnection connection, SysObjectsInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_objects] ");
            sb.Append("where [object_type] = @ObjectType ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ObjectType", entity.ObjectType);

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
        public override SysObjectsInfo Retrieve(string connection_string, SysObjectsInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_objects] ");
            sb.Append("where [object_type] = @ObjectType ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@ObjectType", entity.ObjectType);

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
