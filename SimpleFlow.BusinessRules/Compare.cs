﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFlow.BusinessRules
{
    public class Compare
    {
        protected object m_VariableA;
        protected object m_VariableB;
        protected string m_Operator;

        public object VariableA
        {
            set { m_VariableA = value; }
        }

        public object VariableB
        {
            set { m_VariableB = value; }
        }

        public string Operator
        {
            set { m_Operator = value; }
        }

        public virtual bool GetResult()
        {
            return false;
        }
    }

    public class CompareINT : Compare
    {
        public override bool GetResult()
        {
            int A = (int)m_VariableA;
            int B = Convert.ToInt32(m_VariableB);

            switch (m_Operator)
            {
                case "==":
                    if (A == B) return true;
                    break;
                case ">=":
                    if (A >= B) return true;
                    break;
                case "<=":
                    if (A <= B) return true;
                    break;
                case ">":
                    if (A > B) return true;
                    break;
                case "<":
                    if (A < B) return true;
                    break;
                case "!=":
                    if (A != B) return true;
                    break;
            }

            return false;
        }
    }

    public class CompareNVARCHAR : Compare
    {
        public override bool GetResult()
        {
            string A = (string)m_VariableA;
            string B = (string)m_VariableB;

            switch (m_Operator)
            {
                case "==":
                    if (A == B) return true;
                    break;
                case "!=":
                    if (A != B) return true;
                    break;
            }

            return false;
        }
    }

}
