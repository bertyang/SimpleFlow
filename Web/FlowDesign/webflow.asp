<html xmlns:v="urn:schemas-microsoft-com:vml">
<HEAD>
<TITLE> WebFlow 2005 Designer </TITLE>
<META HTTP-EQUIV="Content-Type" CONTENT="text/html; charset=gb2312">
<META NAME="Author" CONTENT="FengChun(f15_nsm@hotmail.com)">
<META NAME="Keywords" CONTENT="WebFlow">
<META NAME="Description" CONTENT="WebFlow著作权归开发者 Fengchun 拥有，保留一切商业权利">
<link href="inc/style.css" type=text/css rel=stylesheet>		

<script language=jscript src="inc/contextMenu/context.js"></script>
<script language=jscript src="inc/webflow.js"></script>
<script language=jscript src="inc/function.js"></script>
<script language=jscript src="inc/shiftlang.js"></script>
<script language=jscript src="inc/movestep.js"></script>

<SCRIPT LANGUAGE="JScript">
<!--
//自动取得浏览器语言
var LANG = navigator.browserLanguage;
if (LANG.indexOf('en') > -1){
    LANG = 'en';
}
if (LANG.indexOf('zh') > -1){
    LANG = 'zh';
}

function saveToXML(){
  	if(document.all.FlowXML.value=='') {
	   alert('请先创建新流程！\n\nPlease create a new flow at first!');
	   return;
  	}

	var xmlDoc = new ActiveXObject('MSXML2.DOMDocument');
	xmlDoc.async = false;
	xmlDoc.loadXML(document.all.FlowXML.value);
	var xmlRoot = xmlDoc.documentElement;
	var Flow = xmlRoot.getElementsByTagName("FlowConfig").item(0);
	var flowId = Flow.getElementsByTagName("BaseProperties").item(0).getAttribute("flowId");

	var xmlhttp=new ActiveXObject("Microsoft.XMLHTTP");
	xmlhttp.open("POST", "SaveFlow.aspx?flowId="+flowId, false);
	xmlhttp.Send(xmlDoc);

	//alert(xmlhttp.responseText);	
	if (xmlhttp.responseText == "True") {
	    alert("保存成功");
	}
	else {
	    alert("保存失败");
	}
}


function loadFromXML(formId){

  var fileName=formId+".xml";
  var xmlDoc = new ActiveXObject('MSXML2.DOMDocument');
  xmlDoc.async = false;
  var flag = xmlDoc.load('../forms/' + formId + '/' + fileName);
  if (!flag) {
    alert('文件导入失败！请先检查: flows/'+filename+' 是否存在！\n\nLoad file fail! Please check the file "flows/'+filename+'" if be exist!');return;
  }
  var xmlRoot = xmlDoc.documentElement;  
  FlowXML.value = xmlRoot.xml;
  drawTreeView();
}

function rights(){
  var dialogRights = window.showModalDialog("_rights.html", window, "dialogWidth:373px; dialogHeight:460px; center:yes; help:no; resizable:no; status:no") ;	
}

function about(){
  var dialogAbout = window.showModalDialog("_about.html", window, "dialogWidth:460px; dialogHeight:373px; center:yes; help:no; resizable:no; status:no") ;
}

function delFlow() {

    if (!confirm("确认删除吗？"))
        return;
        
    if (document.all.FlowXML.value == '') {
        alert('请先创建新流程！\n\nPlease create a new flow at first!');
        return;
    }

    var xmlDoc = new ActiveXObject('MSXML2.DOMDocument');
    xmlDoc.async = false;
    xmlDoc.loadXML(document.all.FlowXML.value);
    var xmlRoot = xmlDoc.documentElement;
    var Flow = xmlRoot.getElementsByTagName("FlowConfig").item(0);
    var flowId = Flow.getElementsByTagName("BaseProperties").item(0).getAttribute("flowId");

    var xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
    xmlhttp.open("POST", "DeleteFlow.aspx?flowId=" + flowId, false);
    xmlhttp.Send();

    //alert(xmlhttp.responseText);
    if (xmlhttp.responseText == "True") {
        alert("删除成功");
        window.parent.location="../flowlist.aspx";
    }
    else {
        alert("删除失败");
    }
}
//-->
</SCRIPT>
<STYLE>
v\:* { Behavior: url(#default#VML) }
</STYLE>
</HEAD>

<BODY onload='shiftLanguage(LANG,"main");document.title+=" Build "+document.lastModified;' oncontextmenu="cleancontextMenu();return false;" scroll="auto">
<TABLE border=0 cellspacing="0" cellpadding="0">
<TR>
	<TD valign=top><font size=6><font style="color:blue">W</font><font style="color:red">e</font><font style="color:green">b</font><font style="color:olive">F</font><font style="color:navy">l</font><font style="color:orange">o</font><font style="color:purple">w</font></font></TD>
	<TD valign=top><font size=5 style="color:blue"><sup>&reg</sup></font>&nbsp;</TD>
	<TD valign=middle nowrap><font size=6 style="color:green">2005</font>&nbsp;&nbsp;<font size=4 style="color:blue"><span id=topText></span></font></TD>
	<TD valign=bottom align=right width="100%">&nbsp;&nbsp;<font size=3 style="color:blue"><A HREF="#" onclick='LANG="zh";shiftLanguage("zh","main");'>中文</A>|<A HREF="#" onclick='LANG="en";shiftLanguage("en","main");'>English</A></font>&nbsp;</TD>
</TR>
</TABLE>
<INPUT TYPE="hidden" name=FlowXML onpropertychange='if(AUTODRAW) redrawVML();'>
<TABLE border=0>
<TR>
	<TD width="170" valign=top>
	<TABLE width="100%" height=500 cellspacing="0" cellpadding="0" class="panel_style">
	<TR height=20>
	<TD width=20 background=""></TD><TD width="" background=""><div id=treeText>流程导航视图</div></TD>
	</TR>
	<TR height=1>
	<TD colspan=2 class="panel_line"></TD>
	</TR>
	<TR>
	<TD colspan=2 height="100%" bgcolor=white>
	<table width="" height="" border="0" cellspacing="0" cellpadding="0">
    <tr>
       <td height="5" colspan=3>
    </tr>
	<tr>
       <td width="0"></td>
	   <td valign=top align=left height="450"><iframe id=treeview src="_flowtree.html" frameborder=0 width="100%" height="100%"></iframe><div></div><BR></td>
	   <td width="0"></td>
    </tr>
	</table>
	</TD>
	</TR>
	<TR height=1>
	<TD colspan=2 class="panel_line"></TD>
	</TR>
	<TR height=22>
	<TD colspan=2 align=right>
	<TABLE>
	<TR>
		<TD>&nbsp;</TD>
		<TD><INPUT id="btnNewFlow" TYPE="image" SRC="inc/images/newflow.gif" title="创建新流程" onclick='newFlow()' onfocus='this.blur()'></TD>
		<TD>&nbsp;</TD>
		<TD><INPUT id="btnEditFlow" TYPE="image" SRC="inc/images/editflow.gif" title="修改流程" onclick='editFlow()' onfocus='this.blur()'></TD>
		<TD>&nbsp;</TD>
		<TD><INPUT id="Image1" TYPE="image" SRC="inc/images/delFlow.gif" title="删除流程" onclick='delFlow()' onfocus='this.blur()'></TD>
		<TD>&nbsp;</TD>
		<TD><INPUT id="btnSaveFlow" TYPE="image" SRC="inc/images/saveflow.gif" title="导出流程" onclick='saveToXML()' onfocus='this.blur()'></TD>
		<TD>&nbsp;</TD>
		<TD><INPUT id="btnAbout" TYPE="image" SRC="inc/images/Q&A.gif" title="关于" onclick='about()' onfocus='this.blur()'></TD>
		<TD></TD>
	</TR>
	</TABLE>
	</TD>	
	</TR>
	</TABLE>
	</TD>
	<TD width=8></TD>
	<TD width="800" height="500">
	<TABLE cellspacing="0" cellpadding="0" class="panel_style">
	<TR>
	<TD colspan=2 width="800" height="500" onclick="cleancontextMenu();return false;" oncontextmenu='flowContextMenu();return false;' valign=top align=left>
    <v:group ID="FlowVML"  style="left:193;top:56;width:800px;height:500px;position:absolute;" coordsize="2000,2000">
	</v:group>
	
	</TD>
	</TR>			
	</TABLE>
	</TD>
</TR>
</TABLE>

<TABLE style="display:none">
<TR>
	<TD><span id=loadText>从"flows/"目录下导入：</span><SELECT NAME="flowList" class=txtput>
</SELECT> <INPUT id=btnLoadFlow TYPE="image" SRC="inc/images/loadflow.gif" title="导入流程" onclick='loadFromXML()' onfocus='this.blur()'></TD>
</TR>
</TABLE>
<SCRIPT LANGUAGE="JavaScript">
<!--
//rights();
loadFromXML("<%=request("form_Id")%>");
//-->
</SCRIPT>
</BODY>
</HTML>
