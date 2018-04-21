using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using SimpleFlow.DBFramework.SQLServer;

namespace SimpleFlow.Entity
{
    /// <summary>
    /// sys_site_list
    /// </summary>
    [SimpleFlow.DBFramework.SQLServer.Entity("sys_site_list", typeof(SysSiteListInfoHelper))]
    public class SysSiteListInfo : SimpleFlow.SystemFramework.IEntity
    {
        public SysSiteListInfo()
        {
        }
        public SysSiteListInfo(int _SiteSerial)
        {
            m_SiteSerial = _SiteSerial;
        }

        private int m_SiteSerial;

        /// <summary>
        /// site_serial
        /// </summary>
        public int SiteSerial
        {
            get
            {
                return m_SiteSerial;
            }
            set
            {
                m_SiteSerial = value;
            }
        }

        private string m_SiteName;

        /// <summary>
        /// site_name
        /// </summary>
        public string SiteName
        {
            get
            {
                return m_SiteName;
            }
            set
            {
                m_SiteName = value;
            }
        }

        private int m_CurrentUploadPathId;

        /// <summary>
        /// current_upload_path_id
        /// </summary>
        public int CurrentUploadPathId
        {
            get
            {
                return m_CurrentUploadPathId;
            }
            set
            {
                m_CurrentUploadPathId = value;
            }
        }

        private string m_SiteType;

        /// <summary>
        /// site_type
        /// </summary>
        public string SiteType
        {
            get
            {
                return m_SiteType;
            }
            set
            {
                m_SiteType = value;
            }
        }

        private string m_SiteDesc;

        /// <summary>
        /// site_desc
        /// </summary>
        public string SiteDesc
        {
            get
            {
                return m_SiteDesc;
            }
            set
            {
                m_SiteDesc = value;
            }
        }

        private string m_FlowerEngineservice;

        /// <summary>
        /// flower_engineservice
        /// </summary>
        public string FlowerEngineservice
        {
            get
            {
                return m_FlowerEngineservice;
            }
            set
            {
                m_FlowerEngineservice = value;
            }
        }

        private string m_FlowerFlowerapi;

        /// <summary>
        /// flower_flowerapi
        /// </summary>
        public string FlowerFlowerapi
        {
            get
            {
                return m_FlowerFlowerapi;
            }
            set
            {
                m_FlowerFlowerapi = value;
            }
        }

        private string m_FlowerFormcradle;

        /// <summary>
        /// flower_formcradle
        /// </summary>
        public string FlowerFormcradle
        {
            get
            {
                return m_FlowerFormcradle;
            }
            set
            {
                m_FlowerFormcradle = value;
            }
        }
    }
}
