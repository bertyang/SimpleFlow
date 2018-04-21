<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Navigation.ascx.cs" Inherits="Controls_Navigation" %>
<div>
    <table border="0" width="100%">
        <tr>
             <td style="padding-top:5px;">
                <b><asp:Literal ID="LiteralMenu" runat="server"></asp:Literal></b>
            </td>
        </tr>
        <tr>
            <td style="padding-top:5px;">
                <asp:Literal ID="LiteralDescription" runat="server"></asp:Literal>
            </td>
        </tr>
        <tr>
            <td style="padding-top:30px;">
                <b><asp:Literal ID="LiteralSubMenu" runat="server"></asp:Literal></b>
            </td>
        </tr>
    </table>
</div>

