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
public partial class SystemConfig : BasePage
{
    public override string GetOwnerMenuID()
    {
        return "3A8FED7B-A23D-4F8A-BBBA-CAF57EC68312";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        this.LoadData();
    }


    private void LoadData()
    {
        this.GridView1.DataSource = SysConfigBiz.GetAllConfig();
        this.GridView1.DataBind();
    }


    private void DoAddFirst(Control button)
    {
        Control _temp = button.NamingContainer;
        string config_id = (_temp.FindControl("textbox_config_id") as TextBox).Text.Trim();
        string config_value = (_temp.FindControl("textbox_config_value") as TextBox).Text.Trim();

        if (string.IsNullOrEmpty(config_id))
        {
            ScriptHelper.AjaxAlertFocus(this.UpdatePanel1, "please input config id.",
                _temp.FindControl("textbox_config_id"));
            return;
        }

        if (string.IsNullOrEmpty(config_value))
        {
            ScriptHelper.AjaxAlertFocus(this.UpdatePanel1, "please input config value",
                _temp.FindControl("textbox_config_value"));
            return;
        }

        SysConfig entity = new SysConfig();
        entity.ConfigId = config_id;
        entity.ConfigValue = config_value;


        SysConfigBiz.Insert(entity);

        this.LoadData();
    }


    private void DoAddNew(Control button)
    {
        Control _temp = button.NamingContainer;
        string config_id = (_temp.FindControl("textbox_config_id") as TextBox).Text.Trim();
        string config_value = (_temp.FindControl("textbox_config_value") as TextBox).Text.Trim();

        if (string.IsNullOrEmpty(config_id))
        {
            this.AjaxAlert(this.UpdatePanel1, "please input config id.");
            return;
        }

        if (string.IsNullOrEmpty(config_value))
        {
            ScriptHelper.AjaxAlert(this.UpdatePanel1, "please input config value");
            return;
        }


        SysConfig entity = new SysConfig();
        entity.ConfigId = config_id;
        entity.ConfigValue = config_value;


        SysConfigBiz.Insert(entity);

        this.LoadData();
    }


    private void DoDelete(Control button)
    {
        Control _temp = button.NamingContainer;

        string config_id = (_temp.FindControl("hidden_config_id") as HtmlInputHidden).Value;

        // this.Response.Write("<p>" + config_id + "</p>");
        
        SysConfig entity = new SysConfig(config_id);

        SysConfigBiz.Delete(entity);

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
        string config_id = (_temp.FindControl("hidden_config_id") as HtmlInputHidden).Value;
        string config_value = (_temp.FindControl("textbox_config_value") as TextBox).Text;
        if (string.IsNullOrEmpty(config_value))
        {
            ScriptHelper.AjaxAlert(this.UpdatePanel1, "please input config value");
            return;
        }

        SysConfig entity = new SysConfig();
        entity.ConfigId = config_id;
        entity.ConfigValue = config_value;


        SysConfigBiz.Update(entity);

        this.LoadData();

        this.GridView1.EditIndex = -1;
        this.GridView1.DataBind();        
    }


    protected void Button_Click(object sender, EventArgs e)
    {
        ImageButton button = sender as ImageButton;
        // Response.Write("<p>" + button.TemplateControl.ToString() + "</p>");
        // Response.Write("<p>" + button.NamingContainer.ToString() + "</p>");
        // Response.Write("<p>" + button.CommandName.ToLower() + "</p>");
        switch (button.CommandName.ToLower())
        {
            case "addfirst":
                this.DoAddFirst(button);
                break;
            case "addnew" :
                this.DoAddNew(button);
                break;
            case "delete" :
                this.DoDelete(button);
                break;
            case "edit" :
                this.DoEdit(button);
                break;
            case "cancel" :
                this.DoCancel(button);
                break;
            case "update" :
                this.DoUpdate(button);
                break;
            default:
                break;
        }

        // DataGridItem item = (DataGridItem)commandButton.Parent.Parent;
        //int editIndex = -1;

        //MenuBiz menuBiz;
        //SysMenu menuEntity;


        //switch (commandButton.CommandName.ToLower())
        //{
        //    case "edit":
        //        editIndex = item.ItemIndex;
        //        break;
        //    case "update":
        //        menuEntity = new SysMenu();
        //        menuEntity.MenuId = DataGridMenu.DataKeys[item.ItemIndex].ToString().Trim();
        //        menuEntity.MenuName = ((TextBox)item.FindControl("TextBoxMenuNameEdit")).Text.Trim();
        //        menuEntity.Description = ((TextBox)item.FindControl("TextBoxDescriptionEdit")).Text.Trim();
        //        menuEntity.TypeId = int.Parse(((DropDownList)item.FindControl("DropDownListTypeEdit")).SelectedItem.Value.Trim());
        //        if (menuEntity.MenuName == "")
        //        {
        //            AjaxAlert(UpdatePanelMenu, "Menu name is required!");
        //            return;
        //        }
        //        if (Request.QueryString["MenuID"] != null
        //            && Request.QueryString["MenuID"].Trim() != ""
        //            && menuEntity.TypeId == (int)MenuType.None)
        //        {
        //            AjaxAlert(UpdatePanelMenu, "Please select menu type!");
        //            return;
        //        }
        //        menuBiz = new MenuBiz();
        //        menuBiz.UpdateMenu(menuEntity);
        //        break;
        //    case "addnew":
        //        string parentID = MenuBiz.RootMenuID;
        //        if (Request.QueryString["MenuID"] != null && Request.QueryString["MenuID"].Trim() != "" && Request.QueryString["MenuID"].Trim() != MenuBiz.RootMenuID)
        //        {
        //            parentID = Request.QueryString["MenuID"].Trim();
        //        }
        //        menuEntity = new SimpleFlow.Entity.Menu();
        //        menuEntity.Menu_Id = Guid.NewGuid().ToString();
        //        menuEntity.Menu_Name = ((TextBox)item.FindControl("TextBoxMenuNameFoot")).Text.Trim();
        //        menuEntity.Description = ((TextBox)item.FindControl("TextBoxDescriptionFoot")).Text.Trim();
        //        menuEntity.Type_Id = int.Parse(((DropDownList)item.FindControl("DropDownListTypeFoot")).SelectedItem.Value.Trim());
        //        menuEntity.Parent_Id = parentID;
        //        if (menuEntity.MenuName == "")
        //        {
        //            AjaxAlert(UpdatePanelMenu, "Menu name is required!");
        //            return;
        //        }
        //        if (Request.QueryString["MenuID"] != null
        //            && Request.QueryString["MenuID"].Trim() != ""
        //            && menuEntity.Type_Id == (int)MenuType.None)
        //        {
        //            AjaxAlert(UpdatePanelMenu, "Please select menu type!");
        //            return;
        //        }
        //        menuBiz = new MenuBiz();
        //        menuBiz.InsertMenu(menuEntity);
        //        break;
        //    case "cancel":
        //        break;
        //    case "delete":
        //        break;
        //    case "up":
        //        int index = item.ItemIndex;
        //        //獲取當前記錄的menu_id, order_index
        //        string menuID = DataGridMenu.DataKeys[index].ToString().Trim();
        //        int order = int.Parse(((Label)DataGridMenu.Items[index].Cells[0].FindControl("LabelOrder")).Text);
        //        //獲取上一條記錄的menu_id, order_index
        //        string lastMenuID = DataGridMenu.DataKeys[index - 1].ToString().Trim();
        //        int lastOrder = int.Parse(((Label)DataGridMenu.Items[index - 1].Cells[0].FindControl("LabelOrder")).Text);
        //        MenuBiz.UpdateOrderIndexOfMenu(menuID, lastMenuID, order, lastOrder);
        //        break;
        //    case "down":
        //        int currentIndex = item.ItemIndex;
        //        //獲取當前記錄的menu_id, order_index
        //        string currentMenuID = DataGridMenu.DataKeys[currentIndex].ToString().Trim();
        //        int currentOrder = int.Parse(((Label)DataGridMenu.Items[currentIndex].Cells[0].FindControl("LabelOrder")).Text);
        //        //獲取下一條記錄的menu_id, order_index
        //        string nextMenuID = DataGridMenu.DataKeys[currentIndex + 1].ToString().Trim();
        //        int nextOrder = int.Parse(((Label)DataGridMenu.Items[currentIndex + 1].Cells[0].FindControl("LabelOrder")).Text);
        //        MenuBiz.UpdateOrderIndexOfMenu(currentMenuID, nextMenuID, currentOrder, nextOrder);
        //        break;
        //}
        //DataGridMenu.EditItemIndex = editIndex;
        //BindDataGridMenu();
    }

}
