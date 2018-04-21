//from FLowER Platform for IE 7.0
function getInternetExplorerVersion()
// Returns the version of Internet Explorer or a -1
// (indicating the use of another browser).
{
	var rv = -1; // Return value assumes failure
	if (navigator.appName == 'Microsoft Internet Explorer')
	{
		var ua = navigator.userAgent;
		var re = new RegExp("MSIE ([0-9]{1,}[\.0-9]{0,})");
		if (re.exec(ua) != null)
			rv = parseFloat(RegExp.$1);
	}
	return rv;
}

// For IE 7.0 or abover version
var TITLE_BAR_ESTIMATED = 22; // 29 pixels or so for XP, 22 for Win2K...etc.Also relate to various themes.
var CHROME_THICKNESS_ESTIMATED = 2; // about 2 pixels or so...
// For Service Pack 2
var STATUS_BAR_ESTIMATED = 0; // Roughly 25 pixels or so... *no status bar in default security zone.

var ADJUSTED_WIDTH = 2 * CHROME_THICKNESS_ESTIMATED;
var ADJUSTED_HEIGHT = 2 * CHROME_THICKNESS_ESTIMATED + TITLE_BAR_ESTIMATED + STATUS_BAR_ESTIMATED;


var BROWSER_VERSION = getInternetExplorerVersion();

function openModalDialog(sURL, vArguments, sFeatures)
{
	if(BROWSER_VERSION > -1 && BROWSER_VERSION > 6.0)	// IE and version over than 6.0
	{
		try
		{
			var strHeight = sFeatures.match(/dialogHeight\s*[\:|=]\s*\d*\.?\d*\s*px/ig)[0]; //get height setting like "diaHeight:300px"
			var strWidth = sFeatures.match(/dialogWidth\s*[\:|=]\s*\d*\.?\d*\s*px/ig)[0]; //get width setting like "diaWidth:300px"
			var dblHeight= strHeight.match(/\d+\.?\d*/g)[0]; //get height setting number like 300
			var dblWidth= strWidth.match(/\d+\.?\d*/g)[0]; //get width setting number like 300
		}
		catch(e)
		{
			alert("Features to open ModalDialog are not correct. Please modify them." ); //for RD only :)
			return;
		}
		sFeatures = sFeatures.replace(strHeight, strHeight.replace(dblHeight, parseFloat(dblHeight) - ADJUSTED_HEIGHT )); //adjust height
		sFeatures = sFeatures.replace(strWidth, strWidth.replace(dblWidth, parseFloat(dblWidth) - ADJUSTED_WIDTH)); //adjust width
	}	
	return showModalDialog(sURL, vArguments, sFeatures);
}

function trim(str)
{	
	var k=0;
	var m=0;
	var i=0;
	for(i=0;i<str.length;i++)
	{
		if(str.charCodeAt(i)!=32)
		{
			k=i;
			break;
		}
	}
	if(i==str.length)   {str=""; return(str);}
	for(i=str.length-1;i>-1;i--)
	{
		if(str.charCodeAt(i)!=32)
		{
			m=i;
			break;
		}
	}
	str=str.substring(k,m+1);
	return(str);
} 

function ShowInfor(strtemp)
{
	mywindow = window.open("", "_blank", "top=100,left=70,width=400,height=300,toolbar=no,menubar=no,location=no,resizable=yes");
	mywindow.document.open();
	mywindow.document.writeln(strtemp);
	mywindow.document.close();
}

// Begin for search dropdownlist item.
var SearchKey = "";
var LastSearchTime = Date.parse(Date());
var IntervalLimit = 2000;    

function MatchSearchItem()
{
	var SourceElement;
	var CurrentTime;
	var ItemCount;
	
	SourceElement = event.srcElement;
	CurrentTime=Date.parse(Date());
	ItemCount = SourceElement.length;

	if(CurrentTime - LastSearchTime > IntervalLimit)
	{
		SearchKey = "";
	}
	LastSearchTime = CurrentTime;
	SearchKey = SearchKey + String.fromCharCode(window.event.keyCode); 
	
	for(i = 0; i < ItemCount; i++)
	{		
		var ItemText = SourceElement.options[i].text.toLowerCase();		
		var MatchedIndex = ItemText.indexOf(SearchKey);
		
		if (MatchedIndex == 0)
		{
			SourceElement.options[i].selected = true;
			// if next statement is remarked,this function will not run as wished, otherwise,  onchange event will not be fired.
			Window.event.returnValue = false; 			
			return;
		}   
	} 
}
// End for search dropdownlist item.

//Begin For Calendar [begin]
var DATE_SEPARATORS = new Array("/", "-", ".", " ", "");
var DEFAULT_DATE_SEPARATOR = DATE_SEPARATORS[[1]];	// Value limited in array DATE_SEPARATORS.
var DEFAULT_DATE_FORMAT = "[yyyymmdd]";				// Support yyyymmdd, mmddyyyy, ddmmyyyy
var LATIN_MONTH_LIST = new Array("Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec");
// Default features in IE6 or below and other browsers.
var CALENDAR_DIALOG_FEATURES = "status:no;dialogWidth:270px;dialogHeight:250px;center:yes;help:no;scroll:no;";

if(BROWSER_VERSION > -1 && BROWSER_VERSION > 6.0)	// Browser is IE and version above 6.0, redefine features.
{	
	CALENDAR_DIALOG_FEATURES = "status:no;dialogWidth:" + (270 - ADJUSTED_WIDTH) + "px;dialogHeight:" + (250 - ADJUSTED_HEIGHT) + "px;center:yes;help:no;scroll:no;";
}

// Open calendar. Notic: existes some special code for flowER platform.
function calendar(t) 
{
	// Set calendar1.htm path relative to current document.
	var sPath =  GotRootPath() + "forms/Public/Utility/calendar1.htm";

	if(typeof getCalendarPath == "function")
	{
		sPath = getCalendarPath() + sPath;
	}
	
	// Set dialog features, shield the browser's version difference.	
	var sFeatures = CALENDAR_DIALOG_FEATURES;	
	// Set dialog position.
	if(typeof getDialogPosition == "function") 
	{
		sFeatures += getDialogPosition();
	}
	
	// Set input date.
	var inDate = t.value;	
	if(typeof beforeCalendar == "function")
	{
		inDate = beforeCalendar(inDate);				
	}
	
	// Open dialog
	var outDate = showModalDialog(sPath, inDate, sFeatures);	
	if(typeof afterCalendar == "function")
	{
		outDate = afterCalendar(outDate);
	}
	
	// Refresh source element's value.	
	t.value = outDate;
}

function GotRootPath(){
	var sPath = location.pathname;
	if (sPath.split.length > 1){
		return sPath.substr(0, sPath.indexOf("/", 1) + 1);
	}
	else{
		return "/";
	}
}

// Returns the version of Internet Explorer or a -1
// (indicating the use of another browser).
function getBrowserVersion()
{
	var rv = -1;	// Return value assumes failure
	if (navigator.appName == 'Microsoft Internet Explorer')
	{
		var ua = navigator.userAgent;
		var re = new RegExp("MSIE ([0-9]{1,}[\.0-9]{0,})");
		if (re.exec(ua) != null)
			rv = parseFloat(RegExp.$1);
	}
	return rv;
}

// Set reasonable position for Calendar according to event object.
function getDialogPosition()
{
	try
	{		
		var sDialogLeft = event.screenX - event.offsetX;
		var sDialogTop = event.screenY + event.srcElement.offsetHeight;
		if(sDialogTop + 250 > screen.availHeight)
			sDialogTop = event.screenY - event.srcElement.offsetHeight - 250;		
		return "dialogLeft:" + sDialogLeft + "px;dialogTop:" + sDialogTop + "px;";
	}
	catch(ex)
	{
		return "";
	}
}

// Get calendar1.htm path relative to current document.
function getCalendarPath()
{
	return "";
}

// Pre-Process input date as you excepted.
function beforeCalendar(inDate)
{	
	// Change next code here.
	// You must ensure calendar can parse 'inDate' correctly .		
	if(inDate == "")
		return inDate;
	var ifDate = inDate.search(/[-./ ]/i);
	if(ifDate != -1)
		inDate = inDate.replace(/[-. ]/g, "/");
	else 
		{
		// *We assume the input date formate is consistent with DEFAULT_DATE_FORMAT strictly.	
			var sDateFormat = DEFAULT_DATE_FORMAT.toLowerCase();
			if (sDateFormat.charAt(0) == "y")
			{
				inDate = inDate.substr(0,4).concat("/",inDate.substr(4,2),"/",inDate.substr(6,2));
			}
			else 
			{
				inDate = inDate.substr(0,2).concat("/",inDate.substr(2,2),"/",inDate.substr(4,4));
			}
		}			
		var aDate = inDate.split("/");	
		if (aDate.length == 3)
		{
			var oDate = new Object();
			var sDateFormat = DEFAULT_DATE_FORMAT.toLowerCase();
			
			oDate[sDateFormat.charAt(0)] = aDate[0];		
			oDate[sDateFormat.charAt(sDateFormat.length - 1)] = aDate[2];
					
			var sFirst = sDateFormat.charAt(0);
			var sPreserve = "ymd";
			for(var i = 1; i < sDateFormat.length; i++)
			{
				if(sPreserve.indexOf(sDateFormat.charAt(i)) != -1)
				{			
					if(sFirst != sDateFormat.charAt(i))	
					{			
						oDate[sDateFormat.charAt(i)] = aDate[1];
						break;
					}
				}				
			}		
			return oDate["y"] + "/" + oDate["m"] + "/" + oDate["d"];
		}
		else
			return inDate;	
}
// Pre-Process output date as you excepted.
// Default date formate is [mm dd, yyyy] return by calendar. Sample: [February 4, 2006].
function afterCalendar(outDate)
{	
	// Change next code here.
	// You can re-formate 'outDate' as your system need.
	return formatDate(outDate, DEFAULT_DATE_FORMAT, DEFAULT_DATE_SEPARATOR);
}

function ToDate(toParse, separator){
	var parts = toParse.split(DEFAULT_DATE_SEPARATOR);
	return new Date(parts[2], parts[1], parts[0]);
}

function formatDateS(sDate){
	return formatDate(sDate, DEFAULT_DATE_FORMAT, DEFAULT_DATE_SEPARATOR);
}
// Formate date according to input date format.
function formatDate(sDate, sDateFormat, sDateSeparator) 
{
	var sScrap = "";
	var dScrap = new Date(sDate);
	
	// If date is invalid, empty string returned.	
	if(isNaN(dScrap)) return "";
	
	iDay = dScrap.getDate();
	iMonth = dScrap.getMonth() + 1;
	iYear = dScrap.getFullYear();

	if (iDay < 10) iDay = "0" + iDay;
	if (iMonth < 10) iMonth ="0" + iMonth;
	
	var oDate = new Object();
	oDate.y = iYear;
	oDate.m = iMonth;
	oDate.d = iDay;

	if (arguments.length == 1 || sDateFormat == "") {sDateFormat = "yyyymmdd";}
	if (arguments.length == 2) {sDateSeparator = "/";}
	sDateFormat = sDateFormat.toLowerCase();
	
	var sPrevious = "";
	var sCurrent = "";
	var sPreserve = "ymd";
	for(var i = 0; i < sDateFormat.length; i++)
	{
		if(sPreserve.indexOf(sDateFormat.charAt(i)) != -1)
		{			
			sCurrent = sDateFormat.charAt(i);
			if(sCurrent != sPrevious)
			{
				sScrap += oDate[sCurrent] + sDateSeparator;
				sPrevious = sCurrent;
			}				
		}
	}
	if(sDateSeparator =="")
		return sScrap == "" ? sScrap : sScrap.substring(0, sScrap.length );
	else
		return sScrap == "" ? sScrap : sScrap.substring(0, sScrap.length - 1);
}
//For Calendar [end]

function Upload(batch_id)
{	
	var str="../../GeneralPage/BatchUpload.aspx?batch_id="+batch_id;

	batch_id=window.showModalDialog(str,0,"status:no;dialogWidth:500px;dialogHeight:298px");
	
	return batch_id;	
}

function Download(batch_id)
{	
	var str="../../GeneralPage/BatchDownLoad.aspx?batch_id="+batch_id;

	window.showModalDialog(str,0,"status:no;dialogWidth:500px;dialogHeight:298px");
	
	return;	
}

function onlyNum()
{
	if(!((event.keyCode>=48&&event.keyCode<=57)||(event.keyCode>=96&&event.keyCode<=105)))
	//考虑小键盘上的数字键
	event.returnvalue=false;
}