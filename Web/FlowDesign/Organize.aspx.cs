using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SimpleFlow.Entity;
using SimpleFlow.BusinessFacade;


public partial class FlowDesign_Organize : System.Web.UI.Page
{
    public string ActiveId
    {
        get
        {
            object o = ViewState["ActiveId"];
            return (o == null) ? String.Empty : (string)o;
        }

        set
        {
            ViewState["ActiveId"] = value;
        }
    }

    private string m_UserId=string.Empty;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            ActiveId = Request.QueryString["ActiveId"];
            LinksTreeView.Attributes.Add("onclick", "postBackByObject()");
            m_UserId=FormFlowBiz.GetOrgParticipant(ActiveId);
            InitTreeView();
        }
    }


    private void InitTreeView()
    {
        LoadData(LinksTreeView.Nodes[0], "0");
        LinksTreeView.CollapseAll();
    }

    private void LoadData(TreeNode node, string deptId)
    {
        //Load user
        List<SysUserInfo> listUser = OrganizeBiz.GetEmployee(deptId);

        foreach (SysUserInfo user in listUser)
        {
            TreeNode newNode = new TreeNode();
            newNode.Text = user.UserName;
            newNode.Value = user.UserId;
            newNode.ImageUrl = "~/images/man.gif";

            if (m_UserId.Contains(user.UserId))
            {
                newNode.Checked = true;
            }

            node.ChildNodes.Add(newNode);
        }

        //Load dept
        List<SysDeptInfo> listDept = OrganizeBiz.GetSubDept(deptId);

        foreach (SysDeptInfo dept in listDept)
        {
            TreeNode newNode = new TreeNode();
            newNode.Text = dept.DeptCode;
            newNode.Value = dept.DeptId;
            newNode.ImageUrl = "~/images/Multi.gif";
            node.ChildNodes.Add(newNode);

            LoadData(newNode, dept.DeptId);
        }

    }

   
    protected void ButtonSave_Click(object sender, EventArgs e)
    {
        string userId = string.Empty;

        if (LinksTreeView.CheckedNodes.Count > 0)
        {
            foreach (TreeNode node in LinksTreeView.CheckedNodes)
            {
                if (node.ImageUrl == "~/images/man.gif")
                {
                    userId += node.Value + ";";
                }
            }
        }

        FormFlowBiz.SaveOrgParticipant(ActiveId, userId.Trim(';'));
    }

    protected void LinksTreeView_CheckChanged(Object sender, TreeNodeEventArgs e)
    {       
        Check(e.Node,e.Node.Checked);
    }

    private void Check(TreeNode parentNode, bool isChecked)
    {
        foreach (TreeNode node in parentNode.ChildNodes)
        {
            node.Checked = isChecked;

            Check(node, isChecked);
        }   
    }


}
