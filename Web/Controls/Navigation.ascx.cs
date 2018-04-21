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

using SimpleFlow.BusinessFacade;

public partial class Controls_Navigation : System.Web.UI.UserControl
{
    /// <summary>
    /// request menuID from Parent Page
    /// </summary>
    public string MenuID
    {
        get
        {
            if (ViewState["MenuID"] == null)
            {
                ViewState["MenuID"] = "";
            }
            return (string)ViewState["MenuID"];
        }
        set 
        {
            ViewState["MenuID"] = value;
        }
    }

    protected void Page_Load(object sender, EventArgs e)
    {   
        //if (MenuID != null && MenuID != "")
        //{
        //    DataSet menuData =  MenuBiz.GetNavigationBySubMenuID(MenuID);
        //    if (menuData != null && menuData.Tables[0].Rows.Count > 0)
        //    {
        //        LiteralMenu.Text = Server.HtmlEncode( (string)menuData.Tables[0].Rows[0]["menu"]);
        //        LiteralSubMenu.Text = Server.HtmlEncode((string)menuData.Tables[0].Rows[0]["submenu"]);
        //        LiteralDescription.Text = Server.HtmlEncode((string)menuData.Tables[0].Rows[0]["description"]);
        //    }
        //}
    }
}
