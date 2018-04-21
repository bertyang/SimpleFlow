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
public partial class GeneralPage_BatchDownload :  BasePage
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










 
}
