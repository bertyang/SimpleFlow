using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class SysCodeMasterHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<SysCodeMaster>
    {
        public SysCodeMasterHelper()
        {
        }

        /// <summary>
        ///  insert one SysCodeMaster to database 
        /// </summary>
        public override void Insert(string connection_string, SysCodeMaster entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_code_master] (");
            sb.Append("[main_key],");
            sb.Append("[description] ");
            sb.Append(" ) values ( ");
            sb.Append("@MainKey,");
            sb.Append("@Description ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MainKey", entity.MainKey);
            paramList.Add("@Description", entity.Description);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysCodeMaster to database 
        /// </summary>
        public override void Insert(SqlConnection connection, SysCodeMaster entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_code_master] (");
            sb.Append("[main_key],");
            sb.Append("[description] ");
            sb.Append(" ) values ( ");
            sb.Append("@MainKey,");
            sb.Append("@Description ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MainKey", entity.MainKey);
            paramList.Add("@Description", entity.Description);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysCodeMaster to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, SysCodeMaster entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_code_master] (");
            sb.Append("[main_key],");
            sb.Append("[description] ");
            sb.Append(" ) values ( ");
            sb.Append("@MainKey,");
            sb.Append("@Description ) ");

            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MainKey", entity.MainKey);
            paramList.Add("@Description", entity.Description);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :main_key/
        /// </summary>
        public override void Update(string connection_string, SysCodeMaster entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_code_master] set ");
            sb.Append("[description] = @Description ");
            sb.Append("where [main_key] = @MainKey ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@MainKey", entity.MainKey);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :main_key/
        /// </summary>
        public override void Update(SqlConnection connection, SysCodeMaster entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_code_master] set ");
            sb.Append("[description] = @Description ");
            sb.Append("where [main_key] = @MainKey ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@MainKey", entity.MainKey);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :main_key/
        /// </summary>
        public override void Update(SqlTransaction transaction, SysCodeMaster entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_code_master] set ");
            sb.Append("[description] = @Description ");
            sb.Append("where [main_key] = @MainKey ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@MainKey", entity.MainKey);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :main_key/
        /// </summary>
        public override void Delete(string connection_string, SysCodeMaster entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_code_master] ");
            sb.Append("where [main_key] = @MainKey ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@MainKey", entity.MainKey);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :main_key/
        /// </summary>
        public override void Delete(SqlConnection connection, SysCodeMaster entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_code_master] ");
            sb.Append("where [main_key] = @MainKey ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@MainKey", entity.MainKey);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :main_key/
        /// </summary>
        public override void Delete(SqlTransaction transaction, SysCodeMaster entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_code_master] ");
            sb.Append("where [main_key] = @MainKey ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@MainKey", entity.MainKey);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to SysCodeMaster
        /// warning: this row must include all the columns of table(sys_code_master)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_code_master)</param>
        /// <returns>an entity of SysCodeMaster</returns>
        public void FillEntityByRow(SysCodeMaster entity, System.Data.DataRow row)
        {
            if (!row.IsNull("main_key"))
            {
                entity.MainKey = (string)row["main_key"];
            }
            else
            {
            }
            if (!row.IsNull("description"))
            {
                entity.Description = (string)row["description"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to SysCodeMaster
        /// warning: this row must include all the columns of table(sys_code_master)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_code_master)</param>
        /// <returns>an entity of SysCodeMaster</returns>
        public override SysCodeMaster Row2Entity(System.Data.DataRow row)
        {
            SysCodeMaster entity = new SysCodeMaster();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysCodeMaster Retrieve(SqlTransaction transaction, SysCodeMaster entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_code_master] ");
            sb.Append("where [main_key] = @MainKey ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@MainKey", entity.MainKey);

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
        public override SysCodeMaster Retrieve(SqlConnection connection, SysCodeMaster entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_code_master] ");
            sb.Append("where [main_key] = @MainKey ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@MainKey", entity.MainKey);

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
        public override SysCodeMaster Retrieve(string connection_string, SysCodeMaster entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_code_master] ");
            sb.Append("where [main_key] = @MainKey ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@MainKey", entity.MainKey);

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
