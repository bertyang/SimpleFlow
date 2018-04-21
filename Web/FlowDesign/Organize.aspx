<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Organize.aspx.cs" Inherits="FlowDesign_Organize" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <script type="text/javascript">

        // 点击复选框时触发事件
        function postBackByObject() {
            var o = window.event.srcElement;
            if (o.tagName == "INPUT" && o.type == "checkbox") {
                //这里的第一个参数是UpdatePanel ID，因为我使用了MS的ASPAJAX来实现局部刷新
                //如果没有使用MS的ASPAJAX，这里的两个参数都可以为空
                __doPostBack("UpdatePanelManager", "");
            }
        }
    </script>

</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanelManager" runat="server">
            <ContentTemplate>
                <asp:TreeView ID="LinksTreeView" Font-Names="Arial" ForeColor="Blue" 
                    OnTreeNodeCheckChanged="LinksTreeView_CheckChanged"
                    ShowCheckBoxes="All" runat="server">
                    <Nodes>
                        <asp:TreeNode Text="Company" SelectAction="Expand" />
                    </Nodes>
                </asp:TreeView>
                <asp:Button ID="ButtonSave" runat="server" Text="保存" OnClick="ButtonSave_Click" />
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
