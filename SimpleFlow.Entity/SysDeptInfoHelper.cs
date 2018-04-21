using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class SysDeptInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<SysDeptInfo>
    {
        public SysDeptInfoHelper()
        {
        }

        /// <summary>
        ///  insert one SysDept to database 
        /// </summary>
        public override void Insert(string connection_string, SysDeptInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_dept] (");
            sb.Append("[dept_id],");
            sb.Append("[dept_code],");
            sb.Append("[dept_name],");
            sb.Append("[parent_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@DeptId,");
            sb.Append("@DeptCode,");
            sb.Append("@DeptName,");
            sb.Append("@ParentId ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@DeptId", entity.DeptId);
            paramList.Add("@DeptCode", entity.DeptCode);
            paramList.Add("@DeptName", entity.DeptName);
            paramList.Add("@ParentId", entity.ParentId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysDept to database 
        /// </summary>
        public override void Insert(SqlConnection connection, SysDeptInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_dept] (");
            sb.Append("[dept_id],");
            sb.Append("[dept_code],");
            sb.Append("[dept_name],");
            sb.Append("[parent_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@DeptId,");
            sb.Append("@DeptCode,");
            sb.Append("@DeptName,");
            sb.Append("@ParentId ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@DeptId", entity.DeptId);
            paramList.Add("@DeptCode", entity.DeptCode);
            paramList.Add("@DeptName", entity.DeptName);
            paramList.Add("@ParentId", entity.ParentId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one SysDept to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, SysDeptInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [sys_dept] (");
            sb.Append("[dept_id],");
            sb.Append("[dept_code],");
            sb.Append("[dept_name],");
            sb.Append("[parent_id] ");
            sb.Append(" ) values ( ");
            sb.Append("@DeptId,");
            sb.Append("@DeptCode,");
            sb.Append("@DeptName,");
            sb.Append("@ParentId ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@DeptId", entity.DeptId);
            paramList.Add("@DeptCode", entity.DeptCode);
            paramList.Add("@DeptName", entity.DeptName);
            paramList.Add("@ParentId", entity.ParentId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :dept_id/
        /// </summary>
        public override void Update(string connection_string, SysDeptInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_dept] set ");
            sb.Append("[dept_code] = @DeptCode, ");
            sb.Append("[dept_name] = @DeptName, ");
            sb.Append("[parent_id] = @ParentId ");
            sb.Append("where [dept_id] = @DeptId ");
            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@DeptCode", entity.DeptCode);
            paramList.Add("@DeptName", entity.DeptName);
            paramList.Add("@ParentId", entity.ParentId);
            paramList.Add("@DeptId", entity.DeptId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :dept_id/
        /// </summary>
        public override void Update(SqlConnection connection, SysDeptInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_dept] set ");
            sb.Append("[dept_code] = @DeptCode, ");
            sb.Append("[dept_name] = @DeptName, ");
            sb.Append("[parent_id] = @ParentId ");
            sb.Append("where [dept_id] = @DeptId ");
            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@DeptCode", entity.DeptCode);
            paramList.Add("@DeptName", entity.DeptName);
            paramList.Add("@ParentId", entity.ParentId);
            paramList.Add("@DeptId", entity.DeptId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :dept_id/
        /// </summary>
        public override void Update(SqlTransaction transaction, SysDeptInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("update [sys_dept] set ");
            sb.Append("[dept_code] = @DeptCode, ");
            sb.Append("[dept_name] = @DeptName, ");
            sb.Append("[parent_id] = @ParentId ");
            sb.Append("where [dept_id] = @DeptId ");
            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@DeptCode", entity.DeptCode);
            paramList.Add("@DeptName", entity.DeptName);
            paramList.Add("@ParentId", entity.ParentId);
            paramList.Add("@DeptId", entity.DeptId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :dept_id/
        /// </summary>
        public override void Delete(string connection_string, SysDeptInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_dept] ");
            sb.Append("where [dept_id] = @DeptId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@DeptId", entity.DeptId);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :dept_id/
        /// </summary>
        public override void Delete(SqlConnection connection, SysDeptInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_dept] ");
            sb.Append("where [dept_id] = @DeptId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@DeptId", entity.DeptId);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :dept_id/
        /// </summary>
        public override void Delete(SqlTransaction transaction, SysDeptInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("delete from [sys_dept] ");
            sb.Append("where [dept_id] = @DeptId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@DeptId", entity.DeptId);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// convert one row to SysDept
        /// warning: this row must include all the columns of table(sys_dept)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_dept)</param>
        /// <returns>an entity of SysDept</returns>
        public void FillEntityByRow(SysDeptInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("dept_id"))
            {
                entity.DeptId = (string)row["dept_id"];
            }
            else
            {
            }
            if (!row.IsNull("dept_code"))
            {
                entity.DeptCode = (string)row["dept_code"];
            }
            else
            {
            }
            if (!row.IsNull("dept_name"))
            {
                entity.DeptName = (string)row["dept_name"];
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
        }

        /// <summary>
        /// convert one row to SysDept
        /// warning: this row must include all the columns of table(sys_dept)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(sys_dept)</param>
        /// <returns>an entity of SysDept</returns>
        public override SysDeptInfo Row2Entity(System.Data.DataRow row)
        {
            SysDeptInfo entity = new SysDeptInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override SysDeptInfo Retrieve(SqlTransaction transaction, SysDeptInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_dept] ");
            sb.Append("where [dept_id] = @DeptId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@DeptId", entity.DeptId);

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
        public override SysDeptInfo Retrieve(SqlConnection connection, SysDeptInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_dept] ");
            sb.Append("where [dept_id] = @DeptId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@DeptId", entity.DeptId);

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
        public override SysDeptInfo Retrieve(string connection_string, SysDeptInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [sys_dept] ");
            sb.Append("where [dept_id] = @DeptId ");
            ParameterBuilder paramList = new ParameterBuilder(1);
            paramList.Add("@DeptId", entity.DeptId);

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
