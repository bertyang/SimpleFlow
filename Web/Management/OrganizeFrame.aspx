<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrganizeFrame.aspx.cs" Inherits="OrganizeFrame" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
    <frameset  cols="30%, 75%"  >
        <frame title="OrganizeTree" name="Menu" src="OrganizeTree.aspx"/>
        <frame title="OrganizeInfo" name="Content" src="OrganizeInfo.aspx"/> 
    </frameset>  
</html>
