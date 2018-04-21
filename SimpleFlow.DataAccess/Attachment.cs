using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;
using System.Data.SqlClient;

using SimpleFlow.Entity;
using SimpleFlow.SystemFramework;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.DataAccess
{
    public class AttachmentDataAccess
    {
      
            public static SysAttachment GetAttachment(string attachmentId)
            {
                return SqlHelper.Retrieve<SysAttachment>(Config.ConnectionString, new SysAttachment(attachmentId));
            }


            /// <summary>
            /// 将上传文件加到某个批次
            /// </summary>
            /// <param name="curr_user"></param>
            /// <param name="postedFile"></param>
            /// <param name="batch_id"></param>
            /// <returns></returns>
            public static SysAttachment InsertAttachment(SysAttachment item, SysBatchUpload batch_entity)
            {
                SqlConnection conn = new SqlConnection(Config.ConnectionString);
                conn.Open();
                try
                {

                    SqlTransaction trans = conn.BeginTransaction();
                    try
                    {
                        SqlHelper.Insert(trans, item);
                        SqlHelper.Insert(trans, batch_entity);

                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw ex;
                    }
                }
                finally
                {
                    conn.Close();
                }

                return item;
            }


            public static bool batch_attach_exists(SqlTransaction trans, SysBatchUpload entity)
            {
                string sql = " select count(*) from sys_batch_upload where batch_id = @batch_id and attachment_id = @attachment_id ";
                ParameterBuilder pb = new ParameterBuilder();
                pb.Add("@batch_id", entity.BatchId);
                pb.Add("@attachment_id", entity.AttachmentId);

                return (int)SqlHelper.ExecuteScalar(trans, CommandType.Text, sql, pb.ToArray()) > 0;
            }

            public static void InsertAttachment(SysAttachment item)
            {
                SqlHelper.Insert(Config.ConnectionString, item);
            }


            public static string GetDocPath(int path_id)
            {
                return SqlHelper.Retrieve<SysDocPath>(Config.ConnectionString, new SysDocPath(path_id)).DocPath;
            }

            /// <summary>
            /// 删除某个批次的所有文件
            /// </summary>
            /// <param name="batch_id"></param>
            public static void DeleteBatch(SqlTransaction trans, string batch_id)
            {
                List<string> file_list = new List<string>(5);

                List<SysAttachment> attr_list = GetBatchAttachments(batch_id);

                foreach (SysAttachment attr in attr_list)
                {
                    file_list.Add(GetFilePath(attr));
                    SqlHelper.Delete(trans, attr);
                    SqlHelper.Delete(trans, new SysBatchUpload(batch_id, attr.AttachmentId));
                }

                // 删除对应的文件
                foreach (string file_path in file_list)
                {
                    try
                    {
                        System.IO.File.Delete(file_path);
                    }
                    catch (Exception ex)
                    {
                        SimpleFlow.SystemFramework.Log.WriteLog(ex);
                    }
                }
            }

            /// <summary>
            /// 删除某个批次的所有文件
            /// </summary>
            /// <param name="batch_id"></param>
            public static void DeleteBatch(string batch_id)
            {
                SqlConnection conn = new SqlConnection(Config.ConnectionString);

                conn.Open();

                try
                {
                    SqlTransaction trans = conn.BeginTransaction();
                    try
                    {
                        DeleteBatch(trans, batch_id);

                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw ex;
                    }
                }
                finally
                {
                    conn.Close();
                }
            }


            /// <summary>
            /// 删除批次中的某个文件
            /// </summary>
            /// <param name="batch_id"></param>
            /// <param name="attachment_id"></param>
            public static void DeleteBatchAttachment(string batch_id, string attachment_id)
            {

                List<string> file_list = new List<string>(1);
                SqlConnection conn = new SqlConnection(Config.ConnectionString);
                conn.Open();
                try
                {
                    SqlTransaction trans = conn.BeginTransaction();
                    try
                    {
                        SysAttachment attr = SqlHelper.Retrieve(trans, new SysAttachment(attachment_id));
                        if (attr != null)
                        {
                            file_list.Add(GetFilePath(attr));
                            SqlHelper.Delete(trans, attr);
                        }

                        SqlHelper.Delete(trans, new SysBatchUpload(batch_id, attachment_id));

                        trans.Commit();
                    }
                    catch (Exception ex)
                    {
                        trans.Rollback();
                        throw ex;
                    }
                }
                finally
                {
                    conn.Close();
                }

                foreach (string file_path in file_list)
                {
                    try
                    {

                        System.IO.File.Delete(file_path);
                    }
                    catch (Exception ex)
                    {
                        SimpleFlow.SystemFramework.Log.WriteLog(ex);
                    }
                }
            }

            private static string GetFilePath(SysAttachment att)
            {
                string dir = System.IO.Path.Combine(GetDocPath(att.PathId), att.CurrentFileDir);
                return System.IO.Path.Combine(dir, att.CurrentFileName);
            }
            /// <summary>
            /// 获取某个批次的所有附件
            /// </summary>
            /// <param name="batch_id">批次ID</param>
            /// <returns></returns>
            public static List<SysAttachment> GetBatchAttachments(string batch_id)
            {
                StringBuilder sb = new StringBuilder(200);
                sb.Append(" select sys_attachment.* from sys_batch_upload, sys_attachment ");
                sb.Append(" where sys_batch_upload.attachment_id = sys_attachment.attachment_id ");
                sb.Append(" and sys_batch_upload.batch_id = @batch_id  ");
                sb.Append(" order by sys_attachment.upload_time asc ");
                ParameterBuilder pb = new ParameterBuilder("@batch_id", batch_id);
                return SqlHelper.GetListBySql<SysAttachment>(Config.ConnectionString, sb.ToString(), pb.ToArray());
            }

            public static SysSiteList GetSysSiteList(int SiteSerial)
            {
                SysSiteListHelper site_helper = new SysSiteListHelper();

                return site_helper.Retrieve(Config.ConnectionString, new SysSiteList(SiteSerial));
            }

            public static SysDocPath GetSysDocPath(int SiteSerial)
            {
                SysDocPathHelper doc_helper = new SysDocPathHelper();

                return doc_helper.Retrieve(Config.ConnectionString, new SysDocPath(SiteSerial));
            }


        }

}
