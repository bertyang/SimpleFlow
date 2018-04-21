using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleFlow.BusinessFacade
{
    /// <summary>
    /// 表单状态
    /// </summary>
    public static class FormStatus
    {
        /// <summary>
        /// AP: 文档改版控制状态由I变成N（签核完成）
        /// </summary>
        public const string AP = "AP";

        /// <summary>
        /// RJ: 文档改版控制状态由I变成O（被否决）
        /// </summary>
        public const string RJ = "RJ";

        /// <summary>
        /// RC: 文档改版控制状态由I变成N（被撤回）
        /// </summary>
        public const string RC = "RC";

        /// <summary>
        /// 未完成
        /// </summary>
        public const string NC = "NC";

        /// <summary>
        /// 送出
        /// </summary>
        public const string UA = "UA";

        /// <summary>
        /// 被删除
        /// </summary>
        public const string DE = "DE";

        /// <summary>
        /// 判断状态是否是有效的状态字符串
        /// </summary>
        /// <param name="status"></param>
        /// <returns></returns>
        public static bool IsValid(string status)
        {
            if (status == AP)
            {
                return true;
            }
            if (status == RJ)
            {
                return true;
            }
            if (status == RC)
            {
                return true;
            }
            if (status == NC)
            {
                return true;
            }
            if (status == UA)
            {
                return true;
            }
            if (status == DE)
            {
                return true;
            }
            if (status == UA)
            {
                return true;
            }
            return false;
        }


        /// <summary>
        /// 获取状态的全称
        /// </summary>
        /// <param name="status_abbr"></param>
        /// <returns></returns>
        public static string GetStatusFullName(string status_abbr)
        {
            if (status_abbr == NC)
            {
                return "no complete";
            }
            else if (status_abbr == UA)
            {
                return "approving";
            }
            else if (status_abbr == AP)
            {
                return "finished";
            }
            else if (status_abbr == RJ)
            {
                return "reject";
            }
            else if (status_abbr == RC)
            {
                return "withdraw";
            }
            else if (status_abbr == DE)
            {
                return "Delete";
            }
            else
            {
                throw new ApplicationException(status_abbr + " is not a validate status");
            }

        }
    }

    public static class ApproveStatus
    {
        public const string APP_VALUE_YES = "Y";
        public const string APP_VALUE_NO = "N";
        public const string APP_VALUE_PASS = "P";
        public const string APP_VALUE_RESERVE = "R";

        public const string APPROVE_TYPE_DEAL = "D";
        public const string APPROVE_TYPE_APPROVE = "A";
        public const string APPROVE_TYPE_MANUAL = "M";
        public const string APPROVE_TYPE_AUTOPASS = "P";
        public const string APPROVE_TYPE_RESEND = "B";

        public const string ASSIGN_TYPE_NORMAL = "N";
        public const string ASSIGN_TYPE_ADD = "A";
        public const string ASSIGN_TYPE_TRANSFER = "T";
        public const string ASSIGN_TYPE_REJECT = "R";


        public const string STATUS_UNDER_APPROVE = "U";
        public const string STATUS_APPROVED = "A";
        public const string STATUS_FORWARD = "F";
        public const string STATUS_REJECT = "R";
        public const string STATUS_PASS = "P";
        public const string STATUS_DYNAMIC = "D";
        public const string STATUS_RECALL = "C";
        public const string STATUS_DELETE = "L";
        public const string STATUS_WITHDRAW = "H";
        public const string STATUS_ERROR = "E";
        public const string STATUS_TRANSFER = "T";

    }
}
