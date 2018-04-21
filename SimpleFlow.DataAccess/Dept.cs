using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SimpleFlow.Entity;
using SimpleFlow.SystemFramework;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.DataAccess
{
    public class DeptAccess
    {
        public static List<SysDeptInfo> GetSubDept(string deptId)
        {
            ColumnFilterList cfl = new ColumnFilterList();
            cfl.Add(new ColumnFilter("parent_id", deptId));

            return SqlHelper.QueryTable<SysDeptInfo>(Config.ConnectionString, cfl);
        }

        public static List<SysUserInfo> GetEmployee(string deptId)
        {
            SysDeptInfo dept = GetDept(deptId); 
            if (dept==null) return new List<SysUserInfo>();

            ColumnFilterList cfl = new ColumnFilterList();
            cfl.Add(new ColumnFilter("dept_code", dept.DeptCode));

            return SqlHelper.QueryTable<SysUserInfo>(Config.ConnectionString, cfl);
        }

        public static SysDeptInfo GetDept(string deptId)
        {
            return SqlHelper.Retrieve<SysDeptInfo>(Config.ConnectionString, new SysDeptInfo(deptId));
        }
    }
}
