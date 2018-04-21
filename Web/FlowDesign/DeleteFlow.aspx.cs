using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

using SimpleFlow.BusinessFacade;


public partial class FlowDesign_DeleteFlow : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string flowId = Request.QueryString["FlowId"];

            bool result = FormFlowBiz.DeleteWorkFlowXML(flowId);

            string fileName = flowId + ".xml";

            string path = System.AppDomain.CurrentDomain.BaseDirectory + "FlowDesign\\flows\\";

            if (File.Exists(path + fileName))
            {
                File.Delete(path + fileName);
            }

            //Return            
            Response.ContentType = "text/html";
            Response.Write(result.ToString());
            Response.End();
        }
        catch (Exception ex)
        {
            SimpleFlow.SystemFramework.Log.WriteLog("FlowDesign_CreateID", ex);
        }
    }
}
