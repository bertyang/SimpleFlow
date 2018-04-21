using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using SimpleFlow.DBFramework.SQLServer;
using SimpleFlow.Entity;
using SimpleFlow.SystemFramework;

namespace SimpleFlow.DataAccess
{
    public class EngineDataAccess
    {
        public static bool ApplyForm(FormHeaderInfo formHeader, List<FormApproveInfo> formApproveList)
        {
           
            SqlConnection conn = new SqlConnection(Config.ConnectionString);

            conn.Open();

            try
            {
                SqlTransaction trans = conn.BeginTransaction();

                try
                {
                    
                    SqlHelper.Insert(trans, formHeader);

                    for (int i = 0; i < formApproveList.Count; i++)
                    {
                        FormApproveInfo formApprove = formApproveList[i];

                        if (formApprove == null)
                            continue;

                        SqlHelper.Insert(trans, formApprove);
                    }

                    trans.Commit();

                    return true;

                }
                catch (Exception ex)
                {
                    trans.Rollback();
                   // SimpleFlow.SystemFramework.Log.WriteLog("Engine_ApplyForm", ex);
                    return false;
                }

            }
            finally
            {
                conn.Close();
            }
        }


        public static bool ApproveForm(FormHeaderInfo formHeader, List<FormApproveInfo> formApproveList)
        {

            SqlConnection conn = new SqlConnection(Config.ConnectionString);

            conn.Open();

            try
            {
                SqlTransaction trans = conn.BeginTransaction();

                try
                {

                    SqlHelper.Insert(trans, formHeader);

                    for (int i = 0; i < formApproveList.Count; i++)
                    {
                        FormApproveInfo formApprove = formApproveList[i];

                        if (formApprove == null)
                            continue;

                        SqlHelper.Insert(trans, formApprove);
                    }

                    trans.Commit();

                    return true;

                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    SimpleFlow.SystemFramework.Log.WriteLog("Engine_ApplyForm", ex);
                    return false;
                }

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
