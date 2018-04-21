<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BatchUploadViewer.ascx.cs" Inherits="Controls_BatchUploadViewer" %>
<asp:UpdatePanel runat="server" ID="UpdatePanel1">
<ContentTemplate>

<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        Width="98%">
            <Columns>
                <asp:TemplateField HeaderText="File Name">
                    <ItemStyle Width="50%" />
                    <ItemTemplate>
                    <asp:HiddenField ID="hidden_attachment_id" runat="server"
                     Value='<%# DataBinder.Eval(Container.DataItem, "AttachmentId") %>' />
                    
                    <asp:HyperLink ID="hyperlink_file_name" runat="server"
                     Text='<%# Server.HtmlEncode((string)DataBinder.Eval(Container.DataItem, "OriginalFileName")) %>'
                     NavigateUrl='<%# "~/GeneralPage/FileDownload.aspx?attachment_id=" + DataBinder.Eval(Container.DataItem, "AttachmentId").ToString() %>'
                      Target="_blank"
                     ></asp:HyperLink>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="File Size(KB)" Visible="false">
                    <ItemStyle Width="15%" HorizontalAlign="right" />
                    <ItemTemplate>
                    <asp:Label ID="label_file_size" runat="server" 
                        Text='<%# (((int)DataBinder.Eval(Container.DataItem, "FileSize")) / 1024).ToString("N0") %>' /> 
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Upload Time" Visible="false">
                    <ItemStyle Width="20%"  />                    
                    <ItemTemplate>
                    <asp:Label ID="label_upload_time" runat="server" 
                    Text='<%#  FormatDateTime((DateTime)DataBinder.Eval(Container.DataItem, "UploadTime")) %>' /> 
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                    <asp:ImageButton ID="ImageButtonDelete" runat="server" CssClass="ButtonDelete" 
                    OnClick="delete_button_click"  ImageUrl="~/Images/delete.gif" />
                    </ItemTemplate>
                </asp:TemplateField>
                
            </Columns>
        </asp:GridView>


    <asp:HiddenField ID="hidden_field_batch_id" runat="server"  />
    <input type="button" id="btnUploadFile" runat="server" 
    onclick="btnUploadFile_Click('hidden_field_batch_id.ClientID');" 
        value="upload" onserverclick="btnUploadFile_ServerClick" />



</ContentTemplate>
</asp:UpdatePanel>