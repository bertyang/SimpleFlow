using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessRules
{
    public static class ActiveType
    {
        public const string StartActive = "BeginStep";
        public const string NormalActive = "NormalStep";
        public const string EndActive = "EndStep";
    }


    public class Active:ActiveInfo
    {
        #region

        private Participant m_Participant=new Participant();
        public Participant Participant
       {
           get
           {
               return m_Participant;
           }
           set
           {
               m_Participant= value;
           }
       }
        #endregion
      
        public Active()
        {
        }
        public Active(string activeId)
        {
            ActiveId = activeId;

            ActiveInfo active = ActiveDataAccess.GetActive(activeId);

            ActiveName = active.ActiveName;
            FormId = active.FormId;
            ActiveType = active.ActiveType;

            List<ParticipantInfo> listParameterInfo = ParticipantDataAccess.GetParticipantByActive(activeId);

            //participant
            if (listParameterInfo.Count>0)
            {
                m_Participant = (Participant)Assembly.Load("SimpleFlow.BusinessRules").CreateInstance("SimpleFlow.BusinessRules.Participant" + listParameterInfo[0].ParticipantKind);
                m_Participant.ParticipantId = listParameterInfo[0].ParticipantId;
            }
        }

        public List<Approver> ParseParticipant(int formNo)
        {
           return m_Participant.GetApprover(formNo);
        }
     
    }
}
