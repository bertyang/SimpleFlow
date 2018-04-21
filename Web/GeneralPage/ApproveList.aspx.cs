using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using SimpleFlow.Entity;
using SimpleFlow.BusinessFacade;

public partial class GeneralPage_ApproveList : System.Web.UI.Page
{
    private int m_FormId;
    private int m_FormNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (!string.IsNullOrEmpty(Request.QueryString["FormId"]))
            {
                m_FormId = Convert.ToInt32(Request.QueryString["FormId"]);
            }

            if (!string.IsNullOrEmpty(Request.QueryString["FormNo"]))
            {
                m_FormNo = Convert.ToInt32(Request.QueryString["FormNo"]);
            }

            BindData();
        }
    }

    private void BindData()
    {
        List<FormApproveInfo> listFormApprove=FormApproveBiz.GetApproveList(m_FormId, m_FormNo);

        GridViewAproveList.DataSource = listFormApprove.OrderBy(cs => cs.AppSerial);
        GridViewAproveList.DataBind();
    }
}
