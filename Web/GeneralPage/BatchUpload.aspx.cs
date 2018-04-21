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
public partial class GeneralPage_BatchUpload : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            string batch_id = this.Request["batch_id"];
            if (string.IsNullOrEmpty(batch_id))
            {
                batch_id = Guid.NewGuid().ToString("D");
                this.LoadBatchData(null);
            }
            else
            {
                this.LoadBatchData(batch_id);
            }
            this.ViewState["batch_id"] = batch_id;
            this.hidden_batch_id.Value = batch_id;
        }
    }


    private void LoadBatchData(string batch_id)
    {
        if (string.IsNullOrEmpty(batch_id))
        {
            List<SysAttachment> list = new List<SysAttachment>();            
            this.GridView1.DataSource = list;
            this.GridView1.DataBind();
        }
        else
        {
            List<SysAttachment> list = AttachmentBiz.GetBatchAttachments(batch_id);
            this.GridView1.DataSource = list;
            this.GridView1.DataBind();
        }
    }

   

    private void insert_one_file(FileUpload file_upload, SysUserInfo curr_user, string batch_id)
    {
        if ((file_upload.PostedFile != null) &&
            (!string.IsNullOrEmpty(file_upload.PostedFile.FileName)))
        {
            SysAttachment attachment = AttachmentBiz.InsertAttachment(curr_user,
                file_upload.PostedFile, batch_id);
        }
    }
    

    protected void button_upload_Click(object sender, EventArgs e)
    {
        string batch_id = (string)this.ViewState["batch_id"];
        SysUserInfo curr_user = this.GetCurrentUserInfo();

        this.insert_one_file(this.file_upload_1, curr_user, batch_id);
        this.insert_one_file(this.file_upload_2, curr_user, batch_id);
        this.insert_one_file(this.file_upload_3, curr_user, batch_id);

        this.LoadBatchData(batch_id);
    }

    protected void button_upload_close_Click(object sender, EventArgs e)
    {
        string batch_id = (string)this.ViewState["batch_id"];
        SysUserInfo curr_user = this.GetCurrentUserInfo();

        this.insert_one_file(this.file_upload_1, curr_user, batch_id);
        this.insert_one_file(this.file_upload_2, curr_user, batch_id);
        this.insert_one_file(this.file_upload_3, curr_user, batch_id);

        ScriptManager.RegisterStartupScript(this.UpdatePanel1, this.GetType(),
            "close_window",
            string.Format("window.returnValue = '{0}';window.close();", this.ViewState["batch_id"]),
            true);
    }

    protected void delete_button_click(object sender, EventArgs e)
    {
        
        ImageButton button = sender as ImageButton;
        string batch_id = (string)this.ViewState["batch_id"];
        string attachment_id = (button.NamingContainer.FindControl("hidden_attachment_id") as HiddenField).Value;
        // this.AjaxAlert(this.UpdatePanel1, batch_id);
        // this.AjaxAlert(this.UpdatePanel1, attachment_id);
        AttachmentBiz.DeleteBatchAttachment(batch_id, attachment_id);
        this.LoadBatchData((string)this.ViewState["batch_id"]);
        
    }
    

    protected void button_delete_all_ServerClick(object sender, EventArgs e)
    {
        string batch_id = (string)this.ViewState["batch_id"];
        AttachmentBiz.DeleteBatch(batch_id);
        this.LoadBatchData(batch_id);
    }
}
