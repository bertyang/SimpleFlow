<%@ Register TagPrefix="ControlLibrary" Namespace="SimpleFlow.WebControlLibrary" Assembly="SimpleFlow.WebControlLibrary" %>
<%@ Control Language="C#" AutoEventWireup="false" CodeFile="Menu.ascx.cs" Inherits="Controls_Menu" %>
<div style="float:left;width:190px;" id="menuPanel">
	<table>
	<tr>
	<td valign="top" style="width:180px">
	<div style="display:block; width:100%" id="treeViewPanel">
		<ControlLibrary:TreeView CssClass="MenuPanel" runat="server" id="TreeViewMenu" EnableViewState="false"></ControlLibrary:TreeView>
	</div>
	</td><td valign="top">
	<div class="MenuIconHideCss">
		<asp:Image runat="server" ImageUrl="~/Images/Icon_hide.gif"  id="ImgIcon" AlternateText="hide menu" />
	</div>
	</td>
	</tr>
	</table>
	<input id="InputHiddenRootSite" runat="server" type="hidden" />
</div>