using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

using SimpleFlow.DataAccess;
using SimpleFlow.Entity;


namespace SimpleFlow.BusinessFacade
{
    public static class FormApproveBiz
    {
        /// <summary>
        /// 总是按form_no倒排序
        /// </summary>
        /// <param name="page_index">页索引,第一页为1。</param>
        /// <param name="page_size"></param>
        /// <param name="form_Id"></param>
        /// <param name="part_no"></param>
        /// <param name="form_no"></param>
        /// <returns></returns>
        public static List<FormApproveInfo> QueryApprovePage(int page_size, ref int page_index,
             string user_id, string form_no, out int page_count)
        {
           return FormApproveDataAccess.QueryApprovePage( page_size, ref  page_index,
              user_id,  form_no, out  page_count);            
        }

        public static List<FormApproveInfo> GetApproveList(int formId,int formNo)
        {
            return FormApproveDataAccess.GetAll(formId, formNo);
        }
    }
}
