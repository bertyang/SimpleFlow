<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Condition.aspx.cs" Inherits="FlowDesign_Condition" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
    <link type="text/css" rel="stylesheet" href="../Styles/BaseStyle.css" />
    <script language="javascript" type="text/javascript" src="../Scripts/StringFunctions.js"></script>     

  <script language="javascript" type="text/javascript">
      function check() {
          if (Trim(document.getElementById("<%=TextBoxValue.ClientID%>").value) == "") {
              alert("ֵ����Ϊ��");
              document.getElementById("<%=TextBoxValue.ClientID%>").focus();
              return false;
          }

          return true;
      } 
            </script>    
</head>
<body>
    <form id="form1" runat="server">
           
            <table style="width:100%;">
            <tr>
                <td>���ӷ�:</td>
                <td><asp:RadioButtonList ID="RadioButtonListJoin" runat="server" 
                        RepeatDirection="Horizontal"  AutoPostBack="true"
                        onselectedindexchanged="RadioButtonListJoin_SelectedIndexChanged" >
                        <asp:ListItem Value="AND" Selected>AND</asp:ListItem>
                        <asp:ListItem Value="OR">OR</asp:ListItem>
                    </asp:RadioButtonList></td>
                <td>��λ:</td>
                <td><asp:DropDownList ID="DropDownListField" runat="server" ></asp:DropDownList>                   
                </td>
                <td>������:</td>
                <td>
                    <asp:DropDownList ID="DropDownListOperator" runat="server">
                        <asp:ListItem>&gt;</asp:ListItem>
                        <asp:ListItem>=</asp:ListItem>
                        <asp:ListItem>&lt;</asp:ListItem>
                        <asp:ListItem>&gt;=</asp:ListItem>
                        <asp:ListItem>&lt;=</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>ֵ:</td>
                <td><asp:TextBox ID="TextBoxValue" runat="server" Width=50></asp:TextBox>
                </td>               
            </tr>
            <tr>
                <td colspan=8 align=center>                   
                    <asp:Button ID="Add" runat="server" Text="����" onclick="Add_Click" OnClientClick="return check();" />
                </td>                
            </tr>
            <tr>
                <td colspan=8>
                    <asp:GridView ID="GridViewCondition" runat="server" AutoGenerateColumns="False" 
                        CellPadding="4"  ForeColor="#333333" Width=100% 
                        OnRowEditing="GridViewCondition_RowEditing" 
                        OnRowCancelingEdit="GridViewCondition_CancelingEdit"  
                        OnRowUpdating="GridViewCondition_OnRowUpdating"
                         OnRowDeleting="GridViewCondition_OnRowDeleting"
                         DataKeyNames="ConditionSubId" GridLines="None">
                        <RowStyle BackColor="#EFF3FB" />
                        <HeaderStyle HorizontalAlign=Left />
                        <Columns>                          
                            <asp:TemplateField HeaderText="�ֶ�" SortExpression="ConditionSubField">                                 
                                <EditItemTemplate>
                                    <asp:DropDownList ID="DropDownListField" runat="server" ></asp:DropDownList>  
                                    <asp:Label ID="LabelField" runat="server" Text='<%# Bind("ConditionSubField") %>' Visible=false></asp:Label>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="LabelField" runat="server" Text='<%# Bind("ConditionSubField") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>                            
                            <asp:TemplateField HeaderText="������" SortExpression="ConditionSubOperator">
                                 <HeaderStyle HorizontalAlign=Left  />
                                <EditItemTemplate>
                                    <asp:DropDownList ID="DropDownListOperator" runat="server" >
                                        <asp:ListItem>&gt;</asp:ListItem>
                                        <asp:ListItem>=</asp:ListItem>
                                        <asp:ListItem>&lt;</asp:ListItem>
                                        <asp:ListItem>&gt;=</asp:ListItem>
                                        <asp:ListItem>&lt;=</asp:ListItem>
                                    </asp:DropDownList>  
                                    <asp:Label ID="LabelOperator" runat="server" Text='<%# Bind("ConditionSubOperator") %>' Visible=false></asp:Label>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="LabelOperator" runat="server" 
                                        Text='<%# Bind("ConditionSubOperator") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="ֵ" SortExpression="ConditionSubValue">
                                <EditItemTemplate>
                                    <asp:TextBox ID="TextBoxValue" runat="server" 
                                        Text='<%# Bind("ConditionSubValue") %>' Width=50></asp:TextBox>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="TextBoxValue" runat="server" Text='<%# Bind("ConditionSubValue") %>'></asp:Label>
                                </ItemTemplate>
                            </asp:TemplateField>   
                            <asp:TemplateField Visible=false>                                
                                <EditItemTemplate>
                                    <asp:Label ID="LabelCreateTime" runat="server" Text='<%# Bind("createtime") %>'></asp:Label>
                                </EditItemTemplate>
                            </asp:TemplateField>                                           
                  
                            <asp:TemplateField ShowHeader="False"  HeaderText="�༭">
                                <HeaderStyle HorizontalAlign=Left  />
                                <EditItemTemplate>
                                    <asp:LinkButton ID="LinkButtonUpdate" runat="server" CausesValidation="True" 
                                        CommandName="Update" Text="����"></asp:LinkButton>
                                    &nbsp;<asp:LinkButton ID="LinkButtonCancel" runat="server" CausesValidation="False" 
                                        CommandName="Cancel" Text="ȡ��"></asp:LinkButton>
                                </EditItemTemplate>
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" 
                                        CommandName="Edit" Text="�༭" ></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="ɾ��" ShowHeader="False">
                                <HeaderStyle HorizontalAlign=Left  />
                                <ItemTemplate>
                                    <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" 
                                        CommandName="Delete" Text="ɾ��" OnClientClick="return confirm('ȷ��ɾ����')"></asp:LinkButton>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <AlternatingRowStyle BackColor="White" />
                    </asp:GridView>
                </td>               
            </tr>
        </table>      
    </form>
</body>
</html>
