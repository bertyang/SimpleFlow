<%@ Page Language="C#" MasterPageFile="~/DefaultMasterPage.master" AutoEventWireup="true" CodeFile="CodeList.aspx.cs" Inherits="CodeList" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>
<table width="80%">
    <tr>
        <td width="30%">Main Key: </td>
        <td width="70%"><asp:Label ID="label_main_key" runat="server" />  </td>
    </tr>
    <tr>
        <td>Description: </td>
        <td><asp:Label ID="label_main_description" runat="server" /> </td>
    </tr>
</table>
</div>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" ShowFooter="true" AllowPaging="false" Width="100%">
            <Columns>
                <asp:TemplateField HeaderText="Sub Key">
                    <ItemStyle Width="20%" />
                    <ItemTemplate>                        
                        <asp:Label ID="label_sub_key" runat="server"
                        Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "SubKey")) %>' />
                                                
                        <input id="hidden_sub_key" runat="server" type="HIDDEN"
                         value='<%# DataBinder.Eval(Container.DataItem, "SubKey") %>' />
                    </ItemTemplate>          
                    
                    <EditItemTemplate>
                        <asp:Label ID="label_sub_key" runat="server"
                        Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "SubKey")) %>' />
                        
                        <input id="hidden_sub_key" runat="server" type="HIDDEN"
                         value='<%# DataBinder.Eval(Container.DataItem, "SubKey") %>' />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="textbox_sub_key" runat="server" Width="95%" />                        
                    </FooterTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Content">
                    <ItemStyle Width="20%" />
                    <ItemTemplate>
                        <asp:Label ID="label_content" runat="server"
                        Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "Content")) %>' />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="textbox_content" runat="server"
                         Text='<%# DataBinder.Eval(Container.DataItem, "Content") %>' 
                          TextMode="MultiLine" Width="95%"
                         />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="textbox_content" runat="server" 
                        TextMode="MultiLine" Width="95%"
                        />                        
                    </FooterTemplate>
                </asp:TemplateField>
                
                <asp:TemplateField HeaderText="Description">
                    <ItemStyle Width="40%" />
                    <ItemTemplate>
                        <asp:Label ID="label_description" runat="server"
                        Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "Description")) %>' />
                    </ItemTemplate>
                    <EditItemTemplate>
                        <asp:TextBox ID="textbox_description" runat="server"
                         Text='<%# DataBinder.Eval(Container.DataItem, "Description") %>' 
                          TextMode="MultiLine" Width="95%"
                         />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="textbox_description" runat="server" 
                        TextMode="MultiLine" Width="95%"
                        />                        
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
                    <tr>
                        <th width="20%">Sub Key</th>
                        <th width="20%">Content</th>
                        <th width="40%">Description</th>
                        <th width="10%">Edit</th>
                        <th width="10%">Delete</th>
                    </tr>
                    <tr>
                        <td><asp:TextBox ID="textbox_sub_key" runat="server" Width="95%" /></td>
                        <td><asp:TextBox ID="textbox_content" runat="server" Width="95%" TextMode="multiLine" /></td>
                        <td><asp:TextBox ID="textbox_description" runat="server" Width="95%" TextMode="MultiLine" /></td>
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

