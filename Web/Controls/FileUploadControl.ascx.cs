using System;
using System.Data;
using System.ComponentModel;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Collections.Generic;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SimpleFlow.WebControlLibrary;

using SimpleFlow.Entity;
using SimpleFlow.BusinessFacade;

//[Designer(typeof(GDMSNew.ControlLibrary.FileUploadControlDesigner), typeof(System.Web.UI.Design.ControlDesigner))]
public partial class Controls_FileUploadControl : System.Web.UI.UserControl
{
    //private string m_AttachmentID;
    //private string m_FileName;

    [Browsable(true)]
    [Description("点击按钮后打开的上传页面")]
    [DefaultValue("~/GeneralPage/FileUpload.aspx")]
    public string UploadPage
    {
        get
        {
            if (this.ViewState["UploadPage"] == null)
            {
                return "~/GeneralPage/FileUpload.aspx";
            }
            else
            {
                return this.ViewState["UploadPage"] as string;
            }
        }
        set
        {
            this.ViewState["UploadPage"] = value;
        }
    }



    [Browsable(true)]
    public string AttachmentID
    {
        get { return this.txtAttachmentID.Text; }
        set { this.txtAttachmentID.Text = value; }
    }


    [Browsable(true)]
    public string AttachFileName
    {
        get { return this.txtFileName.Text; }
        set { this.txtFileName.Text = value; }
    }


    [Browsable(true)]
    [Description("是否允许上传多个文件")]
    [DefaultValue(false)]
    public bool AllowMoreFiles
    {
        get
        {
            return (this.txtAllowMoreFiles.Text == "Y");
        }
        set
        {
            this.txtAllowMoreFiles.Text = value ? "Y" : "N";
        }
    }



    public List<SysAttachment> GetAttachments()
    {
        List<SysAttachment> list = new List<SysAttachment>();
        SysAttachment item = AttachmentBiz.GetAttachment(this.AttachmentID);
        list.Add(item);
        return list;
    }

    private string GetAbsoluteMenuUrl(string url)
    {

        string trimed_url = url.Trim();
        if (trimed_url.StartsWith("~/"))
        {
            string rel_url = trimed_url.Substring(2, trimed_url.Length - 2);
            string appPath = this.Request.ApplicationPath.Trim();
            if (!appPath.EndsWith("/"))
            {
                appPath += "/";
            }
            return appPath + rel_url;
        }
        return trimed_url;
    }


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!this.IsPostBack)
        {

            this.txtFileName.Visible = true;
            this.txtAttachmentID.Visible = true;

            string clientHandler = string.Format("javascript:upload_file_handler('{0}', '{1}', '{2}');",
                this.GetAbsoluteMenuUrl(this.UploadPage),
                this.txtFileName.ClientID, this.txtAttachmentID.ClientID);
            this.btnUpload.Attributes.Add("onclick", clientHandler);

            this.txtFileName.Attributes.Add("readonly", "true");
        }        
    }


    
}
