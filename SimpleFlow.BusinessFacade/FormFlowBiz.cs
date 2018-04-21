using System;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using System.Xml;
using System.IO;
using System.Collections.Generic;

using SimpleFlow.Entity;
using SimpleFlow.DataAccess;
using SimpleFlow.BusinessRules;
using SimpleFlow.SystemFramework;

namespace SimpleFlow.BusinessFacade
{
    public static class FormFlowBiz
    {
        /// <summary>
        /// 获取工作流xml描述
        /// </summary>
        /// <param name="workflowID">流程ID</param>
        /// <returns></returns>
        public static string GetFlowXML(int formId)
        {
            string xml = "";

            try
            {
                FormInfo form = FormDataAccess.GetForm(formId);

                if (form != null)
                    xml = form.FlowXml;
            }
            catch (Exception ex)
            {
                SimpleFlow.SystemFramework.Log.WriteLog("GetWorkFlowXML", ex);

                xml = "";
            }

            return xml;
        }


        /// <summary>
        /// 更新流程xml
        /// </summary>
        /// <param name="workFlowXml">流程xml描述</param>
        public static bool UpdateWorkFlowXML(string workFlowXml)
        {
            Byte[] b = System.Text.UTF8Encoding.UTF8.GetBytes(workFlowXml);
            XmlDocument objXmlDoc = new XmlDocument();
            objXmlDoc.Load(System.Xml.XmlReader.Create(new MemoryStream(b)));                        

            #region form
            XmlNode node = objXmlDoc.SelectSingleNode("WebFlow/FlowConfig/BaseProperties");
            int flowId = Convert.ToInt32(node.Attributes["flowId"].Value);
            FormInfo form = FormBiz.GetForm(flowId);
            form.FormName = node.Attributes["flowText"].Value;
            form.FlowXml = workFlowXml;
            #endregion

            #region active
            List<ActiveInfo> listActive = new List<ActiveInfo>();

            XmlNodeList nodeStepList = objXmlDoc.SelectNodes("WebFlow/Steps/Step");

            foreach (XmlNode nodeStep in nodeStepList)
            {
                XmlNode nodeBase=nodeStep.SelectSingleNode("BaseProperties");

                ActiveInfo active = ActiveDataAccess.GetActive(nodeBase.Attributes["id"].Value);

                if (active==null) active=new ActiveInfo();

                active.ActiveId = nodeBase.Attributes["id"].Value;
                active.ActiveName = nodeBase.Attributes["text"].Value;
                active.ActiveType = nodeBase.Attributes["stepType"].Value;        
                active.FormId = form.FormId;
                listActive.Add(active);
            }
            #endregion

            #region condition
            List<ConditionInfo> listCondition = new List<ConditionInfo>();
            XmlNodeList nodeActionList = objXmlDoc.SelectNodes("WebFlow/Actions/Action");

            foreach (XmlNode nodeAction in nodeActionList)
            {
                XmlNode nodeBase = nodeAction.SelectSingleNode("BaseProperties");

                ConditionInfo condition = ConditionDataAccess.GetCondition(nodeBase.Attributes["id"].Value);

                if (condition == null) condition = new ConditionInfo();

                condition.FromActiveId = nodeBase.Attributes["from"].Value;
                condition.ToActiveId = nodeBase.Attributes["to"].Value;
                condition.ConditionId = nodeBase.Attributes["id"].Value;
                condition.ConditionName = nodeBase.Attributes["text"].Value;                            
                condition.FormId = form.FormId;
                listCondition.Add(condition);
            }
            
            #endregion

            return FlowDataAccess.UpdateFlow(form,listActive,listCondition);
               
        }


        /// <summary>
        /// 删除流程xml
        /// </summary>
        /// <param name="workFlowXml">流程xml描述</param>
        public static bool DeleteWorkFlowXML(string formId)
        {

            return FlowDataAccess.DeleteFlow(formId);
        }


        /// <summary>
        /// 删除流程xml
        /// </summary>
        /// <param name="workFlowXml">流程xml描述</param>
        public static List<ConditionSubInfo> GetConditionSubList(string conditionId)
        {
            return ConditionSubDataAccess.GetConditionSubList(conditionId);
        }


        public static void UpdateConditionSub(ConditionSubInfo cs)
        {
            ConditionSubDataAccess.UpdateConditionSub(cs);
        }

        public static void AddConditionSub(ConditionSubInfo cs)
        {
            ConditionSubDataAccess.AddConditionSub(cs);
        }

        public static void DelConditionSub(string ConditionSubId)
        {
            ConditionSubDataAccess.DelConditionSub(ConditionSubId);
        }

        public static ConditionSubInfo GetConditionSub(string ConditionSubId)
        {
            return ConditionSubDataAccess.GetConditionSub(ConditionSubId);
        }

        public static ConditionInfo GetCondition(string ConditionId)
        {
            return ConditionDataAccess.GetCondition(ConditionId);
        }

        public static void UpdateCondition(ConditionInfo condition)
        {
            ConditionDataAccess.Update(condition);
        }

        public static void BuildFlowFile(int formId)
        {
            string fileName = formId + ".xml";

            string path =string.Format("{0}\\Forms\\{1}\\", System.AppDomain.CurrentDomain.BaseDirectory,formId);

            try
            {
                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }

                FileStream stream = new FileStream(path + fileName, FileMode.OpenOrCreate, FileAccess.Write, FileShare.ReadWrite);

                StreamWriter sw = new StreamWriter(stream, System.Text.Encoding.UTF8);

                sw.Write(GetFlowXML(formId));

                sw.Close();
                stream.Close();
            }
            catch (Exception ex)
            {
                Log.WriteLog(ex);
            }
        }


        public static void SaveOrgParticipant(string activeId,string userId)
        {

            List<ParticipantInfo> list=ParticipantDataAccess.GetParticipantByActive(activeId);


            if (list.Count > 0)
            {
                ParticipantOrgInfo org = ParticipantDataAccess.GetParticipantOrg(list[0].ParticipantId);
                org.UserId = userId;
                ParticipantDataAccess.UpdateParticipantOrg(org);
            }
            else
            {
                ParticipantOrgInfo org = new ParticipantOrgInfo();
                org.UserId = userId;
                org.ParticipantId = Guid.NewGuid().ToString("D");
                ParticipantDataAccess.InsertParticipantOrg(org);
            }            

        }

        public static string GetOrgParticipant(string activeId)
        {

            List<ParticipantInfo> list = ParticipantDataAccess.GetParticipantByActive(activeId);


            if (list.Count > 0)
            {
                ParticipantOrgInfo org = ParticipantDataAccess.GetParticipantOrg(list[0].ParticipantId);

                return org.UserId;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
