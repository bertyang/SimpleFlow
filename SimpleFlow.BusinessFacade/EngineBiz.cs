using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

using SimpleFlow.BusinessRules;
using SimpleFlow.DataAccess;


namespace SimpleFlow.BusinessFacade
{
    public class EngineBiz
    {      
        public static bool ApplyForm(int formId,int formNo,string applyerId)
        {
            FormHeader formHeader = new FormHeader(formId, formNo);

            formHeader.Applyer = applyerId;

            ParseParticipantBiz p = new ParseParticipantBiz(formId, formNo);

            FormApproveList formApproveList = p.Parse();

            DbConnection conn = ConnectionDataAccess.CreateConnection();

            conn.Open();

            try
            {
                DbTransaction trans = conn.BeginTransaction();

                try
                {
                    formHeader.Insert(trans);

                    formApproveList.Insert(trans);

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

        public static bool ApproveForm(int formId, int formNo, String formApproveId, String approverId, String approveValue, String approveContent)
        {
            FormApproveList fal = new FormApproveList(formId,formNo);

            FormHeader formHeader = new FormHeader(formId, formNo);

            FormApprove CurrentFA = fal.Find(delegate(FormApprove fa) { return (fa.FormApproveId == formApproveId); });

            DbConnection conn = ConnectionDataAccess.CreateConnection();

            conn.Open();

            try
            {
                DbTransaction trans = conn.BeginTransaction();
                
                try
                {
                    CurrentFA.AppStatus = ApproveStatus.STATUS_APPROVED;
                    CurrentFA.AppActor = approverId;
                    CurrentFA.AppContent = approveContent;
                    CurrentFA.AppValue = approveValue;
                    CurrentFA.EndDate = DateTime.Now;
                    CurrentFA.Update(trans);

                    if (approveValue == ApproveStatus.APP_VALUE_NO) //否决
                    {
                        formHeader.FormStatus = FormStatus.RJ;
                        formHeader.EndDate = DateTime.Now;
                        formHeader.Update(trans);
                    }
                    else //同意
                    {
                        int currentSerial = CurrentFA.AppSerial;
                        int nextSerial = currentSerial + 1;

                        for (int i = 0; i < fal.Count; i++)
                        {
                            if (fal[i].AppSerial == currentSerial && fal[i].AppStatus ==  ApproveStatus.STATUS_UNDER_APPROVE)
                            {
                                break;
                            }
                            else if (fal[i].AppSerial == nextSerial)
                            {
                                fal[i].AppStatus = ApproveStatus.STATUS_UNDER_APPROVE;
                                fal[i].Update(trans);
                            }
                            else if (fal[i].AppSerial > nextSerial)
                            {
                                break;
                            }
                        }

                        //签核完成
                        if (fal.Count == fal.FindAll(delegate(FormApprove fa) { return (fa.AppStatus ==  ApproveStatus.STATUS_APPROVED); }).Count)
                        {
                            formHeader.FormStatus = FormStatus.AP;
                            formHeader.EndDate = DateTime.Now;
                            formHeader.Update(trans);
                        }
                    }

                    trans.Commit();

                    return true;

                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    SimpleFlow.SystemFramework.Log.WriteLog("Engine_ApproveForm", ex);
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
