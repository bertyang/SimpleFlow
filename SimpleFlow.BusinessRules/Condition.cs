using System;
using System.Collections.Generic;
using System.Text;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessRules
{    
    public class Condition : ConditionInfo
    {
        #region
        private Active m_FromActive;
        private Active m_ToActive;
        private List<ConditionSub> m_listConditionSub=new List<ConditionSub>();

        public Active FromActive
        {
            get{return m_FromActive;}
            set { m_FromActive = value; }
        }

        public Active ToActive
        {
            get { return m_ToActive; }
            set { m_ToActive = value; }
        }

        public List<ConditionSub> ListConditionSub
        {
            get { return m_listConditionSub; }
        }
        #endregion

        public Condition()
        {
        }

        public Condition(string _ConditionId)
        {
            ConditionId = _ConditionId;

            ConditionInfo condition = ConditionDataAccess.GetCondition(_ConditionId);

            ConditionName=condition.ConditionName;

            ConditionJoin = condition.ConditionJoin;

            //m_FromActive = new Active(condition.FromActiveId);

            //m_ToActive = new Active(condition.ToActiveId);


            //Load Condition Sub
            List<ConditionSubInfo> listConditionSub = ConditionSubDataAccess.GetConditionSubList(_ConditionId);

            foreach (ConditionSubInfo conditionSub in listConditionSub)
            {
                m_listConditionSub.Add(new ConditionSub(conditionSub.ConditionSubId));
            }
        }

        public bool Parse(int formId,int formNo)
        {
            if (ListConditionSub.Count==0) return true;

            StringBuilder ConditionExps = new StringBuilder();

            foreach (ConditionSub cs in ListConditionSub)
            {
                ConditionExps.Append(cs.Parse(formId, formNo).ToString().ToUpper()+";");
            }

            return Parse(ConditionExps.ToString().TrimEnd(';'));

        }

        private bool Parse(string exps)
        {
            string[] split = exps.Split(';');

            if (ConditionJoin == "OR")
            {
                for (int i = 0; i < split.Length; i++)
                {
                    if (split[i] == "TRUE")
                    {
                        return true;
                    }
                }

                return false;
            }
            else if (ConditionJoin == "AND")
            {
                for (int i = 0; i < split.Length; i++)
                {
                    if (split[i] == "FALSE")
                    {
                        return false;
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
