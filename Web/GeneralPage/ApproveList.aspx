<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ApproveList.aspx.cs" Inherits="GeneralPage_ApproveList" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>签核列表</title>
    <link type="text/css" rel="stylesheet" href="../Styles/BaseStyle.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridViewAproveList" runat="server" AutoGenerateColumns="false">
            <Columns>
                <asp:BoundField DataField="appname" HeaderText="姓名" />
                <asp:BoundField DataField="approle" HeaderText="角色" />
                <asp:BoundField DataField="appserial" HeaderText="顺序" />
                 <asp:BoundField DataField="enddate" HeaderText="签核时间" />
                  <asp:BoundField DataField="appvalue" HeaderText="签核意见" />
                   <asp:BoundField DataField="appcontent" HeaderText="签核备注" />
            </Columns>
        </asp:GridView>    
    </div>
    </form>
</body>
</html>
