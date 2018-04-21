<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Communication.aspx.cs" 
Inherits="Communication" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
    <head>
		<title>GDMS System Error</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR" />
		<meta content="C#" name="CODE_LANGUAGE" />
		<meta content="JavaScript" name="vs_defaultClientScript" />
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema" />
		<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
		<link runat="server" href="Styles/BaseStyle.css" rel="stylesheet" />	
		
    </head>
    <body style="MARGIN: 0px">
		<form id="Form1" method="post" runat="server">
		    <center>
			    <div id="Main">
				    <div style="HEIGHT: 75px"></div>
				    <div style="BACKGROUND-IMAGE: url(images/Error_BG.jpg); WIDTH: 492px; BACKGROUND-REPEAT: no-repeat; HEIGHT: 600px">
					    <div style="HEIGHT: 65px"></div>
					    <div style="PADDING-LEFT: 60px" >
						    <p>
								    <asp:Label Runat="server" ID="LabelMessage"></asp:Label>
							</p>
                            <p>
								    <asp:Label Runat="server" ID="LabelContact"></asp:Label>
							</p>
                            
                            <asp:DataList ID="adminDataList" runat="server">
                            <ItemStyle HorizontalAlign="left" />
                            <ItemTemplate>
                            <p><%# DataBinder.Eval(Container.DataItem, "EnglishName")%> / <%# DataBinder.Eval(Container.DataItem, "Extension")%>,
                                <a href="mailto:<%# DataBinder.Eval(Container.DataItem, "Email")%>"><%# DataBinder.Eval(Container.DataItem, "Email")%></a> 
                             </p>
                            </ItemTemplate>
                            </asp:DataList>
					    </div>
				    </div>
			    </div>
			</center>
		</form>
	</body>
</html>
