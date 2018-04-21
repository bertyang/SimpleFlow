<%@ Page Language="C#" MasterPageFile="~/DefaultMasterPage.master" AutoEventWireup="true"
    CodeFile="TransferFrame.aspx.cs" Inherits="TransferFrame" Title="Untitled Page" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <script language="javascript" type="text/javascript">
        function Send() {
            //$("#form").contents().find("ButtonSend").click();
            frames['form'].document.getElementById('ButtonSend').click();
        }

        function Save() {
            frames['form'].document.getElementById('ButtonSave').click();
        }

        function CC() {
            frames['form'].document.getElementById('ButtonCC').click();
        }

        function Exist() {
            window.location = "ApplyForm.aspx";
            window.returnValue = false;
        }        


    </script>
    <table border="0">
        <tr>
            <td>
                <asp:Button ID="ButtonSend" runat="server" Text="ËÍÇ©" OnClientClick="Send()" />
            </td>
            <td>
                <asp:Button ID="ButtonSave" runat="server" Text="´æ´¢" OnClientClick="Save()" />
            </td>
            <td>
                <asp:Button ID="ButtonCC" runat="server" Text="³­ËÍ" OnClientClick="CC()"/>
            </td>
            <td>
                <asp:Button ID="ButtonExist" runat="server" Text="Àë¿ª" OnClientClick="Exist()"/>
            </td>
        </tr>
        <tr>
            <td colspan=4>
                <iframe id="form" width="100%" height="100%" frameborder="0" scrolling="auto" title="GDMS"
                    src="<%=m_strSrc%>"></iframe>
            </td>
        </tr>
    </table>         
</asp:Content>
