using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class TestBakInfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<TestBakInfo>
    {
        public TestBakInfoHelper()
        {
        }

        /// <summary>
        ///  insert one TestBak to database 
        /// </summary>
        public override void Insert(string connection_string, TestBakInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [Test_bak] (");
            sb.Append("[a],");
            sb.Append("[b],");
            sb.Append("[form_no] ");
            sb.Append(" ) values ( ");
            sb.Append("@A,");
            sb.Append("@B,");
            sb.Append("@FormNo ) ");

            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@A", entity.A);
            paramList.Add("@B", entity.B);
            paramList.Add("@FormNo", entity.FormNo);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one TestBak to database 
        /// </summary>
        public override void Insert(SqlConnection connection, TestBakInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [Test_bak] (");
            sb.Append("[a],");
            sb.Append("[b],");
            sb.Append("[form_no] ");
            sb.Append(" ) values ( ");
            sb.Append("@A,");
            sb.Append("@B,");
            sb.Append("@FormNo ) ");

            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@A", entity.A);
            paramList.Add("@B", entity.B);
            paramList.Add("@FormNo", entity.FormNo);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one TestBak to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, TestBakInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [Test_bak] (");
            sb.Append("[a],");
            sb.Append("[b],");
            sb.Append("[form_no] ");
            sb.Append(" ) values ( ");
            sb.Append("@A,");
            sb.Append("@B,");
            sb.Append("@FormNo ) ");

            ParameterBuilder paramList = new ParameterBuilder(3);
            paramList.Add("@A", entity.A);
            paramList.Add("@B", entity.B);
            paramList.Add("@FormNo", entity.FormNo);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Update(string connection_string, TestBakInfo entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Update(SqlConnection connection, TestBakInfo entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Update(SqlTransaction transaction, TestBakInfo entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Delete(string connection_string, TestBakInfo entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Delete(SqlConnection connection, TestBakInfo entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Delete(SqlTransaction transaction, TestBakInfo entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// convert one row to TestBak
        /// warning: this row must include all the columns of table(Test_bak)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(Test_bak)</param>
        /// <returns>an entity of TestBak</returns>
        public void FillEntityByRow(TestBakInfo entity, System.Data.DataRow row)
        {
            if (!row.IsNull("a"))
            {
                entity.A = (string)row["a"];
            }
            else
            {
            }
            if (!row.IsNull("b"))
            {
                entity.B = (int)row["b"];
            }
            else
            {
            }
            if (!row.IsNull("form_no"))
            {
                entity.FormNo = (int)row["form_no"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to TestBak
        /// warning: this row must include all the columns of table(Test_bak)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(Test_bak)</param>
        /// <returns>an entity of TestBak</returns>
        public override TestBakInfo Row2Entity(System.Data.DataRow row)
        {
            TestBakInfo entity = new TestBakInfo();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override TestBakInfo Retrieve(SqlTransaction transaction, TestBakInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [Test_bak] ");
            ParameterBuilder paramList = new ParameterBuilder(0);

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
        public override TestBakInfo Retrieve(SqlConnection connection, TestBakInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [Test_bak] ");
            ParameterBuilder paramList = new ParameterBuilder(0);

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
        public override TestBakInfo Retrieve(string connection_string, TestBakInfo entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [Test_bak] ");
            ParameterBuilder paramList = new ParameterBuilder(0);

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
