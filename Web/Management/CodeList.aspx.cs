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
public partial class CodeList : BasePage
{
    public override string GetOwnerMenuID()
    {
        return "2416BFCE-1464-43AA-8DE1-C97BC6F7A69B";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            string main_key = Request["main_key"];

            if (string.IsNullOrEmpty(main_key))
            {
                this.Response.End();
                return;
            }

            this.ViewState["main_key"] = main_key;
            SysCodeMaster master = CodeBiz.GetMaster(main_key);
            this.label_main_key.Text = main_key;
            this.label_main_description.Text = master.Description;
        }

        this.LoadData();

    }


    private void LoadData()
    {
        this.GridView1.DataSource = CodeBiz.GetCodeList((string)this.ViewState["main_key"]);
        this.GridView1.DataBind();
    }


    private void DoAddFirst(Control button)
    {
        Control _temp = button.NamingContainer;
        string main_key = (string)this.ViewState["main_key"];
        string sub_key = (_temp.FindControl("textbox_sub_key") as TextBox).Text.Trim();
        string content = (_temp.FindControl("textbox_content") as TextBox).Text.Trim();
        string desc = (_temp.FindControl("textbox_description") as TextBox).Text.Trim();

        if (string.IsNullOrEmpty(sub_key))
        {
            ScriptHelper.AjaxAlertFocus(this.UpdatePanel1, "please input sub_key.",
                _temp.FindControl("textbox_sub_key"));
            return;
        }

        if (string.IsNullOrEmpty(content))
        {
            ScriptHelper.AjaxAlertFocus(this.UpdatePanel1, "please input content",
                _temp.FindControl("textbox_content"));
            return;
        }

        SysCodeList entity = new SysCodeList(main_key, sub_key);
        entity.Content = content;
        entity.Description = desc;

        CodeBiz.InsertCodeList(entity);

        this.LoadData();
    }


    private void DoAddNew(Control button)
    {
        this.DoAddFirst(button);
    }


    private void DoDelete(Control button)
    {
        Control _temp = button.NamingContainer;
        string main_key = (string)this.ViewState["main_key"];
        string sub_key = (_temp.FindControl("hidden_sub_key") as HtmlInputHidden).Value;

        SysCodeList entity = new SysCodeList(main_key, sub_key);
        CodeBiz.DeleteCodeList(entity);
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
        string main_key = (string)this.ViewState["main_key"];
        string sub_key = (_temp.FindControl("hidden_sub_key") as HtmlInputHidden).Value.Trim();
        string content = (_temp.FindControl("textbox_content") as TextBox).Text.Trim();
        string desc = (_temp.FindControl("textbox_description") as TextBox).Text.Trim();
        if (string.IsNullOrEmpty(content))
        {
            ScriptHelper.AjaxAlert(this.UpdatePanel1, "please input content");
            return;
        }

        SysCodeList entity = new SysCodeList(main_key, sub_key);
        entity.Content = content;
        entity.Description = desc;

        CodeBiz.UpdateCodeList(entity);

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
