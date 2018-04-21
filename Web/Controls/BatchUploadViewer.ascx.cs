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


using SimpleFlow.SystemFramework;
using SimpleFlow.BusinessFacade;

public partial class Controls_BatchUploadViewer : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {
            // this.hidden_field_batch_id.Style.Add(HtmlTextWriterStyle.Display, "none");
            // this.hidden_upload_url.Value = (this.Page as BasePage).GetAbsoluteUrl("~/GeneralPage/BatchUpload.aspx");
            // this.LoadData();
        }
    }

    protected override void LoadControlState(object savedState)
    {
        base.LoadControlState(savedState);
        this.BatchId = this.hidden_field_batch_id.Value;
    }

    
   
    public string FormatDateTime(DateTime dt)
    {
        if (this.Page is BasePage)
        {
            return (this.Page as BasePage).FormatDateTime(dt);
        }
        return dt.ToString(Config.DateTimeFormat);
    }

    [System.ComponentModel.Browsable(true)]
    [System.ComponentModel.Description("批次上传ID")]
    [System.ComponentModel.Category("WebFramework")]
    public string BatchId
    {
        get 
        {
            return this.hidden_field_batch_id.Value;
        }
        set 
        {
            this.hidden_field_batch_id.Value = value;
        }
    }

    [System.ComponentModel.Browsable(true)]
    [System.ComponentModel.Description("是否显示删除按钮")]
    [System.ComponentModel.Category("WebFramework")]
    [System.ComponentModel.DefaultValue(true)]
    public bool ShowDeleteButton
    {
        get
        {
            if (this.ViewState["show_delete_button"] == null)
            {
                return false;
            }
            return (bool)this.ViewState["show_delete_button"];
        }
        set
        {
            this.ViewState["show_delete_button"] = value;
        }
    }


    [System.ComponentModel.Browsable(true)]
    [System.ComponentModel.Description("是否显示上传按钮")]
    [System.ComponentModel.Category("WebFramework")]
    [System.ComponentModel.DefaultValue(true)]
    public bool ShowUploadButton
    {
        get
        {
            if (this.ViewState["show_upload_button"] == null)
            {
                return false;
            }
            return (bool)this.ViewState["show_upload_button"];
        }
        set
        {
            this.ViewState["show_upload_button"] = value;
        }
    }


    [System.ComponentModel.Browsable(true)]
    [System.ComponentModel.Description("是否显示表头")]
    [System.ComponentModel.Category("WebFramework")]
    [System.ComponentModel.DefaultValue(true)]
    public bool ShowGridHeader
    {
        get
        {
            if (this.ViewState["show_grid_header"] == null)
            {
                return false;
            }
            return (bool)this.ViewState["show_grid_header"];
        }
        set
        {
            this.ViewState["show_grid_header"] = value;
        }
    }


    protected override void OnPreRender(EventArgs e)
    {
        base.OnPreRender(e);
        string upload_url = (this.Page as BasePage).GetAbsoluteUrl("~/GeneralPage/BatchUpload.aspx");
        StringBuilder sb = new StringBuilder(500);
        sb.AppendLine("<script language='javascript' type='text/javascript'>");
        sb.AppendLine("function btnUploadFile_Click(batch_object_id)");
        sb.AppendLine("{");
        sb.AppendLine("  var obj = document.getElementById(batch_object_id); ");
        sb.AppendLine("  if (obj != null)");
        sb.AppendLine("  {");
        sb.AppendLine("    var batch_id = obj.value;");
        sb.AppendFormat("    var url = '{0}?batch_id=' + obj.value; ", upload_url);
        sb.AppendLine();
        sb.AppendLine("    obj.value = window.showModalDialog(url, '', 'resizable:yes');");
        sb.AppendLine("  }");
        sb.AppendLine("}");
        sb.AppendLine("</script>");

        string script = sb.ToString();

        this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(),
            "btnUploadFile_Click", script);

        this.btnUploadFile.Attributes.Add("onclick",
            string.Format("btnUploadFile_Click('{0}');", this.hidden_field_batch_id.ClientID));

        this.LoadData();

        this.btnUploadFile.Visible = this.ShowUploadButton;
        this.GridView1.Columns[3].Visible = this.ShowDeleteButton;
        this.GridView1.ShowHeader = this.ShowGridHeader;
    }

    
    private void LoadData()
    {
        this.GridView1.DataSource = AttachmentBiz.GetBatchAttachments(this.BatchId);
        this.GridView1.DataBind();
    }

    private void LoadData(string batch_id)
    {
        this.GridView1.DataSource = AttachmentBiz.GetBatchAttachments(batch_id);
        this.GridView1.DataBind();
    }

   
    protected void delete_button_click(object sender, EventArgs e)
    {
        ImageButton button = sender as ImageButton;
        string attachment_id = (button.NamingContainer.FindControl("hidden_attachment_id") as HiddenField).Value;
        AttachmentBiz.DeleteBatchAttachment(this.BatchId, attachment_id);

        this.LoadData();
    }

    protected void btnUploadFile_ServerClick(object sender, EventArgs e)
    {
        this.LoadData();
    }
    
}
