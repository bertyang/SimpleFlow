<%@ Control Language="C#" AutoEventWireup="true" CodeFile="GridPagerControl.ascx.cs" Inherits="Controls_GridPagerControl" %>
<table cellpadding="0" cellspacing="0" border="0">
<tr>
<td align="left" nowrap>
   <asp:Label ID="label_page_size" runat="server" Text="page size:" />
   <asp:TextBox ID="textbox_page_size" runat="server" Text="10" Width="30px" />
   &nbsp;
   <asp:Label ID="label_page_count" runat="server" Text="page count:" />
   <asp:TextBox ID="textbox_page_count" runat="server" Text="0" ReadOnly="true" Width="30px"  />
   &nbsp;
   <asp:Label ID="label_page_index" runat="server" Text="page index:" />
   <asp:TextBox ID="textbox_page_index" runat="server" Text="1" Width="30px" />
</td>   
<td align="right" nowrap>      
   <asp:ImageButton ID="button_first" runat="server" OnClick="button_first_Click" />
   <asp:ImageButton ID="button_prev" runat="server" OnClick="button_prev_Click" />
   <asp:ImageButton ID="button_next" runat="server" OnClick="button_next_Click" />   
   <asp:ImageButton ID="button_last" runat="server" OnClick="button_last_Click" />
   &nbsp;
</td>
</tr>
</table>
