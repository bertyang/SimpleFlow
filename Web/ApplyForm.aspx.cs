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
using SimpleFlow.Entity;
using SimpleFlow.BusinessFacade;


public partial class ApplyForm : BasePage
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

    protected void apply_form_link_Click(object sender, EventArgs e)
    {
        Control button = sender as Control;
        SysUserInfo curr_user = this.GetCurrentUserInfo();
        string form_Id = (button.NamingContainer.FindControl("hidden_form_id") as HiddenField).Value;
        
        #region add to form_header 
        //FormHeader header = new FormHeader(form_Id, form_no);
        //header.FormDate = DateTime.Now;
        //header.FormDueDate = DateTime.Now;
        //header.FormFiller = curr_user.UserId;
        //header.SiteSerial = curr_user.SiteSerial;
        //header.Status = FormStatus.NC;
        //FormHeaderBiz.InsertFormHeader(header);
        #endregion

        FormInfo form = FormBiz.GetForm(int.Parse(form_Id));
        string apply_url = form.ApplyUrl;
        if (string.IsNullOrEmpty(apply_url))
        {
            throw new ApplicationException(string.Format("form kind ({0})'s apply_url not set.", form_Id));
        }
        StringBuilder sb = new StringBuilder(150);
        sb.Append(apply_url);
        //sb.Append(apply_url.Contains("?") ? "&" : "?");
        //sb.AppendFormat("form_no={0}", form_no);
        Response.Redirect("transferframe.aspx");
        
    }


    public override string GetOwnerMenuID()
    {
        return "09963260-6D51-4F07-9C1B-B40228EE66E5";
    }
}
