using System;
using System.Collections.Generic;
using System.Text;


public static class MessageHelper
{
    public const int Default_Message = 0;
    public const int No_Privilege_To_Access = 10;
    public const int No_Privilege_To_Download = 20;



    public static string GetMessage(int message_id)
    {
        if (message_id == No_Privilege_To_Access)
        {
            return "Sorry, you don't have permission, please contact the system administrator.";
        }
        else if (message_id == No_Privilege_To_Download)
        {
            return "Sorry, you don't have permission, please contact the system administrator.";
        }
        else
        {
            return "Normally you should not be navigated to this page.If you accessed this page coincidence just ignore it or please contact system administrator.";
        }
    }
}

