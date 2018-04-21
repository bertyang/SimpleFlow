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


public partial class HomePage : BasePage // : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //List<SimpleFlow.Entity.Menu> menuList = biz.GetNonSystemMenuList();

        //List<MenuNode> nodeList = biz.BuildMenuTree(menuList);

        //this.DataList1.DataSource = nodeList;
        //this.DataList1.DataBind();
    }

    protected void DataList1_ItemDataBound(object sender, DataListItemEventArgs e)
    {
        //DataList listObj = e.Item.FindControl("ChildDataList") as DataList;
        //if (listObj != null)
        //{
        //    MenuNode nodeObj = e.Item.DataItem as MenuNode;
        //    if (nodeObj != null)
        //    {
        //        listObj.DataSource = nodeObj.Nodes;
        //        listObj.DataBind();
        //        for (int i = 0; i < nodeObj.Nodes.Count; i++)
        //        {
        //            HyperLink subMenuLink = listObj.Items[i].FindControl("HyperLinkSubMenu") as HyperLink;
        //            if (nodeObj.Nodes[i].Menu.Type_Id == (int)MenuTypeEnum.FileObject)
        //            {
        //                subMenuLink.NavigateUrl = BizConfig.FileObjectUrl + "?menu_id=" + HttpUtility.UrlPathEncode(nodeObj.Nodes[i].Menu.Menu_Id);
        //            }
        //            else if (nodeObj.Nodes[i].Menu.Type_Id == (int)MenuTypeEnum.ImageObject)
        //            {
        //                subMenuLink.NavigateUrl = BizConfig.ImageObjectUrl + "?menu_id=" + HttpUtility.UrlPathEncode(nodeObj.Nodes[i].Menu.Menu_Id);
        //            }
        //            else if (nodeObj.Nodes[i].Menu.Type_Id == (int)MenuTypeEnum.LinkObject)
        //            {
        //                subMenuLink.NavigateUrl = BizConfig.LinkObjectUrl + "?menu_id=" + HttpUtility.UrlPathEncode(nodeObj.Nodes[i].Menu.Menu_Id);
        //            }
        //        }

        //    }
        //}
    }


    //public override SiteMapNodeList GetSiteMapNodeList()
    //{
    //    // return base.GetSiteMapNodeList();
    //    SiteMapNodeList list = new SiteMapNodeList();
    //    list.Add("Home", "~/Default.aspx");
    //    return list;
    //}


    public override string GetOwnerMenuID()
    {
        return base.GetOwnerMenuID();        
    }


    public override bool UserHasPrivilege()
    {
        // return base.UserHasPrivilege();
        return true;
    }
    
}
