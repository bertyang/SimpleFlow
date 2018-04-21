using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace SimpleFlow.WebControlLibrary
{
    
    [ToolboxData("<{0}:CustomFileUpload runat=server></{0}:CustomFileUpload>")]
    public class CustomFileUpload : WebControl, IPostBackDataHandler, INamingContainer
    {
        public CustomFileUpload() : base(HtmlTextWriterTag.Table)
        {
            
        }


        private string m_AttachmentID;

        [Browsable(true)]
        public string AttachmentID
        {
            get { return m_AttachmentID; }
            set { m_AttachmentID = value; }
        }

        private string m_AttachFileName;

        [Browsable(true)]
        public string AttachFileName
        {
            get { return m_AttachFileName; }
            set { m_AttachFileName = value; }
        }


        private bool m_AllowMoreFiles = false;


        [Browsable(true)]
        [Description("是否允许上传多个文件")]
        [DefaultValue(false)]
        public bool AllowMoreFiles
        {
            get
            {
                return m_AllowMoreFiles; 
            }
            set
            {
                m_AllowMoreFiles = value;
            }
        }


        private string m_ButtonText = "Browse...";

        [Browsable(true)]
        [Description("铵钮上的文字")]
        [DefaultValue("Browse...")]
        public string ButtonText
        {
            get { return m_ButtonText; }
            set { m_ButtonText = value; }
        }


        private string m_UploadPage = "~/GeneralPage/FileUpload.aspx";

        [Browsable(true)]
        [Description("点击按钮后打开的上传页面")]
        [DefaultValue("~/GeneralPage/FileUpload.aspx")]
        public string UploadPage
        {
            get
            {
                return m_UploadPage;
            }
            set
            {
                m_UploadPage = value;
            }
        }
        

        


        //private string GetClientAttachmentID()
        //{
        //    return this.ClientID + this.ClientIDSeparator + "AttachmentID";
        //}

        //private string GetClientFileNameID()
        //{
        //    return this.ClientID + this.ClientIDSeparator + "AttachFileName";
        //}
        

        private string GetAbsoluteMenuUrl(string url)
        {
            string trimed_url = url.Trim();
            if (!this.DesignMode)
            {
                
                if (trimed_url.StartsWith("~/"))
                {
                    string rel_url = trimed_url.Substring(2, trimed_url.Length - 2);
                    string appPath = this.Page.Request.ApplicationPath.Trim();
                    if (!appPath.EndsWith("/"))
                    {
                        appPath += "/";
                    }
                    return appPath + rel_url;
                }
            }
            return trimed_url;
        }


        private void RegisterClientScript()
        {
            if (this.DesignMode)
            {
                return;
            }

            if (!this.Page.ClientScript.IsClientScriptBlockRegistered(this.GetType(), this.GetType().ToString()))
            {
                this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(), this.GetType().ToString(),
                    @"

<script language='javascript' type='text/javascript'>
function upload_file_handler(upload_url, name_object_id, id_object_id)
{
    var result = window.showModalDialog(upload_url, null, 'dialogWidth:300px;dialogHeight:200px;');
    // alert(result);
    if ((result != null) && (result.length > 0))
    {
        var item_array = result.split(';');
        if (item_array.length > 0)
        {
            var prop_array = item_array[0].split('=');
            if (prop_array.length >= 2)
            {
                var name_obj = document.getElementById(name_object_id);
                name_obj.value = unescape(prop_array[1]);
                // alert(name_obj.value);
                var id_obj = document.getElementById(id_object_id);
                id_obj.value = unescape(prop_array[0]);
                // alert(id_obj.value);
            }
        }
    }
}
</script>

");
            }
             
        }     


        protected override void OnPreRender(EventArgs e)
        {
            this.RegisterClientScript();
            base.OnPreRender(e);            
        }


        protected override object SaveViewState()
        {
            object obj = base.SaveViewState();
            return new object[] { this.AllowMoreFiles, this.UploadPage, this.ButtonText, obj };
        }


        protected override void LoadViewState(object savedState)
        {
            object[] obj = savedState as object[];
            this.AllowMoreFiles = (bool)obj[0];
            this.UploadPage = obj[1] as string;
            this.ButtonText = obj[2] as string;
            
            base.LoadViewState(obj[3]);
        }



        public override bool HasControls()
        {
            return false;
        }

        protected override void  RenderContents(HtmlTextWriter writer)
        {
            string client_txt_file_name_id = this.ClientID + this.ClientIDSeparator + "txtFileName";
            string client_txt_attachment_id = this.ClientID + this.ClientIDSeparator + "AttachmentID";
            // this.RenderBeginTag(writer);

            // base.RenderControl(writer);
            writer.RenderBeginTag(HtmlTextWriterTag.Tr);
            writer.RenderBeginTag(HtmlTextWriterTag.Td);

            writer.AddAttribute(HtmlTextWriterAttribute.Type, "text");
            writer.AddAttribute(HtmlTextWriterAttribute.Id, client_txt_file_name_id);
            writer.AddAttribute(HtmlTextWriterAttribute.Name, this.UniqueID + "$txtFileName");
            writer.AddAttribute(HtmlTextWriterAttribute.Value, m_AttachFileName);
            writer.AddAttribute(HtmlTextWriterAttribute.ReadOnly, "true");
            writer.RenderBeginTag(HtmlTextWriterTag.Input);
            writer.RenderEndTag();

            writer.AddAttribute("type", "hidden");
            writer.AddAttribute("id", client_txt_attachment_id);
            writer.AddAttribute("name", this.UniqueID + "$AttachmentID");
            writer.AddAttribute("value", this.AttachmentID);

            writer.RenderBeginTag(HtmlTextWriterTag.Input);
            writer.RenderEndTag();


            writer.AddAttribute("type", "hidden");
            writer.AddAttribute("id", this.ClientID);
            writer.AddAttribute("name", this.UniqueID);
            writer.AddAttribute("value", this.AttachmentID);
            writer.RenderBeginTag(HtmlTextWriterTag.Input);
            writer.RenderEndTag();



            writer.RenderEndTag(); // td

            writer.RenderBeginTag(HtmlTextWriterTag.Td);

            writer.AddAttribute(HtmlTextWriterAttribute.Type, "button");
            writer.AddAttribute(HtmlTextWriterAttribute.Id, this.ClientID + this.ClientIDSeparator + "btnUpload");
            writer.AddAttribute(HtmlTextWriterAttribute.Name, this.UniqueID + "$btnUpload");
            writer.AddAttribute(HtmlTextWriterAttribute.Value, m_ButtonText);

            string handler = string.Format("javascript:upload_file_handler('{0}', '{1}', '{2}');",
                        this.GetAbsoluteMenuUrl(this.UploadPage),
                        client_txt_file_name_id,
                        client_txt_attachment_id);

            writer.AddAttribute(HtmlTextWriterAttribute.Onclick, handler);
            writer.RenderBeginTag(HtmlTextWriterTag.Input);
            writer.RenderEndTag();

            writer.RenderEndTag(); // td


            writer.RenderEndTag(); //tr

            // this.RenderEndTag(writer);

            
        }


               


        #region IPostBackDataHandler Members

        bool IPostBackDataHandler.LoadPostData(string postDataKey, System.Collections.Specialized.NameValueCollection postCollection)
        {
            this.EnsureChildControls();

            m_AttachmentID = postCollection[this.UniqueID + "$AttachmentID"];
            m_AttachFileName = postCollection[this.UniqueID + "$txtFileName"];

            // this.Page.Response.Write("enter LoadPostData");
            // this.Page.Response.Write("   m_AttachFileName = " + m_AttachFileName);

            return true;

            
        }

        void IPostBackDataHandler.RaisePostDataChangedEvent()
        {
            
        }

        #endregion
    }
}
