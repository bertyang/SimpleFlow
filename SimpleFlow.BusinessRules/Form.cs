using System;
using System.Collections.Generic;
using System.Text;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessRules
{
    public class Form:FormInfo
    {
        private List<Active> m_listActive=new List<Active>();
        private List<Condition> m_listCondition=new List<Condition>();


        #region

        public Active StartActive
        {
            get
            {
                return m_listActive.Find(delegate(Active active) { return (active.ActiveType == ActiveType.StartActive); }); ;
            }
        }

        public Active EndActive
        {
            get
            {
                return m_listActive.Find(delegate(Active active) { return (active.ActiveType == ActiveType.EndActive); }); ;
            }
        }

        public List<Active> Actives
        {
            get
            {
                return m_listActive;
            }
            set
            {
                m_listActive = value;
            }
        }

        public List<Condition> Conditions
        {
            get
            {
                return m_listCondition;
            }
            set
            {
                m_listCondition = value;
            }
        }


        #endregion

        public Form()
        {
        }

        public Form(int _FormId)
        {
            FormId = _FormId;

            FormInfo form = FormDataAccess.GetForm(_FormId);

            FormName = form.FormName;
            FlowXml = form.FlowXml;

            //Load Active
            List<ActiveInfo> listActive = ActiveDataAccess.GetAll(_FormId);


            foreach (ActiveInfo active in listActive)
            {
                m_listActive.Add(new Active(active.ActiveId));
            }

            //Load Condition
            List<ConditionInfo> listCondition = ConditionDataAccess.GetAll(_FormId);

            foreach (ConditionInfo condition in listCondition)
            {
                Condition obj = new Condition(condition.ConditionId);

                obj.FromActive = m_listActive.Find(delegate(Active active) { return (active.ActiveId == condition.FromActiveId); });
                obj.ToActive = m_listActive.Find(delegate(Active active) { return (active.ActiveId == condition.ToActiveId); });

                m_listCondition.Add(obj);
            }

            //Load Condition Sub
            //List<ConditionInfoSub> listConditionSub = SqlHelper.QueryTable<ConditionInfoSub>(BizConfig.ConnectionString, cfl);

            //foreach (ConditionInfoSub conditionSub in listConditionSub)
            //{
            //    m_listConditionSub.Add(new ConditionSub(conditionSub.ConditionSubId));
            //}
     
        }

    }
}
