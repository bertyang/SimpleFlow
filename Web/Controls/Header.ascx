<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Header.ascx.cs" Inherits="Controls_Header" %>


<table border="0" cellpadding="0" cellspacing="0" width="100%"  style="height:28px" class="HomePageHeader">
<tr>
    <td style="width:30%; text-align:left; padding-left:20px;" class="WelcomeNameCss">
        <asp:Label runat="server" ID="LabelWelcome">Welcome, Boy Liu</asp:Label>
    </td>
    <td style="width:70%; text-align:right; padding-right:20px;"> 
        <asp:LinkButton ID="LinkButtonTradition" Runat="server" Visible="False" CssClass="LanguageChange"></asp:LinkButton>
		<asp:Image id="Img1" runat="server" ImageUrl="~/Images/EPS_Bottom_BG.gif" visible="False" AlternateText="split"  />
		<asp:LinkButton ID="LinkButtonEnglish" Runat="server" Visible="False" CssClass="LanguageChange"></asp:LinkButton>
		<asp:Image id="Img2" runat="server" ImageUrl="~/Images/EPS_Bottom_BG.gif" visible="False" AlternateText="split" />
		<asp:LinkButton ID="LinkButtonLogout" Runat="server" OnClick="LinkButtonLogout_Click" CssClass="LogoutButton"	>Logout</asp:LinkButton>		
    </td>
</tr>
</table>
