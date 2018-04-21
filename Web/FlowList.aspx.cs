using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.IO;

using SimpleFlow.Entity;
using SimpleFlow.BusinessFacade;


public partial class FlowList : BasePage
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

    protected void design_form_link_Click(object sender, EventArgs e)
    {
        Control button = sender as Control;

        string form_Id = (button.NamingContainer.FindControl("hidden_form_id") as HiddenField).Value;

        FormFlowBiz.BuildFlowFile(int.Parse(form_Id));

        string url = string.Format("flowdesign//flowdesign.aspx?form_Id={0}", form_Id);

        Response.Redirect(url);

    }

    public override string GetOwnerMenuID()
    {
        return "C6488B8B-6980-4762-B76E-E88CA05E8388";
    }
}