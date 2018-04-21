using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

using System.Xml;

namespace SimpleFlow.BusinessFacade
{
    public static class FormHeaderBiz
    {
        public static List<FormHeaderInfo> GetFormHeadersByKind(int form_Id)
        {
            return FormHeaderDataAccess.GetFormHeadersByKind(form_Id);
        }

        /// <summary>
        /// 总是按form_no倒排序
        /// </summary>
        /// <param name="page_index">页索引,第一页为1。</param>
        /// <param name="page_size"></param>
        /// <param name="form_Id"></param>
        /// <param name="part_no"></param>
        /// <param name="form_no"></param>
        /// <returns></returns>
        public static List<FormHeaderInfo> QueryPage(int page_size, ref int page_index,
            string form_Id, string user_id,string form_no, out int page_count)
        {
            return FormHeaderDataAccess.QueryPage(page_size, ref page_index, form_Id, user_id, form_no, out page_count);
        }




        /// <summary>
        /// 
        /// </summary>
        /// <param name="formId"></param>
        /// <returns></returns>
        public static int CreateFormNo(string formId)
        {
            return CommonBiz.CreateId(formId);
        }
        

    }
}
