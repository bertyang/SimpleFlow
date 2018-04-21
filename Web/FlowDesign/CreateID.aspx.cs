using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



public partial class FlowDesign_CreateID : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            //Create ID
            string Id= Guid.NewGuid().ToString("D").ToUpper();

            //Return            
            Response.ContentType = "text/html";
            Response.Write(Id);
            Response.End();
        }
        catch (Exception ex)
        {
            SimpleFlow.SystemFramework.Log.WriteLog("FlowDesign_CreateID", ex);
        }
    }
}
