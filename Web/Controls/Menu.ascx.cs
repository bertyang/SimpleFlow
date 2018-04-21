using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using SimpleFlow.WebControlLibrary;
using SimpleFlow.SystemFramework;

using SimpleFlow.Entity;
using SimpleFlow.BusinessFacade;

public partial class Controls_Menu : System.Web.UI.UserControl
{
    //private string m_CurrentPage = null;

    private void Page_Load(object sender, System.EventArgs e)
	{
        ImgIcon.Attributes.Add("onclick", "SwitchTreeViewStatus(this);");
        ImgIcon.Style.Add("display", "block");

        RegistUtilityScripts();
        RegisteScriptHoldDiv();
        BuildMenu();
	}


    private string GetAbsoluteMenuUrl(string url)
    {
        if (string.IsNullOrEmpty(url))
        {
            return url;
        }
        string trimed_url = url.Trim();
        if (trimed_url.StartsWith("~/"))
        {
            string rel_url = trimed_url.Substring(2, trimed_url.Length - 2);
            string appPath = this.Request.ApplicationPath.Trim();
            if (!appPath.EndsWith("/"))
            {
                appPath += "/";
            }
            return appPath + rel_url;
        }
        return trimed_url;
    }

    private void BuildMenu()
    {       
        TreeViewMenu.MarginBase = 5;
        TreeViewMenu.LevelIncrease = 10;


        
        List<SysMenu> sourceMenuList;

        BasePage base_page = this.Page as BasePage;
        if (base_page != null)
        {
            string emp_id = base_page.CurrentUser.UserId;
            sourceMenuList = HomePageBiz.GetMenuListByUser(emp_id);
        }
        else
        {
            sourceMenuList = MenuBiz.GetAllMenus();
        }

        Trace.Write("count of menus: " + sourceMenuList.Count.ToString());

        SystemMenuList systemMenus = new SystemMenuList();

        foreach (SysMenu sourceMenu in sourceMenuList)
        {            
            if (sourceMenu.IsValid.ToUpper() == "Y")
            {
                sourceMenu.Url = GetAbsoluteMenuUrl(sourceMenu.Url);
                systemMenus.Add(sourceMenu);
            }
        }
        systemMenus.SortByDisplayOrder();


        List<string> selected_list = this.GetSelectedList(sourceMenuList);
        RenderMenu(MenuBiz.RootMenuID, systemMenus, TreeViewMenu, selected_list);
    }


    private List<string> GetSelectedList(List<SysMenu> menu_list)
    {
        Dictionary<string, SysMenu> dict = new Dictionary<string,SysMenu>(menu_list.Count);
        foreach(SysMenu menu in menu_list)
        {
            dict.Add(menu.MenuId, menu);
        }

        string owner_menu_id = (this.Page as BasePage).GetOwnerMenuID();

        List<string> selected_list = new List<string>(3);
        while (dict.ContainsKey(owner_menu_id))
        {
            selected_list.Add(owner_menu_id);
            owner_menu_id = dict[owner_menu_id].ParentId;
        }
        return selected_list;
    }

    private void RenderMenu(string parentID, SystemMenuList menuList, TreeView menuLeft, List<string> selected_list)
	{
		SystemMenuList subMenuList = menuList.Filter(parentID);
        subMenuList.SortByDisplayOrder();
		foreach(IMenuItem menu in subMenuList)
		{
			TreeNode item = new TreeNode(menu.MenuName, menu.Url);
			item.CssClass = "MenuLeftCss";
			item.MouseOverCss = "MenuLeftMouseOverCss";
			item.SelectedCss = "MenuLeftMouseOverCss";
            item.Selected = selected_list.Contains(menu.MenuId);
            if (string.IsNullOrEmpty(menu.Url))
            {
                item.NodeType = NodeType.Text;
            }
			menuLeft.Nodes.Add(item);
            RenderMenu(menu.MenuId, menuList, item, selected_list);
		}
	}


    private void RenderMenu(string parentID, SystemMenuList menuList, TreeNode item, List<string> selected_list)
    {
        SystemMenuList subMenuList = menuList.Filter(parentID);
        subMenuList.SortByDisplayOrder();

        foreach (IMenuItem menu in subMenuList)
        {
            TreeNode subItem = new TreeNode(menu.MenuName, menu.Url);
            subItem.CssClass = "SubMenu";
            subItem.MouseOverCss = "SubMenuOver";
            subItem.SelectedCss = "SubMenuOver";
            BasePage base_page = this.Page as BasePage;
            subItem.Selected = selected_list.Contains(menu.MenuId);
            item.Nodes.Add(subItem);
            RenderMenu(menu.MenuId, menuList, subItem, selected_list);
        }
    }

	private void BuildUrl(SystemMenuList menuList)
	{
		foreach(IMenuItem menu in menuList)
		{
			menu.Url = Resolve_ClientUrl(menu.Url);
		}
	}

	internal string Resolve_ClientUrl(string relativeUrl)
	{
		string sourceDirectory = this.TemplateSourceDirectory;
		if (sourceDirectory.Length == 0)
		{
			return relativeUrl;
		}
		string baseDir = BaseDir;
		if (!UrlPath.IsAppRelativePath(relativeUrl))
		{
			if (string.Compare(baseDir, sourceDirectory, true) == 0)
			{
				return relativeUrl;
			}
			if ((relativeUrl.Length == 0) || !UrlPath.IsRelativeUrl(relativeUrl))
			{
				return relativeUrl;
			}
		}
		string text3 = UrlPath.Combine(sourceDirectory, relativeUrl);
		baseDir = UrlPath.AppendSlashToPathIfNeeded(baseDir);
		return UrlPath.MakeRelative(baseDir, text3);
	}

	private string _baseVirtualDir = null;

	string BaseDir
	{
		get
		{
			if (this._baseVirtualDir == null)
			{
				string text1 = Request.FilePath;
				this._baseVirtualDir = UrlPath.GetDirectory(text1);
			}
			return this._baseVirtualDir;
		}
	}

    //string CurrentPage
    //{
    //    get
    //    {
    //        if (this.m_CurrentPage == null)
    //        {
    //            string currentPage = Request.Url.AbsolutePath;
    //            this.m_CurrentPage = currentPage.ToLower();
    //        }
    //        return this.m_CurrentPage;
    //    }
    //}

	void RegistUtilityScripts()
	{
		// alter by derek 2007-4-30, this alteration may fixed the problem when hide left panel or top panel
		// and refresh frequently, it can't be held the state.
		string applicationPath = Request.ApplicationPath;
		if (this.Page.ClientScript.IsClientScriptBlockRegistered("BasicUtilityControl") == false)
		{
            this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "BasicUtilityControl",
                string.Format("<Script language = \"JavaScript\" src = \"{0}/Scripts/BasicUtilityControl.js\"></Script>", applicationPath));

            
            //Page.RegisterClientScriptBlock("BasicUtilityControl",
            //    "<Script language = \"JavaScript\" src = \"~/Scripts/BasicUtilityControl.js\"></Script>");
		}

		if (this.Page.ClientScript.IsStartupScriptRegistered("ResizeWindow") == false)
		{
			this.Page.ClientScript.RegisterStartupScript(this.GetType(), "ResizeWindow", string.Format(@"
            <Script language = ""JavaScript"">
                var RootSite = ""{0}"";
                ResizeWindow();
                ResetLeftMenuIcon();
                var mainPanel = document.getElementById(""Main"");
                if (mainPanel != null){{
	                mainPanel.onresize = ResizeWindow;
                }}
            </Script>",  applicationPath));
		                
        }
        
    }

	private void RegisteScriptHoldDiv()
	{
		InputHiddenRootSite.Value = Request.ApplicationPath;
		// Regist the client id to page
		//m_Register.RegisteClientScript(this.Page, new string[] {InputHiddenRootSite.ClientID}, "CurrentRootSite");
		//m_Register.RegisteClientScript(this.Page, "PanelDisplay");
		if (this.Page.ClientScript.IsStartupScriptRegistered("CurrentRootSiteArray") == false) 
		{
			string arrayScript = @"<Script language = ""JavaScript"">var CurrentRootSite = new Array('{0}');</Script>";
			this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                "CurrentRootSiteArray", string.Format(arrayScript, InputHiddenRootSite.ClientID));
		}

		if (this.Page.ClientScript.IsStartupScriptRegistered("PanelDisplayFunction") == false)
		{
			string functionScript = @"<Script language = ""Javascript"">PanelDisplay();</Script>";
			this.Page.ClientScript.RegisterStartupScript(this.GetType(),
                "PanelDisplayFunction", functionScript);
		}
	}


	#region Web Form Designer generated code
	override protected void OnInit(EventArgs e)
	{
		//
		// CODEGEN: This call is required by the ASP.NET Web Form Designer.
		//
		InitializeComponent();
		base.OnInit(e);
	}
	
	/// <summary>
	///		Required method for Designer support - do not modify
	///		the contents of this method with the code editor.
	/// </summary>
	private void InitializeComponent()
	{
		this.Load += new System.EventHandler(this.Page_Load);

	}
	#endregion
}
