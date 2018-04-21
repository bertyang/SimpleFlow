<%@ Page language="c#" Inherits="GDMSNew.Presentation.LogOn" CodeFile="LogOn.aspx.cs" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN" >
<html xmlns="http://www.w3.org/1999/xhtml" >
	<head runat="server">
		<title runat="server">Welcome to GDMS</title>
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1" />
		<meta name="CODE_LANGUAGE" content="C#" />
		<meta name="vs_defaultClientScript" content="JavaScript" />
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5" />
		<link href="Styles/BaseStyle.css" rel="stylesheet" />
		<script language="javascript" type="text/javascript" src="Scripts/StringFunctions.js"></script>		
	</head>
	<body topmargin="0" leftmargin="0">
		<form id="Form1" method="post" runat="server">
		<asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
		
			
            
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">	
                <ContentTemplate>
                <div id="DivMain" style="text-align:center; position:relative">
                
				<table style="MARGIN-TOP: 100px" cellspacing="0" cellpadding="0" width="396" align="center"
				border="0">
				<tr>
					<td><asp:Image ID="ImageLoginBanner" Height="86" ImageUrl="~/images/Login_Banner.jpg" Width="396" runat="server"></asp:Image></td>
				</tr>
				<tr>
					<td><asp:Image ID="ImageLoginSystem" Height="50" ImageUrl="~/images/Login_system.jpg" Width="396" runat="server"></asp:Image></td>
				</tr>
				<tr>
					<td bgcolor="#e8e8e8" height="134">
						<table cellspacing="10" cellpadding="0" width="396" border="0">
							<tr>
								<td width="152" height="27" align="right" style="font-family: Arial;font-size:8pt;color: #3D3D3D;">
								    <strong><asp:Label runat="server" ID="LabelUserName">User Name</asp:Label></strong>
								</td>
								<td width="120" height="27">
								    <asp:TextBox id="TextBoxUserName" runat="server" Width="150px" CssClass="TextboxSingleFlat"></asp:TextBox>
								</td>
								<td width="124" height="27">&nbsp;</td>
							</tr>
							<tr>
								<td width="152" height="27"   align="right"  style="font-family: Arial;font-size:8pt;color: #3D3D3D;">
								    <strong><asp:Label runat="server" ID="LabelPassword">Password</asp:Label></strong>
								</td>
								<td width="120" height="27">
								    <asp:TextBox id="TextBoxPassword" runat="server" TextMode="Password" Width="150px" CssClass="TextboxSingleFlat"></asp:TextBox>
								</td>
								<td width="124" height="27">&nbsp;</td>
							</tr>
							<tr>
								<td width="152" height="35">&nbsp;</td>
								<td width="120" height="35">
								    <asp:Button runat="server" ID="ButtonLogin" Text="Welcome Login" ForeColor="#3D3D3D" CssClass="button150" Font-Bold="true" OnClick="ButtonLogin_Click" />
								</td>
								<td width="124" height="27">&nbsp;</td>
							</tr>
						</table>
					</td>
				</tr>
				<tr>
					<td style="BORDER-TOP: #ffffff 1px solid" bgcolor="#d8d8d8" height="25">&nbsp;</td>
				</tr>
			</table>
			</div>	
                </ContentTemplate>
            </asp:UpdatePanel>	
            
            
            
            
		</form>
		
	</body>
</html>
