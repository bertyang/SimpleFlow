<%@ Page Language="C#" MasterPageFile="~/DefaultMasterPage.master" AutoEventWireup="true" CodeFile="CodeMaster.aspx.cs" Inherits="Management_CodeMaster" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowFooter="true" AllowPaging="false" Width="100%" HeaderStyle-CssClass="gridTitle">
            <Columns>
                <asp:TemplateField HeaderText="Main Key">
                    <ItemStyle Width="20%" />
                    <ItemTemplate>
                        <asp:HyperLink ID="hyperlink_main_key" runat="server"
                         NavigateUrl='<%# "~/Management/CodeList.aspx?main_key=" + Server.UrlEncode((string)DataBinder.Eval(Container.DataItem, "MainKey")) %>'
                          Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "MainKey")) %>' />
                        
                        <!--  
                        <asp:Label ID="label_main_key" runat="server"
                        Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "MainKey")) %>' />
                        -->
                        
                        <input id="hidden_main_key" runat="server" type="HIDDEN"
                         value='<%# DataBinder.Eval(Container.DataItem, "MainKey") %>' />
                    </ItemTemplate>          
                    
                    <EditItemTemplate>
                        <asp:Label ID="label_main_key" runat="server"
                        Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "MainKey")) %>' />
                        
                        <input id="hidden_main_key" runat="server" type="HIDDEN"
                         value='<%# DataBinder.Eval(Container.DataItem, "MainKey") %>' />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="textbox_main_key" runat="server" Width="95%"  CssClass="TextboxSingleFlat" />                        
                    </FooterTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Description">
                    <ItemStyle Width="50%" />
                    <ItemTemplate>
                        <asp:Label ID="label_description" runat="server"
                        Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "Description")) %>' />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="textbox_description" runat="server"
                         Text='<%# DataBinder.Eval(Container.DataItem, "Description") %>' 
                          TextMode="MultiLine" Width="95%"  CssClass="TextboxMultiFlat"
                         />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="textbox_description" runat="server" 
                        TextMode="MultiLine" Width="95%" CssClass="TextboxMultiFlat"
                        />                        
                    </FooterTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Detail">
            <HeaderStyle  Width="10%" />
            <ItemTemplate>
                <asp:HyperLink ID="hyperlink_main_key" runat="server"
                NavigateUrl='<%# "~/Management/CodeList.aspx?main_key=" + Server.UrlEncode((string)DataBinder.Eval(Container.DataItem, "MainKey")) %>'
                ImageUrl='~/Images/modify.gif' />
            </ItemTemplate>
                <EditItemTemplate>                
            </EditItemTemplate>
            <FooterTemplate>                
            </FooterTemplate>                     
        </asp:TemplateField>
        
                
                <asp:TemplateField HeaderText="Edit">
            <HeaderStyle Width="10%" />
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
            <HeaderStyle  Width="10%" />
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
                        <th width="20%">Main Key</th>
                        <th width="50%">Description</th>
                        <th width="10%">Detail</th>
                        <th width="10%">Edit</th>
                        <th width="10%">Delete</th>
                    </tr>
                    <tr>
                        <td><asp:TextBox ID="textbox_main_key" runat="server" Width="95%"  CssClass="TextboxSingleFlat" /></td>
                        <td><asp:TextBox ID="textbox_description" runat="server" Width="95%" TextMode="MultiLine" CssClass="TextboxMultiFlat" /></td>
                        <td>&nbsp;</td>
                        <td><asp:ImageButton ID="ImageButtonSave" runat="server" CssClass="ButtonSave" 
                CommandName="addfirst" OnClick="Button_Click" ImageUrl="~/Images/save.gif" /></td>
                        <td>&nbsp;</td>
                    </tr>
                </table>
            </EmptyDataTemplate>
            </asp:GridView>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>

