<%@ Page Language="C#" MasterPageFile="~/DefaultMasterPage.master" AutoEventWireup="true" 
CodeFile="TraceForm.aspx.cs" Inherits="TraceForm" Title="Trace Form (select form kind) " %>
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
                        <asp:Image ID="form_image" runat="server" ImageUrl="~/images/icon1.gif" />
                        <asp:HyperLink ID="form_url" runat="server" 
                         Text='<%# HTMLEncode(DataBinder.Eval(Container.DataItem, "FormName")) %>'
                        NavigateUrl='<%# "~/TraceFormDetail.aspx?form_Id=" + DataBinder.Eval(Container.DataItem, "FormId").ToString() %>' />
                    </p>
                </ItemTemplate>        
        </asp:DataList>
    </ContentTemplate>
</asp:UpdatePanel>
</asp:Content>


