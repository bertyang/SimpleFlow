using System;
using System.Collections.Generic;
using System.Text;

using SimpleFlow.BusinessFacade;
using SimpleFlow.Entity;

public class AttachmentDownload : BasePage
{
    public virtual SysAttachment GetAttachment()
    {
        throw new Exception("please override GetAttachment method.");
    }

    private string GetFilePath(SysAttachment obj)
    {
        string base_dir = AttachmentBiz.GetDocPath(obj.PathId);
        string file_dir = System.IO.Path.Combine(base_dir, obj.CurrentFileDir);
        string file_path = System.IO.Path.Combine(file_dir, obj.CurrentFileName);

        return file_path;
    }

    protected override void OnLoad(EventArgs e)
    {
        try
        {
            base.OnLoad(e);
            // Response.Buffer = true;
            // Response.BufferOutput = true;

            Response.Clear();
            Response.ClearHeaders();
            Response.Buffer = false;


            SysAttachment obj = this.GetAttachment();
            // 解决文件名乱码问题。
            string Original_File_Name = System.Web.HttpUtility.UrlEncode(obj.OriginalFileName, System.Text.Encoding.UTF8);
            this.Response.ContentType = obj.ContentType;
            this.Response.AddHeader("Content-Disposition", "attachment;filename=" + Original_File_Name);                
            this.Response.AddHeader("Content-Length", obj.FileSize.ToString());
            

            string file_path = this.GetFilePath(obj);
            this.Response.WriteFile(file_path);
            //this.Response.End();
            System.Web.HttpContext.Current.ApplicationInstance.CompleteRequest(); 

        }
        catch (Exception ex)
        {
            SimpleFlow.SystemFramework.Log.WriteLog(ex);
            this.Response.Redirect("~/Communication.aspx");
        }

    }
}

