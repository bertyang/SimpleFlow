using System;
using System.Collections.Generic;
using System.Text;
using System.Web.UI;


public static class ScriptHelper
{
    public static void AjaxAlert(System.Web.UI.Control reg_control, string message)
    {
        if (message == null)
        {
            message = string.Empty;
        }
        message = message.Replace("'", "''");

        ScriptManager.RegisterStartupScript(reg_control,
                                               reg_control.GetType(),
                                               Guid.NewGuid().ToString(),
                                               string.Format("alert('{0}');", message),
                                               true);

        ////ScriptManager.RegisterClientScriptBlock(reg_control,
        ////                                       reg_control.GetType(),
        ////                                       Guid.NewGuid().ToString(),
        ////                                       string.Format("alert('{0}');", message),
        ////                                       true);

    }




    public static void AjaxAlertFocus(Control reg_control, string message, Control focus_control)
    {
        if (message == null)
        {
            message = string.Empty;
        }
        message = message.Replace("'", "''");
        StringBuilder sb = new StringBuilder(200);
        sb.AppendFormat("alert('{0}');", message);
        sb.AppendFormat("var __item__ = document.getElementById('{0}');", focus_control.ClientID);
        sb.Append("if (__item__ != null)");
        sb.Append(" {  __item__.focus(); }");

        ScriptManager.RegisterClientScriptBlock(reg_control,
                                               reg_control.GetType(),
                                               Guid.NewGuid().ToString(),
                                               sb.ToString(),
                                               true);
    }


    public static void AjaxAlertFocus(Control reg_control, string message)
    {
        AjaxAlertFocus(reg_control, message, reg_control);
    }


    public static void AjaxAlertSelect(Control reg_control, string message, Control focus_control)
    {
        if (message == null)
        {
            message = string.Empty;
        }
        message = message.Replace("'", "''");
        StringBuilder sb = new StringBuilder(200);
        sb.AppendFormat("alert('{0}');", message);
        sb.AppendFormat("var __item__ = document.getElementById('{0}');", focus_control.ClientID);
        sb.Append("if (__item__ != null)");
        sb.Append(" {  __item__.select(); }");

        ScriptManager.RegisterClientScriptBlock(reg_control,
                                               reg_control.GetType(),
                                               Guid.NewGuid().ToString(),
                                               sb.ToString(),
                                               true);
    }


    public static void AjaxAlertSelect(Control reg_control, string message)
    {
        AjaxAlertFocus(reg_control, message, reg_control);
    }


}
