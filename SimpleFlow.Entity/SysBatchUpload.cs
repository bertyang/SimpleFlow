using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// sys_batch_upload
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("sys_batch_upload", typeof(SysBatchUploadHelper))]
    public class SysBatchUpload : SimpleFlow.SystemFramework.IEntity
    {
        public SysBatchUpload()
        {
        }
        public SysBatchUpload(string _BatchId,string _AttachmentId)
        {
            m_BatchId = _BatchId;
            m_AttachmentId = _AttachmentId;
        }

        private string m_BatchId;

        /// <summary>
        /// batch_id
        /// </summary>
        public string BatchId
        {
            get
            {
                return m_BatchId;
            }
            set
            {
                m_BatchId = value;
            }
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
    }
}
