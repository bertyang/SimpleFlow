using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Web;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;

namespace SimpleFlow.BusinessFacade
{
    public static class AttachmentBiz
    {
        public static SysAttachment GetAttachment(string attachmentId)
        {
            return AttachmentDataAccess.GetAttachment(attachmentId);
        }


        /// <summary>
        /// 新增一个单独上传的附件，该附件不在任何批次中。
        /// </summary>
        /// <param name="curr_user"></param>
        /// <param name="postedFile"></param>
        /// <returns></returns>
        public static SysAttachment InsertAttachment(SysUserInfo curr_user, System.Web.HttpPostedFile postedFile)
        {
            string originalFilePath = postedFile.FileName;

            SysSiteList site_entity = AttachmentDataAccess.GetSysSiteList(curr_user.SiteSerial);
            if (site_entity == null)
            {
                throw new ApplicationException(string.Format("site [{0}] does not exists.", curr_user.SiteSerial));
            }

            // get site's upload path
            SysDocPath doc_path_entity = AttachmentDataAccess.GetSysDocPath(site_entity.CurrentUploadPathId);
            if (doc_path_entity == null)
            {
                throw new ApplicationException(string.Format("path_id [{0}]does not configed in db.", site_entity.CurrentUploadPathId));
            }
            string baseDir = doc_path_entity.DocPath;


            DateTime dt_now = DateTime.Now;            
            string subDir = dt_now.ToString("yyyyMM");
            string fileDir = Path.Combine(baseDir, subDir);

            if (!System.IO.Directory.Exists(fileDir))
            {
                System.IO.Directory.CreateDirectory(fileDir);
            }

            string attachmentId = System.Guid.NewGuid().ToString("D");
            string currentFileName = attachmentId + Path.GetExtension(originalFilePath);
            string currentFilePath = Path.Combine(fileDir, currentFileName);

            postedFile.SaveAs(currentFilePath);

            SysAttachment item = new SysAttachment();
            item.AttachmentId = attachmentId;
            item.CurrentFileName = currentFileName;
            item.CurrentFileDir = subDir;
            item.FileSize = postedFile.ContentLength;
            item.OriginalFileName = Path.GetFileName(originalFilePath);
            item.UploadTime = dt_now;
            item.UploadUser = curr_user.UserId;
            item.ContentType = postedFile.ContentType;
            item.PathId = site_entity.CurrentUploadPathId;
            item.FileExtension = Path.GetExtension(originalFilePath);

            AttachmentDataAccess.InsertAttachment(item);

            return item;
        }


        /// <summary>
        /// 将上传文件加到某个批次
        /// </summary>
        /// <param name="curr_user"></param>
        /// <param name="postedFile"></param>
        /// <param name="batch_id"></param>
        /// <returns></returns>
        public static SysAttachment InsertAttachment(SysUserInfo curr_user, System.Web.HttpPostedFile postedFile, string batch_id)
        {
            string originalFilePath = postedFile.FileName;
            // save file
            // get user's site
            SysSiteList site_entity = AttachmentDataAccess.GetSysSiteList(curr_user.SiteSerial);
            if (site_entity == null)
            {
                throw new ApplicationException(string.Format("site [{0}] does not exists.", curr_user.SiteSerial));
            }
            
            // get site's upload path
            SysDocPath doc_path_entity = AttachmentDataAccess.GetSysDocPath(site_entity.CurrentUploadPathId);
            if (doc_path_entity == null)
            {
                throw new ApplicationException(string.Format("path_id [{0}]does not configed in db.", site_entity.CurrentUploadPathId));
            }
            string baseDir = doc_path_entity.DocPath;

            // get child dir
            DateTime dt_now = DateTime.Now;
            string subDir = dt_now.ToString("yyyyMM");
            string fileDir = Path.Combine(baseDir, subDir);

            if (!System.IO.Directory.Exists(fileDir))
            {
                System.IO.Directory.CreateDirectory(fileDir);
            }

            string attachmentId = System.Guid.NewGuid().ToString("D");
            string currentFileName = attachmentId + Path.GetExtension(originalFilePath);
            string currentFilePath = Path.Combine(fileDir, currentFileName);

            postedFile.SaveAs(currentFilePath);

            SysAttachment item = new SysAttachment();

            item.AttachmentId = attachmentId;
            item.CurrentFileName = currentFileName;
            item.CurrentFileDir = subDir;
            item.FileSize = postedFile.ContentLength;
            // postedFile.
            item.OriginalFileName = Path.GetFileName(originalFilePath);
            item.UploadTime = dt_now;
            item.UploadUser = curr_user.UserId;
            item.ContentType = postedFile.ContentType;
            item.PathId = site_entity.CurrentUploadPathId;
            item.FileExtension = Path.GetExtension(originalFilePath);

            SysBatchUpload batch_entity = new SysBatchUpload(batch_id, attachmentId);

            AttachmentDataAccess.InsertAttachment(item,batch_entity);
           
            return item;
        }


        internal static void InsertAttachment(SysAttachment item)
        {
            AttachmentDataAccess.InsertAttachment(item);
        }

        public static string GetDocPath(int path_id)
        {
            return AttachmentDataAccess.GetDocPath(path_id);
        }

        private static string GetFilePath(SysAttachment att)
        {
            string dir = System.IO.Path.Combine(GetDocPath(att.PathId), att.CurrentFileDir);
            return System.IO.Path.Combine(dir, att.CurrentFileName);
        }


        /// <summary>
        /// 删除某个批次的所有文件
        /// </summary>
        /// <param name="batch_id"></param>
        public static void DeleteBatch(string batch_id)
        {
            AttachmentDataAccess.DeleteBatch(batch_id); 
        }


        /// <summary>
        /// 删除批次中的某个文件
        /// </summary>
        /// <param name="batch_id"></param>
        /// <param name="attachment_id"></param>
        public static void DeleteBatchAttachment(string batch_id, string attachment_id)
        {
            AttachmentDataAccess.DeleteBatchAttachment(batch_id, attachment_id);
        }


        /// <summary>
        /// 获取某个批次的所有附件
        /// </summary>
        /// <param name="batch_id">批次ID</param>
        /// <returns></returns>
        public static List<SysAttachment> GetBatchAttachments(string batch_id)
        {
            return AttachmentDataAccess.GetBatchAttachments(batch_id);
        }
    }
}
