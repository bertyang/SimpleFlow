using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SimpleFlow.Entity;
using SimpleFlow.BusinessFacade;

public partial class OrganizeTree : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void PopulateNode(Object sender, TreeNodeEventArgs e)
    {
        PopulateCategories(e.Node);
    }

    protected void PopulateCategories(TreeNode node)
    {
        string deptId = (node.Value == "Company") ? "0" : node.Value;

        List<SysDeptInfo> listDept = OrganizeBiz.GetSubDept(deptId);

        foreach (SysDeptInfo dept in listDept)
        {
            TreeNode newNode = new TreeNode();
            newNode.Text = dept.DeptCode;
            newNode.Value = dept.DeptId;
            newNode.PopulateOnDemand = true;
            newNode.SelectAction = TreeNodeSelectAction.Expand;
            newNode.ImageUrl = "~/images/Multi.gif";
            newNode.CollapseAll();
            newNode.ShowCheckBox = true;
            node.ChildNodes.Add(newNode);            
        }


        List<SysUserInfo> listUser = OrganizeBiz.GetEmployee(deptId);
        foreach (SysUserInfo user in listUser)
        {
            TreeNode newNode = new TreeNode();
            newNode.Text = user.UserName;
            newNode.Value = user.UserId;
            newNode.PopulateOnDemand = false;
            newNode.ImageUrl = "~/images/man.gif";
            newNode.NavigateUrl = "userinfo.aspx?userId=" + user.UserId;
            newNode.Target = "Content";
            newNode.ShowCheckBox = true;
            node.ChildNodes.Add(newNode);
        }
        
    }

}
