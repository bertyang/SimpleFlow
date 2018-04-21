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
using System.IO;
using System.Text;
using System.Threading;
using System.Globalization;


using SimpleFlow.Entity;
using SimpleFlow.SystemFramework;
using SimpleFlow.BusinessFacade;

public class BasePage : System.Web.UI.Page
{
// private CurrentUserInfo m_CurrentUserInfo = null;
private string m_ApplicationPath = string.Empty;

public BasePage()
    : base()
{
    //
    // TODO: Add constructor logic here
    //

}

private SysUserInfo m_CurrentUserInfo = null;

/// <summary>
/// Current user who is visiting this page
/// </summary>
public SysUserInfo CurrentUser
{
    get
    {
        if (m_CurrentUserInfo == null)
        {
            m_CurrentUserInfo = this.GetCurrentUserInfo();
        }
        return m_CurrentUserInfo;
    }
}


public SysUserInfo GetCurrentUserInfo()
{
    SysUserInfo user;

    try
    {
        user = this.Session["user"] as SysUserInfo;
    }
    catch
    {
        user = null;
    }

    if (user != null)
    {
        return user;
    }
    
    string domain_account = HttpContext.Current.User.Identity.Name;
    if (!string.IsNullOrEmpty(domain_account))  // 用户已通过NT认证
    {
        user = UserBiz.GetUserByAccount(domain_account);
        if (user != null) // 登录成功
        {
            //user.LastLogonTime = DateTime.Now;
            // UserBiz._UpdateUser(user);
            UserBiz.DoLogin(user);

            Session["user"] = user;
        }
        else
        {
            throw new Exception("there is no information of " + domain_account + " in database");
        }
    }
    else // 用户未通过NT认证
    {
        throw new Exception("Access Denied");
    }
    return user;
}


public void ResetSession(SysUserInfo user)
{
    this.Session["user"] = user;
}


public bool IsNullOrTrimedEmpty(string s)
{
    if (s == null)
    {
        return true;
    }
    if (s.Length == 0)
    {
        return true;
    }
    if (s.Trim().Length == 0)
    {
        return true;
    }
    return false;
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

    this.ClientScript.RegisterClientScriptBlock(this.GetType(),
        "caneldar_client_script", sb.ToString(), true);
        
}


/// <summary>
/// Page setup
/// </summary>
/// <param name="e"></param>
protected override void OnLoad(EventArgs e)
{
    if (!this.IsPostBack)
    {
        this.ClearPageCache();
        this.LoadResources();
        this.RegistStyleFiles();
        this.RegistServerEventHandles();
        this.RegistClientAttributes();
        this.RegisterCalendarScript();
    }

    m_CurrentUserInfo = this.GetCurrentUserInfo();
    if (this.UserHasPrivilege())
    {                
        base.OnLoad(e);
    }
    else
    {
        // Response.Redirect("~/Communication.aspx?&message_id=" + MessageHelper.No_Privilege_To_Access.ToString());
        List<AdminInfo> adminList = Config.GetAdminList() as List<AdminInfo>;
        System.Text.StringBuilder sb = new System.Text.StringBuilder(200);
        // string error_message = MessageHelper.GetMessage(MessageHelper.No_Privilege_To_Access);
        // sb.Append(MessageHelper.GetMessage(MessageHelper.No_Privilege_To_Access));
        sb.Append("Sorry, you don’t have permission, please contact ");
        for (int i = 0; i < adminList.Count; i++)
        {
            if (i > 0)
            {
                sb.Append(", ");
            }
            AdminInfo info = adminList[i];
            sb.AppendFormat("{0} - {1}", info.EnglishName, info.Extension);
        }

        string escape_message = Microsoft.JScript.GlobalObject.escape(sb.ToString());
        string script = string.Format("<script language='javascript' type='text/javascript'>alert(unescape('{0}'));</script>", escape_message);
        this.Response.ClearContent();
        this.ClientScript.RegisterStartupScript(this.GetType(), this.GetType().ToString(), script); 
        System.Web.HttpContext.Current.ApplicationInstance.CompleteRequest();
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


/// <summary>
/// 判断用户是否具有权限
/// </summary>
/// <returns></returns>
public virtual bool UserHasPrivilege()
{
    // UserBiz biz = new UserBiz();
    return true;
}


/// <summary>
/// Override default on error behavior, log exception and show user friendly information
/// </summary>
/// <param name="e"></param>
protected override void OnError(EventArgs e)
{
    //TODO: LogException
    Exception ex = this.Server.GetLastError();
    string userID ;

    if (m_CurrentUserInfo != null)
    {
        userID = m_CurrentUserInfo.UserId;
    }
    else
    {
        userID = HttpContext.Current.User.Identity.Name;
    }

    SimpleFlow.SystemFramework.Log.WriteLog(userID, ex);
    Server.ClearError();
    Context.ClearError();

    // string source_error_url = "~/Communication.aspx?MessageID=" + HttpUtility.UrlEncode(ex.Message);
    // string source_error_url = "~/Communication.aspx?MessageID=" + HttpUtility.UrlEncode(ex.Message);
    string source_error_url = "~/Communication.aspx";
    string target_error_url = HttpUtility.UrlPathEncode(source_error_url);
    HttpContext.Current.Response.Redirect(target_error_url);
}

#region virtual methods


/// <summary>
/// Whether force expire
/// </summary>
/// <returns></returns>
protected virtual bool ForceExpire()
{
    return false;
}

/// <summary>
/// Override this method to load culture specific resoruce
/// </summary>
/// <returns></returns>
protected virtual void LoadResources()
{
}

/// <summary>
/// Override this method to regist server event handles, DO NOT use IDE auto-generated codes 
/// </summary>
protected virtual void RegistServerEventHandles()
{
}

/// <summary>
/// Override this method to attach attributes/event handles to client objects
/// </summary>
protected virtual void RegistClientAttributes()
{
}

///// <summary>
///// Override this property to link css file to the page
///// </summary>
//protected virtual string[] StyleFiles
//{
//    get
//    {
//        return null;
//    }
//}

#endregion

#region Helper methods


/// <summary>
/// Sets focus to a control after page load
/// </summary>
/// <param name="controlID">control client id</param>
public void DefaultFocus(string controlID)
{
    this.DefaultFocus(controlID, controlID);
}

/// <summary>
/// Sets focus to a control after page load
/// </summary>
/// <param name="controlID">control client id</param>
/// <param name="key">identity key value</param>
public void DefaultFocus(string controlID, string key)
{
    
    //TODO:set focus to default html element
    const string FOCUS_HELP = @"<script language = ""javascript"" type = ""text/javascript"" src = ""{0}Scripts/FocusHelper.js""></script>";
    const string CLIENT_SCRIPT = @"
    				<script type = ""text/javascript"">
    				<!--
    				WebForm_AutoFocus('{0}');
    				//-->
    				</script>
    			";
    this.ClientScript.RegisterClientScriptBlock(this.GetType(), "FOCUS_HELP", string.Format(FOCUS_HELP, this.Request.ApplicationPath));
    this.ClientScript.RegisterStartupScript(this.GetType(), key, string.Format(CLIENT_SCRIPT, controlID));
}

/// <summary>
/// Sets focus to a html control after page load
/// </summary>
/// <param name="control">control client id</param>
public void DefaultFocus(System.Web.UI.HtmlControls.HtmlControl control)
{
    this.DefaultFocus(control.ClientID, control.ClientID);
}

/// <summary>
/// Sets focus to a html control after page load
/// </summary>
/// <param name="control">control client id</param>
/// <param name="key">identity key value</param>
public void DefaultFocus(System.Web.UI.HtmlControls.HtmlControl control, string key)
{
    this.DefaultFocus(control.ClientID, key);
}

/// <summary>
/// Sets focus to a web control after page load
/// </summary>
/// <param name="control">control client id</param>
public void DefaultFocus(System.Web.UI.WebControls.WebControl control)
{
    this.DefaultFocus(control.ClientID, control.ClientID);
}

/// <summary>
/// Sets focus to a web control after page load
/// </summary>
/// <param name="control">control client id</param>
/// <param name="key">identity key value</param>
public void DefaultFocus(System.Web.UI.WebControls.WebControl control, string key)
{
    this.DefaultFocus(control.ClientID, key);
}

/// <summary>
/// Shows message to user right after page is load
/// </summary>
/// <param name="message"></param>
public void ShowMessageEx(string message)
{
    // TODO: regist startup client script
    const string CLIENT_SCRIPT = @"
    				<script language = ""javascript"" type = ""text/javascript"" >
    				<!--
    				alert(""{0}"");
    				//-->
    				</script>
    			";
    if (this.ClientScript.IsStartupScriptRegistered("ShowMessage") == false)
    {
        this.ClientScript.RegisterStartupScript(this.GetType(), "ShowMessage", string.Format(CLIENT_SCRIPT, message));
    }
}

#endregion



private void RegistStyleFiles()
{
    //			string[] styleFiles = this.StyleFiles;
    //			if (styleFiles == null || styleFiles.Length == 0)
    //			{
    //				return;
    //			}
    //			string culture = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
    //			string path = string.Format("Styles/{0}", culture);
    //			path = Server.MapPath(path);
    //			path = (Directory.Exists(path) ? string.Format("Styles/{0}", culture) : "Styles");
    //			string files = string.Empty;
    //			foreach(string styleFile in styleFiles)
    //			{
    //				files += string.Format("<link rel = \"stylesheet\" href = \"{0}/{1}\">\r\n", path, styleFile);
    //			}
    //			this.RegisterClientScriptBlock("StyleFile", files);

    //this.Request.appli
    //this.RegisterClientScriptBlock("BaseStyle",
    //    string.Format("<link rel = \"stylesheet\" href = \"Styles/{1}/BaseStyle.css\">\r\n", 
    //    m_ApplicationPath, 
    //    Thread.CurrentThread.CurrentCulture.Name));
}


public void AjaxStartupScript(Control regControl, string scriptContent)
{
    ScriptManager.RegisterClientScriptBlock(regControl,
                                           regControl.GetType().BaseType,
                                           Guid.NewGuid().ToString(),
                                           scriptContent,
                                           true);
}

/// <summary>
/// 彈出提示框
/// </summary>
/// <param name="regCtrl">注册脚本块的控件通常用触发事件的按纽</param>
/// <param name="msg">提示信息内容</param>
/// <returns></returns>
public void AjaxAlert(Control regCtrl, string msg)
{
    msg = msg == null ? "" : msg.Replace(@"\", @"\\").Replace("'", @"\'");
    AjaxStartupScript(regCtrl, "alert('" + msg + "');");
}

/// </summary>
/// <param name="input">input</param>
/// <returns>string</returns>
protected string ReplaceSepcialString(string input)
{
    return input == null ? "" : input.Replace(@"\", @"\\").Replace("'", @"\'").Replace("%", "[%]").Replace("_", "[_]").Replace("'", "''").Trim();
}


public string GetAbsoluteUrl(string url)
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


/// <summary>
/// 获取显示导航条的数据
/// </summary>
/// <returns></returns>
public virtual SiteMapNodeList GetSiteMapNodeList()
{
    SiteMapNodeList list = new SiteMapNodeList();
    list.Add("Home", "~/Default.aspx");
    return list;
}


/// <summary>
/// 获取本页所属的功能ID，以便：
/// （1）判断权限
/// （2）选中相应的菜单项
/// </summary>
/// <returns></returns>
public virtual string GetOwnerMenuID()
{
    return "C4752739-2470-443C-BCF7-73E75261DDC9";//"approve form"
}


public string HTMLEncode(object obj)
{
    if (obj == null)
    {
        return string.Empty;
    }
    return this.Server.HtmlEncode(obj.ToString());
}


public string FormatDate(DateTime dt)
{
    return dt.ToString(Config.DateFormat);
}


public string FormatDateTime(DateTime dt)
{
    return dt.ToString(Config.DateTimeFormat);
}


}

