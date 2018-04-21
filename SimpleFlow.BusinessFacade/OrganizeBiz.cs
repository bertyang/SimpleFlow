using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessFacade
{
    public static class OrganizeBiz
    {
        public static List<SysDeptInfo> GetSubDept(string deptId)
        {
            return DeptAccess.GetSubDept(deptId);
        }

        public static List<SysUserInfo> GetEmployee(string deptId)
        {
            return DeptAccess.GetEmployee(deptId);
        }
    }
}
