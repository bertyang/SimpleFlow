<%@ Page Language="C#" MasterPageFile="~/DefaultMasterPage.Master" AutoEventWireup="true" 
CodeFile="MenuMaintain.aspx.cs" Inherits="GDMSNew.Presentation.MenuMaintain" 
 Title="Menu Management"
%>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<asp:UpdatePanel ID="UpdatePanelMenu" runat="server">
<ContentTemplate>

<div>
    <asp:Label ID="LabelMenuDescription" runat="server">Menu Setting</asp:Label>
</div>
<div>                
    <asp:GridView ID="DataGridMenu" runat="server" AutoGenerateColumns="false" Width="100%" 
        ShowFooter="true" AllowPaging="false"  HeaderStyle-CssClass="gridTitle"> 
        <Columns>
            <asp:TemplateField HeaderText="Menu ID">
                <HeaderStyle Width="20%" />
                <ItemTemplate>
                    <asp:Label runat="server" ID="label_menu_id" 
                     Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "MenuId")) %>'></asp:Label>
                     
                     <input id="hidden_menu_id" runat="server" type="hidden"
                        value='<%# DataBinder.Eval(Container.DataItem, "MenuId") %>' />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:Label runat="server" ID="label_menu_id" 
                     Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "MenuId")) %>'></asp:Label>
                     
                     <input id="hidden_menu_id" runat="server" type="hidden"
                        value='<%# DataBinder.Eval(Container.DataItem, "MenuId") %>' />
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox runat="server" ID="textbox_menu_id" CssClass="TextboxSingleFlat" />
                    <asp:Button runat="server" ID="button_create_menu_id" Text="Create New ID"
                        CommandName="create_menu_id" OnClick="Button_Click" CssClass="button100"  />
                </FooterTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Menu Name">
                <HeaderStyle Width="20%" />
                <ItemTemplate>
                    <asp:Label ID="label_menu_name" runat="server"
                     Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "MenuName")) %>' />                    
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="textbox_menu_name" runat="server" MaxLength="100" 
                        Text='<%# DataBinder.Eval(Container.DataItem, "MenuName") %>' 
                        CssClass="TextboxSingleFlat" Width="95%"></asp:TextBox>
                    <!-- <font color="red">*</font> -->
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="textbox_menu_name" runat="server" MaxLength="100" 
                        CssClass="TextboxSingleFlat" Width="95%"></asp:TextBox>
                    <!-- <font color="red">*</font> -->
                </FooterTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="URL">
                <HeaderStyle Width="30%" />
                <ItemTemplate>
                    <asp:Label ID="label_url" runat="server"
                     Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "Url")) %>' />                    
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="textbox_url" runat="server" MaxLength="100"  TextMode="multiLine"
                        Text='<%# DataBinder.Eval(Container.DataItem, "Url") %>' 
                        CssClass="TextboxMultiFlat" Width="95%"></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="textbox_url" runat="server" MaxLength="100"  TextMode="multiLine"
                        CssClass="TextboxMultiFlat" Width="95%"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Description" Visible="false">
                <HeaderStyle Width="20%" />
                <ItemTemplate>
                    <asp:Label ID="label_description" runat="server" 
                        Text='<%# HTMLEncode( DataBinder.Eval(Container.DataItem, "Description")) %>' />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="textbox_description" runat="server" MaxLength="500" 
                    Text='<%# DataBinder.Eval(Container.DataItem, "Description") %>'
                    TextMode="MultiLine" CssClass="TextboxMultiFlat" Width="95%"></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="textbox_description" runat="server" MaxLength="500" 
                    TextMode="MultiLine" CssClass="TextboxMultiFlat" Width="95%"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Type">
                <HeaderStyle Width="5%" />
                <ItemTemplate>
                    <asp:Label ID="label_type_id" runat="server" 
                        Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "TypeId")) %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="textbox_type_id" runat="server" Width="50%"
                        Text='<%# DataBinder.Eval(Container.DataItem, "TypeId") %>' CssClass="TextboxSingleFlat"></asp:TextBox>
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="textbox_type_id" runat="server"  Width="50%"
                        Text='0' CssClass="TextboxSingleFlat"></asp:TextBox>
                </FooterTemplate>
            </asp:TemplateField>
                                              
            
            <asp:TemplateField HeaderText="Order">
                <HeaderStyle Width="5%" />
                <ItemTemplate>
                    <asp:Label ID="label_display_order" runat="server" 
                        Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "DisplayOrder")) %>'></asp:Label>
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="textbox_display_order" runat="server" Width="50%"
                        Text='<%# DataBinder.Eval(Container.DataItem, "DisplayOrder") %>' CssClass="TextboxSingleFlat" ></asp:TextBox>
                    <!-- <font color="red">*</font> -->
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="textbox_display_order" runat="server" Width="50%" 
                        Text='0' CssClass="TextboxSingleFlat" ></asp:TextBox>
                    <!-- <font color="red">*</font> -->
                </FooterTemplate>
            </asp:TemplateField>
            
            
            <asp:TemplateField HeaderText="Valid">
                <HeaderStyle Width="5%" />
                <ItemTemplate>
                    <asp:CheckBox ID="checkbox_is_valid" runat="server" Enabled="false" 
                         Checked='<%# DataBinder.Eval(Container.DataItem, "IsValid").ToString().ToUpper() == "Y" %>' />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:CheckBox ID="checkbox_is_valid" runat="server" Enabled="false" 
                         Checked='<%# DataBinder.Eval(Container.DataItem, "IsValid").ToString().ToUpper() == "Y" %>' />
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:CheckBox ID="checkbox_is_valid" runat="server"
                         Checked="true" />
                     </FooterTemplate>
            </asp:TemplateField>
            
            
            <asp:TemplateField HeaderText="ParentId">
                <HeaderStyle Width="20%" />
                <ItemTemplate>
                    <asp:Label ID="label_parent_id" runat="server"
                     Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "ParentId")) %>' />                    
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:TextBox ID="textbox_parent_id" runat="server" MaxLength="100"   TextMode="multiLine"
                        Text='<%# DataBinder.Eval(Container.DataItem, "ParentId") %>' 
                        CssClass="TextboxMultiFlat" Width="95%"></asp:TextBox>
                    <!-- <font color="red">*</font> -->
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:TextBox ID="textbox_parent_id" runat="server" MaxLength="100"  TextMode="multiLine"
                        CssClass="TextboxMultiFlat" Width="95%"></asp:TextBox>
                    <!-- <font color="red">*</font> -->
                </FooterTemplate>
            </asp:TemplateField>
                        
            
            <asp:TemplateField HeaderText="User" Visible="false">
                <HeaderStyle  Width="5%" />
                <ItemTemplate>
                    <a href='MenuGroupMaintain.aspx?MenuID=<%# (string)DataBinder.Eval(Container.DataItem, "MenuId") %>'>
                    <asp:Image ID="ImageUser" runat="server" CssClass="ImageUser"  ImageUrl="~/Images/UserSecurity.gif" /></a>
                </ItemTemplate>
                <EditItemTemplate>
                    <a href='MenuGroupMaintain.aspx?MenuID=<%# (string)DataBinder.Eval(Container.DataItem, "MenuId") %>&back_url=<%# HttpUtility.UrlEncode(Request.RawUrl) %>'>
                    <asp:Image ID="ImageUser" runat="server" CssClass="ImageUser"  ImageUrl="~/Images/UserSecurity.gif" /></a>
                </EditItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Edit">
                <HeaderStyle  Width="5%" />
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButtonEdit" runat="server" CssClass="ButtonEdit" 
                        CommandName="edit" OnClick="Button_Click" ImageUrl="~/Images/modify.gif" />
                </ItemTemplate>
                <EditItemTemplate>
                    <asp:ImageButton ID="ImageButtonUpdate" runat="server" CssClass="ButtonSave" 
                    CommandName="update" OnClick="Button_Click" ImageUrl="~/Images/save.gif" />
                    &nbsp;
                    <asp:ImageButton ID="ImageButtonCancel" runat="server" CssClass="ButtonCancel" 
                    CommandName="cancel" OnClick="Button_Click" ImageUrl="~/Images/undo.gif" />
                </EditItemTemplate>
                <FooterTemplate>
                    <asp:ImageButton ID="ImageButtonSave" runat="server" CssClass="ButtonSave" 
                    CommandName="addnew" OnClick="Button_Click" ImageUrl="~/Images/save.gif" />
                </FooterTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Delete">
                <HeaderStyle  Width="5%" />
                <ItemTemplate>
                    <asp:ImageButton ID="ImageButtonDelete" runat="server" CssClass="ButtonDelete" 
                    CommandName="delete" OnClick="Button_Click"  ImageUrl="~/Images/delete.gif" />
                </ItemTemplate>
            </asp:TemplateField>
            
            
            <asp:TemplateField HeaderText="Up" HeaderStyle-Width="5%" ItemStyle-Width="5%" Visible="false">
                    <ItemTemplate>
                        <asp:ImageButton id="ImageButtonMoveUp" ToolTip="Move Up" Runat="server"
                         ImageUrl="~/Images/EPS_Icon_BG_Up.gif" CommandName="Up" OnClick="Button_Click" />
                    </ItemTemplate>
                </asp:TemplateField>
            <asp:TemplateField HeaderText="Down" HeaderStyle-Width="5%" ItemStyle-Width="5%" Visible="false">
                <ItemTemplate>
                    <asp:ImageButton id="ImageButtonMoveDown" ToolTip="Move Down" Runat="server" 
                    ImageUrl="~/Images/EPS_Icon_BG_Down.gif"
                    CommandName="Down" OnClick="Button_Click" />   
                </ItemTemplate>
            </asp:TemplateField>
            
        </Columns>                                      
     </asp:GridView>
  </div>          
            
</ContentTemplate>
</asp:UpdatePanel>
</asp:Content>