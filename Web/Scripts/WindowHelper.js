// For IE 7.0 or abover version
var TITLE_BAR_ESTIMATED = 29; // 29 pixels or so for XP, 22 for Win2K...etc.Also relate to various themes.
var CHROME_THICKNESS_ESTIMATED = 2; // about 2 pixels or so...
// For Service Pack 2
var STATUS_BAR_ESTIMATED = 0; // Roughly 25 pixels or so... *no status bar in default security zone.
// Adjust size
var ADJUSTED_WIDTH = 2 * CHROME_THICKNESS_ESTIMATED;
var ADJUSTED_HEIGHT = 2 * CHROME_THICKNESS_ESTIMATED + TITLE_BAR_ESTIMATED + STATUS_BAR_ESTIMATED; 
var BROWSER_VERSION = getBrowserVersion();

function ShowApplicationList(serial)
{
	// Default features in IE6 or below and other browsers.
	var iTop;
	var iLeft;
	var CALENDAR_DIALOG_FEATURES = "Scrollbars=1,status=no,width=880px,height=665px";
	iTop = (window.screen.height - 665) / 2;
	iLeft = (window.screen.width - 880) / 2;

	if(BROWSER_VERSION > -1 && BROWSER_VERSION > 6.0) // Browser is IE and version above 6.0, redefine features.
	{ 
		CALENDAR_DIALOG_FEATURES = "Scrollbars=1,width=" + (880 - ADJUSTED_WIDTH) + "px,height=" + (665 - ADJUSTED_HEIGHT) + "px";
		iTop = (window.screen.height + ADJUSTED_HEIGHT - 665) / 2;
		iLeft = (window.screen.width + ADJUSTED_WIDTH - 880) / 2;
	}
	CALENDAR_DIALOG_FEATURES += ",top=" + iTop + "px,left=" + iLeft + "px";
	window.open("PatentMaintain/ApplicationList.aspx?Serial=" + serial, "New", CALENDAR_DIALOG_FEATURES); 
}
function getBrowserVersion()
{
	var returnValue = -1; // Return value assumes failure
	if (navigator.appName == 'Microsoft Internet Explorer')
	{
		var agent = navigator.userAgent;
		var rule = new RegExp("MSIE ([0-9]{1,}[\.0-9]{0,})");
		if (rule.exec(agent) != null)
			returnValue = parseFloat(RegExp.$1);
	}
	return returnValue;
}

function OpenWindowDefualtSize(url) {
	var  iTop  = (window.screen.height - 570) / 2;
	var  iLeft = (window.screen.width - 870) / 2;
	var features = "width=870,height=570,scrollbars=yes,toolbar=no,menubar=no,resizable=no,location=no,status=no,center=yes,top=" + iTop;
	features += ",left=" + iLeft;
	window.open(url, "", features);
	return false;
}

function OpenWindowBySize(url, width, height) {
	var iTop = (window.screen.height - height) / 2;
	var iLeft = (window.screen.width - width) / 2;
	var features = "scrollbars=yes,toolbar=no,menubar=no,resizable=no,location=no,status=no,center=yes";
	if(BROWSER_VERSION > -1 && BROWSER_VERSION > 6.0) // Browser is IE and version above 6.0, redefine features.
	{ 
		features += ",width=" + (width - ADJUSTED_WIDTH) + "px,height=" + (height - ADJUSTED_HEIGHT) + "px";
		iLeft = (window.screen.width + ADJUSTED_WIDTH - width) / 2;
	}
	else {
		features += ",width=" + width + "px,height=" + height + "px";
	}

	features += ",top=" + iTop;
	features += ",left=" + iLeft;
	return OpenWindowByFeature(url, features, 0, 0);
}

function OpenWindowByFeature(url, features, width, height) {
	//debugger;
	if (width == 0 && height == 0) {
		window.open(url, "", features);
	}
	else {
		var iTop = (window.screen.height - height) / 2;
		var iLeft = (window.screen.width - width) / 2;
		if (features.length > 0) features += ",";
		if(BROWSER_VERSION > -1 && BROWSER_VERSION > 6.0) // Browser is IE and version above 6.0, redefine features.
		{ 
			features += "width=" + (width - ADJUSTED_WIDTH) + "px,height=" + (height - ADJUSTED_HEIGHT) + "px";
			iLeft = (window.screen.width + ADJUSTED_WIDTH - width) / 2;
		}
		else {
			features += "width=" + width + "px,height=" + height + "px";
		}

		features += ",top=" + iTop + "px,left=" + iLeft + "px";
		window.open(url, "", features);
	}
	return false;
}

function OpenWindowWithAllFeatures(url, width, height) {
	//debugger;
	var features = "scrollbars=yes,toolbar=yes,menubar=yes,resizable=yes,location=yes,center=yes";
	var iTop = (window.screen.height - height) / 2;
	var iLeft = (window.screen.width - width) / 2;
	if(BROWSER_VERSION > -1 && BROWSER_VERSION > 6.0) // Browser is IE and version above 6.0, redefine features.
	{ 
		features += ",width=" + (width - ADJUSTED_WIDTH) + "px,height=" + (height - ADJUSTED_HEIGHT) + "px";
		iLeft = (window.screen.width + ADJUSTED_WIDTH - width) / 2;
	}
	else {
		features += ",width=" + width + "px,height=" + height + "px";
		iTop = iTop - 87;				// Because toolbar, menubar and location has a certain height
	}

	features += ",top=" + iTop + "px,left=" + iLeft + "px";
	window.open(url, "", features);
}
function ResizeWindow(){
	try{
		if (document.readyState !="complete"){
			return;
		}
		ResizeHeight();	
	}
	catch(e){}
}