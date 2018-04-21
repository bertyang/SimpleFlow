<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ListBoxSelect.ascx.cs" Inherits="Controls_ListBoxSelect" %>
<script language="javascript" type="text/javascript">
<!--
function MoveRight()
{
	var ListBoxLeft = document.getElementById ('<%=ListBoxLeft.ClientID%>');
	var ListBoxRight = document.getElementById ('<%=ListBoxRight.ClientID%>');
	if (ListBoxLeft.selectedIndex == -1)
	{
		return false;
	}
	try
	{
		for (var i = 0; i < ListBoxLeft.options.length; i++)
		{
			if (ListBoxLeft.options[i].selected)
			{
				var oOption = document.createElement("OPTION");
				ListBoxRight.options.add(oOption);
				oOption.innerText = ListBoxLeft.options[i].innerText;
				oOption.value = ListBoxLeft.options[i].value;
				oOption.selected = true;
				ListBoxLeft.options.remove(i);
				i--;
			}
		}
		SynOrder();
	}
	catch(e)
	{
	}
	return false;
}

function MoveLeft()
{
	var ListBoxLeft = document.getElementById ('<%=ListBoxLeft.ClientID%>');
	var ListBoxRight = document.getElementById ('<%=ListBoxRight.ClientID%>');
	if (ListBoxRight.selectedIndex == -1)
	{
		return false;
	}
	try
	{
		for (var i = 0; i < ListBoxRight.options.length; i++)
		{
			if (ListBoxRight.options[i].selected)
			{
				var oOption = document.createElement("OPTION");
				ListBoxLeft.options.add(oOption);
				oOption.innerText = ListBoxRight.options[i].innerText;
				oOption.value = ListBoxRight.options[i].value;
				oOption.selected = true;
				ListBoxRight.options.remove(i);
				i--;
			}
		}
		SynOrder();
	}
	catch(e)
	{
	}
	return false;
}

function MoveRightAll()
{
	var ListBoxLeft = document.getElementById ('<%=ListBoxLeft.ClientID%>');
	var ListBoxRight = document.getElementById ('<%=ListBoxRight.ClientID%>');
	try
	{
		while (ListBoxLeft.options.length > 0)
		{
			var oOption = document.createElement("OPTION");
			ListBoxRight.options.add(oOption);
			oOption.innerText = ListBoxLeft.options[0].innerText;
			oOption.value = ListBoxLeft.options[0].value;
			oOption.selected = ListBoxLeft.options[0].selected;
			ListBoxLeft.options.remove(0);
		}
		SynOrder();
	}
	catch(e)
	{
	}
	return false;
}

function MoveLeftAll()
{
	var ListBoxLeft = document.getElementById ('<%=ListBoxLeft.ClientID%>');
	var ListBoxRight = document.getElementById ('<%=ListBoxRight.ClientID%>');
	try
	{
		while(ListBoxRight.options.length>0)
		{
			var oOption = document.createElement("OPTION");
			ListBoxLeft.options.add(oOption);
			oOption.innerText = ListBoxRight.options[0].innerText;
			oOption.value = ListBoxRight.options[0].value;
			oOption.selected = ListBoxRight.options[0].selected;
			ListBoxRight.options.remove(0);
		}
		SynOrder();
	}
	catch(e)
	{
	}
	return false;
}

function MoveUp()
{
	var ListBoxLeft = document.getElementById ('<%=ListBoxLeft.ClientID%>');
	var ListBoxRight = document.getElementById ('<%=ListBoxRight.ClientID%>');
	var selectedIndex = -1;
	var count = ListBoxRight.options.length;
	
	for (var i = 0; i < count; i++)
	{
		if (ListBoxRight.options[i].selected)
		{
			if (selectedIndex == -1)
			{
				selectedIndex = i;
			}
			var oOption = document.createElement("OPTION");
			ListBoxRight.options.add(oOption);
			oOption.innerText = ListBoxRight.options[i].innerText;
			oOption.value = ListBoxRight.options[i].value;
			oOption.selected = true;
			ListBoxRight.options.remove(i);
			i--;
			count--;
		}
	}
	
	if (selectedIndex == -1 || count == 0)
	{
		return false;
	}

	for (var i = (selectedIndex > 0 ? selectedIndex - 1 : 0); i < count; i++)
	{
		oOption = document.createElement("OPTION");
		ListBoxRight.options.add(oOption);
		oOption.innerText = ListBoxRight.options[selectedIndex > 0 ? selectedIndex - 1 : 0].innerText;
		oOption.value = ListBoxRight.options[selectedIndex > 0 ? selectedIndex - 1 : 0].value;
		ListBoxRight.options.remove(selectedIndex > 0 ? selectedIndex - 1 : 0);
	}
	SynOrder();
	return false;
}

function MoveDown()
{
	var ListBoxLeft = document.getElementById ('<%=ListBoxLeft.ClientID%>');
	var ListBoxRight = document.getElementById ('<%=ListBoxRight.ClientID%>');
	Reverse(ListBoxRight);
	MoveUp();
	Reverse(ListBoxRight);
	SynOrder();
	return false;
}

function Reverse(oList)
{
	var count = oList.options.length;
	for (var i = count - 1; i >= 0; i--)
	{
		var oOption = document.createElement("OPTION");
		oList.options.add(oOption);
		oOption.innerText = oList.options[i].innerText;
		oOption.value = oList.options[i].value;
		oOption.selected = oList.options[i].selected;
	}
	for (var i = 0; i < count; i++)
	{
		oList.options.remove(0);
	}
}

function SynOrder()
{
	var TextBoxSynOrder = document.getElementById ('<%=TextBoxSynOrder.ClientID%>');
	var ListBoxRight = document.getElementById ('<%=ListBoxRight.ClientID%>');
	
	var arrayOrderValues = new Array();
	for (var i = 0; i < ListBoxRight.options.length; i++)
	{
		arrayOrderValues[arrayOrderValues.length] = ListBoxRight.options[i].value;
	}
	TextBoxSynOrder.value = arrayOrderValues.join(",");
}
//-->
</script>
<table id="TableSelectFrame" cellspacing="0" cellpadding="0" width="370px" border="0">
    <tr>
        <td align="center"">
            <asp:Label ID="LabelUnSelectTitle" runat="server" Text=""></asp:Label></td>
        <td></td>
        <td align="center">
            <asp:Label ID="LabelSelectTitle" runat="server" Text=""></asp:Label></td>

    </tr>
    <tr>

        <td valign="top" align="right" rowspan="10">
            <asp:ListBox ID="ListBoxLeft" runat="server" AutoPostBack="false" SelectionMode="Multiple"
                Style="height: 216px; width: 160px;"></asp:ListBox>
        </td>
        <td width="50px" align="center" style="padding-left: 10px;">
            <table>
                <tr>
                    <td style="height: 25px">
                        <asp:ImageButton ID="ImageButtonArrowRightAll" runat="server" ImageUrl="~/Images/Button_ArrowRight1.gif" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:ImageButton ID="ImageButtonArrowRight" runat="server" ImageUrl="~/Images/Button_ArrowRight2.gif" /></td>
                </tr>
                <tr>
                    <td>
                        <asp:ImageButton ID="ImageButtonArrowLeft" runat="server" ImageUrl="~/Images/Button_ArrowLeft2.gif" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:ImageButton ID="ImageButtonArrowLeftAll" runat="server" ImageUrl="~/Images/Button_ArrowLeft1.gif" /></td>
                </tr>
            </table>
        </td>
        <td valign="top" align="left" rowspan="10">
            <asp:ListBox ID="ListBoxRight" runat="server" AutoPostBack="false" SelectionMode="Multiple"
                Style="height: 216px; width: 160px;"></asp:ListBox></td>

    </tr>
    <tr>
        <td colspan="3" style="display: none">
            <asp:TextBox ID="TextBoxSynOrder" runat="server" Width="0px"></asp:TextBox>
            <asp:TextBox ID="TextBoxOrigOrder" Width="0px" runat="server"></asp:TextBox>
        </td>
    </tr>
</table>