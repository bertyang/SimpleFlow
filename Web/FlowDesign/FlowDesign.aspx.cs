using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class FlowDesign :  BasePage
{
    protected string url=string.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(Request.QueryString["form_Id"]))
        {
            url = string.Format("webflow.asp?form_Id={0}", Request.QueryString["form_Id"]);
        }
    }

    public override string GetOwnerMenuID()
    {
        return "C6488B8B-6980-4762-B76E-E88CA05E8388";
    }
}
