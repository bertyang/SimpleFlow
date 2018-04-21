<%@ Page Language="C#" MasterPageFile="~/DefaultMasterPage.master" AutoEventWireup="true" 
CodeFile="UserInfo.aspx.cs" Inherits="UserInfo" Title="User Information" %>

<%@ Register Src="../Controls/DateControl.ascx" TagName="DateControl" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="text-align:center">
        <asp:Label ID="Label10" runat="server" Text="User Base Data Maintain"></asp:Label></div>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
<ContentTemplate>

    <div style="border:solid 1px black" >    
    <table style="width: 100%">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Name "></asp:Label></td>
            <td>
                <asp:TextBox ID="text_name" runat="server" ReadOnly="True" Enabled="False" CssClass="TextboxSingleFlat"></asp:TextBox></td>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Ext.Number "></asp:Label></td>
            <td>
                <asp:TextBox ID="text_ext_no" runat="server" MaxLength="20" CssClass="TextboxSingleFlat"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Department "></asp:Label></td>
            <td>
                <asp:TextBox ID="text_dept" runat="server" ReadOnly="True" Enabled="False" CssClass="TextboxSingleFlat"></asp:TextBox></td>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Mail Address "></asp:Label></td>
            <td>
                <asp:TextBox ID="text_email" runat="server" MaxLength="50" CssClass="TextboxSingleFlat"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="Employed Date"></asp:Label></td>
            <td>
                <uc1:DateControl ID="DateControl1" runat="server" />
            </td>
            <td>
                <asp:Label ID="Label8" runat="server" Text="Site"></asp:Label></td>
            <td>
                <asp:DropDownList ID="ddl_site" runat="server" DataTextField="SiteName" DataValueField="SiteSerial" Width="132px">
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td colspan="4" align="center">
            <asp:Button ID="button_update_basic_info" runat="server" Text="Update" Width="80px" OnClick="button_update_basic_info_Click" CssClass="button80" />
            </td>
        </tr>
    </table>
    </div>
</ContentTemplate>
</asp:UpdatePanel>        
    
    <p> &nbsp; </p>

<asp:UpdatePanel ID="UpdatePanel2" runat="server">
<ContentTemplate>    
    <div style="text-align:center; border: solid 1px black;">
        
    <table style="width: 100%">
        <tr>
            <td>
                <asp:Label ID="Label12" runat="server" Text="Old Password "></asp:Label></td>
            <td>
                <asp:TextBox ID="text_old_password" runat="server" TextMode="Password" MaxLength="30" CssClass="TextboxSingleFlat"></asp:TextBox></td>
            <td>
                <asp:Label ID="label_new_password" runat="server" Text="New Password "></asp:Label></td>
            <td>
                <asp:TextBox ID="text_new_password" runat="server" TextMode="Password" MaxLength="30" CssClass="TextboxSingleFlat"></asp:TextBox></td>
        </tr>
        <tr>
            <td>
                </td>
            <td>
                </td>
            <td>
                <asp:Label ID="label_confirm_password" runat="server" Text="Confirm Password "></asp:Label></td>
            <td>
                <asp:TextBox ID="text_confirm_password" runat="server" TextMode="Password" MaxLength="30" CssClass="TextboxSingleFlat"></asp:TextBox></td>
        </tr>
    </table>
    <div style="text-align:center;margin-bottom:5px;">
    <asp:Button ID="button_modify_password" runat="server" Text="Modify Password" Width="150px" OnClick="button_modify_password_Click" CssClass="button150" />
    </div>
    </div>
</ContentTemplate>
</asp:UpdatePanel>           
</asp:Content>

