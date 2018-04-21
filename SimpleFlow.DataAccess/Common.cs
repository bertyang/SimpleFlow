using System;
using System.Data;
using System.Data.SqlClient;

using SimpleFlow.DBFramework.SQLServer;
using SimpleFlow.Entity;
using SimpleFlow.SystemFramework;


namespace SimpleFlow.DataAccess
{
    public class CommonDataAccess
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public static int CreateId(string type)
        {
            SqlParameter[] sqlParas = new SqlParameter[2];

            sqlParas[0] = new SqlParameter();
            sqlParas[0].ParameterName = "@type";
            sqlParas[0].SqlDbType = SqlDbType.NVarChar;
            sqlParas[0].Size = 10;
            sqlParas[0].Direction = ParameterDirection.Input;
            sqlParas[0].Value = type;

            sqlParas[1] = new SqlParameter();
            sqlParas[1].ParameterName = "@id";
            sqlParas[1].SqlDbType = SqlDbType.Int;
            sqlParas[1].Direction = ParameterDirection.Output;

            try
            {
                SqlHelper.ExecuteNonQuery(Config.ConnectionString, CommandType.StoredProcedure, "usp_common_createid", sqlParas);
                return Convert.ToInt32(sqlParas[1].Value);
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }

        public static Object GetColomnValue(string columnName ,string tableName,int formNo)
        {
            string sql = string.Format("select {0} from simpleflowdata.dbo.{1} where formno={2}", columnName, tableName, formNo);

            return SqlHelper.ExecuteScalar(Config.ConnectionString, CommandType.Text, sql);
        }



        public static DataTable GetColumns(string tableName)
        {
            string sql = string.Format("select name,name from simpleflowdata.dbo.syscolumns where id in (select id from simpleflowdata.dbo.sysobjects where name='{0}')", tableName);

            return SqlHelper.ExecuteDataTableBySql(Config.ConnectionString, sql, null);

        }


        public static string GetColumnType(string tableName, string columnName)
        {
            string sql = "select a.name from simpleflowdata.dbo.systypes a  "
            + "inner join simpleflowdata.dbo.syscolumns b on a.xtype=b.xtype and a.xusertype=b.xtype and b.name='{0}'  "
            + "inner join simpleflowdata.dbo.sysobjects c on c.id=b.id and c.name='{1}' ";

            sql = string.Format(sql,columnName,tableName);

            Object obj = SqlHelper.ExecuteScalar(Config.ConnectionString, CommandType.Text, sql);

            string columnType = string.Empty;

            if (obj != null)
            {
                columnType = (string)obj;
            }

            return columnType;
        }

        public static string CreateFormId()
        {
            SqlConnection conn = new SqlConnection(Config.ConnectionString);
            conn.Open();
            try
            {

                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    SqlParameter[] sqlParas = new SqlParameter[2];

                    sqlParas[0] = new SqlParameter();
                    sqlParas[0].ParameterName = "@type";
                    sqlParas[0].SqlDbType = SqlDbType.NVarChar;
                    sqlParas[0].Size = 10;
                    sqlParas[0].Direction = ParameterDirection.Input;
                    sqlParas[0].Value = "formid";

                    sqlParas[1] = new SqlParameter();
                    sqlParas[1].ParameterName = "@id";
                    sqlParas[1].SqlDbType = SqlDbType.Int;
                    sqlParas[1].Direction = ParameterDirection.Output;

                    SqlHelper.ExecuteNonQuery(trans, CommandType.StoredProcedure, "usp_common_createid", sqlParas);

                    int i = Convert.ToInt32(sqlParas[1].Value);

                    SysObjectsInfo obj = new SysObjectsInfo();

                    obj.ObjectType = i.ToString();
                    obj.MaxId = 0;

                    SqlHelper.Insert(trans, obj);

                    trans.Commit();

                    return i.ToString();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
            }
            finally
            {
                conn.Close();
            }
              
        }

    }
}
