<%@ Page Language="C#" AutoEventWireup="true" CodeFile="FileUpload.aspx.cs" Inherits="GeneralPage_FileUpload" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <meta http-equiv="Expires"  content="0" /> 
    <meta http-equiv="Cache-Control" content="no-cache" /> 
    <meta http-equiv="Pragma" content="no-cache" /> 
    <base target="_self" />

    <title runat="server">Upload File</title>
    <link type="text/css" rel="stylesheet" href="../Styles/BaseStyle.css" />
    <script language="javascript" type="text/javascript">
    function body_load()
    {
        var obj = document.getElementById("txtCloseOnLoad");
        if ((obj != null) && (obj.value == "Y"))
        {
            var info_obj = document.getElementById("txtFileList");
            if (info_obj != null)
            {
                window.returnValue = info_obj.value;
                // alert(window.returnValue);
                window.close();
            }
        }
    }
    </script>
</head>
<body  onload="javascript:body_load()">
    
    <form id="Form1" runat="server" method="post" >
        <table id="Table1" border="0" cellpadding="0" cellspacing="0" width="100%">
            <tr>
                <td>
                    <asp:Label ID="lblnotice" runat="server" CssClass="lblSystemAlert"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="text-align:center">
                    <asp:FileUpload ID="updFile" runat="server" CssClass="textGeneral" Width="264px" />
                </td>
            </tr>
            <tr>
                <td style="text-align:center">
                    <asp:Button ID="btnUpload" runat="server" CssClass="button60" OnClick="btnUpload_Click" Text="Upload" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" HeaderStyle-CssClass="gridTitle">
                        <Columns>
                            <asp:TemplateField HeaderText="File Name">
                            <ItemTemplate>
                               <%# DataBinder.Eval(Container.DataItem, "Original_File_Name") %>
                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="File Size">
                            <ItemTemplate>
                               <%# DataBinder.Eval(Container.DataItem, "File_Size") %>
                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:TemplateField HeaderText="Content Type">
                            <ItemTemplate>
                               <%# DataBinder.Eval(Container.DataItem, "Content_Type") %>
                            </ItemTemplate>
                            </asp:TemplateField>
                            <asp:CommandField HeaderText="Delete" ShowDeleteButton="True" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>                
            <tr>
                <td>
                    <input id="txtCloseOnLoad" runat="server" type="hidden" value="N" style="width: 40px" />
                    <input id="txtFileList" runat="server" type="hidden" style="width: 40px" />
                    <input id="txtAllowMoreFiles" runat="server" type="hidden" style="width: 40px" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnConfirm" runat="server" CssClass="button60" Text="Confirm" Visible="False" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
