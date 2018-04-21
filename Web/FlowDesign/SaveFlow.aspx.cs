using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;
using System.IO;


using SimpleFlow.BusinessFacade;

public partial class FlowDesign_SaveFlow : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //Save
            XmlDocument objXmlDoc = new XmlDocument();
            objXmlDoc.Load(this.Request.InputStream);
            bool result=FormFlowBiz.UpdateWorkFlowXML(objXmlDoc.InnerXml);
           
            //Return            
            Response.ContentType = "text/html";
            Response.Write(result.ToString());
            Response.End();           
        }
        catch(Exception ex)
        {
            SimpleFlow.SystemFramework.Log.WriteLog("FlowDesign_SaveFlow", ex);
        }
    }
}
