using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Text;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SimpleFlow.WebControlLibrary;

using SimpleFlow.Entity;
using SimpleFlow.BusinessFacade;
public partial class GeneralPage_FileUpload : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.ClearPageCache();

        if (!this.IsPostBack)
        {
            this.txtCloseOnLoad.Value = "N";
            this.txtFileList.Value = string.Empty;
            this.txtAllowMoreFiles.Value = this.Request["AllowMoreFiles"];
            this.ViewState["Attachments"] = new SysAttachment[] { };

            this.GridView1.DataSource = this.ViewState["Attachments"];
            this.GridView1.DataBind();
        }
    }


    /// <summary>
    /// 清空客户端的浏览器缓存
    /// </summary>
    /// <remarks>
    /// 此方法在每次页面加载时都会被调用，主要是解决ModalDialog对页面缓存的问题
    /// </remarks>
    private void ClearPageCache()
    {
        Response.Buffer = true;
        Response.Expires = 0;
        Response.ExpiresAbsolute = DateTime.Now.AddDays(-1);
        Response.AddHeader("pragma", "no-cache");
        Response.AddHeader("cache-control", "private");
        Response.CacheControl = "no-cache";
    }


    private string AttachmentList2String(List<SysAttachment> attachList)
    {
        StringBuilder sb = new StringBuilder(100);
        for(int i=0; i<attachList.Count; i++)
        {
            SysAttachment obj = attachList[i];
            if (i > 0)
            {
                sb.Append(";");
            }
        
            sb.Append(Microsoft.JScript.GlobalObject.escape(obj.AttachmentId));
            sb.Append("=");
            sb.Append(Microsoft.JScript.GlobalObject.escape(obj.OriginalFileName));
        }

        return sb.ToString();
    }

    protected void btnUpload_Click(object sender, EventArgs e)
    {
        if ((updFile.PostedFile != null) && (!string.IsNullOrEmpty(updFile.PostedFile.FileName)))
        {
            SysAttachment item = AttachmentBiz.InsertAttachment(this.GetCurrentUserInfo(), updFile.PostedFile);


            List<SysAttachment> attachList = new List<SysAttachment>();
            if (this.ViewState["Attachments"] != null)
            {
                attachList.AddRange(this.ViewState["Attachments"] as SysAttachment[]);
            }            
            attachList.Add(item);

            this.ViewState["Attachments"] = attachList.ToArray();

            this.GridView1.DataSource = attachList;
            this.GridView1.DataBind();


            this.txtFileList.Value = this.AttachmentList2String(attachList);

            if (this.txtAllowMoreFiles.Value != "Y")
            {
                this.txtCloseOnLoad.Value = "Y";
            }

        }
    }


    public override bool UserHasPrivilege()
    {
        return true;
    }
}
