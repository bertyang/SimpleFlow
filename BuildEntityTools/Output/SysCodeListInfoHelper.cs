using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class SysCodeListInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<SysCodeListInfo>
    {
        public SysCodeListInfoHelper()
        {
        }

        /// <summary>
        ///  insert one SysCodeList to database 
        /// </summary>
        public override void Insert(string connection_string, SysCodeListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_code_list] (");
            sb.Append("[main_key],");
            sb.Append("[sub_key],");
            sb.Append("[content],");
            sb.Append("[description] ");
            sb.Append(" ) values ( ");
            sb.Append("@MainKey,");
            sb.Append("@SubKey,");
            sb.Append("@Content,");
            sb.Append("@Description ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@MainKey", entity.MainKey);
            paramList.Add("@SubKey", entity.SubKey);
            paramList.Add("@Content", entity.Content);
            paramList.Add("@Description", entity.Description);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysCodeList to database 
        /// </summary>
        public override void Insert(SqlConnection connection, SysCodeListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_code_list] (");
            sb.Append("[main_key],");
            sb.Append("[sub_key],");
            sb.Append("[content],");
            sb.Append("[description] ");
            sb.Append(" ) values ( ");
            sb.Append("@MainKey,");
            sb.Append("@SubKey,");
            sb.Append("@Content,");
            sb.Append("@Description ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@MainKey", entity.MainKey);
            paramList.Add("@SubKey", entity.SubKey);
            paramList.Add("@Content", entity.Content);
            paramList.Add("@Description", entity.Description);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysCodeList to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, SysCodeListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_code_list] (");
            sb.Append("[main_key],");
            sb.Append("[sub_key],");
            sb.Append("[content],");
            sb.Append("[description] ");
            sb.Append(" ) values ( ");
            sb.Append("@MainKey,");
            sb.Append("@SubKey,");
            sb.Append("@Content,");
            sb.Append("@Description ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@MainKey", entity.MainKey);
            paramList.Add("@SubKey", entity.SubKey);
            paramList.Add("@Content", entity.Content);
            paramList.Add("@Description", entity.Description);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :main_key/sub_key/
        /// </summary>
        public override void Update(string connection_string, SysCodeListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_code_list] set ");
            sb.Append("[content] = @Content, ");
            sb.Append("[description] = @Description ");
            sb.Append("where [main_key] = @MainKey ");
            sb.Append("and [sub_key] = @SubKey ");
            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@Content", entity.Content);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@MainKey", entity.MainKey);
            paramList.Add("@SubKey", entity.SubKey);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :main_key/sub_key/
        /// </summary>
        public override void Update(SqlConnection connection, SysCodeListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_code_list] set ");
            sb.Append("[content] = @Content, ");
            sb.Append("[description] = @Description ");
            sb.Append("where [main_key] = @MainKey ");
            sb.Append("and [sub_key] = @SubKey ");
            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@Content", entity.Content);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@MainKey", entity.MainKey);
            paramList.Add("@SubKey", entity.SubKey);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :main_key/sub_key/
        /// </summary>
        public override void Update(SqlTransaction transaction, SysCodeListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_code_list] set ");
            sb.Append("[content] = @Content, ");
            sb.Append("[description] = @Description ");
            sb.Append("where [main_key] = @MainKey ");
            sb.Append("and [sub_key] = @SubKey ");
            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@Content", entity.Content);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@MainKey", entity.MainKey);
            paramList.Add("@SubKey", entity.SubKey);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :main_key/sub_key/
        /// </summary>
        public override void Delete(string connection_string, SysCodeListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_code_list] ");
            sb.Append("where [main_key] = @MainKey ");
            sb.Append("and [sub_key] = @SubKey ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MainKey", entity.MainKey);
            paramList.Add("@SubKey", entity.SubKey);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :main_key/sub_key/
        /// </summary>
        public override void Delete(SqlConnection connection, SysCodeListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_code_list] ");
            sb.Append("where [main_key] = @MainKey ");
            sb.Append("and [sub_key] = @SubKey ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MainKey", entity.MainKey);
            paramList.Add("@SubKey", entity.SubKey);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :main_key/sub_key/
        /// </summary>
        public override void Delete(SqlTransaction transaction, SysCodeListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_code_list] ");
            sb.Append("where [main_key] = @MainKey ");
            sb.Append("and [sub_key] = @SubKey ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MainKey", entity.MainKey);
            paramList.Add("@SubKey", entity.SubKey);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to SysCodeList
        /// warning: this row must include all the columns of table(sys_code_list)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_code_list)</param>
        /// <returns>an entity of SysCodeList</returns>
        public void FillEntityByRow(SysCodeListInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("main_key"))
            {
                entity.MainKey = (string)row["main_key"];
            }
            else
            {
            }
            if (!row.IsNull("sub_key"))
            {
                entity.SubKey = (string)row["sub_key"];
            }
            else
            {
            }
            if (!row.IsNull("content"))
            {
                entity.Content = (string)row["content"];
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
        /// convert one row to SysCodeList
        /// warning: this row must include all the columns of table(sys_code_list)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_code_list)</param>
        /// <returns>an entity of SysCodeList</returns>
        public override SysCodeListInfo Row2Entity(System.Data.DataRow row)
        {
            SysCodeListInfo entity = new SysCodeListInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysCodeListInfo Retrieve(SqlTransaction transaction, SysCodeListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_code_list] ");
            sb.Append("where [main_key] = @MainKey ");
            sb.Append("and [sub_key] = @SubKey ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MainKey", entity.MainKey);
            paramList.Add("@SubKey", entity.SubKey);

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
        public override SysCodeListInfo Retrieve(SqlConnection connection, SysCodeListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_code_list] ");
            sb.Append("where [main_key] = @MainKey ");
            sb.Append("and [sub_key] = @SubKey ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MainKey", entity.MainKey);
            paramList.Add("@SubKey", entity.SubKey);

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
        public override SysCodeListInfo Retrieve(string connection_string, SysCodeListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_code_list] ");
            sb.Append("where [main_key] = @MainKey ");
            sb.Append("and [sub_key] = @SubKey ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MainKey", entity.MainKey);
            paramList.Add("@SubKey", entity.SubKey);

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
