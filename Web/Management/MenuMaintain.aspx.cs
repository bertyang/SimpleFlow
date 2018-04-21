using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SimpleFlow.WebControlLibrary;

using SimpleFlow.Entity;
using SimpleFlow.BusinessFacade;
namespace GDMSNew.Presentation
{
    /// <summary>
    /// MenuMaintain 的摘要说明。
    /// </summary>
    public partial class MenuMaintain : BasePage
    {
        // private int m_MAX_ORDER = 0;
        // private int m_MIN_ORDER = 0;

        /// <summary>
        /// parent_menu_id
        /// </summary>
        public string MenuID
        {
            get
            {
                if (ViewState["MenuID"] == null)
                {
                    ViewState["MenuID"] = string.Empty;
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
            if (!IsPostBack)
            {
                this.LoadData();
            }                        
        }

        private void LoadData()
        {
            List<SysMenu> menu_list = MenuBiz.GetAllMenus();
            this.DataGridMenu.DataSource = menu_list;
            this.DataGridMenu.DataBind();
        }



        private void DoCreateNewId(Control button)
        {
            Control _temp = button.NamingContainer;
            TextBox textbox_menu_id = _temp.FindControl("textbox_menu_id") as TextBox;
            if (textbox_menu_id != null)
            {
                textbox_menu_id.Text = Guid.NewGuid().ToString("D").ToUpper();
            }
        }
        

        private void DoAddNew(Control button)
        {
            Control _temp = button.NamingContainer;
            SysMenu entity = new SysMenu();
            entity.MenuId = (_temp.FindControl("textbox_menu_id") as TextBox).Text.Trim();
            entity.MenuName = (_temp.FindControl("textbox_menu_name") as TextBox).Text;
            entity.ParentId = (_temp.FindControl("textbox_parent_id") as TextBox).Text;
            entity.IsValid = (_temp.FindControl("checkbox_is_valid") as CheckBox).Checked ? "Y" : "N";
            entity.TypeId = int.Parse((_temp.FindControl("textbox_type_id") as TextBox).Text);
            entity.DisplayOrder = int.Parse((_temp.FindControl("textbox_display_order") as TextBox).Text);
            entity.Url = (_temp.FindControl("textbox_url") as TextBox).Text;
            entity.Description = (_temp.FindControl("textbox_description") as TextBox).Text;
            if (string.IsNullOrEmpty(entity.Description))
            {
                entity.Description = entity.MenuName;
            }

            MenuBiz.InsertMenu(entity);

            this.LoadData();
        }


        private void DoDelete(Control button)
        {
            Control _temp = button.NamingContainer;

            string menu_id = (_temp.FindControl("hidden_menu_id") as HtmlInputHidden).Value.Trim();

            MenuBiz.DeleteMenu(menu_id);

            this.LoadData();
        }


        private void DoEdit(Control button)
        {
            Control _temp = button.NamingContainer;
            this.LoadData();
            this.DataGridMenu.EditIndex = (_temp as GridViewRow).RowIndex;
            this.DataGridMenu.DataBind();
        }

        private void DoCancel(Control button)
        {
            // Control _temp = button.NamingContainer;
            this.LoadData();
            this.DataGridMenu.EditIndex = -1;
            this.DataGridMenu.DataBind();
        }


        private void DoUpdate(Control button)
        {
            Control _temp = button.NamingContainer;
            SysMenu entity = new SysMenu();
            entity.MenuId = (_temp.FindControl("hidden_menu_id") as HtmlInputHidden).Value.Trim();
            entity.MenuName = (_temp.FindControl("textbox_menu_name") as TextBox).Text;
            entity.ParentId = (_temp.FindControl("textbox_parent_id") as TextBox).Text;
            entity.IsValid = (_temp.FindControl("checkbox_is_valid") as CheckBox).Checked ? "Y" : "N";
            entity.TypeId = int.Parse((_temp.FindControl("textbox_type_id") as TextBox).Text);
            entity.DisplayOrder = int.Parse((_temp.FindControl("textbox_display_order") as TextBox).Text);
            entity.Url = (_temp.FindControl("textbox_url") as TextBox).Text;
            entity.Description = (_temp.FindControl("textbox_description") as TextBox).Text;
            if (string.IsNullOrEmpty(entity.Description))
            {
                entity.Description = entity.MenuName;
            }


            MenuBiz.UpdateMenu(entity);

            this.LoadData();

            this.DataGridMenu.EditIndex = -1;
            this.DataGridMenu.DataBind();
        }

        protected void Button_Click(object sender, EventArgs e)
        {
            string cmd_name = string.Empty;
            Control button = sender as Control;

            if (button is ImageButton)
            {
                cmd_name = (button as ImageButton).CommandName;
            }
            else if (button is Button)
            {
                cmd_name = (button as Button).CommandName;
            }

            // Response.Write("<p>" + button.TemplateControl.ToString() + "</p>");
            // Response.Write("<p>" + button.NamingContainer.ToString() + "</p>");
            // Response.Write("<p>" + button.CommandName.ToLower() + "</p>");
            switch (cmd_name.ToLower())
            {
                case "create_menu_id":
                    this.DoCreateNewId(button);
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


            //ImageButton commandButton = (ImageButton)sender;
            //DataGridItem item = (DataGridItem)commandButton.Parent.Parent;
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
                
        
        //public override SiteMapNodeList GetSiteMapNodeList()
        //{
        //    SiteMapNodeList list = new SiteMapNodeList();
        //    list.Add("Home", "~/Default.aspx");
        //    list.Add("Setting", null);
        //    list.Add("Menu Setting", "~/Management/MenuMaintain.aspx");

        //    //string parentID = MenuBiz.RootMenuID;
        //    //string menuId = Request.QueryString["MenuID"];
        //    //if (menuId != null
        //    //    && menuId.Trim() != ""
        //    //    && menuId.Trim() != MenuBiz.RootMenuID) // sub menu
        //    //{
        //    //    list.Add("Sub Menu Setting", "~Management/MenuMaintain.aspx?MenuID="
        //    //        + HttpUtility.UrlEncode(menuId));
        //    //}                        
        //    return list;
        //}




        /// <summary>
        /// 获取菜单的ID，请与数据库保持一致。
        /// </summary>
        /// <returns></returns>
        public override string GetOwnerMenuID()
        {
            // return SimpleFlow.Entity.GetOwnerMenuID();
            // return MenuDef.MenuMaintain;
            return "8BC7D70F-D6E1-4433-B7C4-B7343E25BD16";
        }
    }  
}
