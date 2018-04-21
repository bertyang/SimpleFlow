<%@ Page  Language="C#" MasterPageFile="~/DefaultMasterPage.master" AutoEventWireup="true"
    CodeFile="ApproveForm.aspx.cs" Inherits="ApproveForm" Title="Approve Form" %>

<%@ Register Assembly="SimpleFlow.WebControlLibrary" Namespace="SimpleFlow.WebControlLibrary"
    TagPrefix="cc1" %>
<%@ Register Src="Controls/GridPagerControl.ascx" TagName="GridPagerControl" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <script language="javascript" type="text/javascript">
        function onlyNum() {
            if (!((event.keyCode >= 48 && event.keyCode <= 57) || (event.keyCode >= 96 && event.keyCode <= 105) || (event.keyCode == 13) || (event.keyCode == 8))) {
                event.keyCode = null;
                return false;
            }
        }

        function showApproveList(formId, formNo) {
            var left = window.event.screenX - (window.event.clientX - window.event.srcElement.getBoundingClientRect().left);
            var top = window.event.screenY + 20;
            var LinkFile = "generalpage/approvelist.aspx?formId=" + formId + "&formNo=" + formNo;
            var OPENMINIDIALOG = "status:no;dialogWidth:450px;dialogHeight:320px;dialogTop:" + top + "px;dialogLeft:" + left + "px;center:yes;help:no;scroll:no";
            var objReturn = window.showModelessDialog(LinkFile, null, OPENMINIDIALOG);
        }
    </script>

    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <input id="hidden_form_id" type="hidden" runat="server" />
            <table style="width: 458px">
                <tbody>
                    <tr>
                        <td>
                            <asp:Label ID="label_form_no" runat="server" Width="120px" Text="Form No."></asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="textbox_form_no" runat="server" CssClass="TextboxSingleFlat"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="2">
                            <asp:Button ID="button_query" OnClick="button_query_Click" runat="server" Width="80px"
                                Text="Query" CssClass="button80"></asp:Button>
                        </td>
                    </tr>
                    <tr>
                        <td colspan="2">
                            &nbsp;&nbsp;
                        </td>
                    </tr>
                </tbody>
            </table>
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" Width="98%" OnRowDataBound="GridView1_RowDataBound"
                EmptyDataText="this is no data found, please change the condition to query again."
                HeaderStyle-CssClass="gridTitle" AutoGenerateColumns="False">
                <Columns>
                    <asp:TemplateField HeaderText="Apply Date">
                        <ItemTemplate>
                            <asp:Label ID="label_apply_date" runat="server" Text='<%# FormatDate((DateTime)DataBinder.Eval(Container.DataItem, "BeginDate")) %>' />
                        </ItemTemplate>
                        <ItemStyle Width="15%"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Apply User">
                        <ItemTemplate>
                            <asp:Label ID="label_apply_user" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "FormId") %>' />
                        </ItemTemplate>
                        <ItemStyle Width="15%"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="From Kind">
                        <ItemTemplate>
                            <asp:Label ID="label_form_id" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "FormId") %>' />
                        </ItemTemplate>
                        <ItemStyle Width="20%"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Form No.">
                        <ItemTemplate>
                            <asp:HiddenField ID="hidden_form_no" runat="server" Value='<%# DataBinder.Eval(Container.DataItem, "FormNo") %>' />
                            <asp:HiddenField ID="Hidden_FormApproveId" runat="server" Value='<%# DataBinder.Eval(Container.DataItem, "FormApproveId") %>' />
                            <asp:Label ID="label_form_no" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "FormNo") %>' />
                        </ItemTemplate>
                        <ItemStyle Width="10%"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Approve Status">
                        <ItemTemplate>
                            <asp:Label ID="label_approve_status" runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "AppStatus") %>' />
                        </ItemTemplate>
                        <ItemStyle Width="8%"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="View">
                        <ItemTemplate>
                            <asp:HyperLink ID="hyperlink_view" runat="server" ImageUrl="~/Images/viewmore.gif"
                                Target="_blank" NavigateUrl="~/Images/viewmore.gif" />
                        </ItemTemplate>
                        <ItemStyle Width="7%"></ItemStyle>
                    </asp:TemplateField>
                   <asp:TemplateField HeaderText="Approve List">
                        <ItemTemplate>
                            <asp:ImageButton ID="button_approve_list" runat="server" ImageUrl="~/Images/undo.gif" />
                        </ItemTemplate>
                        <ItemStyle Width="7%"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Agree">
                        <ItemTemplate>
                            <asp:ImageButton ID="button_agree" OnClick="button_agree_click" runat="server" OnClientClick="if (!window.confirm('Confirm agree?')) { return false; } "
                                ImageUrl="~/Images/allow.gif">
                            </asp:ImageButton>
                        </ItemTemplate>
                        <ItemStyle Width="10%"></ItemStyle>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Reject">
                        <ItemTemplate>
                            <asp:ImageButton ID="button_reject" runat="server" ImageUrl="~/Images/reject.gif" OnClientClick="if (!window.confirm('Confirm reject?')) { return false; } "
                                OnClick="button_reject_Click"></asp:ImageButton>
                        </ItemTemplate>
                        <ItemStyle Width="8%"></ItemStyle>
                    </asp:TemplateField>
                </Columns>
                <EmptyDataTemplate>
                    <table style="width: 100%; border-collapse: collapse;" border="1" cellpadding="0"
                        cellspacing="0">
                        <tr class="gridTitle">
                            <th width="15%">
                                Apply Date
                            </th>
                            <th width="15%">
                                Apply User
                            </th>
                            <th width="10%">
                                Form Kind
                            </th>
                            <th width="10%">
                                Form No
                            </th>
                            <th width="10%">
                                Approve Status
                            </th>
                            <th width="8%">
                                View
                            </th>
                            <th width="7%">
                                Modify
                            </th>
                            <th width="7%">
                                Approve List
                            </th>
                            <th width="8%">
                                Withdraw
                            </th>
                            <th width="10%">
                                Urge Inform
                            </th>
                        </tr>
                        <tr>
                            <td colspan="10">
                                No Data Found.
                            </td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <HeaderStyle CssClass="gridTitle"></HeaderStyle>
            </asp:GridView>
            <p style="padding-right: 20px" align="right">
                <cc1:GridPagerControl ID="GridPagerControl1" runat="server" OnPageIndexChange="GridPagerControl1_PageIndexChange">
                </cc1:GridPagerControl>
            </p>
            <div style="text-align: right">
                &nbsp;</div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
