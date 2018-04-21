using System;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using SimpleFlow.WebControlLibrary;

using SimpleFlow.SystemFramework;


    public partial class Communication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int int_msg_id = MessageHelper.Default_Message;

            string message_id = Request.QueryString["message_id"];
            if (!string.IsNullOrEmpty(message_id))
            {
                try
                {
                    int_msg_id = int.Parse(message_id);
                }
                catch
                {
                }
            }


            this.LabelMessage.Text = MessageHelper.GetMessage(int_msg_id);

            List<AdminInfo> adminList = Config.GetAdminList() as List<AdminInfo>;
            this.adminDataList.DataSource = adminList;
            this.adminDataList.DataBind();
        }


        protected override void OnError(EventArgs e)
        {
            try
            {
                // Exception ex = Server.GetLastError();
                // Log.WriteException("", ex);
            }
            catch
            {
            }
        }
    }

