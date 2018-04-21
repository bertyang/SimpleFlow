using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace SimpleFlow.SystemFramework
{
    public static class Log
    {
        public static void WriteLog(string log_type, Exception ex)
        {
            SysExceptionLog log = new SysExceptionLog();

            log.LogType = log_type;
            AttachException(log, ex);

            log.LogId = System.Guid.NewGuid().ToString("D").ToUpper();
            log.LogTime = DateTime.Now;
            AttachException(log, ex);

            WriteLog(log);
        }


        public static void WriteLog(Exception ex)
        {
            WriteLog(string.Empty, ex);
        }

        private static void WriteLog(SysExceptionLog log)
        {
            FileSystemLog.Log(log);
        }  


        private static SysExceptionLog AttachException(SysExceptionLog log, System.Exception ex)
        {
            log.ExData = Dictionary2String(ex.Data);
            log.ExMessage = ex.Message;
            log.ExSource = ex.Source;
            log.ExStackTrace = ex.StackTrace;
            if (ex.TargetSite != null)
            {
                log.ExTargetSite = ex.TargetSite.ToString();
            }

            if (ex.InnerException != null)
            {
                System.Exception innerEx = ex.InnerException;
                log.InnerData = Dictionary2String(innerEx.Data);
                log.InnerMessage = innerEx.Message;
                log.InnerSource = innerEx.Source;
                log.InnerStackTrace = innerEx.StackTrace;
                if (innerEx.TargetSite != null)
                {
                    log.InnerTargetSite = innerEx.TargetSite.ToString();
                }
            }
            log.LogTime = DateTime.Now;

            return log;
        }


        /// <summary>
        /// 将Dictionary转成可见的字符串形式。
        /// </summary>
        /// <param name="dict"></param>
        /// <returns></returns>
        private static string Dictionary2String(System.Collections.IDictionary dict)
        {
            if (dict == null)
            {
                return string.Empty;
            }

            StringBuilder sb = new StringBuilder(100);
            foreach (object key in dict.Keys)
            {
                sb.Append(key);
                sb.Append("=");
                sb.Append(dict[key]);
                sb.Append(";");
            }
            return sb.ToString();
        }
        
        //public static void Log(Exception ex, string extra_message)
        //{
        //    SysExceptionLog log = new SysExceptionLog();

        //    log.Description = extra_message;
        //    AttachException(log, ex);

        //    log.LogId = System.Guid.NewGuid().ToString("D").ToUpper();
        //    log.LogTime = DateTime.Now;
        //    AttachException(log, ex);

        //    SimpleFlow.SystemFramework.Log.WriteLog(log);
        //}
        
        

    }
}
