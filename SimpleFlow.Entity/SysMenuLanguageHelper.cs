using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class SysMenuLanguageHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<SysMenuLanguage>
    {
        public SysMenuLanguageHelper()
        {
        }

        /// <summary>
        ///  insert one SysMenuLanguage to database 
        /// </summary>
        public override void Insert(string connection_string, SysMenuLanguage entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_menu_language] (");
            sb.Append("[menu_id],");
            sb.Append("[language_id],");
            sb.Append("[menu_name] ");
            sb.Append(" ) values ( ");
            sb.Append("@MenuId,");
            sb.Append("@LanguageId,");
            sb.Append("@MenuName ) ");

            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@LanguageId", entity.LanguageId);
            paramList.Add("@MenuName", entity.MenuName);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysMenuLanguage to database 
        /// </summary>
        public override void Insert(SqlConnection connection, SysMenuLanguage entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_menu_language] (");
            sb.Append("[menu_id],");
            sb.Append("[language_id],");
            sb.Append("[menu_name] ");
            sb.Append(" ) values ( ");
            sb.Append("@MenuId,");
            sb.Append("@LanguageId,");
            sb.Append("@MenuName ) ");

            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@LanguageId", entity.LanguageId);
            paramList.Add("@MenuName", entity.MenuName);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysMenuLanguage to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, SysMenuLanguage entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_menu_language] (");
            sb.Append("[menu_id],");
            sb.Append("[language_id],");
            sb.Append("[menu_name] ");
            sb.Append(" ) values ( ");
            sb.Append("@MenuId,");
            sb.Append("@LanguageId,");
            sb.Append("@MenuName ) ");

            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@LanguageId", entity.LanguageId);
            paramList.Add("@MenuName", entity.MenuName);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :menu_id/language_id/
        /// </summary>
        public override void Update(string connection_string, SysMenuLanguage entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_menu_language] set ");
            sb.Append("[menu_name] = @MenuName ");
            sb.Append("where [menu_id] = @MenuId ");
            sb.Append("and [language_id] = @LanguageId ");
            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@MenuName", entity.MenuName);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@LanguageId", entity.LanguageId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :menu_id/language_id/
        /// </summary>
        public override void Update(SqlConnection connection, SysMenuLanguage entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_menu_language] set ");
            sb.Append("[menu_name] = @MenuName ");
            sb.Append("where [menu_id] = @MenuId ");
            sb.Append("and [language_id] = @LanguageId ");
            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@MenuName", entity.MenuName);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@LanguageId", entity.LanguageId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :menu_id/language_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, SysMenuLanguage entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_menu_language] set ");
            sb.Append("[menu_name] = @MenuName ");
            sb.Append("where [menu_id] = @MenuId ");
            sb.Append("and [language_id] = @LanguageId ");
            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@MenuName", entity.MenuName);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@LanguageId", entity.LanguageId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :menu_id/language_id/
        /// </summary>
        public override void Delete(string connection_string, SysMenuLanguage entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_menu_language] ");
            sb.Append("where [menu_id] = @MenuId ");
            sb.Append("and [language_id] = @LanguageId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@LanguageId", entity.LanguageId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :menu_id/language_id/
        /// </summary>
        public override void Delete(SqlConnection connection, SysMenuLanguage entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_menu_language] ");
            sb.Append("where [menu_id] = @MenuId ");
            sb.Append("and [language_id] = @LanguageId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@LanguageId", entity.LanguageId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :menu_id/language_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, SysMenuLanguage entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_menu_language] ");
            sb.Append("where [menu_id] = @MenuId ");
            sb.Append("and [language_id] = @LanguageId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@LanguageId", entity.LanguageId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to SysMenuLanguage
        /// warning: this row must include all the columns of table(sys_menu_language)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_menu_language)</param>
        /// <returns>an entity of SysMenuLanguage</returns>
        public void FillEntityByRow(SysMenuLanguage entity, System.Data.DataRow row)
        {
            if (!row.IsNull("menu_id"))
            {
                entity.MenuId = (string)row["menu_id"];
            }
            else
            {
            }
            if (!row.IsNull("language_id"))
            {
                entity.LanguageId = (string)row["language_id"];
            }
            else
            {
            }
            if (!row.IsNull("menu_name"))
            {
                entity.MenuName = (string)row["menu_name"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to SysMenuLanguage
        /// warning: this row must include all the columns of table(sys_menu_language)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_menu_language)</param>
        /// <returns>an entity of SysMenuLanguage</returns>
        public override SysMenuLanguage Row2Entity(System.Data.DataRow row)
        {
            SysMenuLanguage entity = new SysMenuLanguage();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysMenuLanguage Retrieve(SqlTransaction transaction, SysMenuLanguage entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_menu_language] ");
            sb.Append("where [menu_id] = @MenuId ");
            sb.Append("and [language_id] = @LanguageId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@LanguageId", entity.LanguageId);

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
        public override SysMenuLanguage Retrieve(SqlConnection connection, SysMenuLanguage entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_menu_language] ");
            sb.Append("where [menu_id] = @MenuId ");
            sb.Append("and [language_id] = @LanguageId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@LanguageId", entity.LanguageId);

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
        public override SysMenuLanguage Retrieve(string connection_string, SysMenuLanguage entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_menu_language] ");
            sb.Append("where [menu_id] = @MenuId ");
            sb.Append("and [language_id] = @LanguageId ");
            ParameterBuilder paramList = new ParameterBuilder(2);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@LanguageId", entity.LanguageId);

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
