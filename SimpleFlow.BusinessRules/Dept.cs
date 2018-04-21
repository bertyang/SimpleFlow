using System;
using System.Collections.Generic;
using System.Text;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessRules
{
    public class Dept : SysDeptInfo
    {
        private List<Dept> m_listSubDept = new List<Dept>();

        public List<Dept> SubDept
        {
            get
            {
                return m_listSubDept;
            }
        }

        public Dept()
        {
        }

        public Dept(string deptId)
        {
            SysDeptInfo dept = DeptAccess.GetDept(deptId);

            if (dept != null)
            {
                DeptId = dept.DeptId;
                DeptCode = dept.DeptCode;
                DeptName = dept.DeptName;
                ParentId = dept.ParentId;

                //Load Active
                List<SysDeptInfo> listSubDept = DeptAccess.GetSubDept(deptId);

                foreach (SysDeptInfo subDept in listSubDept)
                {
                    m_listSubDept.Add(new Dept(subDept.DeptId));
                }
            }
        }

    }
}
