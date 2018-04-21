using System;
using System.Data;
using System.Collections.Generic;
using System.Text;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessRules
{
    public class Participant
    {
        protected string m_ParticipantId;

        public string ParticipantId
        {  
            set
            {
                m_ParticipantId = value;
            }
            get 
            {
                return m_ParticipantId; 
            }
        }

        public virtual List<Approver> GetApprover(int formNo) 
        {
            return new List<Approver>();
        }
    }

    public class ParticipantField : Participant
    {
        public override List<Approver> GetApprover(int formNo)
        {
            Object obj = ParticipantDataAccess.GetParticipantField(ParticipantId, formNo);

            List<Approver> listApprover = new List<Approver>();

            if (obj != null)
            {
                User user = new User((string)obj);

                Approver approver = new Approver();
                approver.ApproverId = user.UserId;
                approver.ApproverName = user.UserName;
                approver.ApproveRole = "";
                approver.SequenceNo = 1;

                listApprover.Add(approver);
            }
            
            return listApprover;           
        }
    }

    public class ParticipantOrg : Participant
    {
        public override List<Approver> GetApprover(int formNo)
        {
            List<Approver> listApprover = new List<Approver>();

            ParticipantOrgInfo mdOrg = ParticipantDataAccess.GetParticipantOrg(ParticipantId);

            if (mdOrg == null) return listApprover;

            string[] arrUserId = mdOrg.UserId.Split(';');

            for (int i = 0; i < arrUserId.Length;i++)
            {
                User user = new User(arrUserId[i]);

                Approver approver = new Approver();
                approver.ApproverId = user.UserId;
                approver.ApproverName = user.UserName;
                approver.ApproveRole = "";
                approver.SequenceNo = 1;

                listApprover.Add(approver);
            }

            return listApprover;
        }

    }
}
