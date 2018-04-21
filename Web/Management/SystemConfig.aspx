<%@ Page Language="C#" MasterPageFile="~/DefaultMasterPage.master" AutoEventWireup="true" CodeFile="SystemConfig.aspx.cs" Inherits="SystemConfig" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
    ShowFooter="True" Width="100%" HeaderStyle-CssClass="gridTitle"
    >
    <Columns>
        <asp:TemplateField HeaderText="Config ID">
            <HeaderStyle Width="30%" />
            <ItemTemplate>            
                <asp:Label ID="label_config_id" runat="server" 
                Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "ConfigId")) %>'>                
                </asp:Label>
                
                <input runat="server" id="hidden_config_id" type="hidden"
                value='<%# DataBinder.Eval(Container.DataItem, "ConfigId") %>' />
            </ItemTemplate>
            <EditItemTemplate>            
                <asp:Label ID="label_config_id" runat="server"
                Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "ConfigId")) %>' >                                
                </asp:Label>
                
                <input runat="server" id="hidden_config_id" type="hidden"
                value='<%# DataBinder.Eval(Container.DataItem, "ConfigId") %>' />
            </EditItemTemplate>
            <FooterTemplate>
                <asp:TextBox ID="textbox_config_id" runat="server"  Width="95%" CssClass="TextboxSingleFlat">
                </asp:TextBox>            
            </FooterTemplate>            
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Config Value">
            <HeaderStyle Width="50%" />
            <ItemTemplate>
                <asp:Label ID="label_config_value" runat="server">
                    <%# HTMLEncode(DataBinder.Eval(Container.DataItem, "ConfigValue")) %>
                </asp:Label>
            </ItemTemplate>
            <EditItemTemplate>            
                <asp:TextBox ID="textbox_config_value" runat="server" 
                Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "ConfigValue")) %>'
                 Width="95%" CssClass="TextboxSingleFlat"></asp:TextBox>                
            </EditItemTemplate>
            <FooterTemplate>
                <asp:TextBox ID="textbox_config_value" runat="server"  CssClass="TextboxSingleFlat"  Width="95%">
                </asp:TextBox>            
            </FooterTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Edit">
            <HeaderStyle Width="15%" />
            <ItemTemplate>
                <asp:ImageButton ID="image_button_edit" runat="server"
                CommandName="Edit" OnClick="Button_Click" ImageUrl="~/Images/modify.gif" />
            </ItemTemplate>
            <EditItemTemplate>
                <asp:ImageButton ID="image_button_update" runat="server"
                CommandName="Update" OnClick="Button_Click" ImageUrl="~/Images/save.gif" />
                
                &nbsp;
                <asp:ImageButton ID="ImageButtonCancel" runat="server" CssClass="ButtonCancel" 
                CommandName="Cancel" OnClick="Button_Click" ImageUrl="~/Images/undo.gif" />
                            
            </EditItemTemplate>
            <FooterTemplate>
                <asp:ImageButton ID="ImageButtonSave" runat="server" CssClass="ButtonSave" 
                CommandName="AddNew" OnClick="Button_Click" ImageUrl="~/Images/save.gif" />
            </FooterTemplate>
        </asp:TemplateField>
        
        <asp:TemplateField HeaderText="Delete">
            <HeaderStyle  Width="15%" />
            <ItemTemplate>
                <asp:ImageButton ID="ImageButtonDelete" runat="server" CssClass="ButtonDelete" 
                CommandName="Delete" OnClick="Button_Click"  ImageUrl="~/Images/delete.gif" />
            </ItemTemplate>
                <EditItemTemplate>                
            </EditItemTemplate>
            <FooterTemplate>                
            </FooterTemplate>                     
        </asp:TemplateField>
        
    </Columns>
    <EmptyDataTemplate>
        <table width="100%" border="1" cellpadding="0" cellspacing="0" style="border-collapse:collapse">
            <tr class="gridTitle">
                <th width="30%">ConfigID</th>
                <th width="50%">Config Value</th>
                <th width="10%">Edit</th>
                <th width="10%">Delete</th>
            </tr>
            <tr>
                <td>
                    <asp:TextBox ID="textbox_config_id" runat="server" Width="95%"  CssClass="TextboxSingleFlat" />
                </td>
                <td>
                    <asp:TextBox ID="textbox_config_value" runat="server"  Width="95%"  CssClass="TextboxSingleFlat" />
                </td>
                <td>
                    <asp:ImageButton ID="ImageButtonSave" runat="server" CssClass="ButtonSave" 
                CommandName="AddFirst" OnClick="Button_Click" ImageUrl="~/Images/save.gif" />
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    </EmptyDataTemplate>
    </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

