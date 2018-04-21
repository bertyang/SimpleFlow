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
using SimpleFlow.Entity;
using SimpleFlow.BusinessFacade;

using System.Text;

public partial class TraceFormDetail : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            if (!string.IsNullOrEmpty(this.Request["form_Id"]))
            {
                this.ViewState["form_Id"] = this.Request["form_Id"];
                this.QueryData();
            }
            else
            {
                this.Response.Write("no form_Id input.");
            }
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


        List<FormHeaderInfo> list = FormHeaderBiz.QueryPage(
            this.GridPagerControl1.PageSize,
            ref page_index,
            this.ViewState["form_Id"].ToString(),
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
        int form_Id = Convert.ToInt32(this.ViewState["form_Id"]);
        HiddenField hidden_form_no = e.Row.FindControl("hidden_form_no") as HiddenField;        
        if (hidden_form_no != null)
        {
            string form_status = DataBinder.Eval(e.Row.DataItem, "FormStatus").ToString();
            int form_no = int.Parse(hidden_form_no.Value);

            
            FormInfo form_obj = FormBiz.GetForm(form_Id);
            if (form_obj == null)
            {
                throw new ApplicationException(string.Format("form kind ({0}) does not exists.", form_Id));
            }

            HyperLink hyperlink_view = e.Row.FindControl("hyperlink_view") as HyperLink;
            if (form_status == FormStatus.NC || form_status == FormStatus.DE)
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


            ImageButton button_modify = e.Row.FindControl("button_modify") as ImageButton;
            if ((form_status == FormStatus.RC) ||
                (form_status == FormStatus.NC) ||
                (form_status == FormStatus.RJ))
            {
                button_modify.Visible = true;
                
                //string modify_url = form_obj.ModifyUrl;
                //if (string.IsNullOrEmpty(modify_url))
                //{
                //    throw new ApplicationException(string.Format("form kind ({0}), modify_url not set.", form_Id));
                //}
                //if (modify_url.Contains("?"))
                //{
                //    modify_url = string.Format("{0}&form_no={1}", modify_url, form_no);
                //}
                //else
                //{
                //    modify_url = string.Format("{0}&form_no={1}", modify_url, form_no);
                //}
                //hyperlink_modify.NavigateUrl = modify_url;
            }
            else
            {
                // hyperlink_modify.Enabled = false;
                button_modify.Visible = false;
            }

            ImageButton button_withdraw = e.Row.FindControl("button_withdraw") as ImageButton;
            if (form_status == FormStatus.UA)
            {
                // button_withdraw.Enabled = true;
                button_withdraw.Visible = true;
            }
            else
            {
                // button_withdraw.Enabled = false;
                button_withdraw.Visible = false;
            }

            ImageButton button_urgent = e.Row.FindControl("button_urgent") as ImageButton;
            if (form_status == FormStatus.UA)                
            {
                button_urgent.Visible = true;
            }
            else
            {
                button_urgent.Visible = false;
            }

            ImageButton button__approvelist = e.Row.FindControl("button_approve_list") as ImageButton;
            string script =string.Format("showApproveList({0},{1})",
                                        DataBinder.Eval(e.Row.DataItem, "FormId"),
                                        DataBinder.Eval(e.Row.DataItem, "FormNo"));

            button__approvelist.Attributes.Add("onclick", script);

            Label label_form_id = e.Row.FindControl("label_form_id") as Label;
            if (label_form_id != null)
            {
                label_form_id.Text = FormBiz.GetForm(form_Id).FormName;
            }
        }


        Label label_apply_user = e.Row.FindControl("label_apply_user") as Label;
        if (label_apply_user != null)
        {
            string user_id = DataBinder.Eval(e.Row.DataItem, "Applyer").ToString();
            label_apply_user.Text = UserBiz.GetUser(user_id).LoginName;
        }

        Label label_approve_status = e.Row.FindControl("label_approve_status") as Label;
        if (label_approve_status != null)
        {
            string status = DataBinder.Eval(e.Row.DataItem, "FormStatus").ToString();
            label_approve_status.Text = FormStatus.GetStatusFullName(status);
        }

    }


    protected void button_modify_click(object sender, EventArgs e)
    {
        //string form_Id = (string)this.ViewState["form_Id"];
        //HiddenField hidden_form_no = (sender as Control).NamingContainer.FindControl("hidden_form_no") as HiddenField;
        //int form_no = int.Parse(hidden_form_no.Value);

        //FormHeader form_header = FormHeaderBiz.GetFormHeader(form_Id, form_no);
        //if ((form_header.Status == FormStatus.NC) ||
        //    (form_header.Status == FormStatus.RC) ||
        //    (form_header.Status == FormStatus.RJ))
        //{
        //    try
        //    {
        //        //DocumentList doc_list = DocumentBiz.GetDocumentByForm(form_Id, form_no);
        //        //if (doc_list != null)
        //        //{
        //        //    if (doc_list.Status == DocumentStatus.CheckOut)
        //        //    {
        //        //        DocumentBiz.CheckIn(doc_list.DocumentId, this.GetCurrentUserInfo().UserId);
        //        //    }
        //        //}

        //        Form form = FormBiz.GetForm(form_Id);
        //        string modify_url = form.ModifyUrl;
        //        if (this.IsNullOrTrimedEmpty(modify_url))
        //        {
        //            throw new Exception("modify_url is null. form_Id = " + form_Id);
        //        }

        //        string document_id = string.Empty;
        //        //if (doc_list != null)
        //        //{
        //        //    document_id = doc_list.DocumentId;
        //        //}

        //        StringBuilder sb = new StringBuilder(200);
        //        sb.Append(modify_url);
        //        sb.Append(modify_url.Contains("?") ? "&" : "?");
        //        sb.AppendFormat("document_id={0}&form_no={1}", document_id, form_no);
        //        Response.Redirect(sb.ToString(), true);
        //    }
        //    catch (FlowerException ex)
        //    {
        //        SimpleFlow.SystemFramework.Log.WriteLog("flower", ex, this.GetCurrentUserInfo().UserId, string.Empty);
        //        this.AjaxAlert(this.UpdatePanel1, "call flower API error!");
        //    }
        //}
        //else
        //{
        //    // throw new ApplicationException("can
        //    StringBuilder sb = new StringBuilder(200);
        //    sb.Append("cannot withdraw. status is not UA");
        //    sb.AppendFormat("form_Id={0};", form_Id);
        //    sb.AppendFormat("form_no={0};", form_no);
        //    sb.AppendFormat("status={0};", form_header.Status);
        //    SimpleFlow.SystemFramework.Log.WriteLog("flower", this.GetCurrentUserInfo().UserId, sb.ToString());
        //    this.AjaxAlert(this.UpdatePanel1, "Can not recall this form.");
        //}
    }



    protected void button_withdraw_click(object sender, EventArgs e)
    {
        //string form_Id = (string)this.ViewState["form_Id"];
        //HiddenField hidden_form_no = (sender as Control).NamingContainer.FindControl("hidden_form_no") as HiddenField;
        //int form_no = int.Parse(hidden_form_no.Value);

        //FormHeader form_header = FormHeaderBiz.GetFormHeader(form_Id, form_no);
        //if (form_header.Status == FormStatus.UA)
        //{
        //    try
        //    {
        //        //Form form = FormBiz.GetForm(form_Id);
        //        //string flower_form_kind = form.FlowerFormKind;

        //        //FlowerService.RecallForm(flower_form_kind, form_no, this.GetCurrentUserInfo().UserId, "no comment.");

        //        //form_header.Status = FormStatus.RC;
        //        //FormHeaderBiz.UpdateFormHeader(form_header);
        //        ////FormHeaderBiz._UpdateFormStatus(form_Id, form_no, FormStatus.RC);

        //        //FormHeaderBiz.Recall(form_Id, form_no, this.GetCurrentUserInfo().UserId);

        //        this.QueryData();
        //        this.AjaxAlert(this.UpdatePanel1, "Recall form successfully!");
        //    }
        //    catch (FlowerException ex)
        //    {
        //        SimpleFlow.SystemFramework.Log.WriteLog("flower", ex, this.GetCurrentUserInfo().UserId, string.Empty);
        //        this.AjaxAlert(this.UpdatePanel1, "call flower API error!");
        //    }
        //}
        //else
        //{
        //    // throw new ApplicationException("can
        //    StringBuilder sb = new StringBuilder(200);
        //    sb.Append("cannot withdraw. status is not UA");
        //    sb.AppendFormat("form_Id={0};", form_Id);
        //    sb.AppendFormat("form_no={0};", form_no);
        //    sb.AppendFormat("status={0};", form_header.Status);
        //    SimpleFlow.SystemFramework.Log.WriteLog("flower", this.GetCurrentUserInfo().UserId, sb.ToString());
        //    this.AjaxAlert(this.UpdatePanel1, "Can not recall this form.");
        //}
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

    public override string GetOwnerMenuID()
    {
        return "BAA466FF-A2CC-4BDC-9E58-676DE51F2ACD";
    }


    protected void button_urgent_Click(object sender, ImageClickEventArgs e)
    {
        //string form_Id = (string)this.ViewState["form_Id"];
        //HiddenField hidden_form_no = (sender as Control).NamingContainer.FindControl("hidden_form_no") as HiddenField;
        //int form_no = int.Parse(hidden_form_no.Value);

        //FormHeader form_header = FormHeaderBiz.GetFormHeader(form_Id, form_no);
        //if (form_header.Status == FormStatus.UA)
        //{
        //    try
        //    {
        //        //FormHeaderBiz.HurryApprove(form_Id, form_no, this.GetCurrentUserInfo().UserId);
        //        this.AjaxAlert(this.UpdatePanel1, "Urgent Inform successfully!");
        //    }
        //    catch (FlowerException ex)
        //    {
        //        SimpleFlow.SystemFramework.Log.WriteLog("flower", ex, this.GetCurrentUserInfo().UserId, string.Empty);
        //        this.AjaxAlert(this.UpdatePanel1, "call flower API error!");
        //    }
        //}
        //else
        //{
        //    StringBuilder sb = new StringBuilder(200);
        //    sb.Append("cannot send Hurry Mail because status is not UA");
        //    sb.AppendFormat("form_Id={0};", form_Id);
        //    sb.AppendFormat("form_no={0};", form_no);
        //    sb.AppendFormat("status={0};", form_header.Status);
        //    SimpleFlow.SystemFramework.Log.WriteLog("flower", this.GetCurrentUserInfo().UserId, sb.ToString());
        //    this.AjaxAlert(this.UpdatePanel1, "Can not send Urgent Inform mail for this form.");
        //}
    }
}
