using System;
using System.IO;
using System.Text;
using System.Configuration;


namespace SimpleFlow.SystemFramework
{
	/// <summary>
	/// Summary description for FileSystemLog.
	/// </summary>
	internal static class FileSystemLog //: ILog
	{
		

        public const long max_size = 300000; // 300K

        private static string GetLogFile()
        {
            string log_dir = System.AppDomain.CurrentDomain.BaseDirectory + "\\Log\\";
   
            if (!System.IO.Directory.Exists(log_dir))
            {
                System.IO.Directory.CreateDirectory(log_dir);
            }

            string file_prefix = DateTime.Now.ToString("yyyy-MM-dd");
            int index = 0;
            string file_name, file_path;
            // bool get_it = false;

            do
            {
                index += 1;
                file_name = string.Format("{0}-{1}.txt", file_prefix, index);
                file_path = System.IO.Path.Combine(log_dir, file_name);

                if (!System.IO.File.Exists(file_path))
                {
                    // get_it = true;
                    break;
                }

                if (new System.IO.FileInfo(file_path).Length < max_size)
                {
                    // get_it = true;
                    break;
                }
            } while (true);

            return file_path;            
        }

        private static string m_log_prefix = null;

        public static string LogPrefix
        {
            get
            {
                if (m_log_prefix == null)
                {
                    m_log_prefix = new string('-', 76);
                }
                return m_log_prefix;
            }
        }

        public static void Log(SysExceptionLog log)
        {
            
            string file_path = GetLogFile();
            FileStream stream = new FileStream(file_path, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
            try
            {
                StreamWriter writer = new StreamWriter(stream, System.Text.Encoding.UTF8);
                writer.WriteLine();
                writer.WriteLine();
                writer.WriteLine(LogPrefix);
                writer.WriteLine(LogPrefix);
                writer.Write("date-time: ");
                writer.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                writer.Write("log-type: ");
                writer.WriteLine(log.LogType);
                writer.Write("user-id: ");
                writer.WriteLine(log.UserId);
                writer.Write("extra-message: ");
                writer.WriteLine(log.Description);
                writer.Write("error-url: ");
                writer.WriteLine(log.ErrorUrl);
                writer.Write("http-context: ");
                writer.WriteLine(log.HttpContext);

                writer.Write("ex-message: ");
                writer.WriteLine(log.ExMessage);
                writer.Write("ex-data: ");
                writer.WriteLine(log.ExData);
                writer.Write("ex-source: ");
                writer.WriteLine(log.ExSource);
                writer.Write("ex-stack-trace: ");
                writer.WriteLine(log.ExStackTrace);
                writer.Write("ex-target-site: ");
                writer.WriteLine(log.ExTargetSite);

                writer.Write("inner-message: ");
                writer.WriteLine(log.InnerMessage);
                writer.Write("inner-data: ");
                writer.WriteLine(log.InnerData);
                writer.Write("inner-source: ");
                writer.WriteLine(log.InnerSource);
                writer.Write("inner-stack-trace: ");
                writer.WriteLine(log.InnerStackTrace);
                writer.Write("inner-target-site: ");
                writer.WriteLine(log.InnerTargetSite);

                writer.Flush();
                stream.Flush();
                writer.Close();
            }
            catch
            {
            }
            finally
            {
                stream.Close();
            }
            
        }

	}
}
