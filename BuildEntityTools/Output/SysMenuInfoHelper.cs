using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class SysMenuInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<SysMenuInfo>
    {
        public SysMenuInfoHelper()
        {
        }

        /// <summary>
        ///  insert one SysMenu to database 
        /// </summary>
        public override void Insert(string connection_string, SysMenuInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_menu] (");
            sb.Append("[menu_id],");
            sb.Append("[menu_name],");
            sb.Append("[description],");
            sb.Append("[parent_id],");
            sb.Append("[type_id],");
            sb.Append("[url],");
            sb.Append("[is_valid],");
            sb.Append("[display_order] ");
            sb.Append(" ) values ( ");
            sb.Append("@MenuId,");
            sb.Append("@MenuName,");
            sb.Append("@Description,");
            sb.Append("@ParentId,");
            sb.Append("@TypeId,");
            sb.Append("@Url,");
            sb.Append("@IsValid,");
            sb.Append("@DisplayOrder ) ");

            ParameterBuilder paramList = new ParameterBuilder(8);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@MenuName", entity.MenuName);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@ParentId", entity.ParentId);
            paramList.Add("@TypeId", entity.TypeId);
            paramList.Add("@Url", entity.Url);
            paramList.Add("@IsValid", entity.IsValid);
            paramList.Add("@DisplayOrder", entity.DisplayOrder);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysMenu to database 
        /// </summary>
        public override void Insert(SqlConnection connection, SysMenuInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_menu] (");
            sb.Append("[menu_id],");
            sb.Append("[menu_name],");
            sb.Append("[description],");
            sb.Append("[parent_id],");
            sb.Append("[type_id],");
            sb.Append("[url],");
            sb.Append("[is_valid],");
            sb.Append("[display_order] ");
            sb.Append(" ) values ( ");
            sb.Append("@MenuId,");
            sb.Append("@MenuName,");
            sb.Append("@Description,");
            sb.Append("@ParentId,");
            sb.Append("@TypeId,");
            sb.Append("@Url,");
            sb.Append("@IsValid,");
            sb.Append("@DisplayOrder ) ");

            ParameterBuilder paramList = new ParameterBuilder(8);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@MenuName", entity.MenuName);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@ParentId", entity.ParentId);
            paramList.Add("@TypeId", entity.TypeId);
            paramList.Add("@Url", entity.Url);
            paramList.Add("@IsValid", entity.IsValid);
            paramList.Add("@DisplayOrder", entity.DisplayOrder);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysMenu to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, SysMenuInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_menu] (");
            sb.Append("[menu_id],");
            sb.Append("[menu_name],");
            sb.Append("[description],");
            sb.Append("[parent_id],");
            sb.Append("[type_id],");
            sb.Append("[url],");
            sb.Append("[is_valid],");
            sb.Append("[display_order] ");
            sb.Append(" ) values ( ");
            sb.Append("@MenuId,");
            sb.Append("@MenuName,");
            sb.Append("@Description,");
            sb.Append("@ParentId,");
            sb.Append("@TypeId,");
            sb.Append("@Url,");
            sb.Append("@IsValid,");
            sb.Append("@DisplayOrder ) ");

            ParameterBuilder paramList = new ParameterBuilder(8);
            paramList.Add("@MenuId", entity.MenuId);
            paramList.Add("@MenuName", entity.MenuName);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@ParentId", entity.ParentId);
            paramList.Add("@TypeId", entity.TypeId);
            paramList.Add("@Url", entity.Url);
            paramList.Add("@IsValid", entity.IsValid);
            paramList.Add("@DisplayOrder", entity.DisplayOrder);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :menu_id/
        /// </summary>
        public override void Update(string connection_string, SysMenuInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_menu] set ");
            sb.Append("[menu_name] = @MenuName, ");
            sb.Append("[description] = @Description, ");
            sb.Append("[parent_id] = @ParentId, ");
            sb.Append("[type_id] = @TypeId, ");
            sb.Append("[url] = @Url, ");
            sb.Append("[is_valid] = @IsValid, ");
            sb.Append("[display_order] = @DisplayOrder ");
            sb.Append("where [menu_id] = @MenuId ");
            ParameterBuilder paramList = new ParameterBuilder(8);
            paramList.Add("@MenuName", entity.MenuName);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@ParentId", entity.ParentId);
            paramList.Add("@TypeId", entity.TypeId);
            paramList.Add("@Url", entity.Url);
            paramList.Add("@IsValid", entity.IsValid);
            paramList.Add("@DisplayOrder", entity.DisplayOrder);
            paramList.Add("@MenuId", entity.MenuId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :menu_id/
        /// </summary>
        public override void Update(SqlConnection connection, SysMenuInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_menu] set ");
            sb.Append("[menu_name] = @MenuName, ");
            sb.Append("[description] = @Description, ");
            sb.Append("[parent_id] = @ParentId, ");
            sb.Append("[type_id] = @TypeId, ");
            sb.Append("[url] = @Url, ");
            sb.Append("[is_valid] = @IsValid, ");
            sb.Append("[display_order] = @DisplayOrder ");
            sb.Append("where [menu_id] = @MenuId ");
            ParameterBuilder paramList = new ParameterBuilder(8);
            paramList.Add("@MenuName", entity.MenuName);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@ParentId", entity.ParentId);
            paramList.Add("@TypeId", entity.TypeId);
            paramList.Add("@Url", entity.Url);
            paramList.Add("@IsValid", entity.IsValid);
            paramList.Add("@DisplayOrder", entity.DisplayOrder);
            paramList.Add("@MenuId", entity.MenuId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :menu_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, SysMenuInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_menu] set ");
            sb.Append("[menu_name] = @MenuName, ");
            sb.Append("[description] = @Description, ");
            sb.Append("[parent_id] = @ParentId, ");
            sb.Append("[type_id] = @TypeId, ");
            sb.Append("[url] = @Url, ");
            sb.Append("[is_valid] = @IsValid, ");
            sb.Append("[display_order] = @DisplayOrder ");
            sb.Append("where [menu_id] = @MenuId ");
            ParameterBuilder paramList = new ParameterBuilder(8);
            paramList.Add("@MenuName", entity.MenuName);
            paramList.Add("@Description", entity.Description);
            paramList.Add("@ParentId", entity.ParentId);
            paramList.Add("@TypeId", entity.TypeId);
            paramList.Add("@Url", entity.Url);
            paramList.Add("@IsValid", entity.IsValid);
            paramList.Add("@DisplayOrder", entity.DisplayOrder);
            paramList.Add("@MenuId", entity.MenuId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :menu_id/
        /// </summary>
        public override void Delete(string connection_string, SysMenuInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_menu] ");
            sb.Append("where [menu_id] = @MenuId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@MenuId", entity.MenuId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :menu_id/
        /// </summary>
        public override void Delete(SqlConnection connection, SysMenuInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_menu] ");
            sb.Append("where [menu_id] = @MenuId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@MenuId", entity.MenuId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :menu_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, SysMenuInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_menu] ");
            sb.Append("where [menu_id] = @MenuId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@MenuId", entity.MenuId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to SysMenu
        /// warning: this row must include all the columns of table(sys_menu)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_menu)</param>
        /// <returns>an entity of SysMenu</returns>
        public void FillEntityByRow(SysMenuInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("menu_id"))
            {
                entity.MenuId = (string)row["menu_id"];
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
            if (!row.IsNull("description"))
            {
                entity.Description = (string)row["description"];
            }
            else
            {
            }
            if (!row.IsNull("parent_id"))
            {
                entity.ParentId = (string)row["parent_id"];
            }
            else
            {
            }
            if (!row.IsNull("type_id"))
            {
                entity.TypeId = (int)row["type_id"];
            }
            else
            {
            }
            if (!row.IsNull("url"))
            {
                entity.Url = (string)row["url"];
            }
            else
            {
            }
            if (!row.IsNull("is_valid"))
            {
                entity.IsValid = (string)row["is_valid"];
            }
            else
            {
            }
            if (!row.IsNull("display_order"))
            {
                entity.DisplayOrder = (int)row["display_order"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to SysMenu
        /// warning: this row must include all the columns of table(sys_menu)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_menu)</param>
        /// <returns>an entity of SysMenu</returns>
        public override SysMenuInfo Row2Entity(System.Data.DataRow row)
        {
            SysMenuInfo entity = new SysMenuInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysMenuInfo Retrieve(SqlTransaction transaction, SysMenuInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_menu] ");
            sb.Append("where [menu_id] = @MenuId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@MenuId", entity.MenuId);

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
        public override SysMenuInfo Retrieve(SqlConnection connection, SysMenuInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_menu] ");
            sb.Append("where [menu_id] = @MenuId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@MenuId", entity.MenuId);

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
        public override SysMenuInfo Retrieve(string connection_string, SysMenuInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_menu] ");
            sb.Append("where [menu_id] = @MenuId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@MenuId", entity.MenuId);

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
