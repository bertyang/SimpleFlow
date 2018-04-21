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


public partial class Controls_Header : System.Web.UI.UserControl
{
    protected System.Web.UI.WebControls.Label Label1;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.IsPostBack == false)
        {
            LinkButtonTradition.Text = "Chinese";
            LinkButtonEnglish.Text = "English";
            LinkButtonLogout.Text = "Logout";

            BasePage base_page = this.Page as BasePage;
            if (base_page != null)
            {                
                LabelWelcome.Text = "Welcome," + base_page.CurrentUser.LoginName;
                // LinkButtonLogout.Visible = false;
            }
            else
            {
                LabelWelcome.Text = "Welcome";
                // LinkButtonLogout.Visible = false;
            }
            
        }
    }

    private void SetLogonButton(bool isAdministrator, bool impersonating)
    {
        if (isAdministrator == true || impersonating == true)
        {
            // this.LinkButtonLogout.Visible = true;
        }
    }

    public void LinkButtonLogout_Click(object sender, System.EventArgs e)
    {
        this.Session.Clear();        
        Response.Redirect("~/LogOn.aspx");
    }
}
