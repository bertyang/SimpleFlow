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
using SimpleFlow.Entity;
using SimpleFlow.BusinessFacade;

public partial class UserInfo : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            string userId = string.Empty;

            if (!string.IsNullOrEmpty(Request.QueryString["UserId"]))
            {
                userId = Request.QueryString["UserId"];
            }
            else
            {
                userId = this.GetCurrentUserInfo().UserId;
            }

            List<SysSiteList> site_list = SiteBiz.GetAllSites();
            this.ddl_site.DataSource = site_list;
            this.ddl_site.DataBind();

            SysUserInfo curr_user = UserBiz.GetUser(this.GetCurrentUserInfo().UserId);
            this.text_name.Text = curr_user.LoginName;
            this.text_dept.Text = curr_user.DeptCode;
            this.text_email.Text = curr_user.Email;
            this.text_ext_no.Text = curr_user.ExtNo;
            // this.text_site.Text = curr_user.SiteSerial;
            this.DateControl1.Date = curr_user.EntryDate;
            this.ddl_site.SelectedValue = curr_user.SiteSerial.ToString();
            this.DateControl1.Date = curr_user.EntryDate;
        }
    }

    protected void button_update_basic_info_Click(object sender, EventArgs e)
    {
        try
        {            
            SysUserInfo curr_user = UserBiz.GetUser(this.GetCurrentUserInfo().UserId);
            curr_user.ExtNo = this.text_ext_no.Text.Trim();
            curr_user.Email = this.text_email.Text.Trim();
            if (this.DateControl1.Date.HasValue)
            {
                curr_user.EntryDate = this.DateControl1.Date.Value;
            }
            curr_user.SiteSerial = int.Parse(this.ddl_site.SelectedValue);

            UserBiz.UpdateUser(curr_user);
            this.ResetSession(curr_user);
            this.AjaxAlert(this.UpdatePanel1, "update successfully!");
        }
        catch (ApplicationException ex)
        {
            this.AjaxAlert(this.UpdatePanel1, ex.Message);
        }
    }


    protected void button_modify_password_Click(object sender, EventArgs e)
    {
        if (this.text_new_password.Text.Trim().Length == 0)
        {
            this.AjaxAlert(this.UpdatePanel1, "please input new password");
            return;
        }


        SysUserInfo curr_user = UserBiz.GetUser(this.GetCurrentUserInfo().UserId);
        if (this.text_old_password.Text != curr_user.Password)
        {
            this.AjaxAlert(this.UpdatePanel1, "password error.");
            return;
        }

        if (this.text_new_password.Text != this.text_confirm_password.Text)
        {
            this.AjaxAlert(this.UpdatePanel1, "New password and confirm password don't match, please reinput.");
            return;
        }

        curr_user.Password = this.text_new_password.Text;
        UserBiz.UpdateUser(curr_user);
        this.ResetSession(curr_user);

        this.AjaxAlert(this.UpdatePanel2, "modify password successfully!");
    }

    public override string GetOwnerMenuID()
    {
        return "9C3BE2A3-8B6F-48BE-9C16-A43BEFDAED9A";
    }
}
