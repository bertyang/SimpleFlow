<%@ Page Title="" Language="C#" MasterPageFile="~/DefaultMasterPage.master" AutoEventWireup="true" CodeFile="TestApply.aspx.cs" Inherits="TestApply" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    

    <table style="width:100%;">
        <tr>
            <td style="width: 343px">
                Amount:<asp:TextBox ID="TextBoxMoney" runat="server"></asp:TextBox>
            </td>
       
        </tr>
        <tr>
            <td style="width: 343px">
                Leader:<asp:TextBox ID="TextBoxLeader" runat="server"></asp:TextBox></td>
        </tr>
        <tr>            
            <td style="width: 343px">
                Manager:<asp:TextBox ID="TextBoxManager" runat="server"></asp:TextBox></td>
        </tr>
    </table>
    

    <asp:Button  runat="server" ID="Apply" onclick="Apply_Click" Text="Apply"/>
</asp:Content>

