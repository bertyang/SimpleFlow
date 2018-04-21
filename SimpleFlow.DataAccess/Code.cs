using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using SimpleFlow.Entity;
using SimpleFlow.SystemFramework;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.DataAccess
{
    public class CodeDataAccess
    {
        public static List<SysCodeMaster> GetMarsterList()
        {
            return SqlHelper.GetAll<SysCodeMaster>(Config.ConnectionString);
        }


        public static SysCodeMaster GetMaster(string main_key)
        {
            return SqlHelper.Retrieve<SysCodeMaster>(Config.ConnectionString,
                new SysCodeMaster(main_key));
        }


        public static List<SysCodeList> GetCodeList(string main_key)
        {
            return SqlHelper.QueryTable<SysCodeList>(Config.ConnectionString,
                ColumnFilterList.New("main_key", main_key));
        }


        public static void InsertMaster(SysCodeMaster entity)
        {
            SqlHelper.Insert(Config.ConnectionString, entity);
        }

        public static void UpdateMaster(SysCodeMaster entity)
        {
            SqlHelper.Update(Config.ConnectionString, entity);
        }

        public static void DeleteMaster(SysCodeMaster entity)
        {
            SqlConnection conn = new SqlConnection(Config.ConnectionString);
            conn.Open();
            try
            {
                SqlTransaction trans = conn.BeginTransaction();
                try
                {
                    SqlHelper.DeleteTable<SysCodeList>(trans, ColumnFilterList.New("main_key", entity.MainKey));
                    SqlHelper.Delete(trans, entity);
                    trans.Commit();
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

        public static void InsertCodeList(SysCodeList entity)
        {
            SqlHelper.Insert(Config.ConnectionString, entity);
        }

        public static void UpdateCodeList(SysCodeList entity)
        {
            SqlHelper.Update(Config.ConnectionString, entity);
        }

        public static void DeleteCodeList(SysCodeList entity)
        {
            SqlHelper.Delete(Config.ConnectionString, entity);
        }

    }
}
