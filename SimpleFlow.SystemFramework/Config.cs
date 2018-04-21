using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace SimpleFlow.SystemFramework
{
 /// <summary>
    /// CorpComm相关配置
    /// </summary>
    public static class Config
    {

        /// <summary>
        /// 数据库连接字符串
        /// </summary>
        public static string ConnectionString
        {
            get
            {
                // return @"server=hi0-ibmsv616\qisda;database=corpcomm;uid=sa;pwd=123456;"; 
                return ConfigurationManager.AppSettings["ConnectionString"];
            }
        }



        /// <summary>
        /// 上传文件的存放路径
        /// </summary>
        public static string FileUploadDir
        {
            get
            {
                return ConfigurationManager.AppSettings["FileUploadDir"];
            }
        }


        /// <summary>
        /// 是否在新窗口中下载文件
        /// </summary>
        public static bool DownloadFileInNewWindow
        {
            get { return ConfigurationManager.AppSettings["DownloadFileInNewWindow"].ToUpper() == "TRUE"; }
        }

        public static string DateFormat
        {
            get { return ConfigurationManager.AppSettings["DateFormat"]; }
        }

        public static string DateTimeFormat
        {
            get { return ConfigurationManager.AppSettings["DateTimeFormat"]; }
        }

        public static object GetAdminList()
        {
             return  ConfigurationManager.GetSection("AdministratorInformations");
        }
    }
}
