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
using SimpleFlow.Entity;
using SimpleFlow.BusinessFacade;

public partial class TraceForm : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            this.LoadData();
        }
    }


    public void LoadData()
    {
        this.DataList1.DataSource = FormBiz.GetAll();
        this.DataList1.DataBind();

    }


    public override string GetOwnerMenuID()
    {
        return "BAA466FF-A2CC-4BDC-9E58-676DE51F2ACD";
    }
}
