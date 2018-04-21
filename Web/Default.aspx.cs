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


using SimpleFlow.Entity;
using SimpleFlow.BusinessFacade;
public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        bool isNTAuthenticated = HttpContext.Current.User.Identity.IsAuthenticated;
        string userNTAccount = HttpContext.Current.User.Identity.Name.Trim(); //get user NT account

        if (isNTAuthenticated)
        {
            // UserBiz biz = new UserBiz();
            SysUserInfo user = UserBiz.GetUserByAccount(userNTAccount);
            if (user != null)
            {
                this.Session["user"] = user;
                Response.Redirect("~/HomePage.aspx");
            }
            else
            {
                Response.Redirect("~/Logon.aspx");
            }
        }
        else
        {
            Response.Redirect("~/Logon.aspx");
        }

    }
}
