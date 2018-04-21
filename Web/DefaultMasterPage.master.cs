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
using SimpleFlow.WebControlLibrary;


namespace GDMSNew.Presentation
{
    /// <summary>
    /// Master
    /// </summary>
    public partial class DefaultMasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                BasePage bp = this.Page as BasePage;
                if (bp != null)
                {
                    //SiteMapNodeList list = bp.GetSiteMapNodeList();
                    //foreach (GDMSNew.BackGroundService.SiteMapNode node in list)
                    //{
                    //    node.URL = bp.GetAbsoluteUrl(node.URL);
                    //}
                    //this.Repeater1.DataSource = list;
                    //this.Repeater1.DataBind();
                }
                
            }
        }
    }
}