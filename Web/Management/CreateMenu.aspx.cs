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

using SimpleFlow.Entity;
using SimpleFlow.BusinessFacade;
public partial class Management_CreateMenu : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void button_ok_Click(object sender, EventArgs e)
    {
        try
        {
            SysMenu menu = new SysMenu();
            menu.MenuId = txt_menu_id.Text;
            menu.MenuName = txt_menu_name.Text;
            menu.ParentId = txt_parent_id.Text;
            menu.TypeId = int.Parse(txt_type_id.Text);
            menu.Url = txt_url.Text;
            menu.Description = txt_description.Text;
            menu.DisplayOrder = int.Parse(txt_display_order.Text);
            menu.IsValid = txt_is_valid.Text;

            MenuBiz.InsertMenu(menu);

            Response.Redirect("~/management/menumaintain.aspx");
        }
        catch (Exception ex)
        {
            ScriptHelper.AjaxAlert(this.button_ok, ex.Message);
        }
    }
}
