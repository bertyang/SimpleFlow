using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// sys_attachment
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("sys_attachment", typeof(SysAttachmentInfoHelper))]
    public class SysAttachmentInfo : SimpleFlow.SystemFramework.IEntity
    {
        public SysAttachmentInfo()
        {
        }
        public SysAttachmentInfo(string _AttachmentId)
        {
            m_AttachmentId = _AttachmentId;
        }

        private string m_AttachmentId;

        /// <summary>
        /// attachment_id
        /// </summary>
        public string AttachmentId
        {
            get
            {
                return m_AttachmentId;
            }
            set
            {
                m_AttachmentId = value;
            }
        }

        private string m_OriginalFileName;

        /// <summary>
        /// original_file_name
        /// </summary>
        public string OriginalFileName
        {
            get
            {
                return m_OriginalFileName;
            }
            set
            {
                m_OriginalFileName = value;
            }
        }

        private int m_PathId;

        /// <summary>
        /// path_id
        /// </summary>
        public int PathId
        {
            get
            {
                return m_PathId;
            }
            set
            {
                m_PathId = value;
            }
        }

        private string m_CurrentFileDir;

        /// <summary>
        /// current_file_dir
        /// </summary>
        public string CurrentFileDir
        {
            get
            {
                return m_CurrentFileDir;
            }
            set
            {
                m_CurrentFileDir = value;
            }
        }

        private string m_CurrentFileName;

        /// <summary>
        /// current_file_name
        /// </summary>
        public string CurrentFileName
        {
            get
            {
                return m_CurrentFileName;
            }
            set
            {
                m_CurrentFileName = value;
            }
        }

        private int m_FileSize;

        /// <summary>
        /// file_size
        /// </summary>
        public int FileSize
        {
            get
            {
                return m_FileSize;
            }
            set
            {
                m_FileSize = value;
            }
        }

        private System.DateTime m_UploadTime;

        /// <summary>
        /// upload_time
        /// </summary>
        public System.DateTime UploadTime
        {
            get
            {
                return m_UploadTime;
            }
            set
            {
                m_UploadTime = value;
            }
        }

        private string m_UploadUser;

        /// <summary>
        /// upload_user
        /// </summary>
        public string UploadUser
        {
            get
            {
                return m_UploadUser;
            }
            set
            {
                m_UploadUser = value;
            }
        }

        private string m_ContentType;

        /// <summary>
        /// content_type
        /// </summary>
        public string ContentType
        {
            get
            {
                return m_ContentType;
            }
            set
            {
                m_ContentType = value;
            }
        }

        private string m_FileExtension;

        /// <summary>
        /// file_extension
        /// </summary>
        public string FileExtension
        {
            get
            {
                return m_FileExtension;
            }
            set
            {
                m_FileExtension = value;
            }
        }
    }
}
