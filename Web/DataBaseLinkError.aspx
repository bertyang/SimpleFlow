<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DataBaseLinkError.aspx.cs" Inherits="DataBaseLinkError" %>

<%@ Register Src="Controls/Menu.ascx" TagName="Menu" TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Welcome to CorpComm</title>
		<meta name="GENERATOR" Content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" Content="C#">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<script language="javascript" src="Scripts/WindowHelper.js"></script>
</head>
<body onload="ResizeWindow();">
		<form id="Form1" method="post" runat="server">
			<div id="BannerSpacer" class="LogoSpacerCss" style="DISPLAY:block">
				<div id="BannerLeft" class="LogoLeftCss">
				</div>
				<div id="BannerRight" class="LogoRightCss">
				</div>
			</div>
			<div id="Main" align="center" onresize="ResizeWindow();">
				<div style="HEIGHT: 75px"></div>
				<div style="BACKGROUND-IMAGE: url(images/Error_BG.jpg); WIDTH: 492px; BACKGROUND-REPEAT: no-repeat">
					<div style="HEIGHT: 65px"></div>
					<div style="PADDING-LEFT: 20px;PADDING-TOP: 40px" align="left">
						<ul>
							<li>
								<asp:Literal ID="LiteralMessage" Runat="server"></asp:Literal></li>
						</ul>
						<ul>
							<li>
								<asp:Label Runat="server" ID="LabelContact"></asp:Label>
							</li>
						</ul>
					</div>
				</div>
                <br />
			</div>
            
		</form>
	</body>
</html>
