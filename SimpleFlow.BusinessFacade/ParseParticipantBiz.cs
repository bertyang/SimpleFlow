using System;
using System.Collections.Generic;

using SimpleFlow.BusinessRules;

namespace SimpleFlow.BusinessFacade
{   

    public class ParseParticipantBiz
    {
        private int m_FormId;
        private int m_FormNo;
        private Form m_FormFlow;       
        private FormApproveList m_FormApproveList = new FormApproveList();

        public ParseParticipantBiz(int formId, int formNo)
        {
            m_FormId = formId;
            m_FormNo = formNo;
            m_FormFlow = new Form(m_FormId);
        }

        public FormApproveList Parse()
        {
            Parse(m_FormFlow.StartActive);

            Active();

            return m_FormApproveList;
        }

        private void Active()
        {
            int intMinSerial = m_FormApproveList.GetMinSerial();

            List<FormApprove> minSerialFormApprove = m_FormApproveList.FindAll(delegate(FormApprove formApprove)
            { return (formApprove.AppSerial == intMinSerial); });

            foreach (FormApprove formApprove in minSerialFormApprove)
            {
                formApprove.AppStatus = "U";
            }
        }

        private void Parse(Active active)
        {

            List<Condition> BackConditions =
                        m_FormFlow.Conditions.FindAll(delegate(Condition condition)
                        { return (condition.FromActive == active); });


            foreach (Condition con in BackConditions)
            {
                if (con.Parse(m_FormId,m_FormNo))
                {
                    int maxSerial = m_FormApproveList.GetMaxSerial();

                    List<Approver> listApprover= con.ToActive.ParseParticipant(m_FormNo);

                    foreach (Approver aprover in listApprover)
                    {
                        FormApprove fa = new FormApprove();
                        fa.AppAssigner = "SYSTEM";
                        fa.AppEmpId = aprover.ApproverId;
                        fa.AppName = aprover.ApproverName;                        
                        fa.AppSerial = maxSerial + aprover.SequenceNo;
                        fa.AppStatus = "W";
                        fa.AppType = "A";
                        fa.BeginDate = DateTime.Now;
                        fa.EndDate = DateTime.MaxValue;
                        fa.FormId = m_FormId;
                        fa.FormNo = m_FormNo;
                        fa.FormApproveId = Guid.NewGuid().ToString("D").ToUpper();

                        if (string.IsNullOrEmpty(aprover.ApproveRole))
                        {
                            fa.AppRole = con.ToActive.ActiveName;
                        }
                        else
                        {
                            fa.AppRole = aprover.ApproveRole;
                        }

                        m_FormApproveList.Add(fa);
                    }

                    Parse(con.ToActive);
                }
            }

        }
    }
}
