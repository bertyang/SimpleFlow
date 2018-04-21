<%@ Page Language="C#" MasterPageFile="~/DefaultMasterPage.master" AutoEventWireup="true" CodeFile="CreateMenu.aspx.cs" Inherits="Management_CreateMenu" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<asp:Label ID="Label1" runat="server" Text="create menu"></asp:Label>
</div>
<div>
    
    <table>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="menu id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_menu_id" runat="server" Text="" Width="300px" CssClass="TextboxSingleFlat"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="menu name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_menu_name" runat="server" Text="" Width="300px" CssClass="TextboxSingleFlat"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="description"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_description" runat="server" Text="" Width="300px" CssClass="TextboxSingleFlat"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="type id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_type_id" runat="server" Text="" Width="300px" CssClass="TextboxSingleFlat"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label6" runat="server" Text="url"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_url" runat="server" Text="" Width="300px" CssClass="TextboxSingleFlat"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label7" runat="server" Text="is valid"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_is_valid" runat="server" Text="" Width="300px" CssClass="TextboxSingleFlat"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label8" runat="server" Text="display order"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_display_order" runat="server" Text="" Width="300px" CssClass="TextboxSingleFlat"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label9" runat="server" Text="parent id"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txt_parent_id" runat="server" Text="" Width="300px" CssClass="TextboxSingleFlat"></asp:TextBox>
            </td>
        </tr>
    </table>
    <asp:Button ID="button_ok" runat="server" OnClick="button_ok_Click" Text="ok" Width="80px" CssClass="button80" />
    <asp:Button ID="button_cancel" runat="server" Text="cancel" Width="80px" CssClass="button80" /><br />

</div>
</asp:Content>

