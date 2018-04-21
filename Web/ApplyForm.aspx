<%@ Page Language="C#" MasterPageFile="~/DefaultMasterPage.master" 
AutoEventWireup="true" CodeFile="ApplyForm.aspx.cs" Inherits="ApplyForm" 
Title="Apply New Form" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<p align="left" >
<asp:Label ID="page_title" runat="server" Text="Please click the item to go on" />
</p>
    
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <asp:DataList ID="DataList1" runat="server"  HorizontalAlign="Justify" RepeatColumns="3" >
            <SeparatorStyle Width="5%" />
                <SeparatorTemplate>
                <p>&nbsp;</p>
                </SeparatorTemplate>
            <ItemTemplate> 
                    <p>
                        <asp:HiddenField ID="hidden_form_id" runat="server" 
                         Value='<%# DataBinder.Eval(Container.DataItem, "FormId") %>' />
                        <asp:Image ID="form_image" runat="server" ImageUrl="~/images/icon1.gif" />
                        <asp:LinkButton ID="apply_form_link" runat="server" 
                        OnClick="apply_form_link_Click"><%# HTMLEncode(DataBinder.Eval(Container.DataItem, "FormName")) %></asp:LinkButton>                                             
                          
                    </p>
                </ItemTemplate>
        
        </asp:DataList>
    </ContentTemplate>
</asp:UpdatePanel>
</asp:Content>

