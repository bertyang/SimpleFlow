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
using System.Text;

using SimpleFlow.Entity;
using SimpleFlow.BusinessFacade;



public partial class ApproveForm : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            this.QueryData();
        }
    }


    private void QueryData()
    {
        int page_index = this.GridPagerControl1.PageIndex;
        int page_count = this.GridPagerControl1.PageCount;

        SysUserInfo curr_user = this.GetCurrentUserInfo();
        if (curr_user == null)
        {
            this.Response.Write("user is null");
            return;
        }

        List<FormApproveInfo> list = FormApproveBiz.QueryApprovePage(
            this.GridPagerControl1.PageSize,
            ref page_index,
            curr_user.UserId,
            this.textbox_form_no.Text,
            out page_count);

        this.GridView1.DataSource = list;
        this.GridView1.DataBind();

        this.GridPagerControl1.PageCount = page_count;
        this.GridPagerControl1.PageIndex = page_index;
    }



    protected void GridPagerControl1_PageIndexChange(object sender,
        SimpleFlow.WebControlLibrary.PageIndexChangeEventArgs e)
    {
        this.QueryData();
    }


    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        
        HiddenField hidden_form_no = e.Row.FindControl("hidden_form_no") as HiddenField;
        if (hidden_form_no != null)
        {
            string app_status = DataBinder.Eval(e.Row.DataItem, "AppStatus").ToString();
            int form_Id = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "FormId"));
            int form_no = int.Parse(hidden_form_no.Value);


            FormInfo form_obj = FormBiz.GetForm(form_Id);
            if (form_obj == null)
            {
                throw new ApplicationException(string.Format("form kind ({0}) does not exists.", form_Id));
            }

            HyperLink hyperlink_view = e.Row.FindControl("hyperlink_view") as HyperLink;
            if (app_status == FormStatus.NC || app_status == FormStatus.DE)
            {
                hyperlink_view.Visible = false;
            }
            else
            {
                hyperlink_view.Visible = true;

                string view_url = form_obj.ViewUrl;

                if (string.IsNullOrEmpty(view_url))
                {
                    throw new ApplicationException(string.Format("form kind ({0}), view_url not set.", form_Id));
                }
                if (view_url.Contains("?"))
                {
                    view_url = string.Format("{0}&form_no={1}", view_url, form_no);
                }
                else
                {
                    view_url = string.Format("{0}?form_no={1}", view_url, form_no);
                }

                hyperlink_view.NavigateUrl = view_url;
            }

            Label label_form_id = e.Row.FindControl("label_form_id") as Label;
            if (label_form_id != null)
            {
                label_form_id.Text = FormBiz.GetForm(form_Id).FormName;
            }

            ImageButton button_approvelist = e.Row.FindControl("button_approve_list") as ImageButton;
            string script = string.Format("showApproveList({0},{1})",
                                        DataBinder.Eval(e.Row.DataItem, "FormId"),
                                        DataBinder.Eval(e.Row.DataItem, "FormNo"));

            button_approvelist.Attributes.Add("onclick", script);
        }
        
        Label label_apply_user = e.Row.FindControl("label_apply_user") as Label;
        if (label_apply_user != null)
        {
            //string user_id = DataBinder.Eval(e.Row.DataItem, "Applyer").ToString();
            //label_apply_user.Text = UserBiz.GetUser(user_id).LoginName;
        }

        Label label_approve_status = e.Row.FindControl("label_approve_status") as Label;
        if (label_approve_status != null)
        {
            string status = DataBinder.Eval(e.Row.DataItem, "AppStatus").ToString();
            //label_approve_status.Text = FormStatus.GetStatusFullName(status);
        }

    }

    protected void button_agree_click(object sender, EventArgs e)
    {

        Label lableFormId = (sender as Control).NamingContainer.FindControl("label_form_id") as Label;

        HiddenField hidden_form_no = (sender as Control).NamingContainer.FindControl("hidden_form_no") as HiddenField;
        HiddenField Hidden_FormApproveId = (sender as Control).NamingContainer.FindControl("Hidden_FormApproveId") as HiddenField;
        int form_no = int.Parse(hidden_form_no.Value);

        SysUserInfo curr_user = this.GetCurrentUserInfo();

        int formId = int.Parse(lableFormId.Text);

        EngineBiz.ApproveForm(formId, form_no, Hidden_FormApproveId.Value, curr_user.UserId, "Y", "");

        this.QueryData();
    }


    protected void button_reject_Click(object sender, EventArgs e)
    {
        Label lableFormId = (sender as Control).NamingContainer.FindControl("label_form_id") as Label;

        HiddenField hidden_form_no = (sender as Control).NamingContainer.FindControl("hidden_form_no") as HiddenField;
        HiddenField Hidden_FormApproveId = (sender as Control).NamingContainer.FindControl("Hidden_FormApproveId") as HiddenField;
        int form_no = int.Parse(hidden_form_no.Value);

        SysUserInfo curr_user = this.GetCurrentUserInfo();

        int formId=int.Parse(lableFormId.Text);

        EngineBiz.ApproveForm(formId, form_no, Hidden_FormApproveId.Value, curr_user.UserId, "N", "");

        this.QueryData();
    }

    public override string GetOwnerMenuID()
    {
        return "7155EC5A-B5B4-4A23-9416-9151977616F4";
    }

    protected void button_query_Click(object sender, EventArgs e)
    {
        string str_form_no = this.textbox_form_no.Text;
        if ((str_form_no != null) && (str_form_no.Trim().Length > 0))
        {
            int form_no = 0;
            if (!int.TryParse(str_form_no, out form_no))
            {
                this.AjaxAlert(this.UpdatePanel1, "Invalidate Form No.");
                return;
            }
        }
        this.QueryData();
    }

}
