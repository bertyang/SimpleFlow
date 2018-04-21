using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessRules
{
    public class ConditionSub:ConditionSubInfo
    {

        public ConditionSub()
        {
            
        }

        public ConditionSub(string _ConditionSubId)
        {
            ConditionSubInfo conditionSub = ConditionSubDataAccess.GetConditionSub(_ConditionSubId);

            ConditionSubId = _ConditionSubId;
            ConditionSubField = conditionSub.ConditionSubField;          
            ConditionSubOperator=conditionSub.ConditionSubOperator;
            ConditionSubValue=conditionSub.ConditionSubValue;
            //ConditionSubType=conditionSub.ConditionSubType;
            ConditionSubId = conditionSub.ConditionSubId;

        }

        public bool Parse(int formId,int formNo)
        {
            string tableName = string.Format("tb_{0}", formId);
            Object obj = CommonDataAccess.GetColomnValue(ConditionSubField, tableName, formNo); ;

            if (obj != null)
            {
                string columnType = CommonDataAccess.GetColumnType(tableName, ConditionSubField);

                Compare compare = (Compare)Assembly.Load("SimpleFlow.BusinessRules").CreateInstance("SimpleFlow.BusinessRules.Compare" + columnType.ToUpper());

                compare.VariableA = obj;
                compare.VariableB = ConditionSubValue;
                compare.Operator = ConditionSubOperator;

                return compare.GetResult();
            }

            return false;
        }

      
    }
}
