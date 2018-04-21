using System;
using System.Collections.Generic;
using System.Text;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessFacade
{
    public static class CodeBiz
    {
        public static List<SysCodeMaster> GetMarsterList()
        {
            return CodeDataAccess.GetMarsterList();
        }


        public static SysCodeMaster GetMaster(string main_key)
        {
            return CodeDataAccess.GetMaster(main_key);
        }


        public static List<SysCodeList> GetCodeList(string main_key)
        {
            return CodeDataAccess.GetCodeList(main_key);
        }


        public static void InsertMaster(SysCodeMaster entity)
        {
            CodeDataAccess.InsertMaster(entity);
        }

        public static void UpdateMaster(SysCodeMaster entity)
        {
            CodeDataAccess.UpdateMaster(entity);
        }

        public static void DeleteMaster(SysCodeMaster entity)
        {
            CodeDataAccess.DeleteMaster(entity);           
        }

        public static void InsertCodeList(SysCodeList entity)
        {
            CodeDataAccess.InsertCodeList(entity);
        }

        public static void UpdateCodeList(SysCodeList entity)
        {
            CodeDataAccess.UpdateCodeList(entity);
        }

        public static void DeleteCodeList(SysCodeList entity)
        {
            CodeDataAccess.DeleteCodeList(entity);
        }


    }
}
