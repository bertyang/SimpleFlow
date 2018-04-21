<%@ Control Language="C#" AutoEventWireup="true" CodeFile="FileUploadControl.ascx.cs" Inherits="Controls_FileUploadControl" %>
<table>
    <tr>
        <td>
            <asp:TextBox ID="txtFileName" runat="server" ></asp:TextBox></td>
        <td>
            
            <asp:Button ID="btnUpload" runat="server" CssClass="button60"  Text="Browse..." />
            <asp:TextBox ID="txtAttachmentID" runat="server" style="width: 0px;display:none" Visible="False" Width="0px"  />
            <asp:TextBox ID="txtAllowMoreFiles" runat="server" style="width: 0px;display:none" Visible="False" Width="0px" /></td>        
    </tr>
</table>
