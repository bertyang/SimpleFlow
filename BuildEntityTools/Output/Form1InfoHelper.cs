using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    public class Form1InfoHelper : SimpleFlow.DBFramework.SQLServer.EntityHelper<Form1Info>
    {
        public Form1InfoHelper()
        {
        }

        /// <summary>
        ///  insert one Form1 to database 
        /// </summary>
        public override void Insert(string connection_string, Form1Info entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [form_1] (");
            sb.Append("[form_no],");
            sb.Append("[amount],");
            sb.Append("[leader],");
            sb.Append("[manager] ");
            sb.Append(" ) values ( ");
            sb.Append("@FormNo,");
            sb.Append("@Amount,");
            sb.Append("@Leader,");
            sb.Append("@Manager ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@FormNo", entity.FormNo);
            paramList.Add("@Amount", entity.Amount);
            paramList.Add("@Leader", entity.Leader);
            paramList.Add("@Manager", entity.Manager);

            SqlHelper.ExecuteNonQuery(connection_string, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one Form1 to database 
        /// </summary>
        public override void Insert(SqlConnection connection, Form1Info entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [form_1] (");
            sb.Append("[form_no],");
            sb.Append("[amount],");
            sb.Append("[leader],");
            sb.Append("[manager] ");
            sb.Append(" ) values ( ");
            sb.Append("@FormNo,");
            sb.Append("@Amount,");
            sb.Append("@Leader,");
            sb.Append("@Manager ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@FormNo", entity.FormNo);
            paramList.Add("@Amount", entity.Amount);
            paramList.Add("@Leader", entity.Leader);
            paramList.Add("@Manager", entity.Manager);

            SqlHelper.ExecuteNonQuery(connection, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        ///  insert one Form1 to database 
        /// </summary>
        public override void Insert(SqlTransaction transaction, Form1Info entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("insert into [form_1] (");
            sb.Append("[form_no],");
            sb.Append("[amount],");
            sb.Append("[leader],");
            sb.Append("[manager] ");
            sb.Append(" ) values ( ");
            sb.Append("@FormNo,");
            sb.Append("@Amount,");
            sb.Append("@Leader,");
            sb.Append("@Manager ) ");

            ParameterBuilder paramList = new ParameterBuilder(4);
            paramList.Add("@FormNo", entity.FormNo);
            paramList.Add("@Amount", entity.Amount);
            paramList.Add("@Leader", entity.Leader);
            paramList.Add("@Manager", entity.Manager);

            SqlHelper.ExecuteNonQuery(transaction, CommandType.Text, sb.ToString(), paramList.ToArray());
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Update(string connection_string, Form1Info entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Update(SqlConnection connection, Form1Info entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// update by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Update(SqlTransaction transaction, Form1Info entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Delete(string connection_string, Form1Info entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Delete(SqlConnection connection, Form1Info entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// delete by the primary key, 
        /// the primary key is :
        /// </summary>
        public override void Delete(SqlTransaction transaction, Form1Info entity)
        {
            // no primary keys defined in the table.
        }

        /// <summary>
        /// convert one row to Form1
        /// warning: this row must include all the columns of table(form_1)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(form_1)</param>
        /// <returns>an entity of Form1</returns>
        public void FillEntityByRow(Form1Info entity, System.Data.DataRow row)
        {
            if (!row.IsNull("form_no"))
            {
                entity.FormNo = (int)row["form_no"];
            }
            else
            {
            }
            if (!row.IsNull("amount"))
            {
                entity.Amount = (int)row["amount"];
            }
            else
            {
            }
            if (!row.IsNull("leader"))
            {
                entity.Leader = (string)row["leader"];
            }
            else
            {
            }
            if (!row.IsNull("manager"))
            {
                entity.Manager = (string)row["manager"];
            }
            else
            {
            }
        }

        /// <summary>
        /// convert one row to Form1
        /// warning: this row must include all the columns of table(form_1)
        /// </summary>
        /// <param name="row">a data row that include all the column of table(form_1)</param>
        /// <returns>an entity of Form1</returns>
        public override Form1Info Row2Entity(System.Data.DataRow row)
        {
            Form1Info entity = new Form1Info();
            FillEntityByRow(entity, row);
            return entity;
        }

        /// <summary>
        /// 
        /// </summary>
        public override Form1Info Retrieve(SqlTransaction transaction, Form1Info entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [form_1] ");
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
        public override Form1Info Retrieve(SqlConnection connection, Form1Info entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [form_1] ");
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
        public override Form1Info Retrieve(string connection_string, Form1Info entity)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
            sb.Append("select * from [form_1] ");
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
