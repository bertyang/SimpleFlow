<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BatchUpload.aspx.cs" Inherits="GeneralPage_BatchUpload" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <meta http-equiv="Expires"  content="0" /> 
    <meta http-equiv="Cache-Control" content="no-cache" /> 
    <meta http-equiv="Pragma" content="no-cache" /> 
    <link type="text/css" rel="stylesheet" href="../Styles/BaseStyle.css" />
    <base target="_self" />
    <title>Upload Flies</title>
    <script language="javascript" type="text/javascript" >
    function button_close_click()
    {
        window.close();
    }
    
    function window_close()
    {
        var obj = document.getElementById('<% = hidden_batch_id.ClientID %>');
        if (obj != null)
        {
            window.returnValue = obj.value;
        }
        else
        {
            window.returnValue = null;
        }
    }
    </script>
</head>
<body onunload="window_close()">
    <form id="form1" runat="server">    
    <div>
        <asp:FileUpload runat="server" ID="file_upload_1" Width="400px" />
        <br />
        <asp:FileUpload runat="server" ID="file_upload_2" Width="400px" />
        <br />
        <asp:FileUpload runat="server" ID="file_upload_3" Width="400px" />
        <br />
        <asp:Button ID="button_upload" runat="server" Text="Upload" OnClick="button_upload_Click" CssClass="button60" />
        <asp:Button ID="button_upload_close" runat="server" Text="Upload & Close" OnClick="button_upload_close_Click"  CssClass="button100"  />
        <input type="button" id="button_close" runat="server" value="Close"  onclick="button_close_click();" class="button60"  />
        <input type="button" runat="server" ID="button_delete_all" class="button60"
           value="Delete All" onserverclick="button_delete_all_ServerClick" 
           onclick="if (!window.confirm('Are you sure delete all files?')) { return; } "
           />
    </div>
    <br/>
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>
    
    <asp:HiddenField ID="hidden_batch_id" runat="server"
                         Value='<%# ViewState["batch_id"] %>' />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        Width="98%" HeaderStyle-CssClass="gridTitle">
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
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                    <asp:ImageButton ID="ImageButtonDelete" runat="server" 
                        OnClick="delete_button_click"  ImageUrl="~/Images/delete.gif" />
                    </ItemTemplate>
                </asp:TemplateField>
                
            </Columns>
            <EmptyDataTemplate>  
               <table style="width: 100%; border-collapse:collapse;" border="1" cellpadding="0" cellspacing ="0" >
                    <tr class="gridTitle">
                        <td width="50%">File Name</td>
                        <td width="15%">File Size(KB)</td>
                        <td width="20%">Upload Time</td>  
                        <td>Delete</td>
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
