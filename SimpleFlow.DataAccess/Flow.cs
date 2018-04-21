using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using SimpleFlow.Entity;
using SimpleFlow.SystemFramework;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.DataAccess
{
    public class FlowDataAccess
    {
        public static bool UpdateFlow(FormInfo form, List<ActiveInfo> listActive, List<ConditionInfo> listCondition)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                try
                {
                    SqlTransaction trans = conn.BeginTransaction();

                    try
                    {                        
                        #region Delete exists form flow

                        //ColumnFilterList cfl = new ColumnFilterList();
                        //cfl.Add(new ColumnFilter("form_Id", form.FormId));

                        //SqlHelper.DeleteTable<ConditionInfo>(trans, cfl);
                        //SqlHelper.DeleteTable<ActiveInfo>(trans, cfl);
                        SqlHelper.Update(trans, form);

                        #endregion

                        #region Insert form flow
                        foreach (ActiveInfo active in listActive)
                        {
                            if (ActiveDataAccess.GetActive(active.ActiveId) == null)
                            {
                                SqlHelper.Insert(trans, active);
                            }
                            else
                            {
                                SqlHelper.Update(trans, active);
                            }
                        }

                        foreach (ConditionInfo condition in listCondition)
                        {
                            if (ConditionDataAccess.GetCondition(condition.ConditionId) == null)
                            {
                                SqlHelper.Insert(trans, condition);
                            }
                            else
                            {
                                SqlHelper.Update(trans, condition);
                            }
                        }

                        #endregion

                        trans.Commit();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        SimpleFlow.SystemFramework.Log.WriteLog("UpdateWorkFlowXML", ex);
                        return false;
                    }

                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public static bool DeleteFlow(string formId)
        {
            using (SqlConnection conn = new SqlConnection(Config.ConnectionString))
            {
                conn.Open();

                try
                {
                    SqlTransaction trans = conn.BeginTransaction();

                    try
                    {
                        ColumnFilterList cfl = new ColumnFilterList();
                        cfl.Add(new ColumnFilter("form_Id", formId));

                        SqlHelper.DeleteTable<ConditionInfo>(trans, cfl);
                        SqlHelper.DeleteTable<ActiveInfo>(trans, cfl);
                        SqlHelper.DeleteTable<FormInfo>(trans, cfl);

                        trans.Commit();

                        return true;
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        SimpleFlow.SystemFramework.Log.WriteLog("DeleteWorkFlowXML", ex);
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
}
