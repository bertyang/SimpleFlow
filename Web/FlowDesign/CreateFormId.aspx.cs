using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SimpleFlow.BusinessFacade;

public partial class FlowDesign_CreateFormId : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            string formKind = CommonBiz.CreateFormId();

            //Return            
            Response.ContentType = "text/html";
            Response.Write(formKind);
            Response.End();
        }
        catch (Exception ex)
        {
            SimpleFlow.SystemFramework.Log.WriteLog("FlowDesign_CreateFormKind ", ex);
        }
    }
}
