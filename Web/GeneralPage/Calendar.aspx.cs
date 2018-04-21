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


using SimpleFlow.SystemFramework;

public partial class GeneralPage_Calendar : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //this.Calendar1
        if (!this.IsPostBack)
        {
            string selected_date = this.Request["selected_date"];
            if (!string.IsNullOrEmpty(selected_date))
            {
                this.Calendar1.SelectedDate = DateTime.ParseExact(selected_date, Config.DateFormat, null);

                ScriptManager.RegisterClientScriptBlock(this.UpdatePanel1,
                this.GetType(), "close_calendar_window",
                string.Format("window.returnValue='{0}'; ", selected_date),
                true);

            }
            else
            {
                ScriptManager.RegisterClientScriptBlock(this.UpdatePanel1,
                this.GetType(), "close_calendar_window",
                string.Format("window.returnValue='{0}'; ",  DateTime.Now.ToString("yyyy-MM-dd")),
                true);
            }

            
        }
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        ScriptManager.RegisterClientScriptBlock(this.UpdatePanel1,
            this.GetType(), "close_calendar_window",
            string.Format("window.returnValue='{0}'; window.close();", 
            this.Calendar1.SelectedDate.ToString("yyyy-MM-dd")),
            true);
    }


    protected void button_today_Click(object sender, EventArgs e)
    {
        ScriptManager.RegisterClientScriptBlock(this.UpdatePanel1,
            this.GetType(), "close_calendar_window",
            string.Format("window.returnValue='{0}'; window.close();", 
            DateTime.Now.ToString("yyyy-MM-dd")),
            true);
    }
}
