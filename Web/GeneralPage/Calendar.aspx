<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calendar.aspx.cs" Inherits="GeneralPage_Calendar" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <meta http-equiv="Expires"  content="0" /> 
    <meta http-equiv="Cache-Control" content="no-cache" /> 
    <meta http-equiv="Pragma" content="no-cache" /> 
    <base target="_self" />
    <title>Select Date</title>
    <script type="text/javascript">
    function button_clear_click()
    {
        window.returnValue = "";
        window.close();
    }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black"
                    BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black"
                    Height="250px" NextPrevFormat="ShortMonth" Width="330px" OnSelectionChanged="Calendar1_SelectionChanged">
                    <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                    <TodayDayStyle BackColor="#999999" ForeColor="White" />
                    <OtherMonthDayStyle ForeColor="#999999" />
                    <DayStyle BackColor="#CCCCCC" />
                    <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                    <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                    <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt"
                        ForeColor="White" Height="12pt" />
                </asp:Calendar>
                <center><input id="button_clear" style="width: 80px" type="button" value="Clear" 
                onclick="button_clear_click();" />
                    <asp:Button ID="button_today" runat="server" Text="Today" Width="80px" OnClick="button_today_Click" /></center>                                
            </ContentTemplate>
        </asp:UpdatePanel>
    
    </div>
    </form>
</body>
</html>
