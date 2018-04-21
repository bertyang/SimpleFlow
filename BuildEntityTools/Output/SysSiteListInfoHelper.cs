using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class SysSiteListInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<SysSiteListInfo>
    {
        public SysSiteListInfoHelper()
        {
        }

        /// <summary>
        ///  insert one SysSiteList to database 
        /// </summary>
        public override void Insert(string connection_string, SysSiteListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_site_list] (");
            sb.Append("[site_serial],");
            sb.Append("[site_name],");
            sb.Append("[current_upload_path_id],");
            sb.Append("[site_type],");
            sb.Append("[site_desc],");
            sb.Append("[flower_engineservice],");
            sb.Append("[flower_flowerapi],");
            sb.Append("[flower_formcradle] ");
            sb.Append(" ) values ( ");
            sb.Append("@SiteSerial,");
            sb.Append("@SiteName,");
            sb.Append("@CurrentUploadPathId,");
            sb.Append("@SiteType,");
            sb.Append("@SiteDesc,");
            sb.Append("@FlowerEngineservice,");
            sb.Append("@FlowerFlowerapi,");
            sb.Append("@FlowerFormcradle ) ");

            ParameterBuilder paramList = new ParameterBuilder(8);
            paramList.Add("@SiteSerial", entity.SiteSerial);
            paramList.Add("@SiteName", entity.SiteName);
            paramList.Add("@CurrentUploadPathId", entity.CurrentUploadPathId);
            paramList.Add("@SiteType", entity.SiteType);
            paramList.Add("@SiteDesc", entity.SiteDesc);
            paramList.Add("@FlowerEngineservice", entity.FlowerEngineservice);
            paramList.Add("@FlowerFlowerapi", entity.FlowerFlowerapi);
            paramList.Add("@FlowerFormcradle", entity.FlowerFormcradle);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysSiteList to database 
        /// </summary>
        public override void Insert(SqlConnection connection, SysSiteListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_site_list] (");
            sb.Append("[site_serial],");
            sb.Append("[site_name],");
            sb.Append("[current_upload_path_id],");
            sb.Append("[site_type],");
            sb.Append("[site_desc],");
            sb.Append("[flower_engineservice],");
            sb.Append("[flower_flowerapi],");
            sb.Append("[flower_formcradle] ");
            sb.Append(" ) values ( ");
            sb.Append("@SiteSerial,");
            sb.Append("@SiteName,");
            sb.Append("@CurrentUploadPathId,");
            sb.Append("@SiteType,");
            sb.Append("@SiteDesc,");
            sb.Append("@FlowerEngineservice,");
            sb.Append("@FlowerFlowerapi,");
            sb.Append("@FlowerFormcradle ) ");

            ParameterBuilder paramList = new ParameterBuilder(8);
            paramList.Add("@SiteSerial", entity.SiteSerial);
            paramList.Add("@SiteName", entity.SiteName);
            paramList.Add("@CurrentUploadPathId", entity.CurrentUploadPathId);
            paramList.Add("@SiteType", entity.SiteType);
            paramList.Add("@SiteDesc", entity.SiteDesc);
            paramList.Add("@FlowerEngineservice", entity.FlowerEngineservice);
            paramList.Add("@FlowerFlowerapi", entity.FlowerFlowerapi);
            paramList.Add("@FlowerFormcradle", entity.FlowerFormcradle);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysSiteList to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, SysSiteListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_site_list] (");
            sb.Append("[site_serial],");
            sb.Append("[site_name],");
            sb.Append("[current_upload_path_id],");
            sb.Append("[site_type],");
            sb.Append("[site_desc],");
            sb.Append("[flower_engineservice],");
            sb.Append("[flower_flowerapi],");
            sb.Append("[flower_formcradle] ");
            sb.Append(" ) values ( ");
            sb.Append("@SiteSerial,");
            sb.Append("@SiteName,");
            sb.Append("@CurrentUploadPathId,");
            sb.Append("@SiteType,");
            sb.Append("@SiteDesc,");
            sb.Append("@FlowerEngineservice,");
            sb.Append("@FlowerFlowerapi,");
            sb.Append("@FlowerFormcradle ) ");

            ParameterBuilder paramList = new ParameterBuilder(8);
            paramList.Add("@SiteSerial", entity.SiteSerial);
            paramList.Add("@SiteName", entity.SiteName);
            paramList.Add("@CurrentUploadPathId", entity.CurrentUploadPathId);
            paramList.Add("@SiteType", entity.SiteType);
            paramList.Add("@SiteDesc", entity.SiteDesc);
            paramList.Add("@FlowerEngineservice", entity.FlowerEngineservice);
            paramList.Add("@FlowerFlowerapi", entity.FlowerFlowerapi);
            paramList.Add("@FlowerFormcradle", entity.FlowerFormcradle);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :site_serial/
        /// </summary>
        public override void Update(string connection_string, SysSiteListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_site_list] set ");
            sb.Append("[site_name] = @SiteName, ");
            sb.Append("[current_upload_path_id] = @CurrentUploadPathId, ");
            sb.Append("[site_type] = @SiteType, ");
            sb.Append("[site_desc] = @SiteDesc, ");
            sb.Append("[flower_engineservice] = @FlowerEngineservice, ");
            sb.Append("[flower_flowerapi] = @FlowerFlowerapi, ");
            sb.Append("[flower_formcradle] = @FlowerFormcradle ");
            sb.Append("where [site_serial] = @SiteSerial ");
            ParameterBuilder paramList = new ParameterBuilder(8);
            paramList.Add("@SiteName", entity.SiteName);
            paramList.Add("@CurrentUploadPathId", entity.CurrentUploadPathId);
            paramList.Add("@SiteType", entity.SiteType);
            paramList.Add("@SiteDesc", entity.SiteDesc);
            paramList.Add("@FlowerEngineservice", entity.FlowerEngineservice);
            paramList.Add("@FlowerFlowerapi", entity.FlowerFlowerapi);
            paramList.Add("@FlowerFormcradle", entity.FlowerFormcradle);
            paramList.Add("@SiteSerial", entity.SiteSerial);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :site_serial/
        /// </summary>
        public override void Update(SqlConnection connection, SysSiteListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_site_list] set ");
            sb.Append("[site_name] = @SiteName, ");
            sb.Append("[current_upload_path_id] = @CurrentUploadPathId, ");
            sb.Append("[site_type] = @SiteType, ");
            sb.Append("[site_desc] = @SiteDesc, ");
            sb.Append("[flower_engineservice] = @FlowerEngineservice, ");
            sb.Append("[flower_flowerapi] = @FlowerFlowerapi, ");
            sb.Append("[flower_formcradle] = @FlowerFormcradle ");
            sb.Append("where [site_serial] = @SiteSerial ");
            ParameterBuilder paramList = new ParameterBuilder(8);
            paramList.Add("@SiteName", entity.SiteName);
            paramList.Add("@CurrentUploadPathId", entity.CurrentUploadPathId);
            paramList.Add("@SiteType", entity.SiteType);
            paramList.Add("@SiteDesc", entity.SiteDesc);
            paramList.Add("@FlowerEngineservice", entity.FlowerEngineservice);
            paramList.Add("@FlowerFlowerapi", entity.FlowerFlowerapi);
            paramList.Add("@FlowerFormcradle", entity.FlowerFormcradle);
            paramList.Add("@SiteSerial", entity.SiteSerial);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :site_serial/
        /// </summary>
        public override void Update(SqlTransaction transaction, SysSiteListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_site_list] set ");
            sb.Append("[site_name] = @SiteName, ");
            sb.Append("[current_upload_path_id] = @CurrentUploadPathId, ");
            sb.Append("[site_type] = @SiteType, ");
            sb.Append("[site_desc] = @SiteDesc, ");
            sb.Append("[flower_engineservice] = @FlowerEngineservice, ");
            sb.Append("[flower_flowerapi] = @FlowerFlowerapi, ");
            sb.Append("[flower_formcradle] = @FlowerFormcradle ");
            sb.Append("where [site_serial] = @SiteSerial ");
            ParameterBuilder paramList = new ParameterBuilder(8);
            paramList.Add("@SiteName", entity.SiteName);
            paramList.Add("@CurrentUploadPathId", entity.CurrentUploadPathId);
            paramList.Add("@SiteType", entity.SiteType);
            paramList.Add("@SiteDesc", entity.SiteDesc);
            paramList.Add("@FlowerEngineservice", entity.FlowerEngineservice);
            paramList.Add("@FlowerFlowerapi", entity.FlowerFlowerapi);
            paramList.Add("@FlowerFormcradle", entity.FlowerFormcradle);
            paramList.Add("@SiteSerial", entity.SiteSerial);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :site_serial/
        /// </summary>
        public override void Delete(string connection_string, SysSiteListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_site_list] ");
            sb.Append("where [site_serial] = @SiteSerial ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@SiteSerial", entity.SiteSerial);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :site_serial/
        /// </summary>
        public override void Delete(SqlConnection connection, SysSiteListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_site_list] ");
            sb.Append("where [site_serial] = @SiteSerial ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@SiteSerial", entity.SiteSerial);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :site_serial/
        /// </summary>
        public override void Delete(SqlTransaction transaction, SysSiteListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_site_list] ");
            sb.Append("where [site_serial] = @SiteSerial ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@SiteSerial", entity.SiteSerial);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to SysSiteList
        /// warning: this row must include all the columns of table(sys_site_list)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_site_list)</param>
        /// <returns>an entity of SysSiteList</returns>
        public void FillEntityByRow(SysSiteListInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("site_serial"))
            {
                entity.SiteSerial = (int)row["site_serial"];
            }
            else
            {
            }
            if (!row.IsNull("site_name"))
            {
                entity.SiteName = (string)row["site_name"];
            }
            else
            {
            }
            if (!row.IsNull("current_upload_path_id"))
            {
                entity.CurrentUploadPathId = (int)row["current_upload_path_id"];
            }
            else
            {
            }
            if (!row.IsNull("site_type"))
            {
                entity.SiteType = (string)row["site_type"];
            }
            else
            {
            }
            if (!row.IsNull("site_desc"))
            {
                entity.SiteDesc = (string)row["site_desc"];
            }
            else
            {
            }
            if (!row.IsNull("flower_engineservice"))
            {
                entity.FlowerEngineservice = (string)row["flower_engineservice"];
            }
            else
            {
            }
            if (!row.IsNull("flower_flowerapi"))
            {
                entity.FlowerFlowerapi = (string)row["flower_flowerapi"];
            }
            else
            {
            }
            if (!row.IsNull("flower_formcradle"))
            {
                entity.FlowerFormcradle = (string)row["flower_formcradle"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to SysSiteList
        /// warning: this row must include all the columns of table(sys_site_list)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_site_list)</param>
        /// <returns>an entity of SysSiteList</returns>
        public override SysSiteListInfo Row2Entity(System.Data.DataRow row)
        {
            SysSiteListInfo entity = new SysSiteListInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysSiteListInfo Retrieve(SqlTransaction transaction, SysSiteListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_site_list] ");
            sb.Append("where [site_serial] = @SiteSerial ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@SiteSerial", entity.SiteSerial);

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
        public override SysSiteListInfo Retrieve(SqlConnection connection, SysSiteListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_site_list] ");
            sb.Append("where [site_serial] = @SiteSerial ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@SiteSerial", entity.SiteSerial);

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
        public override SysSiteListInfo Retrieve(string connection_string, SysSiteListInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_site_list] ");
            sb.Append("where [site_serial] = @SiteSerial ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@SiteSerial", entity.SiteSerial);

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
