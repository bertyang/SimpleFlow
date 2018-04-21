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
using System.Text;

using SimpleFlow.SystemFramework;
public partial class Controls_DateControl : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        this.TextBox1.Attributes.Add("readonly", "readonly");
        this.TextBox1.Attributes.Add("onclick",
            string.Format("ShowCalendar('{0}');", this.TextBox1.ClientID));

        this.RegisterCalendarScript();
    }


    private string GetAbsoluteUrl(string url)
    {
        if (url != null)
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
        else
        {
            return url;
        }
    }


    private void RegisterCalendarScript()
    {
        StringBuilder sb = new StringBuilder(1024);
        sb.AppendLine("function ShowCalendar(target_id)");
        sb.AppendLine("{");
        sb.AppendLine("var target = document.getElementById(target_id);");
        sb.AppendFormat("var surl = '{0}?select_date=' + target.value;", this.GetAbsoluteUrl("~/GeneralPage/Calendar.aspx"));
        sb.AppendLine();
        sb.AppendLine("var sfeature = 'status:no;resizable:1;dialogWidth:350px;dialogHeight:330px;dialogLeft:' + window.event.clientX + ';dialogTop:' + window.event.clientY;");
        sb.AppendLine("var sDate = window.showModalDialog(surl, '', sfeature);	");
        sb.AppendLine("target.value = sDate;");
        sb.AppendLine("}");

        this.Page.ClientScript.RegisterClientScriptBlock(this.GetType(),
            "caneldar_client_script", sb.ToString(), true);

    }



    public Nullable<DateTime> Date
    {
        get
        {
            if (!string.IsNullOrEmpty(this.TextBox1.Text))
            {
                return DateTime.ParseExact(this.TextBox1.Text, Config.DateFormat, null);
            }
            else
            {
                return null;
            }
        }

        set
        {
            if (value == null)
            {
                this.TextBox1.Text = string.Empty;
            }
            else
            {
                this.TextBox1.Text = value.Value.ToString(Config.DateFormat);
            }
        }
    }
}
