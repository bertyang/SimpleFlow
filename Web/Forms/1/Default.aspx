<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Form._1._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>    
    <script language=javascript type="text/javascript">
        function Exit() {
            var topWindow = window.parent.parent;
            topWindow.location = "../../ApplyForm.aspx";
            window.returnValue = false;
        }  
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <table border="0">
        <tr>
            <td colspan="4">
                Amount:<asp:TextBox ID="TextBoxMoney" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                Leader:<asp:TextBox ID="TextBoxLeader" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td colspan="4">
                Manager:<asp:TextBox ID="TextBoxManager" runat="server"></asp:TextBox>
            </td>
        </tr>
    </table>
        <asp:Button ID="ButtonSave" runat="server" Text="Button" 
    onclick="ButtonSave_Click" style="display:none" />
        <asp:Button ID="ButtonSend" runat="server" Text="Button" 
    onclick="ButtonSend_Click" style="display:none" />
    </form>
</body>
</html>
        