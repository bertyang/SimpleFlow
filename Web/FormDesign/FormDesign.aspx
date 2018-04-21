<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FormDesign.aspx.cs" Inherits="FormDesign_FormDesign" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <input id="FileTemplate" type="file" runat=server />
        <asp:Button ID="ButtonCreate" runat="server" Text="生成" 
            onclick="ButtonCreate_Click" />
    </div>
    </form>
</body>
</html>
