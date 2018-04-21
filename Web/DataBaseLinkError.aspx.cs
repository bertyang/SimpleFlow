using System;
using System.Data;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using SimpleFlow.WebControlLibrary;


public partial class DataBaseLinkError : BasePage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string message = Request.QueryString["message"];
        if (message == null || message.Length == 0)
        {
            message = "DataBase Link Failed.";
        }
        LiteralMessage.Text = message;
    }
    //protected override void LoadResources()
    //{
    //    try
    //    {
    //        this.LabelContact.Text = "Please Contact system administrator " + GetAdministratorInformation();
    //        this.LabelContact.Text = this.LabelContact.Text.Replace("  ", " ");
    //    }
    //    catch
    //    {
    //        this.LabelContact.Text = string.Empty;
    //    }
    //}

    private string GetAdministratorInformation()
    {
        string result = string.Empty;


        //ArrayList administratorInformation = Configuration.CorpCommAdministrator;

        //if (administratorInformation == null || administratorInformation.Count < 3)
        //{
        //    return result;
        //}

        //string englishName = administratorInformation[0].ToString().Trim();
        //string extension = administratorInformation[1].ToString().Trim();
        //string eMail = administratorInformation[2].ToString().Trim();

        //result += englishName + "/" + extension;
        //result = string.Format("<a href='mailto:{0}'>{1}</a>", eMail.Trim(), result);

        return result;
    }
}
