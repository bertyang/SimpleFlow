<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BatchDownload.aspx.cs" Inherits="GeneralPage_BatchDownload" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Download</title>
    <link type="text/css" rel="stylesheet" href="../Styles/BaseStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
    <br/>
      <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" HeaderStyle-CssClass="gridTitle"
        Width="98%">
            <Columns>                
                <asp:TemplateField HeaderText="File Name">
                    <ItemStyle Width="50%" />
                    <ItemTemplate>
                    
                    <asp:HiddenField ID="hidden_attachment_id" runat="server"
                         Value='<%# DataBinder.Eval(Container.DataItem, "AttachmentId") %>' />
                                                  
                    <asp:HyperLink ID="hyperlink_file_name" runat="server"
                     Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "OriginalFileName")) %>'
                     NavigateUrl='<%# "~/GeneralPage/FileDownload.aspx?attachment_id=" + DataBinder.Eval(Container.DataItem, "AttachmentId").ToString() %>'
                      Target="_blank"
                     ></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="File Size(KB)">
                    <ItemStyle Width="15%" HorizontalAlign="right" />
                    <ItemTemplate>
                    <asp:Label ID="label_file_size" runat="server" 
                        Text='<%# (((int)DataBinder.Eval(Container.DataItem, "FileSize")) / 1024).ToString("N0") %>' /> 
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Upload Time">
                    <ItemStyle Width="20%"  />                    
                    <ItemTemplate>
                    <asp:Label ID="label_upload_time" runat="server" 
                    Text='<%#  FormatDateTime((DateTime)DataBinder.Eval(Container.DataItem, "UploadTime")) %>' /> 
                    </ItemTemplate>
                </asp:TemplateField>
               
            </Columns>
            <EmptyDataTemplate>
                <table style="width: 100%; border-collapse:collapse;" border="1" cellpadding="0" cellspacing ="0" >
                    <tr class="gridTitle">
                        <td width="60%">File Name</td>
                        <td width="20%">File Size(KB)</td>
                        <td width="20%">Upload Time</td>                 
                    </tr>
                    <tr>
                        <td colspan="3"> No Data Found.</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
        </asp:GridView>
    
    
</ContentTemplate>    
</asp:UpdatePanel>    
    </form>
</body>
</html>
