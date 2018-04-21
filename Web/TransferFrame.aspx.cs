using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class TransferFrame:  BasePage
{
    protected string m_strSrc = String.Empty;

    protected void Page_Load(object sender, EventArgs e)
    {
        m_strSrc = string.Format("forms/{0}/default.aspx",Request.QueryString["formId"]);
    }
}
