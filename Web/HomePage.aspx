<%@ Page Language="C#" MasterPageFile="~/DefaultMasterPage.master" AutoEventWireup="true" 
CodeFile="HomePage.aspx.cs" Inherits="HomePage" Title=" Welcome to GDMS" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<table border="0" cellpadding="0" cellspacing="0">
<tr>
<td valign="middle">
<asp:Label ID="Label_HomePageTitle" runat="server" 
    CssClass="LabelTitle">Welcome to GDMS</asp:Label>
</td>
</tr>
</table>
</div>
<div >
    <table width="100%">
        <tr>
            <td>
                <asp:Label ID="Label_HomePageWelcome" runat="server" 
                CssClass="bktext12">Welcome to GDMS</asp:Label>
            </td>
        </tr>
        <tr>
            <td style="height:200px; text-align:left" class="bktext_header" >
                <p> &nbsp; </p>
            </td>
        </tr>
    </table>

</div>
</asp:Content>

