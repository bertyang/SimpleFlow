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
public partial class Management_CodeMaster : BasePage
{
    public override string GetOwnerMenuID()
    {
        return "2416BFCE-1464-43AA-8DE1-C97BC6F7A69B";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        this.LoadData();
    }


    private void LoadData()
    {

        this.GridView1.DataSource = CodeBiz.GetMarsterList();
        this.GridView1.DataBind();
    }


    private void DoAddFirst(Control button)
    {
        Control _temp = button.NamingContainer;
        string main_key = (_temp.FindControl("textbox_main_key") as TextBox).Text.Trim();
        string desc = (_temp.FindControl("textbox_description") as TextBox).Text.Trim();

        if (string.IsNullOrEmpty(main_key))
        {
            ScriptHelper.AjaxAlertFocus(this.UpdatePanel1, "please input main_key.",
                _temp.FindControl("textbox_main_key"));
            return;
        }

        if (string.IsNullOrEmpty(desc))
        {
            ScriptHelper.AjaxAlertFocus(this.UpdatePanel1, "please input description",
                _temp.FindControl("textbox_description"));
            return;
        }

        SysCodeMaster entity = new SysCodeMaster();
        entity.MainKey = main_key;
        entity.Description = desc;


        CodeBiz.InsertMaster(entity);

        this.LoadData();
    }


    private void DoAddNew(Control button)
    {
        Control _temp = button.NamingContainer;
        string main_key = (_temp.FindControl("textbox_main_key") as TextBox).Text.Trim();
        string desc = (_temp.FindControl("textbox_description") as TextBox).Text.Trim();

        if (string.IsNullOrEmpty(main_key))
        {
            ScriptHelper.AjaxAlertFocus(this.UpdatePanel1, "please input main_key.",
                _temp.FindControl("textbox_main_key"));
            return;
        }

        if (string.IsNullOrEmpty(desc))
        {
            ScriptHelper.AjaxAlertFocus(this.UpdatePanel1, "please input description",
                _temp.FindControl("textbox_description"));
            return;
        }

        SysCodeMaster entity = new SysCodeMaster();
        entity.MainKey = main_key;
        entity.Description = desc;


        CodeBiz.InsertMaster(entity);

        this.LoadData();
    }


    private void DoDelete(Control button)
    {
        Control _temp = button.NamingContainer;

        string main_key = (_temp.FindControl("hidden_main_key") as HtmlInputHidden).Value;

        SysCodeMaster entity = new SysCodeMaster(main_key);
        CodeBiz.DeleteMaster(entity);
        this.LoadData();
    }


    private void DoEdit(Control button)
    {
        Control _temp = button.NamingContainer;
        this.GridView1.EditIndex = (_temp as GridViewRow).RowIndex;
        this.GridView1.DataBind();
    }

    private void DoCancel(Control button)
    {
        // Control _temp = button.NamingContainer;
        this.GridView1.EditIndex = -1;
        this.GridView1.DataBind();
    }


    private void DoUpdate(Control button)
    {
        Control _temp = button.NamingContainer;
        string main_key = (_temp.FindControl("hidden_main_key") as HtmlInputHidden).Value.Trim();
        string desc = (_temp.FindControl("textbox_description") as TextBox).Text.Trim();
        if (string.IsNullOrEmpty(desc))
        {
            ScriptHelper.AjaxAlert(this.UpdatePanel1, "please input description");
            return;
        }

        SysCodeMaster entity = new SysCodeMaster(main_key);
        entity.Description = desc;

        CodeBiz.UpdateMaster(entity);

        this.LoadData();

        this.GridView1.EditIndex = -1;
        this.GridView1.DataBind();
    }


    protected void Button_Click(object sender, EventArgs e)
    {
        ImageButton button = sender as ImageButton;
        switch (button.CommandName.ToLower())
        {
            case "addfirst":
                this.DoAddFirst(button);
                break;
            case "addnew":
                this.DoAddNew(button);
                break;
            case "delete":
                this.DoDelete(button);
                break;
            case "edit":
                this.DoEdit(button);
                break;
            case "cancel":
                this.DoCancel(button);
                break;
            case "update":
                this.DoUpdate(button);
                break;
            default:
                break;
        }
        
    }
}
