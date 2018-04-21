using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


using SimpleFlow.Entity;
using SimpleFlow.BusinessFacade;
public partial class GeneralPage_FileDownload : AttachmentDownload
{
    public override SysAttachment GetAttachment()
    {
        return AttachmentBiz.GetAttachment(Request["attachment_id"]);
    }
}
